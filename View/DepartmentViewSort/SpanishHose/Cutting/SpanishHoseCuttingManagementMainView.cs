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
using techlink_new_all_in_one.MainController.SubLogic.GetEmpInfo;
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
        double totalQuantity;
        double weightRT;
        string tempDescription;
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
            txbEmpCode.Texts = String.Empty;
            dtgvShowSearchResult.DataSource = null;
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
        private void LoadSearchData(string keyWord)
        {
            if (String.IsNullOrEmpty(keyWord))
            {
                ResetLabel();
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                DataTable dt = new DataTable();
                stringBuilder.Append("select product_no, description, quantity from spanish_hose_base_data where product_no like '%" + keyWord + "%' or description like '%" + keyWord + "%' and unit like 'PCS'");
                sqlSoft.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dt);

                dtgvShowSearchResult.DataSource = null;
                if (dt.Rows.Count > 0)
                {
                    CTMessageBox.Show("Đã tìm thấy " + dt.Rows.Count + " mã thành phẩm!\n已找到 " + dt.Rows.Count + " 个成品代码", "Thông báo / 提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvShowSearchResult.DataSource = dt;
                    dtgvShowSearchResult.Columns["product_no"].HeaderText = "Mã thành phẩm\r\n成品代码";
                    dtgvShowSearchResult.Columns["description"].HeaderText = "Ghi chú\r\n 笔记";
                    dtgvShowSearchResult.Columns["quantity"].Visible = false;
                }
                else
                {
                    CTMessageBox.Show("Không tìm thấy mã thành phẩm trùng khớp!\n没找到匹配的成品代码", "Thông báo / 提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
        private void checkDataInput()
        {
            try
            {
                DataTable dt = new DataTable();
                StringBuilder queryGetData = new StringBuilder();
                queryGetData.Append("select * from spanish_hose_realtime where permission_dept = 'Cutting' and create_date > '" + DateTime.Now.AddHours(-2).ToString("yyyy-MM-dd HH:mm:ss") + "' order by create_date desc");
                sqlSoft.sqlDataAdapterFillDatatable(queryGetData.ToString(), ref dt);

                dtgvCheckData.DataSource = dt;
                dtgvCheckData.Columns["uuid"].Visible = false;
                dtgvCheckData.Columns["product_no"].HeaderText = "Mã thành phẩm\r\n成品代码";
                dtgvCheckData.Columns["description"].HeaderText = "Ghi chú\r\n笔记";
                dtgvCheckData.Columns["quantity"].HeaderText = "Số tấm";
                dtgvCheckData.Columns["weight"].HeaderText = "Trọng lượng\r\n重量";
                dtgvCheckData.Columns["sender"].Visible = false;
                dtgvCheckData.Columns["receiver"].HeaderText = "Người nhận\r\n接收者";
                dtgvCheckData.Columns["create_date"].HeaderText = "Ngày nhận\r\n领料日期 ";
                dtgvCheckData.Columns["permission_dept"].Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Event handler
        private void txbSearchCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadSearchData(txbSearchCode.Texts.Trim());
            }
        }

        private void txbSearchCode__TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSearchCode.Texts.Trim()))
            {
                LoadSearchData(null);
                ResetLabel();
            }
        }

        private void dtgvShowSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvShowSearchResult.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvShowSearchResult.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvShowSearchResult.Rows[selectedrowindex];
                lbChooseProduct.Text = selectedRow.Cells[0].Value.ToString();
                tempDescription = selectedRow.Cells[1].Value.ToString();
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
            btnSave.ButtonText = "Lưu thông tin\r\n保存信息";
            btnSaveExcel.ButtonText = "Xuất báo biểu excel\r\n导出 EXCEL 报告";
            btnCheckData.ButtonText = "Kiểm tra nhanh\r\n快速检查数据";
            checkDataInput();
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
                SpanishHoseCuttingInfo sh = new SpanishHoseCuttingInfo();
                GetEmpInfoFromTxCard.GetAllEmpInfo(txbEmpCode.Texts);
                string reEmpCode = GetEmpInfoFromTxCard.Code;
                string reEmpName = GetEmpInfoFromTxCard.Name;
                sh.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                totalQuantity = Convert.ToDouble(txbQuantity.Texts);
                if (!String.IsNullOrEmpty(reEmpCode) || !String.IsNullOrEmpty(reEmpName))
                {
                    sh.MainCode = lbChooseProduct.Text.Trim();
                    sh.Description = tempDescription.Trim();
                    sh.Quantity = totalQuantity;
                    sh.Weight = Convert.ToDouble(lbWeight.Text.Trim());
                    sh.Receiver = reEmpCode + " - " + reEmpName.TrimEnd();
                    sh.Sender = UserData.user_emp_code + " - " + UserData.user_actual_name;

                    DialogResult dialogResult = CTMessageBox.Show("Xác nhận lưu dữ liệu đã nhập ?\r\n确认保存输入的数据？", "Xác nhận 断言", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        LoadingDialog loading = new LoadingDialog();
                        Thread backgroundThreadSaveData = new Thread(
                        new ThreadStart(() =>
                        {
                            string successMessage = "Lưu dữ liệu thành công!\n\r数据保存成功！";
                            string errorMessage = "Lưu dữ liệu thất bại!\n\r保存数据失败！";
                            StringBuilder queryInsertData = new StringBuilder();
                            queryInsertData.Append("exec Insert_spanish_hose_realtime '" + UUIDGenerator.getAscId() + "', N'" + sh.MainCode + "', N'" + sh.Description + "', " + sh.Quantity + ", '" + sh.Weight + "', N'" + sh.Sender + "', N'" + sh.Receiver + "', '" + sh.Date + "', 'Cutting'");
                            sqlSoft.sqlExecuteNonQuery(queryInsertData.ToString(), successMessage, errorMessage);
                            loading.BeginInvoke(new Action(() => loading.Close()));
                        }));
                        backgroundThreadSaveData.Start();
                        loading.ShowDialog();

                        txbSearchCode.Focus();
                        checkDataInput();
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
                ProgressDialog progressDialog = new ProgressDialog();
                DataTable dt = new DataTable();
                StringBuilder queryGetData = new StringBuilder();
                queryGetData.Append("select * from spanish_hose_realtime where permission_dept = 'Cutting' and create_date >= '" + dtpDateIn.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + dtpDateOut.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' order by create_date desc");
                sqlSoft.sqlDataAdapterFillDatatable(queryGetData.ToString(), ref dt);

                if (dt.Rows.Count > 0)
                {
                    List<SpanishHoseCuttingInfo> details = new List<SpanishHoseCuttingInfo>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SpanishHoseCuttingInfo d = new SpanishHoseCuttingInfo();
                        d.Date = Convert.ToDateTime(dt.Rows[i]["create_date"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                        d.MainCode = dt.Rows[i]["product_no"].ToString();
                        d.Description = dt.Rows[i]["description"].ToString();
                        d.Quantity = Convert.ToDouble(dt.Rows[i]["quantity"].ToString());
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
            try
            {
                DataTable dt = new DataTable();
                StringBuilder queryGetData = new StringBuilder();
                queryGetData.Append("select * from spanish_hose_realtime where permission_dept = 'Cutting' and create_date >= '" + dtpDateIn.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + dtpDateOut.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' order by create_date desc");
                sqlSoft.sqlDataAdapterFillDatatable(queryGetData.ToString(), ref dt);

                if (dt.Rows.Count > 0)
                {
                    dtgvCheckData.DataSource = dt;
                    dtgvCheckData.Columns["uuid"].Visible = false;
                    dtgvCheckData.Columns["product_no"].HeaderText = "Mã thành phẩm\r\n成品代码";
                    dtgvCheckData.Columns["description"].HeaderText = "Ghi chú\r\n笔记";
                    dtgvCheckData.Columns["quantity"].HeaderText = "Số tấm";
                    dtgvCheckData.Columns["weight"].HeaderText = "Trọng lượng\r\n重量";
                    dtgvCheckData.Columns["sender"].Visible = false;
                    dtgvCheckData.Columns["receiver"].Visible = false;
                    dtgvCheckData.Columns["create_date"].HeaderText = "Ngày nhận\r\n领料日期";
                    dtgvCheckData.Columns["permission_dept"].Visible = false;
                }
                else
                {
                    CTMessageBox.Show("Không lấy được dữ liệu từ server! \n 无法从服务器获取数据！", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                throw;
            }
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
                lbQuantity.Text = "0 tấm";
            }
            else
            {
                lbQuantity.Text = txbQuantity.Texts + " tấm";
            }
        }
    }
}
