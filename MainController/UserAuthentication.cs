using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomUI;
using XanderUI;

namespace techlink_new_all_in_one.MainController
{
    public class UserAuthentication
    {
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public bool checkAccount(string username, string password, XUISwitch.State state)
        {
            if (state == XUISwitch.State.On)
            {
                SqlSoft sqlSOFT = new SqlSoft();
                if (username != String.Empty && password != String.Empty)
                {
                    DataTable dtUser = new DataTable();
                    sqlSOFT.sqlDataAdapterFillDatatable("select * from base_user_info where user_name = '" + username + "' and user_password = '" + password + "'", ref dtUser);
                    
                    if (dtUser.Rows.Count == 1)
                    {
                        if (String.IsNullOrEmpty(dtUser.Rows[0]["user_permission"].ToString()))
                        {
                            Alert("Lỗi cơ sở dữ liệu.\r\n数据库错误。", Form_Alert.enmType.Error);
                            return false;
                        }
                        Alert("Đăng nhập thành công!\r\n登录成功！", Form_Alert.enmType.Success);
                        UserData.user_name = username;
                        UserData.user_emp_code = dtUser.Rows[0]["user_emp_code"].ToString().Trim();
                        UserData.user_permission = dtUser.Rows[0]["user_permission"].ToString().Trim();
                        UserData.user_actual_name = dtUser.Rows[0]["user_actual_name"].ToString().Trim();
                        return true;
                    }
                    else
                    {
                        Alert("Sai tài khoản hoặc lỗi kết nối.\r\n帐户名错误或连接错误。", Form_Alert.enmType.Error);
                        return false;
                    }
                }
                else
                {
                    Alert("Tài khoản hoặc mật khẩu trống!\r\n帐号或密码为空！", Form_Alert.enmType.Error);
                    return false;
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(username))
                {
                    string EmpCode = String.Empty, EmpName = String.Empty;
                    SqlHR sqlHR = new SqlHR();
                    string EmpInfo = sqlHR.sqlExecuteScalarString("select Code + ';' + Name from ZlEmployee where Code like '%-%' and CAST(SUBSTRING(Code, CHARINDEX('-', Code) + 1, LEN(Code)) AS int) = '" + username + "'");
                    if (EmpInfo != null)
                    {
                        string[] s = EmpInfo.Split(';');
                        if (s.Length > 1)
                        {
                            EmpCode = s[0];
                            EmpName = s[1];
                        }
                    }
                    if (!String.IsNullOrEmpty(EmpCode))
                    {
                        Alert("Đăng nhập thành công!\r\n登录成功！", Form_Alert.enmType.Success);
                        UserData.user_name = username;
                        UserData.user_emp_code = EmpCode.Trim();
                        if (username == "14042")
                            UserData.user_permission = "1";
                        else
                            UserData.user_permission = "3";
                        UserData.user_actual_name = EmpName.Trim();
                        return true;
                    }
                    else
                    {
                        Alert("Lỗi! Không tìm thấy nhân viên.\r\n错误！没有找到工作人员。", Form_Alert.enmType.Error);
                        return false;
                    }
                }
                else
                {
                    Alert("Lỗi! Mã nhân viên trống.\r\n错误！员工代码为空。", Form_Alert.enmType.Error);
                    return false;
                }
            }
        }
    }
}
