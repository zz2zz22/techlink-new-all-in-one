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

                header.Append("Báo biểu của phòng cắt bộ phận Ống Lớn\r\n大管切割部报告");
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
                xlWorkSheet.Cells[1, "A"] = "Báo biểu phòng cắt bộ phận Ống Tây Ban Nha\r\n到西班牙管材部门切割室报到"; // Thêm ngày vào title
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
                xlWorkSheet.Cells[1, "A"] = "Báo biểu khu vực Cán bộ phận Đùn\r\n区域报告 挤压部门人员"; // Thêm ngày vào title
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
                xlWorkSheet.Cells[1, "A"] = "Báo biểu khu vực Đóng gói bộ phận Đùn\r\n面积报告 挤压零件 包装"; // Thêm ngày vào title
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

        public void ExportDataHSEDeviceInsight(List<HSEDeviceInsightDetail> details, string pathSave, string pathForm)
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
                details = details.OrderByDescending(x => x.device_location).ToList();
                ProgressDialog progressDialog = new ProgressDialog();
                xlWorkSheet = null;
                Thread backgroundThreadTotalDevice = new Thread(
                    new ThreadStart(() =>
                    {
                        int j = 0;
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                        xlWorkSheet.Name = "Tổng thiết bị";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 1)
                            {
                                xlWorkSheet.Cells[7 + j, "A"] = (j + 1).ToString();
                                xlWorkSheet.Cells[7 + j, "B"] = details[i].device_type;
                                xlWorkSheet.Cells[7 + j, "C"] = details[i].device_location;
                                xlWorkSheet.Cells[7 + j, "D"] = details[i].device_manager;
                                xlWorkSheet.Cells[7 + j, "E"] = details[i].install_date;
                                xlWorkSheet.Cells[7 + j, "F"] = details[i].expired_date;
                                xlWorkSheet.Cells[7 + j, "G"] = details[i].newest_maintenance_date;
                                xlWorkSheet.Cells[7 + j, "H"] = details[i].newest_checked_date;
                                j++;
                                progressDialog.UpdateProgress(100 * i / details.Count, "Lấy dữ liệu tổng số thiết bị\r\n获取设备总数据");
                            }
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));

                Thread backgroundThreadNearExpDevice = new Thread(
                    new ThreadStart(() =>
                    {
                        int j = 0;
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
                        xlWorkSheet.Name = "Gần hết hạn";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 2)
                            {
                                xlWorkSheet.Cells[7 + j, "A"] = (j + 1).ToString();
                                xlWorkSheet.Cells[7 + j, "B"] = details[i].device_type;
                                xlWorkSheet.Cells[7 + j, "C"] = details[i].device_location;
                                xlWorkSheet.Cells[7 + j, "D"] = details[i].device_manager;
                                xlWorkSheet.Cells[7 + j, "E"] = details[i].install_date;
                                xlWorkSheet.Cells[7 + j, "F"] = details[i].expired_date;
                                xlWorkSheet.Cells[7 + j, "G"] = details[i].newest_maintenance_date;
                                xlWorkSheet.Cells[7 + j, "H"] = details[i].newest_checked_date;
                                j++;
                                progressDialog.UpdateProgress(100 * i / details.Count, "Lấy dữ liệu thiết bị gần hết hạn sử dụng\r\n检索临近到期日期的设备数据");
                            }
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));

                Thread backgroundThreadOverExpDevice = new Thread(
                    new ThreadStart(() =>
                    {
                        int j = 0;
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);
                        xlWorkSheet.Name = "Đã quá hạn";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 3)
                            {
                                xlWorkSheet.Cells[7 + j, "A"] = (j + 1).ToString();
                                xlWorkSheet.Cells[7 + j, "B"] = details[i].device_type;
                                xlWorkSheet.Cells[7 + j, "C"] = details[i].device_location;
                                xlWorkSheet.Cells[7 + j, "D"] = details[i].device_manager;
                                xlWorkSheet.Cells[7 + j, "E"] = details[i].install_date;
                                xlWorkSheet.Cells[7 + j, "F"] = details[i].expired_date;
                                xlWorkSheet.Cells[7 + j, "G"] = details[i].newest_maintenance_date;
                                xlWorkSheet.Cells[7 + j, "H"] = details[i].newest_checked_date;
                                j++;
                                progressDialog.UpdateProgress(100 * i / details.Count, "Lấy dữ liệu thiết bị đã quá hạn sử dụng\r\n检索过期的设备数据");
                            }
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));

                Thread backgroundThreadValidDevice = new Thread(
                    new ThreadStart(() =>
                    {
                        int j = 0;
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(4);
                        xlWorkSheet.Name = "Còn hạn SD";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 4)
                            {
                                xlWorkSheet.Cells[7 + j, "A"] = (j + 1).ToString();
                                xlWorkSheet.Cells[7 + j, "B"] = details[i].device_type;
                                xlWorkSheet.Cells[7 + j, "C"] = details[i].device_location;
                                xlWorkSheet.Cells[7 + j, "D"] = details[i].device_manager;
                                xlWorkSheet.Cells[7 + j, "E"] = details[i].install_date;
                                xlWorkSheet.Cells[7 + j, "F"] = details[i].expired_date;
                                xlWorkSheet.Cells[7 + j, "G"] = details[i].newest_maintenance_date;
                                xlWorkSheet.Cells[7 + j, "H"] = details[i].newest_checked_date;
                                j++;
                                progressDialog.UpdateProgress(100 * i / details.Count, "Lấy dữ liệu thiết bị còn hạn sử dụng\r\n获取过期的设备数据");
                            }
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));

                Thread backgroundThreadCheckedDevice = new Thread(
                    new ThreadStart(() =>
                    {
                        int j = 0;
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(5);
                        xlWorkSheet.Name = "Đã kiểm tra";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 5)
                            {
                                xlWorkSheet.Cells[7 + j, "A"] = (j + 1).ToString();
                                xlWorkSheet.Cells[7 + j, "B"] = details[i].device_type;
                                xlWorkSheet.Cells[7 + j, "C"] = details[i].device_location;
                                xlWorkSheet.Cells[7 + j, "D"] = details[i].device_manager;
                                xlWorkSheet.Cells[7 + j, "E"] = details[i].install_date;
                                xlWorkSheet.Cells[7 + j, "F"] = details[i].expired_date;
                                xlWorkSheet.Cells[7 + j, "G"] = details[i].newest_maintenance_date;
                                xlWorkSheet.Cells[7 + j, "H"] = details[i].newest_checked_date;
                                j++;
                                progressDialog.UpdateProgress(100 * i / details.Count, "Lấy dữ liệu thiết bị đã kiểm tra trong tháng\r\n获取当月检查的设备数据");
                            }
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));

                Thread backgroundThreadNotCheckedDevice = new Thread(
                    new ThreadStart(() =>
                    {
                        int j = 0;
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(6);
                        xlWorkSheet.Name = "Chưa kiểm tra";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 6)
                            {
                                xlWorkSheet.Cells[7 + j, "A"] = (j + 1).ToString();
                                xlWorkSheet.Cells[7 + j, "B"] = details[i].device_type;
                                xlWorkSheet.Cells[7 + j, "C"] = details[i].device_location;
                                xlWorkSheet.Cells[7 + j, "D"] = details[i].device_manager;
                                xlWorkSheet.Cells[7 + j, "E"] = details[i].install_date;
                                xlWorkSheet.Cells[7 + j, "F"] = details[i].expired_date;
                                xlWorkSheet.Cells[7 + j, "G"] = details[i].newest_maintenance_date;
                                xlWorkSheet.Cells[7 + j, "H"] = details[i].newest_checked_date;
                                j++;
                                progressDialog.UpdateProgress(100 * i / details.Count, "Lấy dữ liệu thiết bị chưa kiểm tra trong tháng\r\n获取当月未检查的设备数据");
                            }
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));

                backgroundThreadTotalDevice.Start();
                progressDialog.ShowDialog();
                backgroundThreadNearExpDevice.Start();
                progressDialog.ShowDialog();
                backgroundThreadOverExpDevice.Start();
                progressDialog.ShowDialog();
                backgroundThreadValidDevice.Start();
                progressDialog.ShowDialog();
                backgroundThreadCheckedDevice.Start();
                progressDialog.ShowDialog();
                backgroundThreadNotCheckedDevice.Start();
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
