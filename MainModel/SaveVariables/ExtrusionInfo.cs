using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techlink_new_all_in_one.MainModel.SaveVariables
{
    [Serializable()]
    public class ExtrusionInfo
    {
        public string Date { get; set; }
        public string MainCode { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
    }
}
