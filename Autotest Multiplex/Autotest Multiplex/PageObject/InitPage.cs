using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.PageObject
{
    class InitPage : BasePage
    {
        public InitPage(IWebDriver driver) : base (driver)
        {

        }


        private IWebElement btnLogin => driver.FindElement(By.ClassName("lk_link"));
        public void ClickLogin() => btnLogin.Click();
    }
}
