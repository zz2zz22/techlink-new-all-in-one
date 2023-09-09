using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.CustomUIShow;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;

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
    public partial class BigHoseDailyTargetInput : Form
    {
        //Fields
        DataTableCollection tablesTarget;
        DataTableCollection tablesCD;
        SqlSoft sqlSoft = new SqlSoft();
        //Constructor
        public BigHoseDailyTargetInput()
        {
            InitializeComponent();
        }

        //Event Handler
        private void btnBrowseProductTarget_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    var list_process = Win32Processes.GetProcessesLockingFile(openFileDialog.FileName);
                    foreach (var item in list_process)
                    {
                        item.Kill();
                    }
                    Thread.Sleep(500);
                    LoadingDialog loading = new LoadingDialog();
                    Thread backgroundLoadExcel = new Thread(
                    new ThreadStart(() =>
                    {
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
                                tablesTarget = result.Tables;
                                
                                loading.BeginInvoke(new Action(() => loading.Close()));
                            }
                        }
                    }));
                    backgroundLoadExcel.Start();
                    loading.ShowDialog();
                    cboSheet.Items.Clear();
                    foreach (DataTable table in tablesTarget)
                        cboSheet.Items.Add(table.TableName);
                }
            }
        }

        private void cboSheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = tablesTarget[cboSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<BigHoseDailyProductTarget> list = new List<BigHoseDailyProductTarget>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (String.IsNullOrEmpty(dt.Rows[i][1].ToString().Trim()) && String.IsNullOrEmpty(dt.Rows[i][0].ToString().Trim()))
                        break;
                    if (!string.IsNullOrEmpty(dt.Rows[i][5].ToString().Trim()) && dt.Rows[i][5].ToString().Trim() != "0")
                    {
                        BigHoseDailyProductTarget obj = new BigHoseDailyProductTarget();
                        obj.target_date = dt.Rows[i][0].ToString().Trim();
                        obj.customer_code = dt.Rows[i][1].ToString().Trim();
                        obj.product_no = dt.Rows[i][2].ToString().Trim();
                        obj.target_quanity = dt.Rows[i][5].ToString().Trim();
                        list.Add(obj);
                    }
                }
                productTargetList.DataSource = list;
                productTargetList.Columns["target_date"].HeaderText = "Ngày\r\n工夫";
                productTargetList.Columns["customer_code"].HeaderText = "Mã khách hàng\r\n客户代码";
                productTargetList.Columns["product_no"].HeaderText = "Mã hàng\r\n普鲁";
                productTargetList.Columns["target_quanity"].HeaderText = "Số lượng\r\n数量";
            }
        }

        private void btnImportProductTarget_Click(object sender, EventArgs e)
        {
            sqlSoft.sqlInsertBigHoseDailyProductTarget(productTargetList);
        }

        private void btnBrowseCDSetting_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txbCDFileName.Text = openFileDialog.FileName;
                    var list_process = Win32Processes.GetProcessesLockingFile(openFileDialog.FileName);
                    foreach (var item in list_process)
                    {
                        item.Kill();
                    }
                    Thread.Sleep(500);
                    LoadingDialog loading = new LoadingDialog();
                    Thread backgroundLoadExcelCD = new Thread(
                    new ThreadStart(() =>
                    {
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
                                tablesCD = result.Tables;

                                loading.BeginInvoke(new Action(() => loading.Close()));
                            }
                        }
                    }));
                    backgroundLoadExcelCD.Start();
                    loading.ShowDialog();
                    cboCDSheets.Items.Clear();
                    foreach (DataTable table in tablesCD)
                        cboCDSheets.Items.Add(table.TableName);
                }
            }
        }

        private void cboCDSheets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = tablesCD[cboCDSheets.SelectedItem.ToString()];
            if (dt != null)
            {
                List<BigHoseProductCD> list = new List<BigHoseProductCD>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (String.IsNullOrEmpty(dt.Rows[i][0].ToString().Trim()))
                        break;
                    BigHoseProductCD obj = new BigHoseProductCD();
                    obj.product_no = dt.Rows[i][0].ToString().Trim();
                    obj.rolling_countdown = dt.Rows[i][4].ToString().Trim();
                    obj.fixative_countdown = dt.Rows[i][5].ToString().Trim();
                    list.Add(obj);
                }
                productCDList.DataSource = list;
                productCDList.Columns["product_no"].HeaderText = "Mã hàng\r\n普鲁";
                productCDList.Columns["rolling_countdown"].HeaderText = "Cuốn ống\r\n盘管";
                productCDList.Columns["fixative_countdown"].HeaderText = "Định hình\r\n形状";
            }
        }

        private void btnImportProductCD_Click(object sender, EventArgs e)
        {
            sqlSoft.sqlInsertBigHoseProductCountdown(productCDList);
        }
    }
}
