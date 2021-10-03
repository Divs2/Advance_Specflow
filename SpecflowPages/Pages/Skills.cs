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
    class Skills
    {
        public static void AddSkills()
        {
            IWebElement CreateSkills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            CreateSkills.Click();

            Driver.TurnOnWait();
            IWebElement Addskills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            Addskills.Click();

            Driver.TurnOnWait();
            IWebElement skillname = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillname.SendKeys(ExcelLibHelper.ReadData(2, "Skills")); 

            Driver.TurnOnWait();
            IWebElement skilllevel = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")); 
           
            var s1 = new SelectElement(skilllevel);
            s1.SelectByValue(ExcelLibHelper.ReadData(2, "Levels"));
            IWebElement saveskill = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            saveskill.Click();

        }
        //Validate Add Skils
        public static void validateaddskill()
        { 
            Driver.TurnOnWait();
            IWebElement actualskill = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            //ssert.That(actualskill.Text == "Drawing", "actual Skill and expected Skill did not match");
            CommonMethods.ExtentReports();
            validation.validate("add skill", (ExcelLibHelper.ReadData(2, "Skills")), actualskill);
        }

        public static void EditSkills()
        {
            IWebElement CreateSkills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            CreateSkills.Click();

            Driver.TurnOnWait();
            IWebElement editSbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editSbtn.Click();

            IWebElement eskill = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            eskill.Clear();
            eskill.SendKeys(ExcelLibHelper.ReadData(5, "Skills"));

            Driver.TurnOnWait();

            IWebElement updbtns = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updbtns.Click();

        }
        //Validate Edit Skills
        public static void validateeditskill()
        { 

            Driver.driver.Navigate().Refresh();
            IWebElement CreateSills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

           CreateSills.Click();
            
            Driver.TurnOnWait();
           IWebElement upskillnm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));

            //  Assert.That(upskillnm.Text == "Painting", "actual colledge and expected colledge did not match");
            CommonMethods.ExtentReports();
            validation.validate("edit skill", (ExcelLibHelper.ReadData(5, "Skills")), upskillnm);


        }

        public static void DeleteSkill()
        {

            IWebElement CreateSkills = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            CreateSkills.Click();
            IWebElement deleteskill = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteskill.Click();
        }
        //Validate Delete Skill
        public static void validatedeleteskill()
        { 
            Driver.TurnOnWait();
            //<IWebElement> elementList = new List<IWebElement>();
            //ementList.AddRange(Driver.driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")));
            //sert.That(elementList.Count > 0, "Test fail");
            CommonMethods.ExtentReports();
            CommonMethods.test = CommonMethods.Extent.StartTest("Delete Skill");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Skill delete");

        }

    }
}
