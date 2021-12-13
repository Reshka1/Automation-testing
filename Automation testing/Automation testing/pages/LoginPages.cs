using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_testing.pages
{
    class LoginPages
    {
        public LoginPages (IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebDriver Driver { get; }

        IWebElement txtUzerName => Driver.FindElement(By.Name("login[username]"));
        IWebElement txtPassword => Driver.FindElement(By.Name("login[password]"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value='Увійти']"));

        public void Login (string userName, string password)
        {
            txtUzerName.SendKeys(userName);
            txtUzerName.SendKeys(password);
            btnLogin.Submit();

        }



    }
}
