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
    public class DriverBase
    {
        protected static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            if (Driver == null)
            {
                GetDefaultDriver();
            }
        }

        private static void GetDefaultDriver()
        {
            Driver = new ChromeDriver(Path.Combine(Environment.CurrentDirectory, @"Tools\"));
            new ChromeOptions().AddArguments("no-sandbox");
            Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
        }



        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
