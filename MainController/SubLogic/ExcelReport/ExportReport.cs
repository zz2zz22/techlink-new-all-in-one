using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using techlink_new_all_in_one.MainModel.SaveVariables;

namespace techlink_new_all_in_one.MainController.SubLogic
{
    public class ExportReport
    {
        public string PathCuttingReport = Environment.CurrentDirectory + @"\Resources\ExportCuttingForm.xlsx";
        public string SpanishHosePathCuttingReport = Environment.CurrentDirectory + @"\Resources\ExportCuttingSpanishHose.xlsx";

        public void ExportExcelSpanishHoseCuttingReport(string PathSave, List<SpanishHoseCuttingInfo> details)
        {
            ToolSupport toolSupport = new ToolSupport();
            toolSupport.ExportDataSpanishHoseCutting(details, PathSave, SpanishHosePathCuttingReport);
        }
        public void ExportExcelCuttingReport(string PathSave, List<BigHoseCuttingInfo> details)
        {
            ToolSupport toolSupport = new ToolSupport();
            toolSupport.ExportDataBigHoseCutting(details, PathSave, PathCuttingReport);
        }
    }
}
