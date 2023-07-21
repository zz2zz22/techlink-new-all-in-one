using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one
{
    public partial class DatabaseConfigView : Form
    {
        //Fields

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
            SqlSoft sqlSoft = new SqlSoft();
            StringBuilder sb = new StringBuilder();
            DataTable dt = new DataTable();
            sb.Append("select uuid, department_name from department_info order by department_name asc");
            sqlSoft.sqlDataAdapterFillDatatable(sb.ToString(), ref dt);
            if(dt.Rows.Count > 0)
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

        //Event Handler
        private void txbBigDepartmentInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txbBigDepartmentInput.Texts.Trim()))
                {
                    SqlSoft sqlSoft = new SqlSoft();
                    sqlSoft.sqlInsertAdminDepartmentInfo(txbBigDepartmentInput.Texts.Trim());
                    txbBigDepartmentInput.Texts = "";
                    label1.Focus();
                    LoadDepartmentCombobox();
                }
                else
                {
                    Alert("Vui lòng không để trống dữ liệu!\r\n请不要将数据留空！", Form_Alert.enmType.Info);
                }
            }
        }

        private void btnAddBigDepartment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbBigDepartmentInput.Texts.Trim()))
            {
                SqlSoft sqlSoft = new SqlSoft();
                sqlSoft.sqlInsertAdminDepartmentInfo(txbBigDepartmentInput.Texts.Trim());
                txbBigDepartmentInput.Texts = "";
                label1.Focus();
                LoadDepartmentCombobox();
            }
            else
            {
                Alert("Vui lòng không để trống dữ liệu!\r\n请不要将数据留空！", Form_Alert.enmType.Info);
            }
        }

        private void DatabaseConfigView_Load(object sender, EventArgs e)
        {
            LoadDepartmentCombobox();
        }

        private void txbStationNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txbStationNameInput.Texts.Trim()))
                {
                    if (cbxChooseDepartment.Items.Count > 0)
                    {
                        SqlSoft sqlSoft = new SqlSoft();
                        sqlSoft.sqlInsertAdminStationInfo(txbStationNameInput.Texts.Trim(), cbxChooseDepartment.SelectedValue.ToString());
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

        private void btnAddStationInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbStationNameInput.Texts.Trim()))
            {
                if (cbxChooseDepartment.Items.Count > 0)
                {
                    SqlSoft sqlSoft = new SqlSoft();
                    sqlSoft.sqlInsertAdminStationInfo(txbStationNameInput.Texts.Trim(), cbxChooseDepartment.SelectedValue.ToString());
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

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(UUIDGenerator.getAscId());
            Alert("UID đã được tạo vào lưu vào clipboard!\r\n生成的UID保存到剪贴板！", Form_Alert.enmType.Success);
        }
    }
}
