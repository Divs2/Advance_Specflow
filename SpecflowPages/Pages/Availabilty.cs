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
    class Availabilty
    {
        public Availabilty()
        {
            PageFactory.InitElements(Driver.driver, this);


        }
        //Click on Availabilty
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement availabilty { get; set; }


        internal void selectavailabilty()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "availabilty");
           Driver.TurnOnWait();
            IWebElement edava = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            edava.Click();
            var Ll = new SelectElement(availabilty);
            Ll.SelectByValue(ExcelLibHelper.ReadData(2, "availabilty"));


            try
            {
                //Start report
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Select availabilty");
                string ExpectedValue = ExcelLibHelper.ReadData(3, "availabilty");
                string ActualValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span")).Text;
                //check expected and actual value are same
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "availabilty Selected");



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
