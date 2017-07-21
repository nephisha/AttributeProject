using System;
using ClinicalTrials.Base;
using ClinicalTrials.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ClinicalTrials.Steps
{
    [Binding]
    public class SubmitAClinicalTrialForThePatientSteps
    {
        private readonly LoginPage _loginPage = new LoginPage();
        private readonly MenuPage _menuPage = new MenuPage();
        private readonly TrialDetailsPage _trialDetailsPage = new TrialDetailsPage();

        [Given(@"that I login to Clinical Trial Application with (.*) and (.*)")]
        public void GivenThatILoginToClinicalTrialApplication(string user, string pwd)
        {
            _loginPage.LaunchTheApplication();
            _loginPage.LoginToApplication(user, pwd);
        }

        [Given(@"she fills up the Trial details with (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*) and (.*)")]
        public void GivenSheFillsUpTheTrialDetails(string sponsor, string coopGroup, string regoNumber, string phase,
            string group, string tumourCategory, string tumourGroup, string stage, string population, string multiCentre,
            string site, string bioMarkerStudy, string molTarget)
        {
            _menuPage.ClickOnToggleMenu();
            _menuPage.SelectSubmitATrialFromToggleMenu();
            _trialDetailsPage.FillUpTrialDetails(sponsor, coopGroup, regoNumber, phase, group, tumourCategory,
                tumourGroup, stage, population, multiCentre, site, bioMarkerStudy, molTarget);
        }
        
        [Given(@"she fills up the BioMarker section (.*) and (.*) and (.*)")]
        public void GivenSheFillsUpTheBioMarkerSection(string eligiblity, string molTarget, string availablity)
        {
            _trialDetailsPage.FillUpBioMarkerDetails(eligiblity, molTarget, availablity);
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
