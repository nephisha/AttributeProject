using System;
using ClinicalTrials.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ClinicalTrials.Steps
{
    [Binding]
    public class SubmitAClinicalTrialForThePatientSteps
    {
        private readonly LoginPage _loginPage;
        private readonly HomePage _homePage;

        public SubmitAClinicalTrialForThePatientSteps()
        {
            var driver = (IWebDriver)ScenarioContext.Current["driver"];
            _loginPage = new LoginPage(driver);
            _homePage = new HomePage(driver);
        }

        [Given(@"that I login to Clinical Trial Application with (.*) and (.*)")]
        public void GivenThatILoginToClinicalTrialApplication(string user, string pwd)
        {
            _loginPage.LoginToApplication(user, pwd);
        }

        [Given(@"she selects the (.*)")]
        public void GivenSheSelectsTheHospital(string hospital)
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
