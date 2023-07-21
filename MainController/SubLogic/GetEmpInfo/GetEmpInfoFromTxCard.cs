using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using techlink_new_all_in_one.MainModel;

namespace techlink_new_all_in_one.MainController.SubLogic.GetEmpInfo
{
    public class GetEmpInfoFromTxCard
    {
        public static string Dept { get; set; }
        public static string Code { get; set; }
        public static string Name { get; set; }
        public static string Sex { get; set; }

        public static void GetAllEmpInfo(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                DataTable dt = new DataTable();
                SqlHR sqlHR = new SqlHR();
                sqlHR.sqlDataAdapterFillDatatable("exec VuSP_GetEmpInfo '" + code + "'", ref dt);
                if (dt.Rows.Count > 0)
                {
                    Dept = dt.Rows[0]["Dept"].ToString().Trim();
                    Code = dt.Rows[0]["Code"].ToString().Trim();
                    Name = dt.Rows[0]["Name"].ToString().Trim();
                    Sex = dt.Rows[0]["Sex"].ToString().Trim();
                }
                else
                {
                    Dept = String.Empty;
                    Code = String.Empty;
                    Name = String.Empty;
                    Sex = String.Empty;
                }
            }
        }
    }
}
