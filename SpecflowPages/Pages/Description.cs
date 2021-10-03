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

namespace MarsQA_1.SpecflowPages.Pages
{
    class Description
    {
        public Description()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        private IWebElement des { get; set; }
        [FindsBy(How = How.Name, Using = "value")]
        private IWebElement text { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        private IWebElement sbtn { get; set; }

        internal void adddescription()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "Description");
            Driver.TurnOnWait();
            des.Click();
            Driver.TurnOnWait();
            text.SendKeys(Keys.Control + "a");
            text.SendKeys(Keys.Backspace);

            text.SendKeys(ExcelLibHelper.ReadData(2, "Description"));
            sbtn.Click();
            Driver.TurnOnWait();
            IWebElement ed = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            CommonMethods.ExtentReports();
            validation.validate("add description", (ExcelLibHelper.ReadData(2, "Description")), ed);

        }
    }
}
