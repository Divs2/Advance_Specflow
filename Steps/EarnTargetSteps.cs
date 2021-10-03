using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EarnTargetSteps
    {
        [Given(@"Seller clicked on edit button of Earn Target")]
        public void GivenSellerClickedOnEditButtonOfEarnTarget()
        {
            EarnTarget ee = new EarnTarget();
            ee.Selectearntarget();
        }
        
        [When(@"Seller clicks on his choice of Earn Target")]
        public void WhenSellerClicksOnHisChoiceOfEarnTarget()
        {
            
        }
        
        [Then(@"Seller's Earn Target must be visible")]
        public void ThenSellerSEarnTargetMustBeVisible()
        {
           
        }
    }
}
