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

            //pathsave = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CutReport-" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm") + ".xlsx";
            //ExportReport exportReport = new ExportReport();
            //exportReport.ExportExcelCuttingReport(pathsave, details);
            //string sender = "tlms@techlink.vn";
            //string sender_pw = "techlink@123";
            //string smtp = sender.Substring(sender.IndexOf('@'));
            //string smtp_server, smtp_port;

            ////smtp_server = "smtp.gmail.com";
            //smtp_server = "pro56.emailserver.vn";
            //smtp_port = "587";

            //Properties.Settings.Default.Save();
            ////Chỉnh receivers nếu có nhiều ng nhận
            //string receivers = "dragonslayer31051999@gmail.com";

            //MailMessage mail = new MailMessage();
            ////SystemLog.Output(SystemLog.MSG_TYPE.Nor, "Send mail to", receivers[i]);
            //SmtpClient SmtpServer = new SmtpClient(smtp_server);
            //mail.From = new MailAddress(sender);
            //mail.To.Add(receivers);
            //mail.Subject = "Báo biểu bộ phận cắt / 切割件报告 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //StringBuilder mailBody = new StringBuilder();
            //mailBody.Append("这是一封软件自动生成的邮件，请勿回复此邮件！\n");
            //mailBody.Append("如有错误，请联系技术人员！\n");
            //mailBody.Append("邮件创建日期：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n\n");

            //mailBody.Append("Đây là mail tự động tạo từ phần mềm vui lòng không trả lời mail này! \n");
            //mailBody.Append("Nếu có sai sót vui lòng liên hệ kỹ thuật viên!. \n");
            //mailBody.Append("Mail được tạo vào " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n\n");
            //mailBody.Append("-----	TECH-LINK SILICONES (VIETNAM) CO., LIMITED	-----");

            //mail.Body = mailBody.ToString();

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment(pathsave);
            //mail.Attachments.Add(attachment);

            //SmtpServer.Port = int.Parse(smtp_port);
            //SmtpServer.UseDefaultCredentials = false;
            //SmtpServer.Credentials = new System.Net.NetworkCredential(sender, sender_pw);
            //SmtpServer.EnableSsl = true;

            //SmtpServer.Send(mail);
            //mail.Dispose();
            //MessageBox.Show("Sent");

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Browse Excel Files";
            saveFileDialog.DefaultExt = "Excel";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathsave = saveFileDialog.FileName;
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
    }
}
