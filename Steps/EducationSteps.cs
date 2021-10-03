using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.ConstantHelpers;
namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        [Given(@"Seller has clicked on  Education tab")]
        public void GivenSellerHasClickedOnEducationTab()
        {
            ExcelLibHelper.PopulateInCollection(ExcelPath, "Education");
        }
        
        [Given(@"Seller has clicked on Add New on Education")]
        public void GivenSellerHasClickedOnAddNewOnEducation()
        {
            Education.AddEducation();
           
        }
        
        [Given(@"Seller has clicked on Edit on Education")]
        public void GivenSellerHasClickedOnEditOnEducation()
        {
            Education.EditEducation();
        }
        
        [When(@"seller clicks on Add button on Education")]
        public void WhenSellerClicksOnAddButtonOnEducation()
        {
             
        }
        
        [When(@"seller clicks on update button on Education")]
        public void WhenSellerClicksOnUpdateButtonOnEducation()
        {
             
        }
        
        [When(@"seller clicks on delete button on Education")]
        public void WhenSellerClicksOnDeleteButtonOnEducation()
        {
            Education.DeleteEducation();
        }
        
        [Then(@"Seller's  education must be saved and visible")]
        public void ThenSellerSEducationMustBeSavedAndVisible()
        {
            Education.validateaddedu();
        }
        
        [Then(@"Seller's  Updated education must be saved and visible")]
        public void ThenSellerSUpdatedEducationMustBeSavedAndVisible()
        {
            Education.validateeditedu();
        }
      
        [Then(@"Seller's  education must be deleted")]
        public void ThenSellerSEducationMustBeDeleted()
        {
            Education.validatedeleteedu();
        }
    }
}
