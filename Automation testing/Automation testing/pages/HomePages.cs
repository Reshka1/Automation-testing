using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_testing.pages
{
    public class HomePages
    {

        public HomePages(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("Увійти до особистого кабінету"));

        IWebElement lnklnkProYakaboo => Driver.FindElement(By.LinkText("Про Yakaboo"));

        public void ClickLogin() => lnkLogin.Click();

        public bool IsProYakabooExist() => lnklnkProYakaboo.Displayed;
    }
}
