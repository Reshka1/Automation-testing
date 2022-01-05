using Autotest_Multiplex.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.Error
{
    public class Exeption : BasePage
    {
        private readonly string _imax = "//a[contains(@class,'')]";

        public bool Check()
        {
            try
            {
                driver.FindElement(By.XPath(_imax));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
