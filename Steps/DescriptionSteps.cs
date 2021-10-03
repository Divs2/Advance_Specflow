using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class DescriptionSteps
    {
        [Given(@"Seller has clicked on Edit Description")]
        public void GivenSellerHasClickedOnEditDescription()
        {
            Description dd = new Description();
            dd.adddescription();

           
        }
        
        [When(@"seller click on save button")]
        public void WhenSellerClickOnSaveButton()
        {
            
        }
        
        [Then(@"Seller's description must be saved and visible")]
        public void ThenSellerSDescriptionMustBeSavedAndVisible()
        {
            
        }
    }
}
