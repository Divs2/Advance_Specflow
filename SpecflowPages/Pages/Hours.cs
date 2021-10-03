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
    class Hours
    {
        public Hours()
        {
            PageFactory.InitElements(Driver.driver, this);

        }

        //Click on Hours
        [FindsBy(How = How.Name, Using = "availabiltyHour")]
        private IWebElement hours { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement Ehours { get; set; }
        internal void Selecthours()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "Hours");
            Driver.TurnOnWait();
            Ehours.Click();
            var h1 = new SelectElement(hours);
            h1.SelectByValue(ExcelLibHelper.ReadData(2, "Hours"));

            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("select available hours");
                string Expectedvalue = ExcelLibHelper.ReadData(3, "Hours");
                string Actualvalue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span")).Text;
                if (Expectedvalue == Actualvalue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Pass");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "available Hours Selected");

                }
                else

                    CommonMethods.test.Log(LogStatus.Fail, "Test fail");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test fail", e.Message);

            }

        }

    }

}

