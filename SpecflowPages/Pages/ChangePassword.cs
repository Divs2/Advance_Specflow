using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.CommonMethods;
using static MarsQA_1.Helpers.ConstantHelpers;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ChangePassword
    {
       
            public ChangePassword()
            {
                PageFactory.InitElements(Driver.driver, this);

            }
            [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/span")]
            private IWebElement prbtn { get; set; }
            [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/span/div/a[2]")]
            private IWebElement cpwd { get; set; }
            [FindsBy(How = How.Name, Using = "oldPassword")]
            private IWebElement OP { get; set; }
            [FindsBy(How = How.Name, Using = "newPassword")]
            private IWebElement NP { get; set; }
            [FindsBy(How = How.Name, Using = "confirmPassword")]
            private IWebElement CP { get; set; }
            [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[4]/button")]
            private IWebElement savebtn { get; set; }

            internal void changepwd()
            {
                ExcelLibHelper.PopulateInCollection(ExcelPath, "ChangePassword");
            Driver.TurnOnWait();
                prbtn.Click();
                Thread.Sleep(5000);
                cpwd.Click();
            Driver.TurnOnWait();
                OP.SendKeys(ExcelLibHelper.ReadData(2, "Current Password"));
            Driver.TurnOnWait();
                NP.SendKeys(ExcelLibHelper.ReadData(2, "Password"));
            Driver.TurnOnWait();
                CP.SendKeys(ExcelLibHelper.ReadData(2, "Password"));
            Driver.TurnOnWait();
                savebtn.Click();
                Driver.driver.Navigate().Refresh();
                Thread.Sleep(5000);

                prbtn.Click();
                Thread.Sleep(5000);
                cpwd.Click();
            Driver.TurnOnWait();
                OP.SendKeys(ExcelLibHelper.ReadData(2, "Password"));
            Driver.TurnOnWait();
            NP.SendKeys(ExcelLibHelper.ReadData(2, "Current Password"));
            Driver.TurnOnWait();
                CP.SendKeys(ExcelLibHelper.ReadData(2, "Current Password"));
            Driver.TurnOnWait();
            savebtn.Click();

            CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Change Password");
                CommonMethods.test.Log(LogStatus.Pass, "test pass");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Change Password");

            }

        }
    }
