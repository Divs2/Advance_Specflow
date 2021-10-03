using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ChangePasswordSteps
    {
        [Given(@"seller has click on changepassword on profile")]
        public void GivenSellerHasClickOnChangepasswordOnProfile()
        {
            ChangePassword cc = new ChangePassword();
            cc.changepwd();
        }
        
        [When(@"seller change password")]
        public void WhenSellerChangePassword()
        {
            
        }
        
        [Then(@"new password should be updated")]
        public void ThenNewPasswordShouldBeUpdated()
        {
            
        }
    }
}
