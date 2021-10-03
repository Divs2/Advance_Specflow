using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AvailabiltySteps
    {
        [Given(@"Seller clicked on edit button of Availabilty")]
        public void GivenSellerClickedOnEditButtonOfAvailabilty()
        {
            Availabilty aa = new Availabilty();
            aa.selectavailabilty();
        }
        
        [When(@"Seller clicks on his choice of Availabilty")]
        public void WhenSellerClicksOnHisChoiceOfAvailabilty()
        {
           
        }
        
        [Then(@"Seller's Availability must be visible")]
        public void ThenSellerSAvailabilityMustBeVisible()
        {
           
        }
    }
}
