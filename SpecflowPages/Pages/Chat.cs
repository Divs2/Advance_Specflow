using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.CommonMethods;
using static MarsQA_1.Helpers.ConstantHelpers;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Chat
    {
        public Chat()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/a[1]")]
        private IWebElement chatbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[2]/div/div/div/div/input")]
        private IWebElement chatmsg { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/div[2]/div/div/div/div/button[1]")]
        private IWebElement sebtn { get; set; }

        internal void chat()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "Chat");
            Driver.TurnOnWait();
            chatbtn.Click();
            Driver.TurnOnWait();
            chatmsg.SendKeys(ExcelLibHelper.ReadData(2, "Chat"));
            Driver.TurnOnWait();
            sebtn.Click();
            Driver.TurnOnWait();
            IWebElement cc = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div/div/span/div[4]/div/div/span"));
            CommonMethods.ExtentReports();
            validation.validate("chat", (ExcelLibHelper.ReadData(2, "Chat")), cc);
        }
    }
}
