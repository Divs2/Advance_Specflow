using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class CertificationSteps
    {
        [Given(@"Seller has clicked on  Certification tab")]
        public void GivenSellerHasClickedOnCertificationTab()
        {
       
        }
        
        [When(@"seller clicks on  certificate Add button")]
        public void WhenSellerClicksOnCertificateAddButton()
        {
            Certification cer = new Certification();
            cer.addcertificate();
        }
        
        [When(@"seller clicks on  certificate update button")]
        public void WhenSellerClicksOnCertificateUpdateButton()
        {
            Certification cer = new Certification();
            cer.editcertification();
        }
        
        [When(@"seller clicks on certificate delete button")]
        public void WhenSellerClicksOnCertificateDeleteButton()
        {
            
        }
        
        [Then(@"Seller's Cetification must be saved and visible")]
        public void ThenSellerSCetificationMustBeSavedAndVisible()
        {
           
                Certification cer = new Certification();
                cer.validateadd();
            
        }
        
        [Then(@"Seller's Cerification must be updated and visible")]
        public void ThenSellerSCerificationMustBeUpdatedAndVisible()
        {


            Certification cer = new Certification();
            cer.validateedit();

        }

        [Then(@"Seller's  certification must be deleted")]
        public void ThenSellerSCertificationMustBeDeleted()
        {
            Certification cer = new Certification();
            cer.deletecertificaate();
        }
    }
}
