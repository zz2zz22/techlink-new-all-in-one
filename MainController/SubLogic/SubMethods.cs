
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.Properties;
using techlink_new_all_in_one.View.CustomUI;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

class SubMethods
{
    //Fields
    public static DataRow empData;
    public static string EmpID { get; set; }
    public static string EmpCode { get; set; }
    public static string EmpName { get; set; }
    public static string EmpEnName { get; set; }
    public static string EmpSex { get; set; } // 0 là nam 1 là nữ
    public static DateTime? EmpBirthDate { get; set; }
    public static string EmpDepartment { get; set; }
    public static string EmpType { get; set; }
    public static string EmpState { get; set; }
    public static string EmpManager { get; set; }
    public static string EmpAcademicLevel { get; set; }

    //Methods
    public static void Alert(string msg, Form_Alert.enmType type)
    {
        Form_Alert frm = new Form_Alert();
        frm.showAlert(msg, type);
    }

    public static bool CheckIsManager(string value)
    {
        DataTable managerList = new DataTable();
        SqlEHR sqlEHR = new SqlEHR();
        sqlEHR.sqlDataAdapterFillDatatable("select distinct Dept_manager from Emp_Department", ref managerList);
        bool containsValue = containsValue = managerList.AsEnumerable()
                                    .SelectMany(row => row.ItemArray)
                                    .Any(field => field.ToString() == value);
        return containsValue;
    }

    public static bool CheckDepartParent(string EmpDeptCode)
    {
        try
        {
            SqlEHR sqlEHR = new SqlEHR();
            DataRow departmentRow = null;
            StringBuilder sqlCheckDepartmentParent = new StringBuilder();
            sqlCheckDepartmentParent.Append("select distinct Dept_parent, Dept_level from Emp_Department where Dept_code like '" + EmpDeptCode + "'");
            sqlEHR.sqlDataAdapterFillDatarow(sqlCheckDepartmentParent.ToString(), ref departmentRow);
            string result = String.Empty;
            if (departmentRow != null)
            {
                if (departmentRow["Dept_level"].ToString() == "1")
                    result = EmpDeptCode; // Nếu rỗng thì code là code parent
                else
                    result = departmentRow["Dept_parent"].ToString();
            }
            else
            {
                return false;
            }
            if (result == "00" || result == "02") //Check bộ phận quản lý và nghiệp vụ Hồng Kông
            {
                return true;
            }
            return false;
        }
        catch (Exception ex)
        {
            CTMessageBox.Show(ex.Message, "Lỗi kiểm tra bộ phận lớn 主要部门检查错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
    public static void GetAllEmpInfo(string code)
    {
        if (!string.IsNullOrEmpty(code))
        {
            empData = null;
            SqlEHR sqlEHR = new SqlEHR();
            sqlEHR.sqlDataAdapterFillDatarow("select * from Emp_BaseInfo where Emp_code like '%TL-%' and CAST(SUBSTRING(Emp_code, CHARINDEX('-', Emp_code) + 1, LEN(Emp_code)) AS int) = '" + code + "'", ref empData); //and Emp_state = '2'
            if (empData != null)
            {
                EmpID = empData["Emp_id"].ToString();
                EmpCode = empData["Emp_code"].ToString();
                EmpName = empData["Emp_name"].ToString();
                EmpEnName = empData["Emp_enname"].ToString();
                EmpSex = empData["Emp_sex"].ToString();
                string customDateFormat = "yyyy-MM-dd HH:mm:ss";
                DateTime parsedDateTime;
                EmpBirthDate = null;
                if (DateTime.TryParseExact(empData["Emp_borndate"].ToString(), customDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDateTime))
                    EmpBirthDate = parsedDateTime;
                EmpDepartment = empData["Emp_dept"].ToString();
                EmpType = empData["Emp_type"].ToString();
                EmpState = empData["Emp_state"].ToString();
                EmpManager = empData["Emp_manager"].ToString();
                EmpAcademicLevel = empData["Emp_xueli"].ToString();
            }
        }
        else
        {
            string msg = "Vui lòng không để trống mã nhân viên!\r\n请不要将员工代码留空！";
            Alert(msg, Form_Alert.enmType.Warning);
        }
    }

    public static void ResetAllEmpInfo()
    {
        EmpID = null;
        EmpCode = null;
        EmpName = null;
        EmpEnName = null;
        EmpSex = null;
        EmpBirthDate = null;
        EmpDepartment = null;
        EmpType = null;
        EmpState = null;
        EmpManager = null;
        EmpAcademicLevel = null;
    }

    public static string GetEmpNameAndCode(string Code)
    {
        GetAllEmpInfo(Code);
        if (!string.IsNullOrEmpty(EmpCode) && !string.IsNullOrEmpty(EmpName))
        {
            if (string.IsNullOrEmpty(EmpEnName))
            {
                return EmpCode + " - " + EmpName;
            }
            else
            {
                return EmpCode + " - " + EmpEnName + " " + EmpName;
            }
        }
        else
            return String.Empty;
    }

    public static string GetEmpCode()
    {
        return SubMethods.empData["Emp_code"].ToString();
    }

    public static string RemoveVietnameseUnicode(string text)
    {
        string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
        string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
        for (int i = 0; i < arr1.Length; i++)
        {
            text = text.Replace(arr1[i], arr2[i]);
            text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
        }
        return text;
    }

    public static string ConvertXlsToXLSX(string filePath)
    {
        Excel.Application objXL = new Excel.Application();
        Excel.Workbook objWB = objXL.Workbooks.Open(filePath);
        objXL.DisplayAlerts = false;
        
        string newPath = Path.GetDirectoryName(filePath) + "\\" + Path.GetFileNameWithoutExtension(filePath);
        objWB.SaveAs(newPath, Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
    Missing.Value, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
    Excel.XlSaveConflictResolution.xlUserResolution, true,
    Missing.Value, Missing.Value, Missing.Value);
        objWB.Close(0);
        objXL.Quit();
        return newPath + ".xlsx";
    }

    public static bool CheckSpecialCharacter(string text)
    {
        var match = text.IndexOfAny(new char[] { '\\', '/', ':', '*', '<', '>', '|', '#', '{', '}', '%', '~', '&', '\'' });
        if (match == -1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
