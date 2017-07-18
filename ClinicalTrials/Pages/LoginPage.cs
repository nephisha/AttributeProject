using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ClinicalTrials.Pages
{
    class LoginPage
    {
        public IWebDriver Driver { get; private set; }

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Log On']")]
        private IWebElement Submit { get; set; }

        public void LoginToApplication(string user, string pwd)
        {
            UserName.SendKeys(user);
            Password.SendKeys(pwd);
            Submit.Click();
        }
    }
}
