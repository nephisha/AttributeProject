using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClinicalTrials.Base
{
    public class DriverBase
    {
        public static IWebDriver Driver { get; set; }

        public static IWebDriver GetDefaultDriver()
        {
            Driver = new ChromeDriver(@"C:\Drivers");
            new ChromeOptions().AddArguments("no-sandbox");
            Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return Driver;
        }
    }
}
