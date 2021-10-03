using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.ConstantHelpers;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"Seller has clicked on  Skills tab")]
        public void GivenSellerHasClickedOnSkillsTab()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "Skills");
        }
        
        [Given(@"Seller has clicked on skill Add New")]
        public void GivenSellerHasClickedOnSkillAddNew()
        {
            Skills.AddSkills();
        }
        
        [Given(@"Seller has clicked on skill Edit")]
        public void GivenSellerHasClickedOnSkillEdit()
        {
            Skills.EditSkills();
        }
        
        [When(@"seller clicks on skill Add button")]
        public void WhenSellerClicksOnSkillAddButton()
        {
              
        }
        
        [When(@"seller clicks on skill Update button")]
        public void WhenSellerClicksOnSkillUpdateButton()
        {
              
        }
        
        [When(@"seller clicks on skill Delete button")]
        public void WhenSellerClicksOnSkillDeleteButton()
        {
            Skills.DeleteSkill();
        }
        
        [Then(@"Seller's Skills must be saved and visible")]
        public void ThenSellerSSkillsMustBeSavedAndVisible()
        {
            Skills.validateaddskill();
        }
        
        [Then(@"Seller's  updted Skill must be saved and visible")]
        public void ThenSellerSUpdtedSkillMustBeSavedAndVisible()
        {
            Skills.validateeditskill();
        }
        
        [Then(@"Seller's Skill must be Deleted")]
        public void ThenSellerSSkillMustBeDeleted()
        {
            Skills.validatedeleteskill();
        }
    }
}
