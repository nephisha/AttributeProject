using ClinicalTrials.Base;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ClinicalTrials.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = DriverBase.GetDefaultDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}
