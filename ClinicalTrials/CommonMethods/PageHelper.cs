using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ClinicalTrials.CommonMethods
{
    public class PageHelper
    {
        private static readonly Random Random = new Random();

        public static void SelectValueFromDropList(IList<IWebElement> dropdownElement, string selectedTextValue)
        {
            var dSize = dropdownElement.Count;

            for (var i = 0; i < dSize; i++)
            {
                var value = dropdownElement.ElementAt(i).Text.ToLower();

                if (value.Contains(selectedTextValue.ToLower()))
                {
                    dropdownElement.ElementAt(i).Click();
                    break;
                }
            }
        }

        public static void SelectValueFromDropdown(IWebElement category, string type)
        {
            var select = new SelectElement(category);
            select.SelectByText(type);
        }

        
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
