using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.Error
{
    public class InheritException : BaseException
    {
        protected static IWebDriver driver;
        public void Check()
        {
            try
            {
                IWebElement webelement = driver.FindElement(By.XPath("//a[contains(@class,'lk_link')]"));
            }
            catch (BaseException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public InheritException(string _Login) : base(_Login)
        {

        }
    }
}
