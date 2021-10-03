using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.ConstantHelpers;
using static MarsQA_1.Helpers.CommonMethods;
using RelevantCodes.ExtentReports;
using System.Threading;
using NUnit.Framework;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Certification
    {
        public Certification()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "Certifications")]
        private IWebElement certi { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement addnew { get; set; }
        [FindsBy(How = How.Name, Using = "certificationName")]
        private IWebElement cername { get; set; }
        [FindsBy(How = How.Name, Using = "certificationFrom")]
        private IWebElement certfrom { get; set; }
        [FindsBy(How = How.Name, Using = "certificationYear")]
        private IWebElement certiyear { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")]
        private IWebElement ceradd { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")]
        private IWebElement upcert { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        private IWebElement upacert { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")]
        private IWebElement decer { get; set; }



        internal void addcertificate()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "Certifications");
            Driver.TurnOnWait();
            certi.Click();
            addnew.Click();
            cername.SendKeys(ExcelLibHelper.ReadData(2, "Certificate"));
            certfrom.SendKeys(ExcelLibHelper.ReadData(2, "From"));
            var y1 = new SelectElement(certiyear);
            y1.SelectByValue(ExcelLibHelper.ReadData(2, "Year"));

            ceradd.Click();
        }

        internal void validateadd()
        {

            Thread.Sleep(1000);
            Driver.driver.Navigate().Refresh();
            Driver.TurnOnWait();
            certi.Click();
            Driver.TurnOnWait();
            IWebElement C = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            string A = "add certificate";
            String B = (ExcelLibHelper.ReadData(2, "Certificate"));

            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest(A);
                Driver.TurnOnWait();
                if (B == C.Text)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, A);
                    Assert.IsTrue(true);
                }
                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test fail");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test fail", e.Message);
            }

        }




        internal void editcertification()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "Certifications");
            Driver.TurnOnWait();
            certi.Click();
            upcert.Click();
            cername.Clear();
            cername.SendKeys(ExcelLibHelper.ReadData(5, "Certificate"));
            certfrom.Clear();
            certfrom.SendKeys(ExcelLibHelper.ReadData(5, "From"));
            var y1 = new SelectElement(certiyear);
            y1.SelectByValue(ExcelLibHelper.ReadData(5, "Year"));
            upacert.Click();
            Driver.driver.Navigate().Refresh();
            Driver.TurnOnWait();
            certi.Click();

        }
        internal void validateedit()
        {
            Driver.TurnOnWait();
            IWebElement C = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));

            string A = "edit certificate";
            String B = (ExcelLibHelper.ReadData(5, "Certificate"));

            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest(A);
                Driver.TurnOnWait();
                if (B == C.Text)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, A);
                }
                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test fail");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test fail", e.Message);
            }


        }
    
        internal void deletecertificaate()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "Certifications");
            Driver.TurnOnWait(); 
            certi.Click();
            decer.Click();
            CommonMethods.ExtentReports();
            CommonMethods.test = CommonMethods.Extent.StartTest("Delete Certifiction");
            CommonMethods.test.Log(LogStatus.Pass, "test pass");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "certificate delete");
        }
    }
}


  