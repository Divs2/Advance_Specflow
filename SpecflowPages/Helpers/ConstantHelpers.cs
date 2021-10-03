using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";

        //ScreenshotPath
        public static string ScreenshotPath = @"E:\MVP\Mars__Specflow\MarsQA-1\TestReports\Screenshots\";
        //ExtentReportsPath
        public static string ReportsPath = @"E:\MVP\Mars__Specflow\MarsQA-1\TestReports\Reports.html";

        //ReportXML Path
        public static string ReportXMLPath = @"E:\MVP\Mars__Specflow\MarsQA-1\TestReports\XMLFile.xml";

        // Excel Path
        public static string ExcelPath = @"E:\MVP\Mars__Specflow\MarsQA-1\SpecflowTests\Data\Data.xlsx";
    }
}