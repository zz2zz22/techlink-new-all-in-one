using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techlink_new_all_in_one.MainModel.SaveVariables
{
    [Serializable()]
    public class HTVQAReportVariables
    {
        public string lot_code { get; set; }
        public float hardness_0h { get; set; }
        public float hardness_200C_4h { get; set; }
        public float tear_strengh_die_B_0h { get; set; }
        public float tensile_strengh_0h { get; set; }
        public float elongation_0h { get; set; }
        public float plasticity_0h { get; set; }
        public float plasticity_150_5h { get; set; }
        public float tc90 { get; set; }
        public float change_plasticity_150_5h { get; set; }
        public float density_0h { get; set; }
    }
}
