using System;
using ClinicalTrials.Base;
using ClinicalTrials.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ClinicalTrials.Steps
{
    [Binding]
    public class SubmitAClinicalTrialForThePatientSteps : TestBase
    {

        private readonly LoginPage _loginPage = new LoginPage(Driver);
        private readonly HomePage _homePage = new HomePage(Driver);

        [Given(@"that I login to Clinical Trial Application with (.*) and (.*)")]
        public void GivenThatILoginToClinicalTrialApplication(string user, string pwd)
        {
            _loginPage.LaunchTheApplication();
            _loginPage.LoginToApplication(user, pwd);
        }

        [Given(@"selects (.*) in Dashboard")]
        public void GivenSelectsHospitalInDashboard(string hospital)
        {
            _homePage.SelectAHospital(hospital);
        }
        
        [Given(@"she fills up the Trial details")]
        public void GivenSheFillsUpTheTrialDetails()
        {
            
        }
        
        [Given(@"she fills up the BioMarker section")]
        public void GivenSheFillsUpTheBioMarkerSection()
        {
            
        }
        
        [Given(@"she fills up the Trial Type")]
        public void GivenSheFillsUpTheTrialType()
        {
            
        }
        
        [Given(@"she fills up the Portfolio Inclusion")]
        public void GivenSheFillsUpThePortfolioInclusion()
        {
            
        }
        
        [Given(@"she fills up the Reporting Group")]
        public void GivenSheFillsUpTheReportingGroup()
        {
            
        }
        
        [When(@"she submits the trial")]
        public void WhenSheSubmitsTheTrial()
        {
            
        }
        
        [Then(@"she should be shown with success message")]
        public void ThenSheShouldBeShownWithSuccessMessage()
        {
            
        }
    }
}
