using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ManageRequestSteps
    {
        [Given(@"Seller has searched skill")]
        public void GivenSellerHasSearchedSkill()
        {
            SendRequest SR = new SendRequest();
            SR.sentreq();
        }
        
        [Given(@"Seller has clicked on Receive request on Managerequest")]
        public void GivenSellerHasClickedOnReceiveRequestOnManagerequest()
        {
            ReceiveRequest rr = new ReceiveRequest();
            rr.receivereque();

        }
        
        [When(@"Seller has sent the request")]
        public void WhenSellerHasSentTheRequest()
        {
            
        }
        
        [When(@"Seller has received request")]
        public void WhenSellerHasReceivedRequest()
        {
            
        }
        
        [Then(@"the request should be visible in sent request")]
        public void ThenTheRequestShouldBeVisibleInSentRequest()
        {
           
        }
        
        [Then(@"the request should be visible in received request")]
        public void ThenTheRequestShouldBeVisibleInReceivedRequest()
        {
            
        }
    }
}
