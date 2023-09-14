using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainController.SubLogic.GenerateUUID;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;
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
        public string sqlExecuteScalarStringHoldConnect(string sql)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            String outstring;
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    outstring = cmd.ExecuteScalar().ToString();
                    return outstring;
                }
                catch (Exception)
                {
                    return String.Empty;
                }
            }
            else
            {
                return String.Empty;
            }
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
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void sqlDataAdapterFillDatatableHoldConnect(string sql, ref DataTable dt)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    CTMessageBox.Show("Lỗi khi tải dữ liệu datatable!\r\n加载数据表数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
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
                        CTMessageBox.Show(errorMessage + "\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //ADMIN SECTION SQL
        public void sqlInsertAdminDepartmentInfo(string department_name)
        {
            try
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                }
                catch (SqlException ex)
                {
                    CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                }
                catch (SqlException ex)
                {
                    CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        public void sqlInsertAdminPermissionInfo(string permission_name)
        {
            try
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                }
                catch (SqlException ex)
                {
                    CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                StringBuilder sb = new StringBuilder();
                sb.Append("Insert into programs_permission (permission_name) ");
                sb.Append("values ");
                sb.Append("(@permission_name)");
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                cmd.Parameters.AddWithValue("@permission_name", permission_name);
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
                CTMessageBox.Show("Lỗi khi thêm dữ liệu quyền hạn!\r\n添加权限数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cái này dùng để insert nút để mở form vào trong hệ thống
        public void sqlInsertProgramInfo(string name, string permission, string description, string formName, Image image, string type)
        {
            try
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                }
                catch (SqlException ex)
                {
                    CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        public void sqlInsertSpanishHoseBaseData(DataGridView dataGridView)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                ProgressDialog progressDialog = new ProgressDialog();
                string product_no = null, description = null, unit = null, quantity = null;
                Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    try
                    {
                        int i = 0;
                        cmd.CommandText = "exec Delete_spanish_hose_base_data";
                        cmd.ExecuteNonQuery();
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            var charsToRemove = new string[] { "@", "'" };
                            StringBuilder sb = new StringBuilder();
                            foreach (var c in charsToRemove)
                            {
                                product_no = row.Cells["product_no"].Value.ToString().Replace(c, string.Empty);
                                description = row.Cells["description"].Value.ToString().Replace(c, string.Empty);
                            }
                            unit = row.Cells["unit"].Value.ToString();
                            quantity = "1";
                            sb.Append("exec Insert_spanish_hose_base_data N'" + product_no + "', N'" + description + "', '" + unit + "', '" + quantity + "'");
                            cmd.CommandText = sb.ToString();
                            cmd.ExecuteNonQuery();
                            i++;
                            progressDialog.UpdateProgress(100 * i / dataGridView.RowCount, "Đang nạp dữ liệu vào server!\r\n正在加载数据到服务器！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                        conn.Close();
                        CTMessageBox.Show("Nhập dữ liệu vào hệ thống hoàn tất!\r\n数据录入系统完成！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                        CTMessageBox.Show("Lỗi khi thêm dữ liệu!\r\n添加数据时出错！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
                backgroundThread.Start();
                progressDialog.ShowDialog();
            }
        }

        //BIG HOSE SECTION SQL
        public void sqlInsertBigHoseBaseData(DataGridView dataGridView)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                ProgressDialog progressDialog = new ProgressDialog();
                string product_no = null, description = null, unit = null, quantity = null;
                Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {

                    try
                    {
                        int i = 0;
                        cmd.CommandText = "exec Delete_big_hose_base_data";
                        cmd.ExecuteNonQuery();

                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            var charsToRemove = new string[] { "@", "'" };
                            StringBuilder sb = new StringBuilder();
                            foreach (var c in charsToRemove)
                            {
                                product_no = row.Cells["product_no"].Value.ToString().Replace(c, string.Empty);
                                description = row.Cells["description"].Value.ToString().Replace(c, string.Empty);
                            }

                            unit = "";
                            quantity = row.Cells["quantity"].Value.ToString();
                            if (!string.IsNullOrEmpty(product_no) && !string.IsNullOrEmpty(description))
                            {
                                sb.Append("exec Insert_big_hose_base_data N'" + product_no + "', N'" + description + "', '" + unit + "', '" + quantity + "'");
                                cmd.CommandText = sb.ToString();
                                cmd.ExecuteNonQuery();
                            }
                            i++;
                            progressDialog.UpdateProgress(100 * i / dataGridView.RowCount, "Đang nạp dữ liệu vào server!\r\n正在加载数据到服务器！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                        conn.Close();
                        CTMessageBox.Show("Nhập dữ liệu vào hệ thống hoàn tất!\r\n数据录入系统完成！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                        CTMessageBox.Show("Lỗi khi thêm dữ liệu!\r\n添加数据时出错！\r\n\r\n" + ex.Message + "\r\n\r\n" + product_no, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
                backgroundThread.Start();
                progressDialog.ShowDialog();
            }
        }

        public void sqlInsertBigHoseDailyProductTarget(DataGridView dataGridView)
        {
            DataTable dtExist = new DataTable();
            DataTable dtNotExist = new DataTable();
            string product_no = null, customer_code = null, target_quanity = null, dateTime = null;
            List<BigHoseDailyProductTargetExist> existUUID = new List<BigHoseDailyProductTargetExist>();
            List<BigHoseDailyProductTargetNotExist> notExistUUID = new List<BigHoseDailyProductTargetNotExist>();

            foreach (DataGridViewRow rowcheck in dataGridView.Rows)
            {
                var charsToRemove = new string[] { "@", "'" };

                foreach (var c in charsToRemove)
                {
                    product_no = rowcheck.Cells["product_no"].Value.ToString().Replace(c, string.Empty);
                    customer_code = rowcheck.Cells["customer_code"].Value.ToString().Replace(c, string.Empty);
                }
                DateTime currentDate = Convert.ToDateTime(rowcheck.Cells["target_date"].Value.ToString());
                dateTime = currentDate.ToString("yyyy-MM-dd 00:00:00");
                target_quanity = rowcheck.Cells["target_quantity"].Value.ToString();
                string uuidExist = sqlExecuteScalarString("select uuid from big_hose_daily_product_target where product_no = N'" + product_no + "' and customer_code = N'" + customer_code + "' and create_date >= '" + dateTime + "' and create_date <= '" + dateTime + "'");
                if (!string.IsNullOrEmpty(uuidExist))
                {
                    BigHoseDailyProductTargetExist obj = new BigHoseDailyProductTargetExist();
                    obj.uuid = uuidExist;
                    obj.product_no = product_no;
                    obj.customer_code = customer_code;
                    obj.target_quanity = target_quanity;
                    obj.target_date = dateTime;
                    existUUID.Add(obj);
                }
                else
                {
                    BigHoseDailyProductTargetNotExist obj = new BigHoseDailyProductTargetNotExist();
                    obj.product_no = product_no;
                    obj.customer_code = customer_code;
                    obj.target_date = dateTime;
                    obj.target_quanity = target_quanity;
                    notExistUUID.Add(obj);
                }
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                int i = 0;
                ProgressDialog progressDialog = new ProgressDialog();
                if (existUUID.Count() > 0 )
                {
                    DialogResult dialogResult = CTMessageBox.Show("Có mã hàng đã được nhập dữ liệu, bạn muốn cập nhật số liệu mới cho các mã đó ?\r\n有已输入数据的商品代码，您想更新这些代码的新数据吗？", "Thông báo 报信", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        Thread backgroundThreadCheckExist = new Thread(
                        new ThreadStart(() =>
                        {
                            try
                            {
                                foreach (BigHoseDailyProductTargetExist s in existUUID)
                                {
                                    dtExist = new DataTable();
                                    sqlDataAdapterFillDatatableHoldConnect("select uuid, station_uuid, count_down from big_hose_product_countdown where product_no = '" + s.product_no + "'", ref dtExist);
                                    string planStart = Convert.ToDateTime(s.target_date).ToString("yyyy-MM-dd 08:00:00");
                                    string planEnd = Convert.ToDateTime(s.target_date).AddDays(1).ToString("yyyy-MM-dd 08:00:00");
                                    DataTable cdResultData = new DataTable();
                                    sqlDataAdapterFillDatatable("select uuid, station_uuid from big_hose_countdown_result where product_no = '" + s.product_no + "' and plan_start >= '" + planStart + "' and plan_end <= '" + planEnd + "'", ref cdResultData);

                                    SqlCommand cmd = new SqlCommand();
                                    cmd.Connection = conn;
                                    cmd.CommandText = "exec Update_big_hose_daily_product_target '" + s.uuid + "', N'" + s.customer_code + "', N'" + s.product_no + "', '" + s.target_quanity + "'";
                                    cmd.ExecuteNonQuery();
                                    if (dtExist != null && dtExist.Rows.Count > 0)
                                    {
                                        for (int cde = 0; cde < dtExist.Rows.Count; cde++)
                                        {
                                            string cd_station = dtExist.Rows[cde]["station_uuid"].ToString();
                                            string cd_per_prod = dtExist.Rows[cde]["count_down"].ToString();
                                            string uuid_result = null;
                                            if (cdResultData != null && cdResultData.Rows.Count > 0)
                                            {
                                                for (int cdi = 0; cdi < cdResultData.Rows.Count; cdi++)
                                                {
                                                    if (cd_station == cdResultData.Rows[cdi]["station_uuid"].ToString())
                                                    {
                                                        uuid_result = cdResultData.Rows[cdi]["uuid"].ToString();
                                                    }
                                                }
                                            }
                                            if (!string.IsNullOrEmpty(cd_per_prod) && !string.IsNullOrEmpty(cd_station))
                                            {
                                                double totalTime = Convert.ToDouble(cd_per_prod) * Convert.ToDouble(s.target_quanity);
                                                if (!string.IsNullOrEmpty(uuid_result))
                                                {
                                                    cmd.CommandText = "exec Update_cd_time_an_target '" + uuid_result + "', '" + s.target_quanity + "','" + totalTime + "'";
                                                    cmd.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    cmd.CommandText = "exec Insert_result_when_insert_target '" + UUIDGenerator.getAscId() + "', N'" + s.product_no + "', '" + cd_station + "', '" + s.target_quanity + "', '" + totalTime + "', '" + planStart + "', '" + planEnd + "'";
                                                    cmd.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                    conn.Close();
                                    i++;
                                    progressDialog.UpdateProgress(100 * i / (existUUID.Count + notExistUUID.Count), "Đang nạp dữ liệu vào server!\r\n正在加载数据到服务器！");
                                }
                                progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                            }
                            catch (Exception ex)
                            {
                                progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                                if (conn.State == ConnectionState.Open)
                                {
                                    conn.Close();
                                }
                                CTMessageBox.Show("Lỗi khi thêm dữ liệu!\r\n添加数据时出错！\r\n\r\n" + ex.Message + "\r\n\r\n" + product_no, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }));
                        backgroundThreadCheckExist.Start();
                        progressDialog.ShowDialog();
                    }
                }
                if (notExistUUID.Count > 0)
                {
                    Thread backgroundThreadCheckNotExist = new Thread(
                    new ThreadStart(() =>
                    {
                        try
                        {

                            foreach (BigHoseDailyProductTargetNotExist ne in notExistUUID)
                            {
                                dtNotExist = new DataTable();
                                sqlDataAdapterFillDatatableHoldConnect("select uuid, station_uuid, count_down from big_hose_product_countdown where product_no = '" + ne.product_no + "'", ref dtNotExist);

                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = conn;
                                string uuid = UUIDGenerator.getAscId();
                                StringBuilder sb = new StringBuilder();
                                if (!string.IsNullOrEmpty(product_no) && !string.IsNullOrEmpty(customer_code))
                                {
                                    sb.Append("exec Insert_big_hose_daily_product_target '" + uuid + "', N'" + ne.customer_code + "', N'" + ne.product_no + "', '" + ne.target_quanity + "', '" + ne.target_date + "'");
                                    cmd.CommandText = sb.ToString();
                                    cmd.ExecuteNonQuery();
                                    if (dtNotExist != null && dtNotExist.Rows.Count > 0)
                                    {
                                        for (int cdne = 0; cdne < dtNotExist.Rows.Count; cdne++)
                                        {
                                            string cd_station = dtNotExist.Rows[cdne]["station_uuid"].ToString();
                                            string cd_per_prod = dtNotExist.Rows[cdne]["count_down"].ToString();
                                            if (!string.IsNullOrEmpty(cd_per_prod) && !string.IsNullOrEmpty(cd_station))
                                            {
                                                double totalTime = Convert.ToDouble(cd_per_prod) * Convert.ToDouble(ne.target_quanity);
                                                string planStart = Convert.ToDateTime(ne.target_date).ToString("yyyy-MM-dd 08:00:00");
                                                string planEnd = Convert.ToDateTime(ne.target_date).AddDays(1).ToString("yyyy-MM-dd 08:00:00");
                                                cmd.CommandText = "exec Insert_result_when_insert_target '" + UUIDGenerator.getAscId() + "', N'" + ne.product_no + "', '" + cd_station + "', '" + ne.target_quanity + "', '" + totalTime + "', '" + planStart + "', '" + planEnd + "'";
                                                cmd.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                }
                                conn.Close();
                                i++;
                                progressDialog.UpdateProgress(100 * i / (existUUID.Count + notExistUUID.Count), "Đang nạp dữ liệu vào server!\r\n正在加载数据到服务器！");
                            }
                            progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));

                        }
                        catch (Exception ex)
                        {
                            progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                            if (conn.State == ConnectionState.Open)
                            {
                                conn.Close();
                            }
                            CTMessageBox.Show("Lỗi khi thêm dữ liệu!\r\n添加数据时出错！\r\n\r\n" + ex.Message + "\r\n\r\n" + product_no, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                    backgroundThreadCheckNotExist.Start();
                    progressDialog.ShowDialog();
                }
                CTMessageBox.Show("Nhập dữ liệu vào hệ thống hoàn tất!\r\n数据录入系统完成！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void sqlInsertBigHoseProductCountdown(DataGridView dataGridView)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                CTMessageBox.Show("Không thể kết nối server SQL Soft!\r\n无法连接到 SQL Soft 服务器！\r\n\r\n" + ex.Message, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                ProgressDialog progressDialog = new ProgressDialog();
                string product_no = null, rolling_countdown = null, fixative_countdown = null;
                Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    try
                    {
                        int i = 0;
                        cmd.CommandText = "exec Delete_big_hose_product_countdown";
                        cmd.ExecuteNonQuery();

                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            var charsToRemove = new string[] { "@", "'" };
                            foreach (var c in charsToRemove)
                            {
                                product_no = row.Cells["product_no"].Value.ToString().Replace(c, string.Empty);
                            }

                            rolling_countdown = row.Cells["rolling_countdown"].Value.ToString();
                            fixative_countdown = row.Cells["fixative_countdown"].Value.ToString();
                            if (string.IsNullOrEmpty(rolling_countdown))
                                rolling_countdown = "0";
                            if (string.IsNullOrEmpty(fixative_countdown))
                                fixative_countdown = "0";
                            if (!string.IsNullOrEmpty(product_no))
                            {
                                cmd.CommandText = "exec Insert_big_hose_product_countdown '" + UUIDGenerator.getAscId() + "', '740NR8961SWFVO', N'" + product_no + "', '" + rolling_countdown + "'";
                                cmd.ExecuteNonQuery();
                                cmd.CommandText = "exec Insert_big_hose_product_countdown '" + UUIDGenerator.getAscId() + "', '740NRGQRF6OFVO', N'" + product_no + "', '" + fixative_countdown + "'";
                                cmd.ExecuteNonQuery();
                            }
                            i++;
                            progressDialog.UpdateProgress(100 * i / dataGridView.RowCount, "Đang nạp dữ liệu vào server!\r\n正在加载数据到服务器！");
                        }
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                        conn.Close();
                        CTMessageBox.Show("Nhập dữ liệu vào hệ thống hoàn tất!\r\n数据录入系统完成！", "Thông báo 报信", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        progressDialog.BeginInvoke(new Action(() => progressDialog.Close()));
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                        CTMessageBox.Show("Lỗi khi thêm dữ liệu!\r\n添加数据时出错！\r\n\r\n" + ex.Message + "\r\n\r\n" + product_no, "Lỗi 弊", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));
                backgroundThread.Start();
                progressDialog.ShowDialog();
            }
        }
    }
}
