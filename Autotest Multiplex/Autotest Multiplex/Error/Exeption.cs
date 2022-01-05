using Autotest_Multiplex.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.Error
{
    public class Error
    {
        protected static IWebDriver driver;
        public readonly string _logo = "//a[contains(@class,'logolink')]";
        public bool Check()
        {
            try
            {
                WebElement webElement = new WebElement();
                IWebElement wbElement = driver.FindElement(By.XPath(_logo));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }

    public class WebElement
{
        private string _logo = "//a[contains(@class,'logolink')]";
        public string logo { get; set; }
        public string _Logo
        {
            get { return _logo; }
        }

    }
    public class ExeptionUi : Exception
    {
        public ExeptionUi (string message) : base(message) { }
    }
}

//exeption https://metanit.com/sharp/tutorial/3.17.php
//супервизор

