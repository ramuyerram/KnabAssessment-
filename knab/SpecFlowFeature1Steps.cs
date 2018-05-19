using System;
using TechTalk.SpecFlow;

namespace knab
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        Utilites Util = new Utilites();
        [Given(@"When user logs into web  (.*)")]
        public void GivenWhenUserLogsIntoWeb(string url)
        {
            Util.NavigateToUrl(url);
        }
        
        [Given(@"sets the value for License plate to (.*)")]
        public void GivenSetsTheValueForLicensePlateTo(string LicensePlateNo)
        {
            Util.SetValueById("licensePlate", LicensePlateNo);
        }
        
        [When(@"Press tab key (.*)")]
        public void WhenPressTabKey(string action)
        {
            Util.SendValues(action);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string expected)
        {
            Util.Validate(expected);
        }
    }
}
