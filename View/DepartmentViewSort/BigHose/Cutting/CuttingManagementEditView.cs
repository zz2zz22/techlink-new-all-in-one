using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainController.SubLogic.GetEmpInfo;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one
{
    public partial class CuttingManagementEditView : Form
    {
        //Fields
        string selectedUUID = String.Empty;
        DataTableCollection tables;
        SqlSoft sqlSoft = new SqlSoft();

        //Constructor
        public CuttingManagementEditView()
        {
            InitializeComponent();
        }

        //Methods
        #region METHODS
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private DataTable LoadDataWithKey(string keyword, string date)
        {
            DataTable dataTable = new DataTable();
            StringBuilder stringBuilder = new StringBuilder();
            if (String.IsNullOrEmpty(keyword))
                stringBuilder.Append("select * from big_hose_realtime where create_date >= '" + date + " 00:00:00' and create_date <= '" + date + " 23:59:59' and permission_dept = 'Cutting' order by create_date desc");
            else if (!String.IsNullOrEmpty(keyword))
                stringBuilder.Append("select * from big_hose_realtime where (product_no like '%" + keyword + "%' or cloth_no like '%" + keyword + "%') and create_date >= '" + date + " 00:00:00' and create_date <= '" + date + " 23:59:59' and permission_dept = 'Cutting' order by create_date desc");
            sqlSoft.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dataTable);
            return dataTable;
        }
        private void LoadShowDTGV(string keyword)
        {
            dtgvShowData.DataSource = null;
            dtgvShowData.DataSource = LoadDataWithKey(keyword, dtpSearchDate.Value.ToString("yyyy-MM-dd"));
            dtgvShowData.Columns["create_date"].HeaderText = "Ngày tạo";
            dtgvShowData.Columns["create_date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dtgvShowData.Columns["product_no"].HeaderText = "Mã thành phẩm";
            dtgvShowData.Columns["cloth_no"].HeaderText = "Mã lớp vải";
            dtgvShowData.Columns["quantity"].HeaderText = "Số Lượng";
            dtgvShowData.Columns["weight"].HeaderText = "Khối lượng";
            dtgvShowData.Columns["sender"].HeaderText = "Người ghi";
            dtgvShowData.Columns["receiver"].HeaderText = "Người nhận";
            dtgvShowData.Columns["uuid"].Visible = false;
            dtgvShowData.Columns["permission_dept"].Visible = false;
        }
        private string GetEmpData(string Code)
        {
            GetEmpInfoFromTxCard.GetAllEmpInfo(Code);
            return GetEmpInfoFromTxCard.Code + " - " + GetEmpInfoFromTxCard.Name;
        }
        #endregion

        //Event handler
        private void CuttingManagementEditView_Load(object sender, EventArgs e)
        {
            selectedUUID = String.Empty;
            dtpSearchDate.Value = DateTime.Now;
            LoadShowDTGV(null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadShowDTGV(txbSearchKey.Texts.Trim().ToUpper());
        }

        private void dtgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvShowData.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvShowData.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvShowData.Rows[selectedrowindex];
                dtpCreateDate.Value = Convert.ToDateTime(selectedRow.Cells["create_date"].Value);
                txbProductNo.Texts = Convert.ToString(selectedRow.Cells["product_no"].Value);
                txbClothNo.Texts = Convert.ToString(selectedRow.Cells["cloth_no"].Value);
                txbQuantity.Texts = Convert.ToString(selectedRow.Cells["quantity"].Value);
                txbWeight.Texts = Convert.ToString(selectedRow.Cells["weight"].Value);
                selectedUUID = Convert.ToString(selectedRow.Cells["uuid"].Value);
                string[] senderEmpCode = Convert.ToString(selectedRow.Cells["sender"].Value).Split('-');
                string[] receiverEmpCode = Convert.ToString(selectedRow.Cells["receiver"].Value).Split('-');
                txbSender.Texts = senderEmpCode[1].Trim();
                txbReceiver.Texts = receiverEmpCode[1].Trim();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialog = CTMessageBox.Show("Thêm dữ liệu vừa nhập ? Hãy kiểm tra kĩ lại trước khi xác nhận!\r\n添加导入的数据？确认前请仔细检查！", "Xác nhận 断言", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    StringBuilder sqlInsert = new StringBuilder();
                    string senderEmp = GetEmpData(txbSender.Texts.Trim());
                    string receiverEmp = GetEmpData(txbReceiver.Texts.Trim());
                    sqlInsert.Append("exec Insert_big_hose_realtime '" + UUIDGenerator.getAscId() + "', N'" + txbProductNo.Texts.Trim().ToUpper() + "', N'" + txbClothNo.Texts.Trim().ToUpper() + "', '" + txbQuantity.Texts + "', '" + txbWeight.Texts + "', N'" + senderEmp + "', N'" + receiverEmp + "', '" + dtpCreateDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', 'Cutting'");
                    sqlSoft.sqlExecuteNonQuery(sqlInsert.ToString());

                    Alert("Thêm dữ liệu thành công!\r\n添加数据成功！", Form_Alert.enmType.Success);

                    LoadShowDTGV(txbSearchKey.Texts.Trim().ToUpper());
                }
                catch(Exception ex)
                {
                    CTMessageBox.Show("Lỗi khi thêm dữ liệu!\r\n添加数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txbSender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbReceiver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedUUID))
            {
                DialogResult dialog = CTMessageBox.Show("Chỉnh sửa dữ liệu ? Hãy kiểm tra kĩ lại trước khi xác nhận!\r\n编辑数据？确认前请仔细检查！", "Xác nhận 断言", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        StringBuilder sqlUpdate = new StringBuilder();
                        string senderEmp = GetEmpData(txbSender.Texts.Trim());
                        string receiverEmp = GetEmpData(txbReceiver.Texts.Trim());
                        sqlUpdate.Append("exec Update_big_hose_realtime '" + selectedUUID + "', N'" + txbProductNo.Texts.Trim().ToUpper() + "', N'" + txbClothNo.Texts.Trim().ToUpper() + "', '" + txbQuantity.Texts + "', '" + txbWeight.Texts + "', N'" + senderEmp + "', N'" + receiverEmp + "', '" + dtpCreateDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', 'Cutting'");
                        sqlSoft.sqlExecuteNonQuery(sqlUpdate.ToString());

                        Alert("Chỉnh sửa dữ liệu thành công!\r\n编辑数据成功！", Form_Alert.enmType.Success);

                        LoadShowDTGV(txbSearchKey.Text.Trim().ToUpper());
                    }
                    catch (Exception ex)
                    {
                        CTMessageBox.Show("Lỗi khi chỉnh sửa dữ liệu!\r\n编辑数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedUUID))
            {
                DialogResult dialog = CTMessageBox.Show("Xóa dữ liệu vừa chọn ? Hãy kiểm tra kĩ lại trước khi xác nhận!\r\n删除选定的数据？确认前请仔细检查！", "Xác nhận 断言", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        StringBuilder sqlDelete = new StringBuilder();
                        sqlDelete.Append("exec Delete_big_hose_realtime '" + selectedUUID + "', 'Cutting'");
                        sqlSoft.sqlExecuteNonQuery(sqlDelete.ToString());

                        Alert("Xóa thành công!\r\n删除成功！", Form_Alert.enmType.Success);

                        LoadShowDTGV(txbSearchKey.Text.Trim().ToUpper());

                    }
                    catch (Exception ex)
                    {
                        CTMessageBox.Show("Lỗi khi xóa dữ liệu!\r\n删除数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtpSearchDate.Value = DateTime.Now;
            txbSearchKey.Texts = "";
            selectedUUID = String.Empty;
            LoadShowDTGV(null);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tables = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tables)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                sqlSoft.sqlExecuteNonQuery("exec Delete_big_hose_base_data");
                foreach (DataGridViewRow row in customerBindingSource.Rows)
                {
                    StringBuilder sb = new StringBuilder();
                    string product_no = row.Cells["product_no"].Value.ToString(), description = row.Cells["description"].Value.ToString(), unit = "", quantity = row.Cells["quantity"].Value.ToString();
                    sb.Append("exec Insert_big_hose_base_data N'" + product_no + "', N'" + description + "', '" + unit + "', '" + quantity + "'");
                    sqlSoft.sqlExecuteNonQuery(sb.ToString());
                }
                Alert("Nhập dữ liệu vào hệ thống hoàn tất!\r\n数据录入系统完成！", Form_Alert.enmType.Success);
            }
            catch(Exception ex)
            {
                CTMessageBox.Show("Lỗi khi thêm dữ liệu!\r\n添加数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = tables[cboSheet.SelectedItem.ToString()];
            dt = dt.AsEnumerable().GroupBy(r => new { ProductNo = r.ItemArray[0], Description = r.ItemArray[1] }).Select(g => g.First()).CopyToDataTable();
            if (dt != null)
            {
                List<BigHoseCuttingItemInfo> list = new List<BigHoseCuttingItemInfo>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BigHoseCuttingItemInfo obj = new BigHoseCuttingItemInfo();
                    obj.product_no = dt.Rows[i]["1"].ToString().Trim();
                    obj.description = dt.Rows[i]["2"].ToString().Trim();
                    obj.unit = "";
                    obj.quantity = dt.Rows[i]["3"].ToString().Trim();
                    list.Add(obj);
                }
                customerBindingSource.DataSource = list;
            }
        }

        private void CuttingManagementEditView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Bạn muốn tắt công cụ đang sử dụng ?\r\n您想关闭正在使用的工具吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
