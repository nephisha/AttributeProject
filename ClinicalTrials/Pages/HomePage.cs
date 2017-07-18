using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ClinicalTrials.Pages
{
    class HomePage
    {
        public IWebDriver Driver { get; private set; }

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "legend-sites")]
        private IWebElement Hospital { get; set; }

        public void SelectAHospital(string hospital)
        {
            var select = new SelectElement(Hospital);
            select.SelectByText(hospital);
        }
    }
}
