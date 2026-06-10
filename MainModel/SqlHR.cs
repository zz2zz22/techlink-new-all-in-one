using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one.MainModel
{
    public class SqlHR
    {
        public SqlConnection conn = DatabaseUtils.GetHRDATAConnection();

        public string GetConnectionString()
        {
            return conn.ConnectionString; // expose the connection string
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public int sqlExecuteScalarInt(string query)
        {
            try
            {
                using (SqlConnection conn = DatabaseUtils.GetHRDATAConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value) return 0;
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch { return 0; }
        }
        public bool sqlExecuteScalarExists(string sql)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL HR!\r\n无法连接到 SQL HR 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    // ← also check if value is "0"
                    if (result == null || result == DBNull.Value)
                        return false;

                    // Handle COUNT queries returning 0
                    if (result is int i && i == 0) return false;
                    if (result is long l && l == 0) return false;
                    if (result is decimal d && d == 0) return false;

                    return true;
                }
                catch (Exception)
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    return false;
                }
            }
            return false;
        }

        public string sqlExecuteScalarString(string sql)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL HR!\r\n无法连接到 SQL HR 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            String outstring;
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
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
            else
            {
                return String.Empty;
            }
        }
        public void getComboBoxData(string sql, ref ComboBox cmb)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL HR!\r\n无法连接到 SQL HR 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                try
                {
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
                catch (Exception ex)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    CTMessageBox.Show("Lỗi khi tải dữ liệu vào combobox!\r\n将数据加载到组合框中时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void sqlDataAdapterFillDatatable(string sql, ref DataTable dt)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL HR!\r\n无法连接到 SQL HR 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                try
                {
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    CTMessageBox.Show("Lỗi khi tải dữ liệu datatable!\r\n加载数据表数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void sqlExecuteNonQuery(string sql, string successMessage, string errorMessage)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL HR!\r\n无法连接到 SQL HR 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    Alert(successMessage, Form_Alert.enmType.Success);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    CTMessageBox.Show(errorMessage + "\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
