using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one
{
    public partial class ExtrusionCalenderManagementMainView : Form
    {
        //Fields
        string dataIn;
        double weightRT, weightReturn;
        string dateStart = null, dateEnd = null;
        string selectedUUID = null;
        string productCodeReturn;
        bool isExitApplication = false;

        //Constructor
        public ExtrusionCalenderManagementMainView()
        {
            InitializeComponent();
        }
        //Methods
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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
        private void LoadCodeList2ComboBox(string keyWord)
        {
            if (String.IsNullOrEmpty(keyWord))
            {
                cbxCodeList.Items.Clear();
            }
            else
            {
                cbxCodeList.Items.Clear();
                SqlMes_base_data sqlMES = new SqlMes_base_data();
                StringBuilder sql = new StringBuilder();
                sql.Append("select distinct product_no from bom_info where product_no like '%" + keyWord.ToUpper() + "%' order by create_date desc");
                sqlMES.getComboBoxData(sql.ToString(), ref cbxCodeList);
                if (cbxCodeList.Items.Count <= 0)
                {
                    CTMessageBox.Show("Không tìm thấy mã hàng nào!" + Environment.NewLine + "未找到商品代码！", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    CTMessageBox.Show("Đã tìm thấy " + cbxCodeList.Items.Count + " mã hàng!" + Environment.NewLine + "找到 " + cbxCodeList.Items.Count + " 个项目代码！", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxCodeList.SelectedIndex = 0;
                }
            }
        }
        private void LoadData2DTGV(string key)
        {
            DataTable dt = new DataTable();
            dtgvHistoryList.DataSource = null;
            SqlSoft sql = new SqlSoft();
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrEmpty(key))
            {
                sb.Append("select * from extrusion_realtime where permission_dept = 'Calender' and create_date > '" + dateStart + "' and create_date < '" + dateEnd + "' order by create_date desc");
            }
            else
            {
                sb.Append("select * from extrusion_realtime where permission_dept = 'Calender' and product_code like '%" + key.ToLower() + "%' order by create_date desc");
            }
            sql.sqlDataAdapterFillDatatable(sb.ToString(), ref dt);

            dtgvHistoryList.DataSource = dt;

            dtgvHistoryList.Columns["uuid"].Visible = false;
            dtgvHistoryList.Columns["product_code"].HeaderText = "Mã thành phẩm\r\n成品代码";
            dtgvHistoryList.Columns["weight"].HeaderText = "Trọng lượng\r\n重量";
            dtgvHistoryList.Columns["length"].Visible = false;
            dtgvHistoryList.Columns["sender"].Visible = false;
            dtgvHistoryList.Columns["receiver"].HeaderText = "Người nhận\r\n接收者";
            dtgvHistoryList.Columns["permission_dept"].Visible = false;
            dtgvHistoryList.Columns["create_date"].HeaderText = "Ngày tạo\r\n创建日期";
            dtgvHistoryList.Columns["create_date"].DefaultCellStyle.Format = "dd/MM HH:mm:ss";
        }
        private bool checkNull()
        {
            if (String.IsNullOrEmpty(cbxCodeList.Text.Trim()) || String.IsNullOrEmpty(txbEmpCode.Texts))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Event Handler
        private void ExtrusionCalenderManagementMainView_Load(object sender, EventArgs e)
        {
            btnSave.ButtonText = "Lưu thông tin" + Environment.NewLine + "保存信息";
            btnSaveExcel.ButtonText = "Xuất Excel" + Environment.NewLine + "导出 EXCEL 报告";
            btnReturnMaterial.ButtonText = "Trả liệu" + Environment.NewLine + "还料";
            DateTime timeNow = DateTime.Now;
            if (timeNow.Hour >= 8 || timeNow.Hour <= 20)
            {
                dateStart = DateTime.Now.ToString("yyyy-MMM-dd 08:00:00");
                dateEnd = DateTime.Now.ToString("yyyy-MMM-dd 20:00:00");
            }
            else if (timeNow.Hour > 20)
            {
                dateStart = DateTime.Now.ToString("yyyy-MMM-dd 20:00:00");
                dateEnd = DateTime.Now.ToString("yyyy-MMM-dd 23:59:59");
            }
            else if (timeNow.Hour < 8)
            {
                dateStart = DateTime.Now.ToString("yyyy-MMM-dd 00:00:00");
                dateEnd = DateTime.Now.ToString("yyyy-MMM-dd 08:00:00");

            }
            LoadData2DTGV(String.Empty);
            ConnectScale();
        }

        private void txbSearchCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadCodeList2ComboBox(txbSearchCode.Texts.Trim());
            }
        }

        private void txbSearchCode__TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSearchCode.Texts.Trim()))
            {
                LoadCodeList2ComboBox(txbSearchCode.Texts.Trim());
                txbEmpCode.Texts = String.Empty;
                label1.Focus();
            }
        }

        private void ExtrusionCalenderManagementMainView_FormClosing(object sender, FormClosingEventArgs e)
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

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isExitApplication)
            {
                try
                {
                    dataIn = serialPort1.ReadLine().Replace("\r\n", "").Replace("kg", "").Trim();
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
                if (checkNull())
                {
                    DialogResult dialogResult = CTMessageBox.Show("Xác nhận lưu dữ liệu bên trên ?" + Environment.NewLine + "确认保存上面的数据？", "Cảnh báo / 警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        ExtrusionInfo d = new ExtrusionInfo();

                        string reEmp = SubMethods.GetEmpNameAndCode(txbEmpCode.Texts.Trim());
                        d.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        if (!String.IsNullOrEmpty(reEmp))
                        {
                            d.MainCode = cbxCodeList.Text.Trim();
                            d.Weight = Convert.ToDouble(lbWeight.Text.Trim());
                            d.Length = 0;
                            d.Receiver = reEmp;
                            d.Sender = UserData.UserCode + " - " + UserData.UserName;
                            LoadingDialog loading = new LoadingDialog();
                            Thread backgroundThreadSaveData = new Thread(
                            new ThreadStart(() =>
                            {
                                SqlSoft sqlSoft = new SqlSoft();
                                StringBuilder queryInsertData = new StringBuilder();
                                queryInsertData.Append(@"insert into extrusion_realtime ");
                                queryInsertData.Append(@"(uuid, product_code, length, weight, sender, receiver, create_date, permission_dept) ");
                                queryInsertData.Append("values ");
                                queryInsertData.Append("('" + UUIDGenerator.getAscId() + "', '" + d.MainCode + "', " + d.Length + ", " + d.Weight + ", N'" + d.Sender + "', N'" + d.Receiver + "', '" + d.Date + "', 'Calender')");
                                string successMessage = "Lưu dữ liệu thành công!\n\r数据保存成功！";
                                string errorMessage = "Lưu dữ liệu thất bại!\n\r保存数据失败！";
                                sqlSoft.sqlExecuteNonQuery(queryInsertData.ToString(), successMessage, errorMessage);
                                loading.BeginInvoke(new Action(() => loading.Close()));
                            }));
                            backgroundThreadSaveData.Start();
                            loading.ShowDialog();
                            txbSearchCode.Focus();

                            LoadData2DTGV(String.Empty);
                        }
                        else
                        {
                            Alert("Kiểm tra lại mã nhân viên \n\r 再次检查员工代码!!", Form_Alert.enmType.Error);
                        }
                    }
                }
                else
                {
                    Alert("Không đủ dữ liệu \n\r 数据不足!!", Form_Alert.enmType.Error);
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Lỗi hệ thống! Vui lòng chụp màn hình và báo cho bộ phận phần mềm!" + Environment.NewLine + "系统错误！请截图并反馈给软件部！" + "\r\n\r\n" + ex.Message, "Cảnh báo / 警告", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlSoft sqlSoft = new SqlSoft();
                StringBuilder queryGetData = new StringBuilder();
                queryGetData.Append("select * from extrusion_realtime where permission_dept = 'Calender' and create_date >= '" + dtpDateIn.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + dtpDateOut.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'");
                sqlSoft.sqlDataAdapterFillDatatable(queryGetData.ToString(), ref dt);

                if (dt.Rows.Count > 0)
                {
                    List<ExtrusionInfo> details = new List<ExtrusionInfo>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ExtrusionInfo d = new ExtrusionInfo();
                        d.Date = Convert.ToDateTime(dt.Rows[i]["create_date"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                        d.MainCode = dt.Rows[i]["product_code"].ToString();
                        d.Length = Convert.ToDouble(dt.Rows[i]["length"].ToString());
                        d.Weight = Convert.ToDouble(dt.Rows[i]["weight"].ToString());
                        d.Sender = dt.Rows[i]["sender"].ToString();
                        d.Receiver = dt.Rows[i]["receiver"].ToString();
                        details.Add(d);
                    }
                    ExcelSave.SaveExcel_ExtrusionCalender(details);
                }
                else
                {
                    CTMessageBox.Show("Không lấy được dữ liệu từ server! \r\n 无法从服务器获取数据！", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnReturnMaterial_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedUUID))
            {
                DialogResult dialogResult = CTMessageBox.Show("Xác nhận trả liệu " + productCodeReturn + "?", "Cảnh báo / 警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    double weight = Math.Round(weightReturn - Convert.ToDouble(lbWeight.Text.Trim()), 2);
                    if (weight < 0)
                        weight = 0;
                    SqlSoft sqlSoft = new SqlSoft();
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("update extrusion_realtime set weight = " + weight + " where uuid = '" + selectedUUID + "' and permission_dept = 'Calender'");
                    string successMessage = "Lưu dữ liệu thành công!\n\r数据保存成功！";
                    string errorMessage = "Lưu dữ liệu thất bại!\n\r保存数据失败！";
                    sqlSoft.sqlExecuteNonQuery(stringBuilder.ToString(), successMessage, errorMessage);
                    cbxCodeList.Text = String.Empty;
                    cbxCodeList.Items.Clear();
                    txbEmpCode.Text = String.Empty;
                    selectedUUID = null;
                    LoadData2DTGV(String.Empty);
                    lbSelectMaterial.Text = String.Empty;
                }
            }
            else
            {
                CTMessageBox.Show("Vui lòng chọn liệu cần trả!", "Cảnh báo / 警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData2DTGV(txbSearch.Text.ToUpper().Trim());
            }
        }

        private void dtgvHistoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvHistoryList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvHistoryList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvHistoryList.Rows[selectedrowindex];
                productCodeReturn = Convert.ToString(selectedRow.Cells["product_code"].Value);
                lbSelectMaterial.Text = productCodeReturn;
                selectedUUID = Convert.ToString(selectedRow.Cells["uuid"].Value);
                weightReturn = Convert.ToDouble(selectedRow.Cells["weight"].Value);
            }
        }

        private void txbEmpCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
