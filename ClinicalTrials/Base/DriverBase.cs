using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ClinicalTrials.Base
{
    public class DriverBase
    {
        public static IWebDriver Driver { get; set; }

        public static IWebDriver GetDefaultDriver()
        {
            Driver = new ChromeDriver(Path.Combine(Environment.CurrentDirectory, @"Tools\"));
            new ChromeOptions().AddArguments("no-sandbox");
            //Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return Driver;
        }
    }
}
