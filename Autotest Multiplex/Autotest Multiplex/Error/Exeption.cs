using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.Error
{
    public class Error
    {
        protected static IWebDriver driver;
        public IWebElement webelement = driver.FindElement(By.XPath("//a[contains(@class,'logolink')]"));
        public void Check()
        {
            try
            {
               WebElement webElement = new WebElement {};
               webElement = driver.FindElement(By.XPath(webelement));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
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
        public ExeptionUi(string message) : base(message) { }
    }
}


