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

        IWebElement txtUserName => Driver.FindElement(By.Name("login[username]"));
        IWebElement txtPassword => Driver.FindElement(By.Name("login[password]"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value='Увійти']"));

        public void Login (string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtUserName.SendKeys(password);
            btnLogin.Submit();

        }



    }
}
