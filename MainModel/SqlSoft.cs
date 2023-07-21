using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one.MainModel
{
    public class SqlSoft
    {
        public SqlConnection conn = DatabaseUtils.GetDBConnection();

        //OTHER METHODS
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public string sqlExecuteScalarString(string sql)
        {

            String outstring;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                outstring = cmd.ExecuteScalar().ToString();
                conn.Close();
                return outstring;
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return String.Empty;
            }


        }
        public void getComboBoxData(string sql, ref ComboBox cmb)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                cmd.Dispose();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmb.Items.Add(row[0].ToString());
                }
                conn.Close();
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void sqlDataAdapterFillDatatable(string sql, ref DataTable dt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {
            }
        }
        public void sqlExecuteNonQuery(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //ADMIN SECTION SQL
        public void sqlInsertAdminDepartmentInfo(string department_name)
        {
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("Insert into department_info (uuid, department_name,create_date) ");
                sb.Append("values ");
                sb.Append("(@uuid, @department_name, @create_date)");
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                cmd.Parameters.AddWithValue("@uuid", UUIDGenerator.getAscId());
                cmd.Parameters.AddWithValue("@department_name", department_name);
                cmd.Parameters.AddWithValue("@create_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                conn.Close();
                Alert("Thêm dữ liệu thành công!\r\n添加数据成功！", Form_Alert.enmType.Success);
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                CTMessageBox.Show("Lỗi khi thêm dữ liệu bộ phận!\r\n添加数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void sqlInsertAdminStationInfo(string station_name, string department_uuid)
        {
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("Insert into station_info (uuid, station_name, department_uuid, create_date) ");
                sb.Append("values ");
                sb.Append("(@uuid, @station_name, @department_uuid, @create_date)");
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                cmd.Parameters.AddWithValue("@uuid", UUIDGenerator.getAscId());
                cmd.Parameters.AddWithValue("@station_name", station_name);
                cmd.Parameters.AddWithValue("@department_uuid", department_uuid);
                cmd.Parameters.AddWithValue("@create_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                conn.Close();
                Alert("Thêm dữ liệu thành công!\r\n添加数据成功！", Form_Alert.enmType.Success);
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                CTMessageBox.Show("Lỗi khi thêm dữ liệu trạm!\r\n添加数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void sqlInsertProgramInfo(string name, string permission, string description, string formName, Image image, string type)
        {
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("Insert into programs_info (uuid, program_name, program_permission,program_status,");
                sb.Append("program_description, program_main_form_name, image, program_type) ");
                sb.Append("values ");
                sb.Append("(@uuid, @name, @permission, @status, ");
                sb.Append("@description, @formName, @image, @type)");
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                cmd.Parameters.AddWithValue("@uuid", UUIDGenerator.getAscId());
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@permission", permission);
                cmd.Parameters.AddWithValue("@status", "OK");
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@formName", formName);
                MemoryStream ms = new MemoryStream();
                image.Save(ms, image.RawFormat);
                cmd.Parameters.AddWithValue("@image", ms.ToArray());
                cmd.Parameters.AddWithValue("@type", type);

                cmd.ExecuteNonQuery();
                conn.Close();
                Alert("Thêm dữ liệu thành công!\r\n添加数据成功！", Form_Alert.enmType.Success);
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                CTMessageBox.Show("Lỗi khi thêm dữ liệu!\r\n添加数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //SPANISH HOSE SECTION SQL
        public void sqlInsertSpanishHoseBaseData(string product_no, string description, string unit, double quantity)
        {
            try
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("Insert into spanish_hose_base_data (product_no, description,unit,quantity) ");
                sb.Append("values ");
                sb.Append("(@product_no, @description, @unit, @quantity)");
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                cmd.Parameters.AddWithValue("@product_no", product_no);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                CTMessageBox.Show("Lỗi khi thêm dữ liệu!\r\n添加数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
