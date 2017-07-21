using System;
using System.Diagnostics;
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

        [AfterFeature]
        public static void AfterAll()
        {
            var chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }
    }
}
