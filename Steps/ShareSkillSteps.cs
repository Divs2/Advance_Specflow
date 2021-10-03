using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ShareSkillSteps
    {
        [Given(@"Seller has clicked on  ShareSkill tab")]
        public void GivenSellerHasClickedOnShareSkillTab()
        {
            
        }
        
        [Given(@"Seller has clicked on  ManageListing tab")]
        public void GivenSellerHasClickedOnManageListingTab()
        {
            
        }
        
        [When(@"Seller click on add button")]
        public void WhenSellerClickOnAddButton()
        {
            ShareSkill s = new ShareSkill();
            s.EnterShareSkill();

        }
        
        [When(@"Seller has edited Shareskill")]
        public void WhenSellerHasEditedShareskill()
        {
            ShareSkill s = new ShareSkill();
            s.EditShareSkill();
        }
        
        [When(@"Seller has Deleted Shareskill")]
        public void WhenSellerHasDeletedShareskill()
        {
            ShareSkill s = new ShareSkill();
            s.Listings();

        }
        
        [Then(@"seller's skill must be saved and visible")]
        public void ThenSellerSSkillMustBeSavedAndVisible()
        {
            ShareSkill s = new ShareSkill();
            s.validateskill();
        }
        
        [Then(@"seller's edited skill must be updated and visible")]
        public void ThenSellerSEditedSkillMustBeUpdatedAndVisible()
        {
            ShareSkill s = new ShareSkill();
            s.validateeditskill();
        }
        
        [Then(@"seller's  skill must be deleted")]
        public void ThenSellerSSkillMustBeDeleted()
        {
            ShareSkill s = new ShareSkill();
            s.validatedelete();
        }
    }
}
