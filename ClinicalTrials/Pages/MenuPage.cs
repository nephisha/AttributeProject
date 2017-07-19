using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicalTrials.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ClinicalTrials.Pages
{
    class MenuPage : PageBase
    {
        public MenuPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//a[@title='Toggle Mobile Menu']")]
        private IWebElement ToggleMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='nav-primary']/li[3]")]
        private IWebElement SubmitATrial { get; set; }

        public void ClickOnToggleMenu()
        {
            ToggleMenu.Click();
        }

        public void SelectSubmitATrialFromToggleMenu()
        {
            SubmitATrial.Click();
        }
    }
}
