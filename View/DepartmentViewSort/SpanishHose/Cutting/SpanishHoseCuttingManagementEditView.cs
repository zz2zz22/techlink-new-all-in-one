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
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one
{ 
    public partial class SpanishHoseCuttingManagementEditView : Form
    {
        //Fields
        string selectedUUID = String.Empty;
        DataTableCollection tables;
        public SpanishHoseCuttingManagementEditView()
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
            SqlSoft sqlSoft = new SqlSoft();
            StringBuilder stringBuilder = new StringBuilder();
            if (String.IsNullOrEmpty(keyword))
                stringBuilder.Append("select * from spanish_hose_realtime where create_date >= '" + date + " 00:00:00' and create_date <= '" + date + " 23:59:59' and permission_dept = 'Cutting' order by create_date desc");
            else if (!String.IsNullOrEmpty(keyword))
                stringBuilder.Append("select * from spanish_hose_realtime where product_no like '%" + keyword + "%' and create_date >= '" + date + " 00:00:00' and create_date <= '" + date + " 23:59:59' and permission_dept = 'Cutting' order by create_date desc");
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
            dtgvShowData.Columns["description"].HeaderText = "Ghi chú";
            dtgvShowData.Columns["quantity"].HeaderText = "Số Lượng";
            dtgvShowData.Columns["weight"].HeaderText = "Khối lượng";
            dtgvShowData.Columns["sender"].HeaderText = "Người ghi";
            dtgvShowData.Columns["receiver"].HeaderText = "Người nhận";
            dtgvShowData.Columns["uuid"].Visible = false;
            dtgvShowData.Columns["permission_dept"].Visible = false;
        }
        private string GetEmpData(string Code)
        {
            SqlHR sqlHR = new SqlHR();
            string EmpCode = sqlHR.sqlExecuteScalarString("select distinct Code from ZlEmployee where Code like '%-%' and CAST(SUBSTRING(Code, CHARINDEX('-', Code) + 1, LEN(Code)) AS int) = '" + Code + "'");
            string EmpName = sqlHR.sqlExecuteScalarString("select distinct Name from ZlEmployee where Code = '" + EmpCode + "'");
            return EmpCode + " - " + EmpName.TrimEnd();
        }

        #endregion

        private void SpanishHoseCuttingManagementEditView_Load(object sender, EventArgs e)
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
                txbClothNo.Texts = Convert.ToString(selectedRow.Cells["description"].Value);
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
                DateTime time = new DateTime();
                SqlSoft sqlSoft = new SqlSoft();
                StringBuilder sqlInsert = new StringBuilder();

                time = dtpCreateDate.Value;

                string senderEmp = GetEmpData(txbSender.Texts.Trim());
                string receiverEmp = GetEmpData(txbReceiver.Texts.Trim());
                sqlInsert.Append("insert into spanish_hose_realtime ");
                sqlInsert.Append("(uuid, product_no, description, quantity, weight, sender, receiver, create_date, permission_dept) ");
                sqlInsert.Append("values ");
                sqlInsert.Append("('" + UUIDGenerator.getAscId() + "', '" + txbProductNo.Texts.Trim().ToUpper() + "', '" + txbClothNo.Texts.Trim().ToUpper() + "', '" + txbQuantity.Texts + "', '" + txbWeight.Texts + "', '" + senderEmp + "', '" + receiverEmp + "', '" + time.ToString("yyyy-MM-dd HH:mm:ss.000") + "', 'Cutting')");
                sqlSoft.sqlExecuteNonQuery(sqlInsert.ToString());

                Alert("Thêm dữ liệu thành công!\r\n添加数据成功！", Form_Alert.enmType.Success);

                LoadShowDTGV(txbSearchKey.Texts.Trim().ToUpper());
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
                    SqlSoft sqlSoft = new SqlSoft();
                    StringBuilder sqlUpdate = new StringBuilder();
                    sqlUpdate.Append("update spanish_hose_realtime ");
                    sqlUpdate.Append("set product_no = '" + txbProductNo.Texts.Trim().ToUpper() + "',  description = N'" + txbClothNo.Texts.Trim().ToUpper() + "', quantity = '" + txbQuantity.Texts + "', weight = '" + txbWeight.Texts + "' ");
                    sqlUpdate.Append("where uuid = '" + selectedUUID + "' and permission_dept = 'Cutting'");
                    sqlSoft.sqlExecuteNonQuery(sqlUpdate.ToString());

                    Alert("Chỉnh sửa dữ liệu thành công!\r\n编辑数据成功！", Form_Alert.enmType.Success);

                    LoadShowDTGV(txbSearchKey.Text.Trim().ToUpper());
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
                    SqlSoft sqlSoft = new SqlSoft();
                    StringBuilder sqlDelete = new StringBuilder();
                    sqlDelete.Append("delete spanish_hose_realtime where uuid = '" + selectedUUID + "' and permission_dept = 'Cutting'");
                    sqlSoft.sqlExecuteNonQuery(sqlDelete.ToString());

                    Alert("Xóa thành công!\r\n删除成功！", Form_Alert.enmType.Success);

                    LoadShowDTGV(txbSearchKey.Text.Trim().ToUpper());
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
            SqlSoft sqlSoft = new SqlSoft();
            sqlSoft.sqlExecuteNonQuery("delete from spanish_hose_base_data");
            foreach (DataGridViewRow row in customerBindingSource.Rows)
            {
                sqlSoft.sqlInsertSpanishHoseBaseData(row.Cells["product_no"].Value.ToString(), row.Cells["description"].Value.ToString(), row.Cells["unit"].Value.ToString(), 1);
            }
            Alert("Nhập dữ liệu vào hệ thống hoàn tất!\r\n数据录入系统完成！", Form_Alert.enmType.Success);
        }

        private void cboSheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = tables[cboSheet.SelectedItem.ToString()];
            dt = dt.AsEnumerable().GroupBy(r => new { ProductNo = r.ItemArray[0], Description = r.ItemArray[1] }).Select(g => g.First()).CopyToDataTable();
            if (dt != null)
            {
                List<SpanishHoseCuttingItemInfo> list = new List<SpanishHoseCuttingItemInfo>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SpanishHoseCuttingItemInfo obj = new SpanishHoseCuttingItemInfo();
                    obj.product_no = dt.Rows[i]["1"].ToString().Trim();
                    obj.description = dt.Rows[i]["2"].ToString().Trim();
                    obj.unit = dt.Rows[i]["3"].ToString().Trim();
                    obj.quantity = 1;
                    list.Add(obj);
                }
                customerBindingSource.DataSource = list;
            }
        }

        private void SpanishHoseCuttingManagementEditView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Bạn muốn tắt công cụ đang sử dụng ?\r\n您想关闭正在使用的工具吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
