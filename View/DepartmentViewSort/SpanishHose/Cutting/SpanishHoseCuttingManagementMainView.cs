using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one
{
    public partial class SpanishHoseCuttingManagementMainView : Form
    {
        //Fields
        string dataIn;
        int totalQuantity;
        double weightRT;
        string tempDescription;
        string tempSelectedMaterial = String.Empty;
        string tempSelectedMaterialType = String.Empty;
        bool isExitApplication = false;
        SqlSoft sqlSoft = new SqlSoft();
        public SpanishHoseCuttingManagementMainView()
        {
            InitializeComponent();
        }

        //Methods
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void ResetLabel()
        {
            dtgvSearchProduct.DataSource = null;
            dtgvSearchMaterial.DataSource = null;
            cbxChooseMaterialType.SelectedIndex = 0;
            txbQuantity.Texts = String.Empty;
            txbEmpCode.Texts = String.Empty;
            tempSelectedMaterial = String.Empty;
            lbSelectedProductCode.Text = "...";
            lbSelectedMaterialCode.Text = "...";
        }
        private void CloseSerialPort()
        {
            isExitApplication = true;
            Thread.Sleep(serialPort1.ReadTimeout); //Wait for reading threads to finish
            serialPort1.Close();
            isExitApplication = false;
        }
        private void showData(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dataIn))
            {
                if (Double.TryParse(dataIn, out weightRT))
                {
                    lbWeight.Text = weightRT.ToString();
                }
            }
        }

        private bool checkNull()
        {
            if (!String.IsNullOrEmpty(txbQuantity.Texts.Trim()))
            {
                if (txbQuantity.Texts.Trim() == "0")
                {
                    return false;
                }
                else
                {
                    if (!String.IsNullOrEmpty(txbEmpCode.Texts.Trim()))
                        return true;
                    else
                        return false;
                }
            }
            else
                return false;
        }

        private void ConnectScale()
        {
            try
            {
                serialPort1.PortName = Properties.Settings.Default.comPort;
                serialPort1.BaudRate = Convert.ToInt32(Properties.Settings.Default.baudRate);
                serialPort1.DataBits = Convert.ToInt32(Properties.Settings.Default.dataBits);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Properties.Settings.Default.stopBits);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Properties.Settings.Default.parityBits);
                serialPort1.ReadTimeout = 100;
                serialPort1.Open();
                Alert("Kết nối cân thành công\r\n秤连接成功", Form_Alert.enmType.Success);
            }
            catch (Exception err)
            {
                CTMessageBox.Show("Lỗi kết nối cân\n\r口连接错误:" + err.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadSearchProductData(string keyWord)
        {
            if (String.IsNullOrEmpty(keyWord))
            {
                ResetLabel();
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                DataTable dt = new DataTable();
                stringBuilder.Append("select product_no, description from spanish_hose_base_data where product_no like '%" + keyWord + "%' or description like '%" + keyWord + "%'");
                sqlSoft.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dt);

                dtgvSearchProduct.DataSource = null;
                if (dt.Rows.Count > 0)
                {
                    CTMessageBox.Show("Đã tìm thấy " + dt.Rows.Count + " mã thành phẩm!\n已找到 " + dt.Rows.Count + " 个成品代码", "Thông báo / 提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvSearchProduct.DataSource = dt;
                    dtgvSearchProduct.Columns["product_no"].HeaderText = "Mã thành phẩm\r\n成品代码";
                    dtgvSearchProduct.Columns["description"].HeaderText = "Quy cách\r\n规格";
                }
                else
                {
                    CTMessageBox.Show("Không tìm thấy mã thành phẩm trùng khớp!\n没找到匹配的成品代码", "Thông báo / 提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LoadSearchMaterialData(string keyWord)
        {
            if (String.IsNullOrEmpty(keyWord))
            {
                ResetLabel();
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                DataTable dt = new DataTable();
                if(keyWord.Contains(';'))
                {
                    string[] key = keyWord.Split(';');
                    stringBuilder.Append("select material_code, material_type from spanish_hose_material_data where material_code like '%" + key[0].Trim() + "%' or material_code like '%" + key[1].Trim() + "%'");
                }
                else
                {
                    stringBuilder.Append("select material_code, material_type from spanish_hose_material_data where material_code like '%" + keyWord + "%'");

                }
                sqlSoft.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dt);

                dtgvSearchMaterial.DataSource = null;
                if (dt.Rows.Count > 0)
                {
                    CTMessageBox.Show("Đã tìm thấy " + dt.Rows.Count + " mã nguyên liệu!\n已经找到了 " + dt.Rows.Count + " 材料！", "Thông báo / 提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvSearchMaterial.DataSource = dt;
                    dtgvSearchMaterial.Columns["material_code"].HeaderText = "Mã nguyên liệu\r\n原材料代码";
                    dtgvSearchMaterial.Columns["material_type"].HeaderText = "Loại nguyên liệu\r\n材料的类型";
                }
                else
                {
                    CTMessageBox.Show("Không tìm thấy mã nguyên liệu trùng khớp!\n找不到匹配的材料代码！", "Thông báo / 提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void checkDataInput(DateTime dateIn, DateTime dateOut)
        {
            try
            {
                DataTable dt = new DataTable();
                StringBuilder queryGetData = new StringBuilder();
                queryGetData.Append("select * from spanish_hose_realtime where permission_dept = 'Cutting' and create_date >= '" + dateIn.ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + dateOut.ToString("yyyy-MM-dd HH:mm:ss") + "' order by create_date desc");
                sqlSoft.sqlDataAdapterFillDatatable(queryGetData.ToString(), ref dt);

                dtgvCheckData.DataSource = dt;
                dtgvCheckData.Columns["uuid"].Visible = false;
                dtgvCheckData.Columns["product_no"].HeaderText = "Mã thành phẩm\r\n成品代码";
                dtgvCheckData.Columns["material_no"].HeaderText = "Mã nguyên liệu\r\n原材料代码";
                dtgvCheckData.Columns["material_type"].HeaderText = "Loại nguyên liệu\r\n材料的类型";
                dtgvCheckData.Columns["description"].HeaderText = "Ghi chú\r\n笔记";
                dtgvCheckData.Columns["quantity"].HeaderText = "Số PCS";
                dtgvCheckData.Columns["weight"].HeaderText = "Trọng lượng\r\n重量";
                dtgvCheckData.Columns["sender"].HeaderText = "Người gửi\r\n发件人";
                dtgvCheckData.Columns["receiver"].HeaderText = "Người nhận\r\n接收者";
                dtgvCheckData.Columns["create_date"].HeaderText = "Ngày nhận\r\n领料日期 ";
                dtgvCheckData.Columns["permission_dept"].Visible = false;
            }
            catch (Exception)
            {
                throw new Exception("Không thể lấy dữ liệu đã nhập từ hệ thống!\r\n无法从系统中导入数据！");
            }
        }
        //Event handler

        private void txbSearchCode__TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSearchProduct.Texts.Trim()))
            {
                LoadSearchProductData(null);
                ResetLabel();
            }
        }


        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbEmpCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SpanishHoseCuttingManagementMainView_Load(object sender, EventArgs e)
        {
            btnSave.ButtonText = "Hoàn tất\r\n结束";
            btnSaveExcel.ButtonText = "Xuất báo biểu excel\r\n导出 EXCEL 报告";
            btnCheckData.ButtonText = "Kiểm tra nhanh\r\n快速检查数据";
            checkDataInput(DateTime.Now.AddHours(-8), DateTime.Now);
            ConnectScale();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isExitApplication)
            {
                try
                {
                    dataIn = serialPort1.ReadLine().Replace("kg", "").Trim();
                    this.BeginInvoke(new EventHandler(showData));
                }
                catch (Exception)
                {
                    Alert("Serial port exception throw", Form_Alert.enmType.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Type và weight tùy theo type

                string matType = cbxChooseMaterialType.Text;
                string matCodeSilicone = lbSelectedMaterialCode.Text.Trim();
                double matWeight = Convert.ToDouble(lbWeight.Text.Trim());
                int selectType = cbxChooseMaterialType.SelectedIndex;
                string reEmp = SubMethods.GetEmpNameAndCode(txbEmpCode.Texts);
                if (selectType == 1)
                {
                    if (!tempSelectedMaterialType.Contains('&'))
                    {
                        CTMessageBox.Show("Cần phải chọn 2 nguyên liệu cho loại FS!\r\n需要为FS类型选择2种成分！", "Xác nhận 断言", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (!String.IsNullOrEmpty(reEmp))
                {
                    SpanishHoseCuttingInfo sh = new SpanishHoseCuttingInfo();
                    sh.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    sh.MainCode = lbSelectedProductCode.Text.Trim();
                    sh.Description = tempDescription.Trim();
                    totalQuantity = Convert.ToInt32(txbQuantity.Texts);
                    sh.Quantity = totalQuantity;
                    sh.Receiver = reEmp;
                    sh.Sender = UserData.UserCode + " - " + UserData.UserName;



                    DialogResult dialogResult = CTMessageBox.Show("Xác nhận lưu dữ liệu đã nhập ?\r\n确认保存输入的数据？", "Xác nhận 断言", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        LoadingDialog loading = new LoadingDialog();
                        Thread backgroundThreadSaveData = new Thread(
                        new ThreadStart(() =>
                        {
                            string successMessage, errorMessage = "Lưu dữ liệu thất bại!\n\r保存数据失败！";
                            StringBuilder queryInsertData = new StringBuilder();
                            switch (selectType)
                            {
                                case 0:
                                    if(tempSelectedMaterialType.Contains("&") || tempSelectedMaterialType.Contains("FABRIC"))
                                    {
                                        CTMessageBox.Show("Chỉ được chọn 1 nguyên liệu và phải là silicone!\r\n只选择一种材料，必须是有机硅！", "Xác nhận 断言", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                    else if (!tempSelectedMaterialType.Contains("&") && tempSelectedMaterialType.Contains("SILICONE"))
                                    {
                                        sh.MaterialCode = matCodeSilicone;
                                        sh.MaterialType = matType;
                                        sh.Weight = matWeight;
                                        successMessage = "Lưu dữ liệu thành công!\n\r数据保存成功！\r\nThành phẩm:" + sh.MainCode + "\r\nLiệu:" + sh.MaterialCode + "\r\nLoại:" + sh.MaterialType + "\r\nSố PCS:" + sh.Quantity + "\r\nTrọng lượng:" + sh.Weight;
                                        queryInsertData.Append("exec Insert_spanish_hose_realtime '" + UUIDGenerator.getAscId() + "', N'" + sh.MainCode + "', N'" + sh.MaterialCode + "', N'" + sh.MaterialType + "', N'" + sh.Description + "', " + sh.Quantity + ", '" + sh.Weight + "', N'" + sh.Sender + "', N'" + sh.Receiver + "', '" + sh.Date + "', 'Cutting'");
                                        sqlSoft.sqlExecuteNonQuery(queryInsertData.ToString(), successMessage, errorMessage);
                                        break;
                                    }
                                    break;
                                case 1:
                                    string[] splitMaterial = tempSelectedMaterialType.Split('&');
                                    if (splitMaterial.Any(word => word.Contains("FABRIC")) && splitMaterial.Any(word => word.Contains("SILICONE")))
                                    {
                                        for(int i = 0; i < splitMaterial.Count(); i++)
                                        {
                                            queryInsertData = new StringBuilder();
                                            string[] detailInfo = splitMaterial[i].Split('#');
                                            if (detailInfo[1].Contains("FABRIC"))
                                            {
                                                sh.MaterialCode = detailInfo[0];
                                                sh.MaterialType = "F";
                                                sh.Weight = (matWeight / 100) * 20;
                                                successMessage = "Lưu dữ liệu thành công!\n\r数据保存成功！\r\nThành phẩm:" + sh.MainCode + "\r\nLiệu:" + sh.MaterialCode + "\r\nLoại:" + sh.MaterialType + "\r\nSố PCS:" + sh.Quantity + "\r\nTrọng lượng:" + sh.Weight;
                                                queryInsertData.Append("exec Insert_spanish_hose_realtime '" + UUIDGenerator.getAscId() + "', N'" + sh.MainCode + "', N'" + sh.MaterialCode + "', N'" + sh.MaterialType + "', N'" + sh.Description + "', " + sh.Quantity + ", '" + sh.Weight + "', N'" + sh.Sender + "', N'" + sh.Receiver + "', '" + sh.Date + "', 'Cutting'");
                                                sqlSoft.sqlExecuteNonQuery(queryInsertData.ToString(), successMessage, errorMessage);
                                            }
                                            if (detailInfo[1].Contains("SILICONE"))
                                            {
                                                sh.MaterialCode = detailInfo[0];
                                                sh.MaterialType = "S";
                                                sh.Weight = (matWeight / 100) * 80;
                                                successMessage = "Lưu dữ liệu thành công!\n\r数据保存成功！\r\nThành phẩm:" + sh.MainCode + "\r\nLiệu:" + sh.MaterialCode + "\r\nLoại:" + sh.MaterialType + "\r\nSố PCS:" + sh.Quantity + "\r\nTrọng lượng:" + sh.Weight;
                                                queryInsertData.Append("exec Insert_spanish_hose_realtime '" + UUIDGenerator.getAscId() + "', N'" + sh.MainCode + "', N'" + sh.MaterialCode + "', N'" + sh.MaterialType + "', N'" + sh.Description + "', " + sh.Quantity + ", '" + sh.Weight + "', N'" + sh.Sender + "', N'" + sh.Receiver + "', '" + sh.Date + "', 'Cutting'");
                                                sqlSoft.sqlExecuteNonQuery(queryInsertData.ToString(), successMessage, errorMessage);
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        CTMessageBox.Show("2 nguyên liệu không thỏa điều kiện!\r\n2种成分不满足条件！", "Xác nhận 断言", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            loading.BeginInvoke(new Action(() => loading.Close()));
                        }));
                        backgroundThreadSaveData.Start();
                        loading.ShowDialog();

                        txbSearchProduct.Focus();
                        checkDataInput(DateTime.Now.AddHours(-8), DateTime.Now);
                    }
                }
                else
                {
                    Alert("Kiểm tra lại mã nhân viên!\r\n再次检查员工代码!", Form_Alert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Lỗi hệ thống! Vui lòng chụp màn hình và báo cho bộ phận phần mềm!\r\n系统错误！请截图并反馈给软件部！" + "\r\n\r\n" + ex.Message, "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string dateIn = dtpDateIn.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string dateOut = dtpDateOut.Value.ToString("yyyy-MM-dd HH:mm:ss");
                ProgressDialog progressDialog = new ProgressDialog();
                DataTable dt = new DataTable();
                StringBuilder queryGetData = new StringBuilder();
                queryGetData.Append("select * from spanish_hose_realtime where permission_dept = 'Cutting' and create_date >= '" + dateIn + "' and create_date <= '" + dateOut + "' order by create_date desc");
                sqlSoft.sqlDataAdapterFillDatatable(queryGetData.ToString(), ref dt);

                if (dt.Rows.Count > 0)
                {
                    List<SpanishHoseCuttingInfo> details = new List<SpanishHoseCuttingInfo>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SpanishHoseCuttingInfo d = new SpanishHoseCuttingInfo();
                        d.Date = Convert.ToDateTime(dt.Rows[i]["create_date"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                        d.MainCode = dt.Rows[i]["product_no"].ToString();
                        d.MaterialCode = dt.Rows[i]["material_no"].ToString();
                        d.MaterialType = dt.Rows[i]["material_type"].ToString();
                        d.Description = dt.Rows[i]["description"].ToString();
                        d.Quantity = Convert.ToInt32(dt.Rows[i]["quantity"].ToString());
                        d.Weight = Convert.ToDouble(dt.Rows[i]["weight"].ToString());
                        d.Sender = dt.Rows[i]["sender"].ToString();
                        d.Receiver = dt.Rows[i]["receiver"].ToString();
                        details.Add(d);
                    }
                    ExcelSave.SaveExcel_SpanishHoseCutting(details);
                }
                else
                {
                    CTMessageBox.Show("Không lấy được dữ liệu từ server! \r\n 无法从服务器获取数据！", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SpanishHoseCuttingManagementMainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = CTMessageBox.Show("Bạn muốn tắt công cụ đang sử dụng ?\r\n您想关闭正在使用的工具吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (serialPort1.IsOpen)
                    CloseSerialPort();
            }
        }

        private void btnCheckData_Click(object sender, EventArgs e)
        {
            checkDataInput(dtpDateIn.Value, dtpDateOut.Value);
        }

        private void txbEmpCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BeginInvoke(new EventHandler(btnSave_Click));
            }
        }

        private void txbQuantity__TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbQuantity.Texts))
            {
                lbQuantity.Text = "0 PCS";
            }
            else
            {
                lbQuantity.Text = txbQuantity.Texts + " PCS";
            }
        }

        private void txbSearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadSearchProductData(txbSearchProduct.Texts.Trim());
            }
        }

        private void dtgvSearchProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSearchProduct.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvSearchProduct.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvSearchProduct.Rows[selectedrowindex];
                lbSelectedProductCode.Text = selectedRow.Cells[0].Value.ToString();
                tempDescription = selectedRow.Cells[1].Value.ToString();
            }
        }

        private void txbSearchMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadSearchMaterialData(txbSearchMaterial.Texts.Trim());
            }
        }

        private void dtgvSearchMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSearchMaterial.SelectedCells.Count > 0 && dtgvSearchMaterial.SelectedCells.Count < 3)
            {
                tempSelectedMaterial = String.Empty;
                tempSelectedMaterialType = String.Empty;
                for (int i = 0; i < dtgvSearchMaterial.SelectedCells.Count; i++)
                {
                    int selectedrowindex = dtgvSearchMaterial.SelectedCells[i].RowIndex;
                    DataGridViewRow selectedRow = dtgvSearchMaterial.Rows[selectedrowindex];
                    if (String.IsNullOrEmpty(tempSelectedMaterial))
                    {
                        tempSelectedMaterial = selectedRow.Cells[0].Value.ToString();
                        tempSelectedMaterialType = selectedRow.Cells[0].Value.ToString() + "#" + selectedRow.Cells[1].Value.ToString();
                    }
                    else
                    {
                        tempSelectedMaterial += "; " + selectedRow.Cells[0].Value.ToString();
                        tempSelectedMaterialType += "&" + selectedRow.Cells[0].Value.ToString() + "#" + selectedRow.Cells[1].Value.ToString();
                    }
                }
                lbSelectedMaterialCode.Text = tempSelectedMaterial;
            }
            else
            {

            }
        }
    }
}
