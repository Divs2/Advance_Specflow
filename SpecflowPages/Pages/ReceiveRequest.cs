using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ReceiveRequest
    {
        public  ReceiveRequest()
            {
            PageFactory.InitElements(Driver.driver, this);


        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]")]
        private IWebElement manageretn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]/div/a[1]")]
        private IWebElement recereqbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]")]
        private IWebElement accbtn { get; set; }

        internal void receivereque()
        {
            Driver.TurnOnWait();
            manageretn.Click();
            Thread.Sleep(1000);
            recereqbtn.Click();
            Driver.TurnOnWait();
            accbtn.Click();
            Thread.Sleep(5000);
            IWebElement rr = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
            Driver.TurnOnWait();
            CommonMethods.ExtentReports();
            validation.validate("Receive Request", "Accepted", rr);
        }

    }
}
