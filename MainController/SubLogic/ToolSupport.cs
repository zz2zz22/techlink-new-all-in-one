using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainModel.SaveVariables;
using Excel = Microsoft.Office.Interop.Excel;

namespace techlink_new_all_in_one.MainController.SubLogic
{
    public class ToolSupport
    {
        private void reOject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                CTMessageBox.Show("Lỗi xuất tệp Excel:\r\n导出 Excel 文件时出错：\r\n" + ex.Message, "Cảnh báo 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                GC.Collect();
            }
        }
        public void ExportDataBigHoseCutting(List<BigHoseCuttingInfo> details, string pathSave, string pathForm)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Open(pathForm, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            try
            {
                details = details.OrderByDescending(x => x.DateReceive).ToList();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "MainReport";
                DateTime date = DateTime.Now;
                xlWorkSheet.Cells[1, "A"] = date.Year + " 年 " + date.Month + " 出仓明细表 (裁布发料）    Danh sách xuất kho " + date.Day + " ." + date.Month + " ." + date.Year + " "; // Thêm ngày vào title
                for (int i = 0; i < details.Count; i++)
                {
                    //xlWorkSheet.Cells[7 + i, "A"] = (i + 1).ToString();
                    xlWorkSheet.Cells[4 + i, "A"] = details[i].DateReceive;
                    xlWorkSheet.Cells[4 + i, "B"] = details[i].MainCode;
                    xlWorkSheet.Cells[4 + i, "C"] = details[i].DetailCode;
                    xlWorkSheet.Cells[4 + i, "D"] = details[i].Quantity;
                    xlWorkSheet.Cells[4 + i, "E"] = details[i].Weight;
                    xlWorkSheet.Cells[4 + i, "F"] = details[i].Sender;
                    xlWorkSheet.Cells[4 + i, "G"] = details[i].Receiver;
                }

                xlWorkBook.SaveAs(pathSave, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue,
                    misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(0);

                xlApp.Quit();
                reOject(xlWorkSheet);
                reOject(xlWorkBook);
                reOject(xlApp);
            }
            catch (Exception)
            {
                xlWorkBook.Close(0);
                xlApp.Quit();
                throw;
            }
        }
        public void ExportDataSpanishHoseCutting(List<SpanishHoseCuttingInfo> details, string pathSave, string pathForm)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Open(pathForm, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            try
            {
                details = details.OrderByDescending(x => x.Date).ToList();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "MainReport";
                DateTime date = DateTime.Now;
                xlWorkSheet.Cells[1, "A"] = "Báo biểu khu vực cắt liệu bộ phận Ống Tây Ban Nha"; // Thêm ngày vào title
                for (int i = 0; i < details.Count; i++)
                {
                    xlWorkSheet.Cells[4 + i, "A"] = details[i].Date;
                    xlWorkSheet.Cells[4 + i, "B"] = details[i].MainCode;
                    xlWorkSheet.Cells[4 + i, "C"] = details[i].Description;
                    xlWorkSheet.Cells[4 + i, "D"] = details[i].Quantity;
                    xlWorkSheet.Cells[4 + i, "E"] = details[i].Weight;
                    xlWorkSheet.Cells[4 + i, "F"] = details[i].Sender;
                    xlWorkSheet.Cells[4 + i, "G"] = details[i].Receiver;
                }

                xlWorkBook.SaveAs(pathSave, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue,
                    misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(0);

                xlApp.Quit();
                reOject(xlWorkSheet);
                reOject(xlWorkBook);
                reOject(xlApp);
            }
            catch (Exception)
            {
                xlWorkBook.Close(0);
                xlApp.Quit();
                throw;
            }
        }
    }
}
