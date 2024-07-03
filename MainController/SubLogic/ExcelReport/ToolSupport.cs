using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;
using ClosedXML.Excel;

namespace techlink_new_all_in_one.MainController.SubLogic
{
    public class ToolSupport
    {
        public void ExportDataBigHoseCutting(List<BigHoseCuttingInfo> details, string pathSave, string pathForm)
        {
            try
            {
                XLWorkbook xlWorkBook = new XLWorkbook(pathForm);
                var xlWorkSheet = xlWorkBook.Worksheet(1);
                xlWorkSheet.Name = "MainReport";

                object misValue = System.Reflection.Missing.Value;
                var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
                foreach (var item in list_process)
                {
                    item.Kill();
                }

                details = details.OrderByDescending(x => x.DateReceive).ToList();
                
                DateTime date = DateTime.Now;

                xlWorkSheet.Range("A1").Value = "Báo biểu của phòng cắt bộ phận Ống Lớn\r\n大管切割部报告";

                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < details.Count; i++)
                        {
                            int row = 4 + i;
                            xlWorkSheet.Range("A" + row).Value = details[i].DateReceive;
                            xlWorkSheet.Range("B" + row).Value = details[i].MainCode;
                            xlWorkSheet.Range("C" + row).Value = details[i].DetailCode;
                            xlWorkSheet.Range("D" + row).Value = details[i].Quantity;
                            xlWorkSheet.Range("E" + row).Value = details[i].Weight;
                            xlWorkSheet.Range("F" + row).Value = details[i].Sender;
                            xlWorkSheet.Range("G" + row).Value = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();

                if (File.Exists(pathSave))
                    File.Delete(pathSave);

                xlWorkBook.SaveAs(pathSave, false);
                xlWorkBook.Dispose();
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi xuất excel Excel导出错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExportDataSpanishHoseCutting(List<SpanishHoseCuttingInfo> details, string pathSave, string pathForm)
        {
            try
            {
                XLWorkbook xlWorkBook = new XLWorkbook(pathForm);
                var xlWorkSheet = xlWorkBook.Worksheet(1);
                xlWorkSheet.Name = "MainReport";

                object misValue = System.Reflection.Missing.Value;
                var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
                foreach (var item in list_process)
                {
                    item.Kill();
                }

                details = details.OrderByDescending(x => x.Date).ToList();

                DateTime date = DateTime.Now;
                xlWorkSheet.Range("A1").Value = "Báo biểu phòng cắt bộ phận Ống Tây Ban Nha\r\n到西班牙管材部门切割室报到"; // Thêm ngày vào title

                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < details.Count; i++)
                        {
                            int row = 4 + i;
                            xlWorkSheet.Range("A" + row).Value = details[i].Date;
                            xlWorkSheet.Range("B" + row).Value = details[i].MainCode;
                            xlWorkSheet.Range("C" + row).Value = details[i].Description;
                            xlWorkSheet.Range("D" + row).Value = details[i].Quantity;
                            xlWorkSheet.Range("E" + row).Value = details[i].Weight;
                            xlWorkSheet.Range("F" + row).Value = details[i].Sender;
                            xlWorkSheet.Range("G" + row).Value = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();

                if (File.Exists(pathSave))
                    File.Delete(pathSave);

                xlWorkBook.SaveAs(pathSave, false);
                xlWorkBook.Dispose();
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi xuất excel Excel导出错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportDataExtrusionCalender(List<ExtrusionInfo> details, string pathSave, string pathForm)
        {
            try
            {
                XLWorkbook xlWorkBook = new XLWorkbook(pathForm);
                var xlWorkSheet = xlWorkBook.Worksheet(1);
                xlWorkSheet.Name = "MainReport";

                object misValue = System.Reflection.Missing.Value;
                var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
                foreach (var item in list_process)
                {
                    item.Kill();
                }

                details = details.OrderByDescending(x => x.Date).ToList();

                DateTime date = DateTime.Now;
                xlWorkSheet.Range("A1").Value = "Báo biểu khu vực Cán bộ phận Đùn\r\n区域报告 挤压部门人员"; // Thêm ngày vào title

                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < details.Count; i++)
                        {
                            int row = 4 + i;
                            xlWorkSheet.Range("A" + row).Value = details[i].Date;
                            xlWorkSheet.Range("B" + row).Value = details[i].MainCode;
                            xlWorkSheet.Range("C" + row).Value = details[i].Length;
                            xlWorkSheet.Range("D" + row).Value = details[i].Weight;
                            xlWorkSheet.Range("E" + row).Value = details[i].Sender;
                            xlWorkSheet.Range("F" + row).Value = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();

                if (File.Exists(pathSave))
                    File.Delete(pathSave);

                xlWorkBook.SaveAs(pathSave, false);
                xlWorkBook.Dispose();
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi xuất excel Excel导出错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportDataExtrusionPacking(List<ExtrusionInfo> details, string pathSave, string pathForm)
        {
            try
            {
                XLWorkbook xlWorkBook = new XLWorkbook(pathForm);
                var xlWorkSheet = xlWorkBook.Worksheet(1);
                xlWorkSheet.Name = "MainReport";

                object misValue = System.Reflection.Missing.Value;
                var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
                foreach (var item in list_process)
                {
                    item.Kill();
                }

                details = details.OrderByDescending(x => x.Date).ToList();
                DateTime date = DateTime.Now;

                xlWorkSheet.Range("A1").Value = "Báo biểu khu vực Đóng gói bộ phận Đùn\r\n面积报告 挤压零件 包装"; // Thêm ngày vào title

                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        for (int i = 0; i < details.Count; i++)
                        {
                            int row = 4 + i;
                            xlWorkSheet.Range("A" + row).Value = details[i].Date;
                            xlWorkSheet.Range("B" + row).Value = details[i].MainCode;
                            xlWorkSheet.Range("C" + row).Value = details[i].Length;
                            xlWorkSheet.Range("D" + row).Value = details[i].Weight;
                            xlWorkSheet.Range("E" + row).Value = details[i].Sender;
                            xlWorkSheet.Range("F" + row).Value = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();

                if (File.Exists(pathSave))
                    File.Delete(pathSave);

                xlWorkBook.SaveAs(pathSave, false);
                xlWorkBook.Dispose();
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi xuất excel Excel导出错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportDataHSEDeviceInsight(List<HSEDeviceInsightDetail> details, string pathSave, string pathForm)
        {
            try
            {
                XLWorkbook xlWorkBook = new XLWorkbook(pathForm);

                object misValue = System.Reflection.Missing.Value;
                var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
                foreach (var item in list_process)
                {
                    item.Kill();
                }

                details = details.OrderByDescending(x => x.device_location).ToList();
                int row;
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThreadTotalDevice = new Thread(
                    new ThreadStart(() =>
                    {
                        int j = 0;
                        var xlWorkSheet = xlWorkBook.Worksheet(1);
                        xlWorkSheet.Name = "Tổng thiết bị";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 1)
                            {
                                row = 7 + j;
                                xlWorkSheet.Range("A" + row).Value = (j + 1).ToString();
                                xlWorkSheet.Range("B" + row).Value = details[i].device_type;
                                xlWorkSheet.Range("C" + row).Value = details[i].device_location;
                                xlWorkSheet.Range("D" + row).Value = details[i].device_manager;
                                xlWorkSheet.Range("E" + row).Value = details[i].install_date;
                                xlWorkSheet.Range("F" + row).Value = details[i].expired_date;
                                xlWorkSheet.Range("G" + row).Value = details[i].newest_maintenance_date;
                                xlWorkSheet.Range("H" + row).Value = details[i].newest_checked_date;
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
                        var xlWorkSheet = xlWorkBook.Worksheet(2);
                        xlWorkSheet.Name = "Gần hết hạn";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 2)
                            {
                                row = 7 + j;
                                xlWorkSheet.Range("A" + row).Value = (j + 1).ToString();
                                xlWorkSheet.Range("B" + row).Value = details[i].device_type;
                                xlWorkSheet.Range("C" + row).Value = details[i].device_location;
                                xlWorkSheet.Range("D" + row).Value = details[i].device_manager;
                                xlWorkSheet.Range("E" + row).Value = details[i].install_date;
                                xlWorkSheet.Range("F" + row).Value = details[i].expired_date;
                                xlWorkSheet.Range("G" + row).Value = details[i].newest_maintenance_date;
                                xlWorkSheet.Range("H" + row).Value = details[i].newest_checked_date;
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
                        var xlWorkSheet = xlWorkBook.Worksheet(3);
                        xlWorkSheet.Name = "Đã quá hạn";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 3)
                            {
                                row = 7 + j;
                                xlWorkSheet.Range("A" + row).Value = (j + 1).ToString();
                                xlWorkSheet.Range("B" + row).Value = details[i].device_type;
                                xlWorkSheet.Range("C" + row).Value = details[i].device_location;
                                xlWorkSheet.Range("D" + row).Value = details[i].device_manager;
                                xlWorkSheet.Range("E" + row).Value = details[i].install_date;
                                xlWorkSheet.Range("F" + row).Value = details[i].expired_date;
                                xlWorkSheet.Range("G" + row).Value = details[i].newest_maintenance_date;
                                xlWorkSheet.Range("H" + row).Value = details[i].newest_checked_date;
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
                        var xlWorkSheet = xlWorkBook.Worksheet(4);
                        xlWorkSheet.Name = "Còn hạn SD";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 4)
                            {
                                row = 7 + j;
                                xlWorkSheet.Range("A" + row).Value = (j + 1).ToString();
                                xlWorkSheet.Range("B" + row).Value = details[i].device_type;
                                xlWorkSheet.Range("C" + row).Value = details[i].device_location;
                                xlWorkSheet.Range("D" + row).Value = details[i].device_manager;
                                xlWorkSheet.Range("E" + row).Value = details[i].install_date;
                                xlWorkSheet.Range("F" + row).Value = details[i].expired_date;
                                xlWorkSheet.Range("G" + row).Value = details[i].newest_maintenance_date;
                                xlWorkSheet.Range("H" + row).Value = details[i].newest_checked_date;
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
                        var xlWorkSheet = xlWorkBook.Worksheet(5);
                        xlWorkSheet.Name = "Đã kiểm tra";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 5)
                            {
                                row = 7 + j;
                                xlWorkSheet.Range("A" + row).Value = (j + 1).ToString();
                                xlWorkSheet.Range("B" + row).Value = details[i].device_type;
                                xlWorkSheet.Range("C" + row).Value = details[i].device_location;
                                xlWorkSheet.Range("D" + row).Value = details[i].device_manager;
                                xlWorkSheet.Range("E" + row).Value = details[i].install_date;
                                xlWorkSheet.Range("F" + row).Value = details[i].expired_date;
                                xlWorkSheet.Range("G" + row).Value = details[i].newest_maintenance_date;
                                xlWorkSheet.Range("H" + row).Value = details[i].newest_checked_date;
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
                        var xlWorkSheet = xlWorkBook.Worksheet(6);
                        xlWorkSheet.Name = "Chưa kiểm tra";
                        for (int i = 0; i < details.Count; i++)
                        {
                            if (details[i].data_type == 6)
                            {
                                row = 7 + j;
                                xlWorkSheet.Range("A" + row).Value = (j + 1).ToString();
                                xlWorkSheet.Range("B" + row).Value = details[i].device_type;
                                xlWorkSheet.Range("C" + row).Value = details[i].device_location;
                                xlWorkSheet.Range("D" + row).Value = details[i].device_manager;
                                xlWorkSheet.Range("E" + row).Value = details[i].install_date;
                                xlWorkSheet.Range("F" + row).Value = details[i].expired_date;
                                xlWorkSheet.Range("G" + row).Value = details[i].newest_maintenance_date;
                                xlWorkSheet.Range("H" + row).Value = details[i].newest_checked_date;
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

                xlWorkBook.SaveAs(pathSave, false);
                xlWorkBook.Dispose();
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi xuất excel Excel导出错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
