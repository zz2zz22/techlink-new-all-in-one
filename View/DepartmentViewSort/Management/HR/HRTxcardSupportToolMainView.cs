using com.sun.org.apache.bcel.@internal.generic;
using javax.net.ssl;
using Org.BouncyCastle.Utilities.Zlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel;

namespace techlink_new_all_in_one
{
    public partial class HRTxcardSupportToolMainView : Form
    {
        SqlHR sqlHR = new SqlHR();

        public HRTxcardSupportToolMainView()
        {
            InitializeComponent();
        }

        private void btnAddMonth_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder();
            query.Append("Declare @n Int\r\n" +
                "Declare @nDate DateTime\r\n" +
                "SEt @nDate =(Select Max(Date0 ) from S_Session)\r\n" +
                "Set @n =1\r\n" +
                "While @n <= " + nudMonthAdd.Value +
                "begin\r\n" +
                "   Insert into S_Session (Date0,Date1 ,isEnd)\r\n" +
                "   Select DateAdd (Month, @n,@nDate ),DateAdd( Day,-1 ,DateAdd( Month,@n +1, @nDate)),0\r\n" +
                "   Set @n=@n +1\r\n" +
                "end\r\n" +
                "--==更新年份，季度，月份等信息\r\n" +
                "Update S_Session Set AllDays=DateDiff (Day, Date0,Date1 )+1,\r\n" +
                "Memo=Cast (Datepart( Year,Date0 ) as Varchar( 4))+'年'+( Case when Datepart(Month ,Date0)< 10 then '0' else '' end)\r\n" +
                "+Cast( Datepart(Month ,Date0) as Varchar(2 ))+'月'\r\n" +
                "where isnull(Memo,'')=''");
            sqlHR.sqlExecuteNonQuery(query.ToString(), "Thêm thành công", "Lỗi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string checkData = "select Name from ZlEmployee where code like '" + txbEmployeeCode.Texts.Trim().ToUpper() + "'";
            string emp = sqlHR.sqlExecuteScalarString(checkData);
            string empCode = txbEmployeeCode.Texts.Trim().ToUpper();
            if (String.IsNullOrEmpty(emp))
            {
                CTMessageBox.Show("Không thể tìm thấy nhân viên vừa nhập trên hệ thống, vui lòng kiểm tra lại mã nhân viên!");
            }
            else
            {
                StringBuilder query = new StringBuilder();
                query.Append("update ZlEmployee set \r\n" +
                    "  ZzDate = '" + txbDateIn.Texts.Trim() + " 00:00:00.000',\r\n" +
                    "  State = 0,\r\n" +
                    "  LzDate = NULL,\r\n" +
                    "  LzCause = NULL,\r\n" +
                    "  LzTc = NULL\r\n" +
                    "  where Code like '" + empCode + "' and State = 9");
                sqlHR.sqlExecuteNonQuery(query.ToString(), "Thêm thành công", "Lỗi");
            }
        }

        private void txbDateIn__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
