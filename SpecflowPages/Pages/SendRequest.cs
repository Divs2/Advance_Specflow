using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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
    class SendRequest
    {
        public SendRequest()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/a[2]/button")]
        private IWebElement signoutbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section[1]/div/a[2]")]
        private IWebElement profileBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]")]
        private IWebElement managerebtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]/div/a[2]")]
        private IWebElement sentreqbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[3]/td[8]/button")]
        private IWebElement reviewbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div/div[3]/button")]
        private IWebElement closebtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[1]/input")]
        private IWebElement serchskillbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[1]/div[1]/div/a[9]")]
        private IWebElement funlifestylebtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[1]/div[5]/button[1]")]
        private IWebElement onlinebtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/div[1]/a[2]/p")]
        private IWebElement ddbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[3]")]
        private IWebElement reqbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[3]/button[1]")]
        private IWebElement ybtn { get; set; }

        internal void sentreq()
        {

            Driver.TurnOnWait();
            signoutbtn.Click();
            ExcelLibHelper.PopulateInCollection(ExcelPath, "SignIn");
            Driver.driver.Navigate().GoToUrl(ExcelLibHelper.ReadData(5, "Url"));

            SignIntab.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(5, "UserName"));
            Password.SendKeys(ExcelLibHelper.ReadData(5, "Password"));
            LoginBtn.Click();
            Driver.TurnOnWait();

            ExcelLibHelper.PopulateInCollection(ExcelPath, "SentRequest");
            Driver.TurnOnWait();

            //reviewbtn.Click();
            //wait(5);
            //closebtn.Click();
            //wait(10);

            //wait(5);
            serchskillbtn.SendKeys(ExcelLibHelper.ReadData(2, "SentRequest"));
            serchskillbtn.SendKeys(Keys.Enter);
            Driver.TurnOnWait();
            funlifestylebtn.Click();
            Driver.TurnOnWait();
            onlinebtn.Click();
            Driver.TurnOnWait();
            ddbtn.Click();
            Driver.TurnOnWait();
            reqbtn.Click();
            Driver.TurnOnWait();
            ybtn.Click();
            Driver.TurnOnWait();
            Driver.driver.Navigate().Refresh();
            Thread.Sleep(1000);
            profileBtn.Click();
            Driver.TurnOnWait();
            managerebtn.Click();
            Thread.Sleep(1000);
            sentreqbtn.Click();

            Driver.TurnOnWait();

            IWebElement sr = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[1]/td[2]/a"));
            CommonMethods.ExtentReports();
            validation.validate("Sent Request", (ExcelLibHelper.ReadData(2, "SentRequest")), sr);





        }

    }
}
