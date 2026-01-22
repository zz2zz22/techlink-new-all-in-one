using ClosedXML.Excel;
using DocumentFormat.OpenXml.Packaging;
using sun.swing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;

using InteropExcel = Microsoft.Office.Interop.Excel;
using System.Reflection; // for Missing.Value

namespace techlink_new_all_in_one.MainController.SubLogic
{
    public class ToolSupport
    {
        public void ExportDataBigHoseCutting(List<BigHoseCuttingInfo> details, string pathSave, string pathForm)
        {
            try
            {
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
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
                        for (int i = 0; i < details.Count; i++)
                        {
                            int row = 4 + i;
                            xlWorkSheet.Range("A" + row).Value = details[i].DateReceive;
                            xlWorkSheet.Range("B" + row).Value = details[i].MainCode;
                            xlWorkSheet.Range("C" + row).Value = details[i].DetailCode;
                            xlWorkSheet.Range("D" + row).SetValue(details[i].Quantity);
                            xlWorkSheet.Range("E" + row).SetValue(details[i].Weight);
                            xlWorkSheet.Range("F" + row).Value = details[i].Sender;
                            xlWorkSheet.Range("G" + row).Value = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        xlWorkBook.SaveAs(pathSave, false);
                        xlWorkBook.Dispose();

                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();

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
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
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

                        for (int i = 0; i < details.Count; i++)
                        {
                            int row = 4 + i;
                            xlWorkSheet.Range("A" + row).Value = details[i].Date;
                            xlWorkSheet.Range("B" + row).Value = details[i].MainCode;
                            xlWorkSheet.Range("C" + row).Value = details[i].MaterialCode;
                            xlWorkSheet.Range("D" + row).Value = details[i].MaterialType;
                            xlWorkSheet.Range("E" + row).Value = details[i].Description;
                            xlWorkSheet.Range("F" + row).Value = details[i].Quantity;
                            xlWorkSheet.Range("G" + row).Value = details[i].Weight;
                            xlWorkSheet.Range("H" + row).Value = details[i].Sender;
                            xlWorkSheet.Range("I" + row).Value = details[i].Receiver;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }

                        xlWorkBook.SaveAs(pathSave, false);
                        xlWorkBook.Dispose();

                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();
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
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
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

                        xlWorkBook.SaveAs(pathSave, false);
                        xlWorkBook.Dispose();

                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();
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
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
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
                        xlWorkBook.SaveAs(pathSave, false);
                        xlWorkBook.Dispose();

                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();
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
                details = details.OrderByDescending(x => x.device_location).ToList();
                int row;
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThreadTotalDevice = new Thread(
                    new ThreadStart(() =>
                    {
                        var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
                        foreach (var item in list_process)
                        {
                            item.Kill();
                        }

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
                                xlWorkSheet.Range("I" + row).Value = details[i].check_status;
                                xlWorkSheet.Range("J" + row).Value = details[i].check_desc;
                                xlWorkSheet.Range("K" + row).Value = details[i].check_emp;
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
                                xlWorkSheet.Range("I" + row).Value = details[i].check_status;
                                xlWorkSheet.Range("J" + row).Value = details[i].check_desc;
                                xlWorkSheet.Range("K" + row).Value = details[i].check_emp;
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
                                xlWorkSheet.Range("I" + row).Value = details[i].check_status;
                                xlWorkSheet.Range("J" + row).Value = details[i].check_desc;
                                xlWorkSheet.Range("K" + row).Value = details[i].check_emp;
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
                                xlWorkSheet.Range("I" + row).Value = details[i].check_status;
                                xlWorkSheet.Range("J" + row).Value = details[i].check_desc;
                                xlWorkSheet.Range("K" + row).Value = details[i].check_emp;
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
                                xlWorkSheet.Range("I" + row).Value = details[i].check_status;
                                xlWorkSheet.Range("J" + row).Value = details[i].check_desc;
                                xlWorkSheet.Range("K" + row).Value = details[i].check_emp;
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
                                xlWorkSheet.Range("I" + row).Value = details[i].check_status;
                                xlWorkSheet.Range("J" + row).Value = details[i].check_desc;
                                xlWorkSheet.Range("K" + row).Value = details[i].check_emp;
                                j++;
                                progressDialog.UpdateProgress(100 * i / details.Count, "Lấy dữ liệu thiết bị chưa kiểm tra trong tháng\r\n获取当月未检查的设备数据");
                            }
                        }
                        xlWorkBook.SaveAs(pathSave, false);
                        xlWorkBook.Dispose();

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
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi xuất excel Excel导出错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportDataAccountantEmployeeSalary(List<EmployeeSalary> details, string pathSave, string pathForm)
        {
            try
            {
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
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

                        details = details.OrderByDescending(x => x.MaSo).ToList();
                        DateTime date = DateTime.Now;

                        xlWorkSheet.Range("A3").Value = "BẢNG LƯƠNG THÁNG " + date.Month + " NĂM " + date.Year + " - 办公室"; // Thêm ngày vào title

                        for (int i = 0; i < details.Count; i++)
                        {
                            int row = 6 + i;
                            xlWorkSheet.Range("A" + row).Value = i + 1;
                            xlWorkSheet.Range("B" + row).Value = details[i].BoPhan;
                            xlWorkSheet.Range("C" + row).Value = details[i].MaSo;
                            xlWorkSheet.Range("D" + row).Value = details[i].Ten;
                            xlWorkSheet.Range("J" + row).Value = details[i].SoNgayChamCong;

                            xlWorkSheet.Range("K" + row).Value = details[i].LuongCB;
                            xlWorkSheet.Range("L" + row).Value = details[i].PCChucVu;
                            xlWorkSheet.Range("M" + row).Value = details[i].PCNgonNgu;
                            xlWorkSheet.Range("N" + row).Value = details[i].PCThamNien;
                            xlWorkSheet.Range("O" + row).Value = details[i].PCGiaoThong;
                            xlWorkSheet.Range("P" + row).Value = details[i].PCNhaTro;
                            xlWorkSheet.Range("Q" + row).Value = details[i].TienDienThoai;
                            xlWorkSheet.Range("R" + row).Value = details[i].PCKyNang;
                            xlWorkSheet.Range("S" + row).Value = details[i].PCConNho;
                            xlWorkSheet.Range("T" + row).Value = details[i].TienThuong;
                            xlWorkSheet.Range("U" + row).Value = details[i].TongLuong;

                            xlWorkSheet.Range("V" + row).Value = details[i].SoNgayLamViec;
                            xlWorkSheet.Range("W" + row).Value = details[i].PhepNam;
                            xlWorkSheet.Range("X" + row).Value = details[i].Gio100;
                            xlWorkSheet.Range("Y" + row).Value = details[i].Gio130;
                            xlWorkSheet.Range("Z" + row).Value = details[i].Gio150;
                            xlWorkSheet.Range("AA" + row).Value = details[i].Gio200;
                            xlWorkSheet.Range("AB" + row).Value = details[i].Gio210;
                            xlWorkSheet.Range("AC" + row).Value = details[i].Gio270;
                            xlWorkSheet.Range("AD" + row).Value = details[i].Gio300;
                            xlWorkSheet.Range("AE" + row).Value = details[i].Gio390;

                            xlWorkSheet.Range("AF" + row).Value = details[i].Luong100;
                            xlWorkSheet.Range("AG" + row).Value = details[i].Luong130;
                            xlWorkSheet.Range("AH" + row).Value = details[i].Luong150;
                            xlWorkSheet.Range("AI" + row).Value = details[i].Luong200;
                            xlWorkSheet.Range("AJ" + row).Value = details[i].Luong210;
                            xlWorkSheet.Range("AK" + row).Value = details[i].Luong270;
                            xlWorkSheet.Range("AL" + row).Value = details[i].Luong300;
                            xlWorkSheet.Range("AM" + row).Value = details[i].Luong390;

                            xlWorkSheet.Range("AN" + row).Value = details[i].TTTongLuong;
                            xlWorkSheet.Range("AO" + row).Value = details[i].LuongOT;
                            xlWorkSheet.Range("AP" + row).Value = details[i].TTChuyenCan;
                            xlWorkSheet.Range("AQ" + row).Value = details[i].TTPCChucVu;
                            xlWorkSheet.Range("AR" + row).Value = details[i].TTPCNgonNgu;
                            xlWorkSheet.Range("AS" + row).Value = details[i].TTPCThamNien;
                            xlWorkSheet.Range("AT" + row).Value = details[i].TTPCGiaoThong;
                            xlWorkSheet.Range("AU" + row).Value = details[i].TTPCNhaTro;
                            xlWorkSheet.Range("AV" + row).Value = details[i].TTPCConNho;
                            xlWorkSheet.Range("AW" + row).Value = details[i].PCPCCC;
                            xlWorkSheet.Range("AX" + row).Value = details[i].PCSinhNhat;
                            xlWorkSheet.Range("AY" + row).Value = details[i].PCHanhKinh;
                            xlWorkSheet.Range("AZ" + row).Value = details[i].TTTienThuong;
                            xlWorkSheet.Range("BA" + row).Value = details[i].TTTienDienThoai;
                            xlWorkSheet.Range("BB" + row).Value = details[i].PCMoiTruong;
                            xlWorkSheet.Range("BC" + row).Value = details[i].PCDongCont;
                            xlWorkSheet.Range("BD" + row).Value = details[i].ThuongDatMucTieu;
                            xlWorkSheet.Range("BE" + row).Value = details[i].ThuongNangSuat;
                            xlWorkSheet.Range("BF" + row).Value = details[i].PCQuanLyNangSuat;
                            xlWorkSheet.Range("BG" + row).Value = details[i].ThuongPhatNhanSu;
                            xlWorkSheet.Range("BH" + row).Value = details[i].KhauTru;
                            xlWorkSheet.Range("BI" + row).Value = details[i].DiTreXemCam;
                            xlWorkSheet.Range("BJ" + row).Value = details[i].ThanhToanPhepNam;
                            xlWorkSheet.Range("BK" + row).Value = details[i].TroCapThoiViec;
                            xlWorkSheet.Range("BL" + row).Value = details[i].DieuChinhLuong;
                            xlWorkSheet.Range("BM" + row).Value = details[i].BoiThuongHopDong;
                            xlWorkSheet.Range("BN" + row).Value = details[i].LuongNhanDuoc;
                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }
                        xlWorkBook.SaveAs(pathSave, false);
                        xlWorkBook.Dispose();

                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi xuất excel Excel导出错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Convert column letter (e.g., "H") to column number (8)
        int ColumnLetterToNumber(string columnLetter)
        {
            int sum = 0;
            foreach (char c in columnLetter.ToUpper())
            {
                sum *= 26;
                sum += (c - 'A' + 1);
            }
            return sum;
        }

        // Convert column number (e.g., 16) to column letter ("P")
        string ColumnNumberToLetter(int columnNumber)
        {
            string columnLetter = "";
            while (columnNumber > 0)
            {
                int modulo = (columnNumber - 1) % 26;
                columnLetter = Convert.ToChar('A' + modulo) + columnLetter;
                columnNumber = (columnNumber - modulo) / 26;
            }
            return columnLetter;
        }

        public void ExportDataHTVQAReport(List<HTVQAReportVariables> details, string pathSave, string pathForm, string title)
        {
            try
            {
                ProgressDialog progressDialog = new ProgressDialog();
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        var list_process = Win32Processes.GetProcessesLockingFile(pathForm);
                        foreach (var item in list_process)
                        {
                            item.Kill();
                        }

                        // Copy template to save path first
                        System.IO.File.Copy(pathForm, pathSave, true);

                        InteropExcel.Application xlApp = new InteropExcel.Application();
                        InteropExcel.Workbook xlWorkBook = xlApp.Workbooks.Open(pathSave);
                        InteropExcel.Worksheet xlWorkSheet = (InteropExcel.Worksheet)xlWorkBook.Sheets[1];

                        details = details.OrderBy(x => x.lot_code).ToList();

                        xlWorkSheet.Range["A1"].Value = title;

                        // Insert columns before column 9
                        if (details.Count > 2)
                        {
                            InteropExcel.Range insertCol = (InteropExcel.Range)xlWorkSheet.Columns[9];
                            insertCol.Insert(InteropExcel.XlInsertShiftDirection.xlShiftToRight, Missing.Value);
                            // If you need to insert more than one column:
                            if (details.Count - 2 > 1)
                            {
                                for (int ins = 1; ins < details.Count - 2; ins++)
                                {
                                    insertCol.Insert(InteropExcel.XlInsertShiftDirection.xlShiftToRight, Missing.Value);
                                }
                            }
                        }

                        for (int i = 0; i < details.Count; i++)
                        {
                            int col = 8 + i; // Start from column H
                            xlWorkSheet.Columns[col].ColumnWidth = 16.3;
                            xlWorkSheet.Cells[2, col].Value = details[i].lot_code;
                            xlWorkSheet.Cells[3, col].Value = details[i].hardness_0h;
                            xlWorkSheet.Cells[4, col].Value = details[i].hardness_200C_4h;
                            xlWorkSheet.Cells[5, col].Value = details[i].tear_strengh_die_B_0h;
                            xlWorkSheet.Cells[6, col].Value = details[i].tensile_strengh_0h;
                            xlWorkSheet.Cells[7, col].Value = details[i].elongation_0h;
                            xlWorkSheet.Cells[8, col].Value = details[i].plasticity_0h;
                            xlWorkSheet.Cells[9, col].Value = details[i].plasticity_150_5h;
                            xlWorkSheet.Cells[10, col].Value = details[i].tc90;
                            xlWorkSheet.Cells[11, col].Value = details[i].change_plasticity_150_5h;
                            xlWorkSheet.Cells[12, col].Value = details[i].density_0h;

                            progressDialog.UpdateProgress(100 * i / details.Count, "Đang tạo dữ liệu excel!\r\n创建 Excel 数据！");
                        }

                        string columnChar = ColumnNumberToLetter(ColumnLetterToNumber("H") + details.Count - 1);

                        for (int r = 3; r < 13; r++)
                        {
                            xlWorkSheet.Range["D" + r].Formula = $"=MIN(H{r}:{columnChar}{r})";
                            xlWorkSheet.Range["E" + r].Formula = $"=MAX(H{r}:{columnChar}{r})";
                            xlWorkSheet.Range["F" + r].Formula = $"=AVERAGE(H{r}:{columnChar}{r})";
                        }

                        xlWorkBook.Save();
                        xlWorkBook.Close();
                        xlApp.Quit();

                        // Release COM objects to avoid memory leaks
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                    }));
                backgroundThread.Start();
                progressDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Lỗi xuất excel Excel导出错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
