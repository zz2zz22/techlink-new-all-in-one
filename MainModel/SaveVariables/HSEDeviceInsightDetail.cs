using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techlink_new_all_in_one.MainModel.SaveVariables
{
    [Serializable()]
    public class HSEDeviceInsightDetail
    {
        public string device_type { get; set; }
        public string device_location { get; set; }
        public string device_manager { get; set; }
        public string install_date { get; set; }
        public string expired_date { get; set; }
        public string newest_maintenance_date { get; set; }
        public string newest_checked_date { get; set; }
        public int data_type { get; set; }
        public string check_status { get; set; }
        public string check_desc { get; set; }
        public string check_emp { get; set; }
    }
}
