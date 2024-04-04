using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techlink_new_all_in_one.MainModel
{
    public class DatabaseUtils
    {
        public static SqlConnection GetDBConnection() //Main server của software
        {
            string datasource = "172.16.0.12";
            string database = "programs_database";
            string username = "ERPUSER";
            string password = "12345";
            return DatabaseSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
        public static SqlConnection GetHRDATAConnection() //Server của txcard - Ứng dụng quản lý của nhân sự
        {
            string datasource = "172.16.0.9\\tx";
            string database = "txcard";
            string username = "sa";
            string password = "ppnn13";
            return DatabaseSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
        public static SqlConnection GetERPDBConnection() //ERP trên con .11 db - TLVN2 (dùng để test) con chính ERP trong db TECHLINK (KHÔNG ĐƯỢC ĐỘNG VÀO NẾU CHƯA TEST KĨ )
        {
            string datasource = "172.16.0.11"; // Main ERP test connection "TLVN2"
            string database = "TECHLINK";
            string username = "soft";
            string password = "techlink@!@#";

            return DatabaseSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
        public static SqlConnection GetDeviceMaintenanceDBConnection()
        {
            string datasource = "172.16.0.12";
            string database = "DEVICES_MAINTENANCE";
            string username = "ERPUSER";
            string password = "12345";

            return DatabaseSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
        public static MySqlConnection GetMes_Base_DataDBC()
        {
            string host = "172.16.0.22";
            string user = "guest";
            string password = "guest@123";
            string database = "mes_base_data";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }
        public static SqlConnection GetEHRDBConnection() //Database hệ thống tongxiang EHR chỉ có quyền đọc
        {
            string datasource = "172.16.99.222";
            string database = "txehr";
            string username = "dev";
            string password = "techlink@!@#";

            return DatabaseSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
