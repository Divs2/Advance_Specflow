using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class NotificationSteps
    {
        [Given(@"Seller clicks on Notification")]
        public void GivenSellerClicksOnNotification()
        {
            Notification nn = new Notification();
            nn.notification();
        }
        
        [When(@"seller reeives a notifiction")]
        public void WhenSellerReeivesANotifiction()
        {
            
        }
        
        [Then(@"notification should be visible in notification tab")]
        public void ThenNotificationShouldBeVisibleInNotificationTab()
        {
            
        }
    }
}
