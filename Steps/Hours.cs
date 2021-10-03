using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AvailableHoursSteps
    {
        [Given(@"Seller clicked on edit button of Hours")]
        public void GivenSellerClickedOnEditButtonOfHours()
        {
            Hours h = new Hours();
            h.Selecthours();
            
        }
        
        [When(@"Seller clicks on his choice of Hours")]
        public void WhenSellerClicksOnHisChoiceOfHours()
        {
            
        }
        
        [Then(@"Seller's Hours must be visible")]
        public void ThenSellerSHoursMustBeVisible()
        {
            
        }
    }
}
