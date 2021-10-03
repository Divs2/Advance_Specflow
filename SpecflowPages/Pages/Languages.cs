using NUnit.Framework;
using OpenQA.Selenium;
using MarsQA_1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Pages

{
    public class Languages
    {

       

        public static void AddLanguges()
        {
                        //Add Languge
            //Click languges

            IWebElement createlanguges = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            createlanguges.Click();


            //Click AddNew Button
            IWebElement addnewbutton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton.Click();

            //Add languges
            IWebElement addlanguge = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlanguge.SendKeys(ExcelLibHelper.ReadData(2, "Language"));


            //Add languge level
            var langugelevel = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            
         
            var Ll = new SelectElement(langugelevel);
            Ll.SelectByValue(ExcelLibHelper.ReadData(2, "Level"));
           
            

            //add and save languges
            IWebElement savelang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelang.Click();
            

            // Check if record is present
            IWebElement actuallang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            CommonMethods.ExtentReports();
            //sert.That(actuallang.Text == "English", "actual languge and expected languge did not match");
            validation.validate("add language", (ExcelLibHelper.ReadData(2, "Language")), actuallang);

            IWebElement addnewbutton1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton1.Click();


            IWebElement addlanguge1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlanguge1.SendKeys(ExcelLibHelper.ReadData(3, "Language")); 


            IWebElement langugelevel1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            var L2 = new SelectElement(langugelevel1);
            L2.SelectByValue(ExcelLibHelper.ReadData(3, "Level"));




            IWebElement savelang1 = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelang1.Click();
            Driver.driver.Navigate().Refresh();

            IWebElement addnewbuton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbuton.Click();


            IWebElement addlangug = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlangug.SendKeys(ExcelLibHelper.ReadData(4, "Language"));
           




            IWebElement langugeleve = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            

            var L3 = new SelectElement(langugeleve);
            L3.SelectByValue(ExcelLibHelper.ReadData(4, "Level"));

            IWebElement savelan = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelan.Click();
            Driver.driver.Navigate().Refresh();

            IWebElement addnewbutto = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutto.Click();


            IWebElement addlangu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlangu.SendKeys(ExcelLibHelper.ReadData(5, "Language"));


            IWebElement langugele = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            var L4 = new SelectElement(langugele);
            L4.SelectByValue(ExcelLibHelper.ReadData(5, "Level"));



            IWebElement savela = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savela.Click();
            Driver.driver.Navigate().Refresh();
        }


        // Edit Languges
        public static void EditLanguges()

        {
            IWebElement createlanguges = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            createlanguges.Click();

            IWebElement editbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            editbtn.Click();

            IWebElement elanguage = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            elanguage.Clear();
            elanguage.SendKeys(ExcelLibHelper.ReadData(8, "Language"));

            IWebElement updbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updbtn.Click();
        }
            public static void Validateeditlanguage() {
                //Validating Edit Language

                Driver.driver.Navigate().Refresh();
                Driver.TurnOnWait();
            
                IWebElement uptlang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            CommonMethods.ExtentReports();
            validation.validate("edit language", (ExcelLibHelper.ReadData(8, "Language")), uptlang);

            
        }

        public static void Deletelanguges()
        {
            IWebElement createlanguges = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            createlanguges.Click();
            IWebElement deletebtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]"));
            deletebtn.Click();
        }
        public static void ValidateDelete()
        { 

            //Validating Delete language

           IWebElement lang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            CommonMethods.ExtentReports();
            CommonMethods.test = CommonMethods.Extent.StartTest("Delete Language");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "languge deleted");

        }


    }

}
