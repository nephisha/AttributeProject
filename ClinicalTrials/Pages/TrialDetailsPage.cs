using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ClinicalTrials.Base;
using ClinicalTrials.CommonMethods;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ClinicalTrials.Pages
{
    public class TrialDetailsPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "Details_StudyName")]
        private IWebElement ScientificTitle { get; set; }

        [FindsBy(How = How.Id, Using = "Details_SponsorId")]
        private IWebElement Sponsor { get; set; }

        [FindsBy(How = How.Id, Using = "Details_CooperativeGroups_chosen")]
        private IWebElement CooperativeGroups { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='Details_CooperativeGroups_chosen']/div/ul/li")]
        private IList<IWebElement> CoopGroupResult { get; set; }

        [FindsBy(How = How.Id, Using = "Details_Acronym")]
        private IWebElement Nickname { get; set; }

        [FindsBy(How = How.Id, Using = "Details_RegistrationNumber")]
        private IWebElement RegistrationNumber { get; set; }

        [FindsBy(How = How.Id, Using = "Details_Phase")]
        private IWebElement Phase { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='controls check-box-list']/label")]
        private IList<IWebElement> Group { get; set; }

        [FindsBy(How = How.Id, Using = "Details_TumourCategory")]
        private IWebElement TumourCategory { get; set; }

        [FindsBy(How = How.Id, Using = "Details_TumourGroups_chosen")]
        private IWebElement TumourGroup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Details_TumourGroups_chosen']/div//li")]
        private IList<IWebElement> TumourGroupResult { get; set; }

        [FindsBy(How = How.Id, Using = "Details_StageOfDisease_chosen")]
        private IWebElement StagesOfDisease { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Details_StageOfDisease_chosen']/div/ul/li")]
        private IList<IWebElement> DiseaseStageResult { get; set; }

        [FindsBy(How = How.Id, Using = "Details_Population")]
        private IWebElement Population { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Details_MultiCentre']/following-sibling::div/label")]
        private IList<IWebElement> MultiTrial { get; set; }

        [FindsBy(How = How.Id, Using = "Details_LeadSite")]
        private IWebElement LeadSite { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Details_BiomarkerSubstudy']/following-sibling::div/label")]
        private IList<IWebElement> BiomarkerSubstudy { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@for='Details_SubStudyMolecularTargets']/following-sibling::div[1]/div")]
        private IWebElement MoleculeTargetBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='Details.SubStudyMolecularTargets']/following-sibling::div/div/ul/li")]
        private IList<IWebElement> MolecularTarget { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='BioMarkerSection_BiomarkerRequired']/parent::label")]
        private IList<IWebElement> BioMarkerTrialEligiblity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='BioMarkerSection_BiomarkerTissueAvailability']/parent::label")]
        private IList<IWebElement> TissueAvailability { get; set; }

        public void EnterScientificTitle(string randomString)
        {
            ScientificTitle.Click();
            ScientificTitle.SendKeys("Test"+randomString);
        }
        
        public void SelectASponsor(string sponsorType)
        {
            PageHelper.SelectValueFromDropdown(Sponsor, sponsorType);
        }

        public void SelectACooperativeGroup(string cGroup)
        {
            CooperativeGroups.Click();
            PageHelper.SelectValueFromDropList(CoopGroupResult, cGroup);
        }

        private void EnterNickName(string randomString)
        {
            Nickname.SendKeys("Clinical" + randomString);
        }

        public void SelectAPhase(string phaseValue)
        {
            PageHelper.SelectValueFromDropdown(Phase, phaseValue);
        }

        public void SelectAGroup(string category)
        {
            PageHelper.SelectValueFromDropList(Group, category);
        }

        public void SelectATumourCategory(string tumourType)
        {
            PageHelper.SelectValueFromDropdown(TumourCategory, tumourType);
        }

        public void SelectATumourGroup(string tumourGroup)
        {
            TumourGroup.Click();
            PageHelper.SelectValueFromDropList(TumourGroupResult, tumourGroup);
        }

        public void SelectStagesOfDisease(string stage)
        {
            StagesOfDisease.Click();
            PageHelper.SelectValueFromDropList(DiseaseStageResult, stage);
        }

        private void SelectAPopulation(string populationType)
        {
            PageHelper.SelectValueFromDropdown(Population, populationType);
        }

        private void SelectMultiCentreTrial(string option)
        {
            PageHelper.SelectValueFromDropList(MultiTrial, option);
        }

        private void SelectLeadSite(string site)
        {
            PageHelper.SelectValueFromDropdown(LeadSite, site);
        }

        private void SelectBioMarkerSubstudy(string subStudyValue)
        {
            PageHelper.SelectValueFromDropList(BiomarkerSubstudy, subStudyValue);
        }

        private void SelectAMolecularTarget(string target)
        {
            MoleculeTargetBox.Click();
            PageHelper.SelectValueFromDropList(MolecularTarget, target);
        }

        private void IsthePresenceOfBiomarkerRequiredForTrialEligibility(string eligiblity)
        {
            PageHelper.SelectValueFromDropList(BioMarkerTrialEligiblity, eligiblity);
        }

        private void IsTissueAvailabilityRequirementToThisStudy(string availablity)
        {
            PageHelper.SelectValueFromDropList(TissueAvailability, availablity);
        }

        public void FillUpTrialDetails(string sponsor, string coopGroup, string regoNumber, string phase, string group,
            string tumourCategory, string tumourGroup, string stage, string population, string multiCentre, string site,
            string bioMarkerStudy, string molTarget)
        {
            EnterScientificTitle(PageHelper.RandomString(8));
            SelectASponsor(sponsor);
            SelectACooperativeGroup(coopGroup);
            EnterNickName(PageHelper.RandomString(3));
            RegistrationNumber.SendKeys(regoNumber);
            SelectAPhase(phase);
            SelectAGroup(group);
            SelectATumourCategory(tumourCategory);
            SelectATumourGroup(tumourGroup);
            SelectStagesOfDisease(stage);
            SelectAPopulation(population);
            SelectMultiCentreTrial(multiCentre);
            SelectLeadSite(site);
            SelectBioMarkerSubstudy(bioMarkerStudy);
            SelectAMolecularTarget(molTarget);
        }

        public void FillUpBioMarkerDetails(string eligiblity, string molTarget, string availablity)
        {
            IsthePresenceOfBiomarkerRequiredForTrialEligibility(eligiblity);
            SelectAMolecularTarget(molTarget);
            IsTissueAvailabilityRequirementToThisStudy(availablity);

        }
    }
}
