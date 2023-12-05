using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace techlink_new_all_in_one.MainModel.SaveVariables
{
    public class TemporaryVariables
    {
        public static string materialCode { get; set; }
        public static string lotNo { get; set; }
        public static bool isInputQuantity { get; set; }
        public static double inputQuantity { get; set; }

        public static DataTable materialDT { get; set; }
        public static void InitMaterialDT()
        {
            if (materialDT != null)
            {
                materialDT = null;
            }
            materialDT = new DataTable();
            DataColumn matCol;

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.String");
            matCol.ColumnName = "mat_name";
            materialDT.Columns.Add(matCol);

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.String");
            matCol.ColumnName = "lot_no";
            materialDT.Columns.Add(matCol);

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.Double");
            matCol.ColumnName = "weight";
            materialDT.Columns.Add(matCol);

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.Double");
            matCol.ColumnName = "tolerance";
            materialDT.Columns.Add(matCol);

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.Double");
            matCol.ColumnName = "actual_weight";
            materialDT.Columns.Add(matCol);

            matCol = new DataColumn();
            matCol.DataType = Type.GetType("System.String");
            matCol.ColumnName = "barcode";
            materialDT.Columns.Add(matCol);
        }
    }
}
