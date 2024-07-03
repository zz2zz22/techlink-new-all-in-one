using System;
using System.Data;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.View.CustomUI;
using XanderUI;
using System.Windows.Forms;
using java.util;
using System.Linq;
using System.Text.RegularExpressions;

namespace techlink_new_all_in_one.MainController
{
    public class UserAuthentication
    {
        public bool CheckAccount(string username, string password, XUISwitch.State state)
        {
            if (state == XUISwitch.State.Off)
            {
                if (username != String.Empty && password != String.Empty)
                {
                    SqlSoft sqlSOFT = new SqlSoft();
                    DataTable dtUser = new DataTable();
                    sqlSOFT.sqlDataAdapterFillDatatable("select * from base_user_info where user_name = '" + username + "' and user_password = '" + password + "'", ref dtUser);

                    if (dtUser.Rows.Count == 1)
                    {
                        if (string.IsNullOrEmpty(dtUser.Rows[0]["user_emp_code"].ToString()))
                        {
                            SubMethods.Alert("Lỗi cơ sở dữ liệu hoặc \r\n数据库错误。", Form_Alert.enmType.Error);
                            return false;
                        }
                        else
                        {
                            string empIntCode = Regex.Match(dtUser.Rows[0]["user_emp_code"].ToString(), @"\d+").Value;
                            SubMethods.GetAllEmpInfo(empIntCode);

                            string EmpCode = SubMethods.EmpCode;
                            string EmpName = SubMethods.EmpName;
                            if (!String.IsNullOrEmpty(SubMethods.EmpEnName))
                            {
                                EmpName = SubMethods.EmpEnName + "-" + SubMethods.EmpName;
                            }
                            UserData.LoginUserID = SubMethods.EmpID;
                            UserData.UserCode = EmpCode;
                            UserData.UserName = EmpName;
                            UserData.UserManager = SubMethods.EmpManager;
                            UserData.UserDepartmentCode = SubMethods.EmpDepartment;
                            UserData.UserType = SubMethods.EmpType;
                            UserData.UserPermission = dtUser.Rows[0]["user_permission"].ToString();
                            SubMethods.ResetAllEmpInfo();
                            SubMethods.Alert("Đăng nhập thành công!\r\n登录成功！", Form_Alert.enmType.Success);
                            return true;
                        }
                    }
                    else
                    {
                        SubMethods.Alert("Sai tài khoản hoặc lỗi kết nối.\r\n帐户名错误或连接错误。", Form_Alert.enmType.Error);
                        return false;
                    }
                }
                else
                {
                    SubMethods.Alert("Tài khoản hoặc mật khẩu trống!\r\n帐号或密码为空！", Form_Alert.enmType.Warning);
                    return false;
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(username))
                {
                    SubMethods.GetAllEmpInfo(username);
                    if(SubMethods.CheckIsManager(username) || SubMethods.CheckDepartParent(SubMethods.EmpDepartment))
                    {
                        SubMethods.ResetAllEmpInfo();
                        string msg = "Bạn đang nhập mã số nhân viên có quyền hạn cao vui lòng nhập mật khẩu!\r\nNếu chưa có mật khẩu hãy liên hệ bộ phận IT hoặc Phần mềm để tạo mật khẩu.\r\n\r\n您正在输入高权限员工代码，请输入密码！\r\n如果您没有密码，请联系 IT 或软件部门创建密码。";
                        CTMessageBox.Show(msg, "Cảnh báo 警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        string EmpCode = SubMethods.EmpCode;
                        string EmpName = SubMethods.EmpName;
                        if (!String.IsNullOrEmpty(SubMethods.EmpEnName))
                        {
                            EmpName = SubMethods.EmpEnName + "-" + SubMethods.EmpName;
                        }
                        if (!String.IsNullOrEmpty(EmpCode))
                        {
                            UserData.LoginUserID = SubMethods.EmpID;
                            UserData.UserCode = EmpCode;
                            UserData.UserName = EmpName;
                            UserData.UserManager = SubMethods.EmpManager;
                            UserData.UserDepartmentCode = SubMethods.EmpDepartment;
                            UserData.UserType = SubMethods.EmpType;
                            UserData.UserPermission = "3";

                            SubMethods.ResetAllEmpInfo();
                            SubMethods.Alert("Đăng nhập thành công!\r\n登录成功！", Form_Alert.enmType.Success);
                            return true;
                        }
                        else
                        {
                            SubMethods.ResetAllEmpInfo();
                            SubMethods.Alert("Không tìm thấy nhân viên trong hệ thống.\r\n系统中未找到员工。", Form_Alert.enmType.Error);
                            return false;
                        }
                    }
                }
                else
                {
                    SubMethods.Alert("Mã nhân viên trống.\r\n员工代码为空。", Form_Alert.enmType.Warning);
                    return false;
                }
            }
        }
    }
}
