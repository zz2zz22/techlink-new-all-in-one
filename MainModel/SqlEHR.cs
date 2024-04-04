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
    public class SqlEHR
    {
        public SqlConnection conn = DatabaseUtils.GetEHRDBConnection();

        //OTHER METHODS
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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
                CTMessageBox.Show("Không thể kết nối server SQL EHR!\r\n无法连接到 SQL EHR 服务器！\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CTMessageBox.Show("Không thể kết nối server SQL EHR!\r\n无法连接到 SQL EHR 服务器！\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CTMessageBox.Show("Không thể kết nối server SQL EHR!\r\n无法连接到 SQL EHR 服务器！\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    CTMessageBox.Show("Lỗi khi tải dữ liệu datatable!\r\n加载数据表数据时出错！\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void sqlDataAdapterFillDatarow(string sql, ref DataRow dataRow)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL EHR!\r\n无法连接到 SQL EHR 服务器！\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                try
                {
                    DataTable tempDataTable = new DataTable();
                    adapter.Fill(tempDataTable);
                    if (tempDataTable.Rows.Count > 0)
                    {
                        dataRow = tempDataTable.Rows[0];
                    }
                    else
                    {
                        dataRow = null;
                    }
                }
                catch (Exception ex)
                {
                    CTMessageBox.Show("Lỗi khi tải dữ liệu datatable!\r\n加载数据表数据时出错！\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
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
                CTMessageBox.Show("Không thể kết nối server SQL EHR!\r\n无法连接到 SQL EHR 服务器！\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.CommandTimeout = 5;
                    cmd.ExecuteNonQuery();
                    if (!string.IsNullOrEmpty(successMessage))
                        Alert(successMessage, Form_Alert.enmType.Success);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    if (!string.IsNullOrEmpty(errorMessage))
                        CTMessageBox.Show(errorMessage + "\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
