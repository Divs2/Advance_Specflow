using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Education
 
    {
        public static void AddEducation()
        {
            Driver.TurnOnWait();
            IWebElement edubtn = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edubtn.Click();
            Driver.TurnOnWait();
            IWebElement eduadd = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            eduadd.Click();
            Driver.TurnOnWait();
            IWebElement clgadd = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            clgadd.SendKeys(ExcelLibHelper.ReadData(2, "University"));
            Driver.TurnOnWait();
            IWebElement clgcountry = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            var e1 = new SelectElement(clgcountry);
            e1.SelectByValue(ExcelLibHelper.ReadData(2, "Country"));
            
            Driver.TurnOnWait();
            IWebElement degreetitle = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            var e2 = new SelectElement(degreetitle);
            e2.SelectByValue(ExcelLibHelper.ReadData(2, "Title"));
            Driver.TurnOnWait();
            IWebElement degreenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreenm.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));
            Driver.TurnOnWait();
            IWebElement yearofgradution = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            var e3 = new SelectElement(yearofgradution);
            e3.SelectByValue(ExcelLibHelper.ReadData(2, "Graduation Year"));
            Driver.TurnOnWait();
            IWebElement addedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addedu.Click();
        }
        //Validating Add languges
        public static void validateaddedu()
        {
            Driver.TurnOnWait();
            IWebElement actualedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            // Assert.That(actualedu.Text == "K.S", "actual colledge and expected colledge did not match");
            CommonMethods.ExtentReports();
            validation.validate("Add education", (ExcelLibHelper.ReadData(2, "University")), actualedu);
        }

        public static void EditEducation()
        {
            Driver.TurnOnWait();
            IWebElement edubtn = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edubtn.Click();
            IWebElement editedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            editedu.Click();
            IWebElement eclg = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            eclg.Clear();
            eclg.SendKeys(ExcelLibHelper.ReadData(4, "University"));
            IWebElement ecountry = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
            var e1 = new SelectElement(ecountry);
            e1.SelectByValue(ExcelLibHelper.ReadData(4, "Country"));
            Driver.TurnOnWait();
            IWebElement edegreetitle = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            var e2 = new SelectElement(edegreetitle);
            e2.SelectByValue(ExcelLibHelper.ReadData(4, "Title"));
            Driver.TurnOnWait();
            IWebElement edegreenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            edegreenm.Clear();
            edegreenm.SendKeys(ExcelLibHelper.ReadData(4, "Degree"));
            Driver.TurnOnWait();
            IWebElement eyearofgradution = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
            var e3 = new SelectElement(eyearofgradution);
            e3.SelectByValue(ExcelLibHelper.ReadData(4, "Graduation Year"));
            IWebElement updbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            updbtn.Click();
        }
        //Validate edit Languge
        public static void validateeditedu()
        {
            Driver.TurnOnWait();
            IWebElement updedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            //  Assert.That(updedu.Text == "B.K", "actual colledge and expected colledge did not match");
            CommonMethods.ExtentReports();
            validation.validate("edit education", (ExcelLibHelper.ReadData(4, "University")), updedu);
        }

        public static void DeleteEducation()
        {
            Driver.TurnOnWait();
            IWebElement edubtn = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edubtn.Click();
            IWebElement deletebtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            deletebtn.Click();

        }
        //Validate delete language
        public static void validatedeleteedu()
        {
            Driver.TurnOnWait();
            // List<IWebElement> elementList = new List<IWebElement>();
            // elementList.AddRange(Driver.driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]")));
            //Assert.That(elementList.Count > 0, "Test fail");
            CommonMethods.ExtentReports();
            CommonMethods.test = CommonMethods.Extent.StartTest("Delete Education");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Deleted");

        }


    }
}
