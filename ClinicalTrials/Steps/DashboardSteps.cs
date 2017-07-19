using System;
using ClinicalTrials.Base;
using ClinicalTrials.Pages;
using TechTalk.SpecFlow;

namespace ClinicalTrials.Steps
{
    [Binding]
    public class DashboardSteps : TestBase
    {
        private readonly HomePage _homePage = new HomePage(Driver);

        [Given(@"I select the (.*)")]
        public void GivenISelectTheHospital(string hospital)
        {
            _homePage.SelectAHospital(hospital);
        }
        
        [Then(@"I should see the dashboard of the selected hospital")]
        public void ThenIShouldSeeTheDashboardOfTheSelectedHospital()
        {
            
        }
    }
}
