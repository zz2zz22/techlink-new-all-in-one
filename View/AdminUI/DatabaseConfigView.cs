using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one
{
    public partial class DatabaseConfigView : Form
    {
        //Fields
        SqlSoft sqlSoft = new SqlSoft();
        string stationUUID, stationName, stationDepartment;
        string departmentUUID, departmentName;
        string permissionUUID, permissionName;

        //Constructor
        public DatabaseConfigView()
        {
            InitializeComponent();
        }

        //Methods
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public void LoadDepartmentCombobox()
        {
            cbxChooseDepartment.Items.Clear();
            StringBuilder sb = new StringBuilder();
            DataTable dt = new DataTable();
            sb.Append("select uuid, department_name from department_info order by department_name asc");
            sqlSoft.sqlDataAdapterFillDatatable(sb.ToString(), ref dt);
            if (dt.Rows.Count > 0)
            {
                cbxChooseDepartment.DataSource = dt;
                cbxChooseDepartment.DisplayMember = "department_name";
                cbxChooseDepartment.ValueMember = "uuid";
                cbxChooseDepartment.SelectedIndex = 0;
            }
            else
            {
                Alert("Thiếu dữ liệu bộ phận lớn!\r\n缺少大零件数据！", Form_Alert.enmType.Warning);
            }
        }

        public void GetStationInfo()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();

            sb.Append("select a.uuid, a.station_name, b.department_name from station_info as a inner join department_info as b on a.department_uuid = b.uuid order by b.department_name asc");
            sqlSoft.sqlDataAdapterFillDatatable(sb.ToString(), ref dt);

            if (dt.Rows.Count > 0)
            {
                dtgvShowStationInfo.DataSource = dt;
                dtgvShowStationInfo.Columns["uuid"].Visible = false;
                dtgvShowStationInfo.Columns["station_name"].HeaderText = "Tên trạm\r\n生产站名称";
                dtgvShowStationInfo.Columns["department_name"].HeaderText = "Bộ phận\r\n零件名称";
            }
            else
            {
                dtgvShowStationInfo.DataSource = null;
            }
        }

        public void GetDepartmentInfo()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();

            sb.Append("select uuid, department_name from department_info order by department_name asc");
            sqlSoft.sqlDataAdapterFillDatatable(sb.ToString(), ref dt);

            if (dt.Rows.Count > 0)
            {
                dtgvShowDepartmentInfo.DataSource = dt;
                dtgvShowDepartmentInfo.Columns["uuid"].Visible = false;
                dtgvShowDepartmentInfo.Columns["department_name"].HeaderText = "Bộ phận\r\n零件名称";
            }
            else
            {
                dtgvShowDepartmentInfo.DataSource = null;
            }
        }

        public void GetPermissionInfo()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();

            sb.Append("select permission_id, permission_name from programs_permission where permission_id > " + UserData.UserPermission + " order by permission_id asc");
            sqlSoft.sqlDataAdapterFillDatatable(sb.ToString(), ref dt);

            if (dt.Rows.Count > 0)
            {
                dtgvShowPermission.DataSource = dt;
                dtgvShowPermission.Columns["permission_id"].HeaderText = "ID";
                dtgvShowPermission.Columns["permission_name"].HeaderText = "Tên quyền hạn\r\n机关名称";
            }
            else
            {
                dtgvShowPermission.DataSource = null;
            }
        }

        //Event Handler
        private void txbBigDepartmentInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txbBigDepartmentInput.Texts.Trim()))
                {
                    sqlSoft.sqlInsertAdminDepartmentInfo(txbBigDepartmentInput.Texts.Trim());
                    txbBigDepartmentInput.Texts = "";
                    label1.Focus();
                    LoadDepartmentCombobox();
                    GetDepartmentInfo();
                }
                else
                {
                    Alert("Vui lòng không để trống dữ liệu!\r\n请不要将数据留空！", Form_Alert.enmType.Info);
                }
            }
        }

        private void DatabaseConfigView_Load(object sender, EventArgs e)
        {
            GetStationInfo();
            GetDepartmentInfo();
            GetPermissionInfo();
            LoadDepartmentCombobox();
        }

        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(stationUUID))
            {
                DialogResult dialogConfirmDeleteStation = CTMessageBox.Show("Bạn có muốn xóa trạm \"" + stationName + "\" của bộ phận \"" + stationDepartment + "\" ra khỏi hệ thống ?\r\n您想从系统中删除单元\"" + stationDepartment + "\"的站\"" + stationName + "\"吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogConfirmDeleteStation == DialogResult.Yes)
                {
                    string successMsg = "Xóa dữ liệu trạm sản xuất thành công!\r\n工厂数据删除成功！";
                    string errorMsg = "Xóa dữ liệu trạm sản xuất thất bại!\r\n工厂数据删除失败！";
                    sqlSoft.sqlExecuteNonQuery("delete from station_info where uuid = '" + stationUUID + "'", successMsg, errorMsg);
                    GetStationInfo();
                }
            }
        }

        private void dtgvShowDepartmentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvShowDepartmentInfo.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvShowDepartmentInfo.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvShowDepartmentInfo.Rows[selectedrowindex];
                departmentUUID = Convert.ToString(selectedRow.Cells["uuid"].Value);
                departmentName = Convert.ToString(selectedRow.Cells["department_name"].Value);
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(departmentUUID))
            {
                DialogResult dialogConfirmDeleteDepartment = CTMessageBox.Show("Bạn có muốn xóa bộ phận \"" + departmentName + "\" ra khỏi hệ thống ?\r\n您想从系统中删除\""+departmentName+"\"部分吗", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogConfirmDeleteDepartment == DialogResult.Yes)
                {
                    string successMsg = "Xóa dữ liệu bộ phận thành công!\r\n零件数据删除成功！";
                    string errorMsg = "Xóa dữ liệu bộ phận thất bại!\r\n零件数据删除失败！";
                    sqlSoft.sqlExecuteNonQuery("delete from department_info where uuid = '" + departmentUUID + "'", successMsg, errorMsg);
                    GetDepartmentInfo();
                }
            }
        }

        private void dtgvShowPermission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvShowPermission.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvShowPermission.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvShowPermission.Rows[selectedrowindex];
                permissionUUID = Convert.ToString(selectedRow.Cells["permission_id"].Value);
                permissionName = Convert.ToString(selectedRow.Cells["permission_name"].Value);
            }
        }

        private void btnDeletePermission_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(permissionUUID))
            {
                DialogResult dialogConfirmDeletePermission = CTMessageBox.Show("Bạn có muốn xóa quyền hạn \"" + permissionName + "\" ra khỏi hệ thống ?\r\n您想从系统中删除权限\"" + permissionName + "\"吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogConfirmDeletePermission == DialogResult.Yes)
                {
                    string successMsg = "Xóa dữ liệu quyền hạn thành công!\r\n权限数据删除成功！";
                    string errorMsg = "Xóa dữ liệu quyền hạn thất bại!\r\n删除数据权限失败！";
                    sqlSoft.sqlExecuteNonQuery("delete from programs_permission where permission_id = '" + permissionUUID + "'", successMsg, errorMsg);
                    GetPermissionInfo();
                }
            }
        }

        private void txbStationNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txbStationNameInput.Texts.Trim()))
                {
                    if (cbxChooseDepartment.Items.Count > 0)
                    {
                        sqlSoft.sqlInsertAdminStationInfo(txbStationNameInput.Texts.Trim(), cbxChooseDepartment.SelectedValue.ToString());
                        GetStationInfo();
                        txbStationNameInput.Texts = "";
                        label2.Focus();
                    }
                    else
                    {
                        Alert("Thiếu dữ liệu bộ phận lớn!\r\n缺少大零件数据！", Form_Alert.enmType.Warning);
                    }
                }
                else
                {
                    Alert("Vui lòng không để trống dữ liệu!\r\n请不要将数据留空！", Form_Alert.enmType.Info);
                }
            }
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(UUIDGenerator.getAscId());
            Alert("UID đã được tạo vào lưu vào clipboard!\r\n生成的UID保存到剪贴板！", Form_Alert.enmType.Success);
        }

        private void txbPermissionName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txbPermissionName.Texts.Trim()))
                {
                    sqlSoft.sqlInsertAdminPermissionInfo(txbPermissionName.Texts.Trim());
                    GetPermissionInfo();
                    txbPermissionName.Texts = "";
                    label2.Focus();
                }
                else
                {
                    Alert("Vui lòng không để trống dữ liệu!\r\n请不要将数据留空！", Form_Alert.enmType.Info);
                }
            }
        }

        private void dtgvShowStationInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvShowStationInfo.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvShowStationInfo.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvShowStationInfo.Rows[selectedrowindex];
                stationUUID = Convert.ToString(selectedRow.Cells["uuid"].Value);
                stationName = Convert.ToString(selectedRow.Cells["station_name"].Value);
                stationDepartment = Convert.ToString(selectedRow.Cells["department_name"].Value);
            }
        }
    }
}
