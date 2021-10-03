using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.ConstantHelpers;
using static MarsQA_1.Helpers.CommonMethods;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;

namespace MarsQA_1.SpecflowPages.Pages
{
    class EarnTarget
    {
        public EarnTarget()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "availabiltyTarget")]
        private IWebElement earntarget { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement etarget { get; set; }
        internal void Selectearntarget()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "EarnTarget");
            Driver.TurnOnWait();
            etarget.Click();
            var t1 = new SelectElement(earntarget);
            t1.SelectByValue(ExcelLibHelper.ReadData(2, "EarnTarget"));

            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Select earn target");
                String Expectedvalue = ExcelLibHelper.ReadData(3, "EarnTarget");
                String Actualvalue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span")).Text;
                if (Expectedvalue == Actualvalue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "earn target selected");
                }
                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Fail");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test fail", e.Message);
            }

        }
    }
}
