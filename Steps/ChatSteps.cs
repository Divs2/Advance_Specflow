using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class ChatSteps
    {
        [Given(@"seller has click on chat")]
        public void GivenSellerHasClickOnChat()
        {
            Chat c = new Chat();
            c.chat();
        }
        
        [When(@"seller send or reeive messge to someone")]
        public void WhenSellerSendOrReeiveMessgeToSomeone()
        {
            
        }
        
        [Then(@"seller should able to see cht history")]
        public void ThenSellerShouldAbleToSeeChtHistory()
        {
           
        }
    }
}
