using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.PageObject
{
    public class BasePage
    {
        protected static IWebDriver driver;

        public BasePage()
        {
        }

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
