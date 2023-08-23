using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainController.SubLogic.GetEmpInfo;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;
using techlink_new_all_in_one.View.CustomUI;

/*
#################################################################
#                             _`				                #
#                          _ooOoo_				                #
#                         o8888888o				                #
#                         88" . "88				                #
#                         (| -_- |)				                #
#                         O\  =  /O				                #
#                      ____/`---'\____				            #
#                    .'  \\|     |//  `.			            #
#                   /  \\|||  :  |||//  \			            #
#                  /  _||||| -:- |||||_  \			            #
#                  |   | \\\  -  /'| |   |			            #
#                  | \_|  `\`---'//  |_/ |			            #
#                  \  .-\__ `-. -'__/-.  /			            #
#                ___`. .'  /--.--\  `. .'___			        #
#             ."" '<  `.___\_<|>_/___.' _> \"".			        #
#            | | :  `- \`. ;`. _/; .'/ /  .' ; |		        #
#            \  \ `-.   \_\_`. _.'_/_/  -' _.' /		        #
#=============`-.`___`-.__\ \___  /__.-'_.'_.-'=================#
                           `= --= -'                    

            TRỜI PHẬT PHÙ HỘ CODE CON KHÔNG BI BUG

          _.-/`)
         // / / )
      .=// / / / )
     //`/ / / / /
     // /     ` /
   ||         /
    \\       /
     ))    .'
         //    /
         /

*/

namespace techlink_new_all_in_one
{
    public partial class CuttingManagementMainView : Form
    {
        //Fields
        string dataIn;
        double returnValue;
        int cutQty;
        DataRow[] foundRows;
        DataTable dt;
        DataTable dts;
        bool isExitApplication = false;
        SqlSoft sqlSoft = new SqlSoft();

