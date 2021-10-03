using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.Support.UI;

using static MarsQA_1.Helpers.ConstantHelpers;
using static MarsQA_1.Helpers.CommonMethods;
using MarsQA_1.Utils;
using System.Data;


namespace MarsQA_1.Helpers
{
    public class CommonMethods
    {
        //Screenshots
        //Screenshot

        public class SaveScreenShotClass
        {

            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(ScreenshotPath))
                {
                    System.IO.Directory.CreateDirectory(ScreenshotPath);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(ScreenshotPath);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }

        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports Extent;



        public static void ExtentReports()
        {
            Extent = new ExtentReports(ConstantHelpers.ReportsPath, false, DisplayOrder.NewestFirst);
            Extent.LoadConfig(ConstantHelpers.ReportXMLPath);
        }
    }
    #region Checkbox
    public class Checkbox
    {
        public static void checkbox(String A, string B, string C)
        {
            if (A == "Sun")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")).Click();
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")).SendKeys(B);
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")).SendKeys(C);


            }

            else if (A == "Mon")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")).Click();
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")).SendKeys(B);
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")).SendKeys(C);

            }
            else if (A == "Tue")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")).Click();
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")).SendKeys(B);
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")).SendKeys(C);


            }
            else if (A == "Wed")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")).Click();
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")).SendKeys(B);
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")).SendKeys(C);
            }
            else if (A == "Thu")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input")).Click();
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")).SendKeys(B);
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")).SendKeys(C);
            }

            else if (A == "Fri")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input")).Click();
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[2]/input")).SendKeys(B);
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[3]/input")).SendKeys(C);
            }
            else if (A == "Sat")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")).Click();
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")).SendKeys(B);
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[3]/input")).SendKeys(C);
            }
            else
            {
                throw new ElementNotVisibleException("select correct day");
            }
        }
    }


    #endregion

    #region clear checklist
    public class ClearCheck
    {
        public static void clearcheckbox(String A)
        {
            if (A == "Sun")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")).Click();



            }

            else if (A == "Mon")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")).Click();


            }
            else if (A == "Tue")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")).Click();


            }
            else if (A == "Wed")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")).Click();
            }
            else if (A == "Thu")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input")).Click();
            }

            else if (A == "Fri")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input")).Click();
            }
            else if (A == "Sat")
            {
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")).Click();
            }
            else
            {
                throw new ElementNotVisibleException("select correct day");
            }
        }
    }
    #endregion


    #region RadioButton
    public class radiobutton
    {
        public static void Radiobutton(string A, String B, String C, IWebElement D, IWebElement E)
        {
            if (A == B)
            {
                D.Click();

            }
            else if (A == C)
            {
                E.Click();
            }
            else
            {
                throw new ElementNotVisibleException("Element not found");
            }
        }
    }

    #endregion


    #region validation
    public class validation
    {
        public static void validate(String A, String B, IWebElement C)
        {
            try
            {
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
    }


    #endregion
    #endregion
}






