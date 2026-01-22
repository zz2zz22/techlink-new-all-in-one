using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techlink_new_all_in_one.MainModel.SaveVariables
{
    [Serializable()]
    public class SpanishHoseCuttingInfo
    {
        public string Date { get; set; }
        public string MainCode { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialType { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
    }
}
