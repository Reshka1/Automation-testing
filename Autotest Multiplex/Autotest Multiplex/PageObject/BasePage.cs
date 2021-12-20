using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.PageObject
{
    public class BasePage// abstract
    {
        protected static IWebDriver driver;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
