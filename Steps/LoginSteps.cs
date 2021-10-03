using MarsQA_1.Helpers;
using System;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            CommonMethods.ExtentReports();
            CommonMethods.test = CommonMethods.Extent.StartTest("login successfully");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "sign in");

        }
    }
}
