using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ClinicalTrials.Base
{
    [Binding]
    class DriverBase
    {
        private static IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = GetDefaultDriver();
            ScenarioContext.Current["driver"] = _driver;

            _driver.Navigate().GoToUrl("http://uat-clinicaltrials.cancerinstitute.org.au/");
        }

        private static IWebDriver GetDefaultDriver()
        {
            _driver = new ChromeDriver(Path.Combine(Environment.CurrentDirectory, @"Tools\"));
            new ChromeOptions().AddArguments("no-sandbox");
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            return _driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}
