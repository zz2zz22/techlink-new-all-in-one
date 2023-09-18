using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainModel.SaveVariables;

namespace techlink_new_all_in_one.MainController.SubLogic
{
    public class ExcelSave
    {
        public static void SaveExcel_BigHoseCutting(List<BigHoseCuttingInfo> details)
        {
            string pathsave = "";

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Browse Excel Files";
            saveFileDialog.DefaultExt = "Excel";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathsave = saveFileDialog.FileName;
                var list_process = Win32Processes.GetProcessesLockingFile(pathsave);
                foreach (var item in list_process)
                {
                    item.Kill();
                }
                saveFileDialog.RestoreDirectory = true;
                ExportReport exportReport = new ExportReport();
                exportReport.ExportExcelCuttingReport(pathsave, details);
                var resultMessage = CTMessageBox.Show("Lưu file báo cáo thành công! Bạn có muốn mở file không?\n\r保存报表文件成功！你想打开文件吗？", "Thông tin 空中", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultMessage == DialogResult.Yes)
                {
                    FileInfo fi = new FileInfo(pathsave);
                    if (fi.Exists)
                    {
                        System.Diagnostics.Process.Start(pathsave);
                    }
                    else
                    {
                        CTMessageBox.Show("File không tồn tại!\r\n文件不存在", "Cảnh báo 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public static void SaveExcel_SpanishHoseCutting(List<SpanishHoseCuttingInfo> details)
        {
            string pathsave = "";

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Browse Excel Files";
            saveFileDialog.DefaultExt = "Excel";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathsave = saveFileDialog.FileName;
                var list_process = Win32Processes.GetProcessesLockingFile(pathsave);
                foreach (var item in list_process)
                {
                    item.Kill();
                }
                saveFileDialog.RestoreDirectory = true;
                ExportReport exportReport = new ExportReport();
                exportReport.ExportExcelSpanishHoseCuttingReport(pathsave, details);
                var resultMessage = CTMessageBox.Show("Lưu file báo cáo thành công! Bạn có muốn mở file không ? \n\r 保存报表文件成功！你想打开文件吗？", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultMessage == DialogResult.Yes)
                {
                    FileInfo fi = new FileInfo(pathsave);
                    if (fi.Exists)
                    {
                        System.Diagnostics.Process.Start(pathsave);
                    }
                    else
                    {
                        MessageBox.Show("File doestn't exist !", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        public static void SaveExcel_ExtrusionCalender(List<ExtrusionInfo> details)
        {
            string pathsave = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Browse Excel Files";
            saveFileDialog.DefaultExt = "Excel";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathsave = saveFileDialog.FileName;
                var list_process = Win32Processes.GetProcessesLockingFile(pathsave);
                foreach (var item in list_process)
                {
                    item.Kill();
                }
                saveFileDialog.RestoreDirectory = true;
                ExportReport exportReport = new ExportReport();
                exportReport.ExportExcelExtrusionCalenderReport(pathsave, details);
                var resultMessage = CTMessageBox.Show("Lưu file báo cáo thành công! Bạn có muốn mở file không ? \n\r 保存报表文件成功！你想打开文件吗？", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultMessage == DialogResult.Yes)
                {
                    FileInfo fi = new FileInfo(pathsave);
                    if (fi.Exists)
                    {
                        System.Diagnostics.Process.Start(pathsave);
                    }
                    else
                    {
                        MessageBox.Show("File doestn't exist !", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public static void SaveExcel_ExtrusionPacking(List<ExtrusionInfo> details)
        {
            string pathsave = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Browse Excel Files";
            saveFileDialog.DefaultExt = "Excel";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathsave = saveFileDialog.FileName;
                var list_process = Win32Processes.GetProcessesLockingFile(pathsave);
                foreach (var item in list_process)
                {
                    item.Kill();
                }
                saveFileDialog.RestoreDirectory = true;
                ExportReport exportReport = new ExportReport();
                exportReport.ExportExcelExtrusionPackingReport(pathsave, details);
                var resultMessage = CTMessageBox.Show("Lưu file báo cáo thành công! Bạn có muốn mở file không ? \n\r 保存报表文件成功！你想打开文件吗？", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultMessage == DialogResult.Yes)
                {
                    FileInfo fi = new FileInfo(pathsave);
                    if (fi.Exists)
                    {
                        System.Diagnostics.Process.Start(pathsave);
                    }
                    else
                    {
                        CTMessageBox.Show("File doestn't exist !", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        public static void SaveExcel_HSEInsightDetail(List<HSEDeviceInsightDetail> details)
        {
            string pathsave = "";

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Browse Excel Files";
            saveFileDialog.DefaultExt = "Excel";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathsave = saveFileDialog.FileName;
                var list_process = Win32Processes.GetProcessesLockingFile(pathsave);
                foreach (var item in list_process)
                {
                    item.Kill();
                }
                saveFileDialog.RestoreDirectory = true;
                ExportReport exportReport = new ExportReport();
                exportReport.ExportExcelHSEDeviceInsight(pathsave, details);
                var resultMessage = CTMessageBox.Show("Lưu file báo cáo thành công! Bạn có muốn mở file không?\n\r保存报表文件成功！你想打开文件吗？", "Thông tin 空中", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultMessage == DialogResult.Yes)
                {
                    FileInfo fi = new FileInfo(pathsave);
                    if (fi.Exists)
                    {
                        System.Diagnostics.Process.Start(pathsave);
                    }
                    else
                    {
                        CTMessageBox.Show("File không tồn tại!\r\n文件不存在", "Cảnh báo 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
