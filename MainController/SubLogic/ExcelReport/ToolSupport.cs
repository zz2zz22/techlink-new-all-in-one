using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;
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
            var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
            foreach (var item in list_process)
            {
                item.Kill();
            }
            xlWorkBook = xlApp.Workbooks.Open(pathForm, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            try
            {
                details = details.OrderByDescending(x => x.DateReceive).ToList();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "MainReport";
                DateTime date = DateTime.Now;
                StringBuilder header = new StringBuilder();

                header.Append("Báo biểu của phòng cắt bộ phận Ống Lớn " + date.ToString("dd-MM-yyyy HH:mm:ss") + "\r\n大管切割部报告" + date.Year + "年" + date.Month + "月" + date.Day + "日" + date.ToString("HH:mm:ss"));
                xlWorkSheet.Cells[1, "A"] = header.ToString();
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < details.Count; i++)
                        {
                            xlWorkSheet.Cells[4 + i, "A"] = details[i].DateReceive;
                            xlWorkSheet.Cells[4 + i, "B"] = details[i].MainCode;
                            xlWorkSheet.Cells[4 + i, "C"] = details[i].DetailCode;
                            xlWorkSheet.Cells[4 + i, "D"] = details[i].Quantity;
                            xlWorkSheet.Cells[4 + i, "E"] = details[i].Weight;
                            xlWorkSheet.Cells[4 + i, "F"] = details[i].Sender;
                            xlWorkSheet.Cells[4 + i, "G"] = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();

                if (File.Exists(pathSave))
                    File.Delete(pathSave);

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
            var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
            foreach (var item in list_process)
            {
                item.Kill();
            }
            xlWorkBook = xlApp.Workbooks.Open(pathForm, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            try
            {
                details = details.OrderByDescending(x => x.Date).ToList();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "MainReport";
                DateTime date = DateTime.Now;
                xlWorkSheet.Cells[1, "A"] = "Báo biểu khu vực cắt liệu bộ phận Ống Tây Ban Nha"; // Thêm ngày vào title
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < details.Count; i++)
                        {
                            xlWorkSheet.Cells[4 + i, "A"] = details[i].Date;
                            xlWorkSheet.Cells[4 + i, "B"] = details[i].MainCode;
                            xlWorkSheet.Cells[4 + i, "C"] = details[i].Description;
                            xlWorkSheet.Cells[4 + i, "D"] = details[i].Quantity;
                            xlWorkSheet.Cells[4 + i, "E"] = details[i].Weight;
                            xlWorkSheet.Cells[4 + i, "F"] = details[i].Sender;
                            xlWorkSheet.Cells[4 + i, "G"] = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();

                if (File.Exists(pathSave))
                    File.Delete(pathSave);

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

        public void ExportDataExtrusionCalender(List<ExtrusionInfo> details, string pathSave, string pathForm)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
            foreach (var item in list_process)
            {
                item.Kill();
            }
            xlWorkBook = xlApp.Workbooks.Open(pathForm, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            try
            {
                details = details.OrderByDescending(x => x.Date).ToList();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "MainReport";
                DateTime date = DateTime.Now;
                xlWorkSheet.Cells[1, "A"] = "区域报告 挤压部门人员" + Environment.NewLine + "Báo biểu khu vực Cán bộ phận Đùn"; // Thêm ngày vào title
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < details.Count; i++)
                        {
                            xlWorkSheet.Cells[4 + i, "A"] = details[i].Date;
                            xlWorkSheet.Cells[4 + i, "B"] = details[i].MainCode;
                            xlWorkSheet.Cells[4 + i, "C"] = details[i].Length;
                            xlWorkSheet.Cells[4 + i, "D"] = details[i].Weight;
                            xlWorkSheet.Cells[4 + i, "E"] = details[i].Sender;
                            xlWorkSheet.Cells[4 + i, "F"] = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();

                if (File.Exists(pathSave))
                    File.Delete(pathSave);

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

        public void ExportDataExtrusionPacking(List<ExtrusionInfo> details, string pathSave, string pathForm)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
            foreach (var item in list_process)
            {
                item.Kill();
            }
            xlWorkBook = xlApp.Workbooks.Open(pathForm, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            try
            {
                details = details.OrderByDescending(x => x.Date).ToList();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "MainReport";
                DateTime date = DateTime.Now;
                xlWorkSheet.Cells[1, "A"] = "面积报告 挤压零件 包装" + Environment.NewLine + "Báo biểu khu vực Đóng gói bộ phận Đùn"; // Thêm ngày vào title
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < details.Count; i++)
                        {
                            xlWorkSheet.Cells[4 + i, "A"] = details[i].Date;
                            xlWorkSheet.Cells[4 + i, "B"] = details[i].MainCode;
                            xlWorkSheet.Cells[4 + i, "C"] = details[i].Length;
                            xlWorkSheet.Cells[4 + i, "D"] = details[i].Weight;
                            xlWorkSheet.Cells[4 + i, "E"] = details[i].Sender;
                            xlWorkSheet.Cells[4 + i, "F"] = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();

                if (File.Exists(pathSave))
                    File.Delete(pathSave);

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
