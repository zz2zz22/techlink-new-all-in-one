using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one.View.SubUI
{
    public partial class ProgramSettingView : Form
    {
        bool isChangeData = false;
        int deleteRowIndex = -1;
        string dataIn;
        bool isExitApplication = false;
        public ProgramSettingView()
        {
            InitializeComponent();
        }

        //Methods
        private void CloseSerialPort()
        {
            isExitApplication = true;
            Thread.Sleep(serialPort1.ReadTimeout); //Wait for reading threads to finish
            serialPort1.Close();
            isExitApplication = false;
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void showData(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dataIn))
            {
                txtDataIn.Text += dataIn + Environment.NewLine;
            }
        }
        private void SaveMailData()
        {
            if (!string.IsNullOrEmpty(txbSenderAddress.Texts))
                Properties.Settings.Default.sender_mail = txbSenderAddress.Texts;
            if (!string.IsNullOrEmpty(txbSenderPassword.Texts))
                Properties.Settings.Default.sender_password = txbSenderPassword.Texts;
            if (!string.IsNullOrEmpty(txbSMTPServer.Texts))
                Properties.Settings.Default.smtp_server = txbSMTPServer.Texts;
            if (!string.IsNullOrEmpty(txbSMTPport.Texts))
                Properties.Settings.Default.smtp_port = txbSMTPport.Texts;

            Properties.Settings.Default.recipients = string.Empty;
            if (dtgvRepicentsList.RowCount > 0)
            {
                for (int i = 0; i < dtgvRepicentsList.RowCount; i++)
                {
                    Properties.Settings.Default.recipients += dtgvRepicentsList.Rows[i].Cells[0].Value.ToString() + ";";
                }
            }
            Properties.Settings.Default.Save();
            LoadRepicents();
            isChangeData = false;
        }
        private void LoadRepicents()
        {
            dtgvRepicentsList.Rows.Clear();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.recipients))
            {
                string[] repicentList = Properties.Settings.Default.recipients.Split(';');
                if (repicentList.Length > 0 && repicentList != null)
                {
                    for (int i = 0; i < repicentList.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(repicentList[i]))
                            dtgvRepicentsList.Rows.Add(repicentList[i]);
                    }
                }
            }
        }
        private void CheckChange()
        {
            if (txbSenderAddress.Texts != Properties.Settings.Default.sender_mail)
                isChangeData = true;
            if (txbSenderPassword.Texts != Properties.Settings.Default.sender_password)
                isChangeData = true;
            if (txbSMTPServer.Texts != Properties.Settings.Default.smtp_server)
                isChangeData = true;
            if (txbSMTPport.Texts != Properties.Settings.Default.smtp_port)
                isChangeData = true;
        }

        //Event Handler
        private void ProgramSettingView_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.comPort))
            {
                string[] ports = SerialPort.GetPortNames();
                cbComPort.Items.AddRange(ports);
                cbComPort.Text = Properties.Settings.Default.comPort;
            }
            else
            {
                string[] ports = SerialPort.GetPortNames();
                cbComPort.Items.AddRange(ports);
            }
            cbBaudRate.Text = Properties.Settings.Default.baudRate;
            cbDataBits.Text = Properties.Settings.Default.dataBits;
            cbStopBits.Text = Properties.Settings.Default.stopBits;
            cbParityBits.Text = Properties.Settings.Default.parityBits;
            btn_testPort.ButtonText = "Thử kết nối\r\n尝试连接";
            btnSaveMailSettting.ButtonText = "Lưu cài đặt mail\r\n保存邮件设置";
            btnTestMailSingle.ButtonText = "Test gửi mail đã chọn\r\n测试发送选定的邮件";
            btnTestMailAll.ButtonText = "Test gửi mail tất cả\r\n测试邮件全部";
            btnDeleteRepicent.ButtonText = "Xóa mail đã chọn\r\n删除选定的邮件";

            txbSenderAddress.Texts = Properties.Settings.Default.sender_mail;
            txbSenderPassword.Texts = Properties.Settings.Default.sender_password;
            txbSMTPServer.Texts = Properties.Settings.Default.smtp_server;
            txbSMTPport.Texts = Properties.Settings.Default.smtp_port;

            LoadRepicents();

            //Ẩn tab khi không có quyền truy cập
            if (UserData.user_permission != "1")
            {
                flatTabMainProgramSetting.TabPages.Remove(tpDatabase);
            }
        }

        private void btn_testPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                txtDataIn.Text = string.Empty;
                CloseSerialPort();
                btn_testPort.ButtonText = "Thử kết nối\r\n尝试连接";
            }
            else
            {
                try
                {
                    if (!String.IsNullOrEmpty(Properties.Settings.Default.comPort))
                    {
                        serialPort1.PortName = Properties.Settings.Default.comPort;
                        serialPort1.BaudRate = Convert.ToInt32(Properties.Settings.Default.baudRate);
                        serialPort1.DataBits = Convert.ToInt32(Properties.Settings.Default.dataBits);
                        serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Properties.Settings.Default.stopBits);
                        serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Properties.Settings.Default.parityBits);
                        serialPort1.ReadTimeout = 100;
                        serialPort1.Open();
                        Alert("Kết nối thành công với " + Properties.Settings.Default.comPort, Form_Alert.enmType.Success);
                        btn_testPort.ButtonText = "Ngừng test\r\n停止测试";
                    }
                    else
                    {
                        Alert("Vui lòng chọn cổng kết nối!\r\n请选择连接端口！", Form_Alert.enmType.Info);
                    }
                }
                catch (Exception err)
                {
                    CTMessageBox.Show(err.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isExitApplication)
            {
                dataIn = serialPort1.ReadLine().Replace("kg", "").Trim();
                this.BeginInvoke(new EventHandler(showData));
            }
        }

        private void txtDataIn_TextChanged(object sender, EventArgs e)
        {
            txtDataIn.SelectionStart = txtDataIn.Text.Length;
            txtDataIn.ScrollToCaret();
        }

        private void cbComPort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.comPort = cbComPort.Text;
            Properties.Settings.Default.Save();
        }

        private void cbBaudRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.baudRate = cbBaudRate.Text;
            Properties.Settings.Default.Save();
        }

        private void cbDataBits_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.dataBits = cbDataBits.Text;
            Properties.Settings.Default.Save();
        }

        private void cbStopBits_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.stopBits = cbStopBits.Text;
            Properties.Settings.Default.Save();
        }

        private void cbParityBits_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.parityBits = cbParityBits.Text;
            Properties.Settings.Default.Save();
        }

        private void ProgramSettingView_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckChange();
            if (serialPort1.IsOpen)
            {
                CloseSerialPort();
                btn_testPort.ButtonText = "Thử kết nối\r\n尝试连接";
            }
            if (isChangeData)
            {
                DialogResult dialogResult = CTMessageBox.Show("Có cữ liệu chưa lưu, lưu và thoát cài đặt?\r\n有未保存的数据、保存并退出设置吗？", "Xác nhận 断言", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    SaveMailData();
                }
            }
        }

        private void txbSMTPport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbRepicentAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txbRepicentAddress.Texts.Trim()))
                {
                    dtgvRepicentsList.Rows.Add(txbRepicentAddress.Texts.Trim());
                    txbRepicentAddress.Texts = "";
                    dtgvRepicentsList.Focus();
                    SaveMailData();
                }
                else
                {
                    txbRepicentAddress.Texts = "";
                    dtgvRepicentsList.Focus();
                }
            }
        }

        private void btnSaveMailSettting_Click(object sender, EventArgs e)
        {
            SaveMailData();
        }

        private void dtgvRepicentsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                lbChosenRepicent.Text = dtgvRepicentsList.Rows[e.RowIndex].Cells[0].Value.ToString();
                deleteRowIndex = e.RowIndex;
            }
        }

        private void btnDeleteRepicent_Click(object sender, EventArgs e)
        {
            if (deleteRowIndex != -1)
            {
                DialogResult dialogResult = CTMessageBox.Show("Xóa mail \"" + lbChosenRepicent.Text + "\" khỏi danh sách?\r\n从列表中删除邮件\"" + lbChosenRepicent.Text + "\"？", "Xác nhận 断言", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    if (dtgvRepicentsList.RowCount > 1)
                    {
                        dtgvRepicentsList.Rows.RemoveAt(deleteRowIndex);
                    }
                    else
                    {
                        dtgvRepicentsList.Rows.Clear();
                    }
                    lbChosenRepicent.Text = "...";
                    deleteRowIndex = -1;
                    SaveMailData();
                }
                else
                {
                    lbChosenRepicent.Text = "...";
                    deleteRowIndex = -1;
                }
            }
        }

        private void btnTestMailSingle_Click(object sender, EventArgs e)
        {

        }
    }
}
