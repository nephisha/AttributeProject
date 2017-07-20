﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ClinicalTrials.Base
{
    public class PageBase : DriverBase
    {
        public PageBase()
        {
            PageFactory.InitElements(Driver, this);
        }
    }
}
