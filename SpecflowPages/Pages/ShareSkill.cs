using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
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
    class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement radio1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement radio2 { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement LocationType1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement LocationType2 { get; set; }




        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement SkillTradeOption1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement SkillTradeOption2 { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement ActiveOption1 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement ActiveOption2 { get; set; }
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }
        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }





        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }


        internal void EnterShareSkill()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "ShareSkill");
            Driver.TurnOnWait();
            //Click ShareSkill Button
            ShareSkillButton.Click();
            //title
            Driver.TurnOnWait();
            Title.SendKeys(ExcelLibHelper.ReadData(2, "Title"));
            //enter description
            Description.SendKeys(ExcelLibHelper.ReadData(2, "Description"));
            //select Cateory
            var cat1 = new SelectElement(CategoryDropDown);
            cat1.SelectByValue(ExcelLibHelper.ReadData(2, "Category"));
            //Select SubCategory
            var scate = new SelectElement(SubCategoryDropDown);
            scate.SelectByValue(ExcelLibHelper.ReadData(2, "SubCategory"));
            //enter tags
            Tags.SendKeys(ExcelLibHelper.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);
            //choose service type

            radiobutton.Radiobutton(ExcelLibHelper.ReadData(2, "ServiceType"), "One-off service", "Hourly basis service", radio2, radio1);

            //choose Location type
            radiobutton.Radiobutton(ExcelLibHelper.ReadData(2, "LocationType"), "On-site", "Online", LocationType1, LocationType2);

            //select available dates
            StartDateDropDown.SendKeys(ExcelLibHelper.ReadData(2, "Startdate"));
            EndDateDropDown.SendKeys(ExcelLibHelper.ReadData(2, "Enddate"));

            //select availiable days
            Checkbox.checkbox(ExcelLibHelper.ReadData(2, "Selectday"), ExcelLibHelper.ReadData(2, "Starttime"), ExcelLibHelper.ReadData(2, "Endtime"));
            // Choose skill trade
            radiobutton.Radiobutton(ExcelLibHelper.ReadData(2, "SkillTrade"), "Skill-exchange", "Credit", SkillTradeOption1, SkillTradeOption2);

            if (ExcelLibHelper.ReadData(2, "SkillTrade") == "Skill-exchange")
            {


                //Enter skill exchange
                SkillExchange.SendKeys(ExcelLibHelper.ReadData(2, "Skill-Exchange"));
                SkillExchange.SendKeys(Keys.Enter);
            }
            else
            {
                CreditAmount.SendKeys(ExcelLibHelper.ReadData(2, "Credit"));

            }

            // work sample upload
            IWebElement worksample = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
            worksample.Click();

            Thread.Sleep(1000);
            AutoIt.AutoItX.WinActivate("Open");

            AutoIt.AutoItX.Send(@"E:\MVP\Mars__Specflow\SkillUpload.txt");
            AutoIt.AutoItX.Send("{Enter}");

            //Select enable or disable your services
            radiobutton.Radiobutton(ExcelLibHelper.ReadData(2, "Active"), "Active", "Hidden", ActiveOption1, ActiveOption2);



            //Click save button
            Save.Click();
        }

        //validate skill is added successfully
        internal void validateskill()
        {

            try
            {
                //Start report
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Share Skill");
                string ExpectedValue = ExcelLibHelper.ReadData(2, "Title");
                string ActualValue = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")).Text;
                //check expected and actual value are same
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "ShareSkil Added");



                }
                else

                    CommonMethods.test.Log(LogStatus.Fail, "Test fail");

            }


            catch (Exception e)

            {
                CommonMethods.test.Log(LogStatus.Fail, "Test fail", e.Message);

            }
        }




        internal void EditShareSkill()
        {

            ExcelLibHelper.PopulateInCollection(ExcelPath, "ShareSkill");
            // Click on ManageListing
            Driver.TurnOnWait();
            manageListingsLink.Click();

            //Click on Edit Button
            Driver.TurnOnWait();
            IWebElement edit = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i"));
            edit.Click();
            Driver.TurnOnWait();
            //edit title
            Title.Clear();
            Title.SendKeys(ExcelLibHelper.ReadData(5, "Title"));
            //edit description
            Description.Clear();
            Description.SendKeys(ExcelLibHelper.ReadData(5, "Description"));
            //edit category
            var cat1 = new SelectElement(CategoryDropDown);
            cat1.SelectByValue(ExcelLibHelper.ReadData(5, "Category"));
            //edit Subcategory
            var scate = new SelectElement(SubCategoryDropDown);
            scate.SelectByValue(ExcelLibHelper.ReadData(5, "SubCategory"));
            //enter tags

            Tags.SendKeys(ExcelLibHelper.ReadData(5, "Tags"));
            Tags.SendKeys(Keys.Enter);
            //choose service type

            radiobutton.Radiobutton(ExcelLibHelper.ReadData(5, "ServiceType"), "One-off service", "Hourly basis service", radio2, radio1);

            //choose Location type
            radiobutton.Radiobutton(ExcelLibHelper.ReadData(5, "LocationType"), "On-site", "Online", LocationType1, LocationType2);

            //select available dates

            StartDateDropDown.SendKeys(ExcelLibHelper.ReadData(5, "Startdate"));

            EndDateDropDown.SendKeys(ExcelLibHelper.ReadData(5, "Enddate"));

            //select availiable days
            ClearCheck.clearcheckbox(ExcelLibHelper.ReadData(2, "Selectday"));
            Checkbox.checkbox(ExcelLibHelper.ReadData(5, "Selectday"), ExcelLibHelper.ReadData(5, "Starttime"), ExcelLibHelper.ReadData(5, "Endtime"));
            // Choose skill trade
            radiobutton.Radiobutton(ExcelLibHelper.ReadData(5, "SkillTrade"), "Skill-exchange", "Credit", SkillTradeOption1, SkillTradeOption2);

            if (ExcelLibHelper.ReadData(5, "SkillTrade") == "Skill-exchange")
            {


                //Enter skill exchange
                SkillExchange.SendKeys(ExcelLibHelper.ReadData(5, "Skill-Exchange"));
                SkillExchange.SendKeys(Keys.Enter);
            }
            else
            {


                CreditAmount.SendKeys(ExcelLibHelper.ReadData(5, "Credit"));
            }



            //edit enable or disable service

            radiobutton.Radiobutton(ExcelLibHelper.ReadData(5, "Active"), "Active", "Hidden", ActiveOption1, ActiveOption2);
            //Click save button
            Save.Click();



        }


        internal void validateeditskill()
        {

            try
            {
                //Start report
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("edit Share Skill");
                string ExpectedValue = ExcelLibHelper.ReadData(5, "Title");
                string ActualValue = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")).Text;
                //check expected and actual value are same
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "ShareSkil edited");



                }
                else

                    CommonMethods.test.Log(LogStatus.Fail, "Test fail");

            }


            catch (Exception e)

            {
                CommonMethods.test.Log(LogStatus.Fail, "Test fail", e.Message);

            }
        }

        internal void Listings()
        {
            //Populate the Excel Sheet
            ExcelLibHelper.PopulateInCollection(ExcelPath, "ManageListings");
            // ExcelLibHelper.PopulateInCollection(CommonMethods.ExcelPath, "ManageListings");
            Driver.TurnOnWait();
            manageListingsLink.Click();
            string ExpectedValue = ExcelLibHelper.ReadData(2, "Title");
            Driver.TurnOnWait();
            string ActualValue = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")).Text;
            if (ExpectedValue == ActualValue)
            {
                Driver.TurnOnWait();
                Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i")).Click();
                if (ExcelLibHelper.ReadData(2, "DeleteAction") == "Yes")
                {
                    Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]")).Click();
                }
                else
                {
                    Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]")).Click();
                }
            }
        }
        internal void validatedelete()
        {

            //Start report
            CommonMethods.ExtentReports();
            CommonMethods.test = CommonMethods.Extent.StartTest("Delete Share Skill");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "ShareSkil deleted");

        }
    }
}