        //Constructor
        public CuttingManagementMainView()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        //Methods
        #region METHODS
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
        private void LoadDTGV()
        {
            dtgvCheckHistory.DataSource = dts;
            dtgvCheckHistory.Columns["create_date"].HeaderText = "Thời gian\r\n白日";
            dtgvCheckHistory.Columns["create_date"].DefaultCellStyle.Format = "MM/dd HH:mm";
            dtgvCheckHistory.Columns["cloth_no"].HeaderText = "Mã liệu\r\n材料代码";
            dtgvCheckHistory.Columns["quantity"].HeaderText = "PCS";
            dtgvCheckHistory.Columns["weight"].HeaderText = "Khối lượng\r\n质量";
            dtgvCheckHistory.Columns["receiver"].HeaderText = "Người nhận\r\n接收者";
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
            catch (Exception ex)
            {
                CTMessageBox.Show("Lỗi kết nối cân\n\r口连接错误:\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadData()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.comPort))
            {
                ConnectScale();
                try
                {
                    if (dt.Rows.Count > 0)
                    {
                        dt = new DataTable();
                    }
                    sqlSoft.sqlDataAdapterFillDatatable("exec Select_big_hose_base_data", ref dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (!txbMatCode.Items.Contains(dt.Rows[i]["product_no"].ToString()))
                                txbMatCode.Items.Add(dt.Rows[i]["product_no"].ToString());
                        }
                        txbMatCode.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    CTMessageBox.Show("Lỗi tải dữ liệu gốc\n\r加载原始数据时出错:\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Alert("Vui lòng cài đặt cân điện tử trước\r\n请先安装电子秤", Form_Alert.enmType.Info);
            }
        }
        private void showData(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dataIn))
            {
                if (double.TryParse(dataIn, out returnValue))
                {
                    returnValue = Convert.ToDouble(dataIn);
                    lbWeight.Text = returnValue.ToString();
                }
            }
        }
        private bool checkNull()
        {
            if (String.IsNullOrEmpty(txbMatCode.Text.Trim()) || String.IsNullOrEmpty(cbxDetailMat.Text.Trim()) || String.IsNullOrEmpty(txbRawQty.Texts.Trim()) || String.IsNullOrEmpty(txbEmpReceiveCode.Texts.Trim()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void CheckData(bool check)
        {
            dts = new DataTable();
            StringBuilder stringBuilder = new StringBuilder();
            if (!check)
                stringBuilder.Append("select create_date, cloth_no, quantity, weight, receiver from big_hose_realtime where permission_dept = 'Cutting' and create_date > '" + DateTime.Now.AddHours(-8).ToString("yyyy-MM-dd HH:mm:ss") + "' order by create_date desc");
            else
                stringBuilder.Append("select create_date, cloth_no, quantity, weight, receiver from big_hose_realtime where permission_dept = 'Cutting' and create_date >= '" + dtpInDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + dtpOutDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' order by create_date desc");
            sqlSoft.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dts);
        }
        private void LoadEmpGetMatData()
        {
            try
            {
                dts = new DataTable();
                StringBuilder stringBuilder = new StringBuilder();
                GetEmpInfoFromTxCard.GetAllEmpInfo(txbEmpReceiveCode.Texts);
                stringBuilder.Append("select create_date, cloth_no, quantity, weight, receiver from big_hose_realtime where receiver like '%" + GetEmpInfoFromTxCard.Code + "%' and create_date > '" + DateTime.Now.AddHours(-2).ToString("yyyy-MM-dd HH:mm:ss") + "' and permission_dept = 'Cutting' order by create_date desc");
                sqlSoft.sqlDataAdapterFillDatatable(stringBuilder.ToString(), ref dts);
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Lỗi tải dữ liệu của nhân viên!\r\n加载员工数据时出错！\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        //Event handler
        private void CuttingManagementMainView_Load(object sender, EventArgs e)
        {
            txbMatCode.Enabled = false;

            //Generate button text
            btnSearchHisEmp.ButtonText = "Xem lịch sử nhận liệu của NV\r\n查看员工数据接收历史记录";
            btnConfirm.ButtonText = "Xác nhận\r\n确认";
            btnCheckExcel.ButtonText = "Xuất báo biểu\r\n导出报表";
            btnCheckData.ButtonText = "Kiểm tra dữ liệu\r\n测试数据";

            LoadData();
        }
        private void CuttingManagementMainView_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btnCheckExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtExcel = new DataTable();
                StringBuilder queryGetData = new StringBuilder();
                queryGetData.Append("select * from big_hose_realtime where create_date >= '" + dtpInDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and create_date <= '" + dtpOutDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and permission_dept = 'Cutting'");
                sqlSoft.sqlDataAdapterFillDatatable(queryGetData.ToString(), ref dtExcel);

                if (dtExcel.Rows.Count > 0)
                {
                    List<BigHoseCuttingInfo> details = new List<BigHoseCuttingInfo>();
                    for (int i = 0; i < dtExcel.Rows.Count; i++)
                    {
                        BigHoseCuttingInfo d = new BigHoseCuttingInfo();
                        d.DateReceive = Convert.ToDateTime(dtExcel.Rows[i]["create_date"].ToString()).ToString("dd/MM/yyyy HH:mm:ss");
                        d.MainCode = dtExcel.Rows[i]["product_no"].ToString();
                        d.DetailCode = dtExcel.Rows[i]["cloth_no"].ToString();
                        d.Quantity = dtExcel.Rows[i]["quantity"].ToString();
                        d.Weight = Convert.ToDouble(dtExcel.Rows[i]["weight"].ToString());
                        d.Sender = dtExcel.Rows[i]["sender"].ToString();
                        d.Receiver = dtExcel.Rows[i]["receiver"].ToString();
                        details.Add(d);
                    }
                    ExcelSave.SaveExcel_BigHoseCutting(details);
                }
                else
                {
                    CTMessageBox.Show("Không có dữ liệu từ server!\n\r服务器没有数据！", "Thông tin 空中", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Lỗi xuất file excel:\n\rExcel导出错误：" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txbEmpReceiveCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isExitApplication)
            {
                try
                {
                    dataIn = serialPort1.ReadLine().Replace("kg", "").Trim();
                    //Problem about scale latency --> Config scale mode --> HOLD mode 0 --> Kinda ok when test multiple time ( must wait for COM port to finalizing conneection )
                    this.BeginInvoke(new EventHandler(showData));
                }
                catch (Exception)
                {
                    Alert("Serial port exception throw", Form_Alert.enmType.Error);
                }
            }
        }
        private void txbMatCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string expression;
                expression = "product_no like '%" + txbMatCode.Text.Trim() + "%'";
                DataRow[] foundRows;
                foundRows = dt.Select(expression);
                txbMatCode.Items.Clear();
                for (int i = 0; i < foundRows.Length; i++)
                {
                    if (!txbMatCode.Items.Contains(foundRows[i][0].ToString()))
                    {
                        txbMatCode.Items.Add(foundRows[i][0].ToString());
                    }
                }
            }
        }
        private void cbxDetailMat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foundRows = null;
            string searchExpression = "description = '" + cbxDetailMat.Text.Trim() + "'";
            foundRows = dt.Select(searchExpression);
            DataRow dr = foundRows.First();
            if (int.TryParse(dr["quantity"].ToString(), out cutQty))
            {
                cutQty = Convert.ToInt32(dr["quantity"].ToString());
                if (!String.IsNullOrWhiteSpace(txbRawQty.Texts))
                {
                    lbCutQty.Text = Convert.ToString(Convert.ToInt32(txbRawQty.Texts) * cutQty);
                }
                else
                {
                    lbCutQty.Text = "0";
                }
            }
            else
            {
                cutQty = 0;
            }
            txbRawQty.Enabled = true;
        }
        private void txbRawQty__TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txbRawQty.Texts))
            {
                lbCutQty.Text = Convert.ToString(Convert.ToInt32(txbRawQty.Texts) * cutQty);
            }
            else
            {
                lbCutQty.Text = "0";
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkNull())
                {
                    GetEmpInfoFromTxCard.GetAllEmpInfo(txbEmpReceiveCode.Texts);
                    string reEmpCode = GetEmpInfoFromTxCard.Code;
                    string reEmpName = GetEmpInfoFromTxCard.Name.TrimEnd();

                    BigHoseCuttingInfo d = new BigHoseCuttingInfo();
                    d.DateReceive = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    d.Sender = UserData.user_emp_code + " - " + UserData.user_actual_name;
                    if (!String.IsNullOrEmpty(reEmpCode) && !String.IsNullOrEmpty(reEmpName))
                    {
                        d.MainCode = txbMatCode.Text.Trim();
                        d.Weight = returnValue;
                        d.DetailCode = cbxDetailMat.Text.Trim();
                        d.Quantity = lbCutQty.Text;
                        d.Receiver = reEmpCode + " - " + reEmpName;

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
                                queryInsertData.Append("exec Insert_big_hose_realtime '" + UUIDGenerator.getAscId() + "', N'" + d.MainCode + "', N'" + d.DetailCode + "', " + d.Quantity + ", '" + d.Weight + "', N'" + d.Sender + "', N'" + d.Receiver + "', '" + d.DateReceive + "', 'Cutting'");
                                sqlSoft.sqlExecuteNonQuery(queryInsertData.ToString(), successMessage, errorMessage);
                                dtgvCheckHistory.DataSource = null;

                                loading.BeginInvoke(new Action(() => loading.Close()));
                            }));
                            backgroundThreadSaveData.Start();
                            loading.ShowDialog();

                            CheckData(false);
                            LoadDTGV();
                        }
                    }
                    else
                    {
                        Alert("Kiểm tra lại mã nhân viên \n\r 再次检查员工代码!!", Form_Alert.enmType.Warning);
                    }
                }
                else
                {
                    Alert("Không đủ dữ liệu \n\r 数据不足!!", Form_Alert.enmType.Warning);
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Lỗi hệ thống! Vui lòng chụp màn hình và báo cho bộ phận phần mềm!\r\n系统错误！请截图并反馈给软件部！" + "\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txbMatCode_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbMatCode.Text.Trim()))
            {
                txbMatCode.Items.Clear();
                cbxDetailMat.Items.Clear();
                txbRawQty.Texts = "";
                txbRawQty.Enabled = false;
                txbEmpReceiveCode.Texts = "";
                lbCutQty.Text = "0";
            }
        }
        private void txbRawQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnSearchHisEmp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txbEmpReceiveCode.Texts))
            {
                CTMessageBox.Show("Vui lòng nhập mã nhân viên để tìm!\r\n请输入员工代码查找！", "Thông tin 空中", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbEmpReceiveCode.Texts = "";
            }
            else
            {
                LoadEmpGetMatData();
                LoadDTGV();
            }
        }
        private void btnCheckData_Click(object sender, EventArgs e)
        {
            CheckData(true);
            LoadDTGV();
        }
        private void txbMatCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txbMatCode.Text))
            {
                foundRows = null;
                string searchExpression = "product_no = '" + txbMatCode.Text.Trim() + "'";
                foundRows = dt.Select(searchExpression);
                cbxDetailMat.Items.Clear();
                foreach (DataRow dr in foundRows)
                {
                    if (!String.IsNullOrEmpty(dr["quantity"].ToString().Trim()) && dr["quantity"].ToString().Trim() != "0")
                    {
                        cbxDetailMat.Items.Add(dr["description"].ToString());
                    }
                }
            }
        }
    }
}
