using System;
using ClinicalTrials.Base;
using ClinicalTrials.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ClinicalTrials.Steps
{
    [Binding]
    public class DashboardSteps
    {
        private readonly HomePage _homePage = new HomePage();

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
