using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.Error
{
    public class InheritableException : BaseException
    {
        protected static IWebDriver driver;
        public void Check()
        {
            try
            {
                IWebElement webelement = driver.FindElement(By.XPath("//a[contains(@class,'logolink')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public InheritableException(string _Logo) : base(_Logo)
        {

        }
    }
}
