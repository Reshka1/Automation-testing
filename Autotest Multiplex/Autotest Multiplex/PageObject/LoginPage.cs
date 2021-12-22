using NodaTime;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.PageObject
{
    public class LoginPage : BasePage
    {
        public LoginPage() : base()
        {

        }

        
        private IWebElement loginInputButton => driver.FindElement(By.XPath("//input[@type='tel']"));

<<<<<<< HEAD
        private IWebElement continueButton => driver.FindElement(By.XPath("//div[contains(@class, 'login__phone__submit active')]"));
       
        private IWebElement checkTel => driver.FindElement(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]"));
=======
        private IWebElement continueButton => 
            driver.FindElement(By.XPath("//div[contains(@class, 'login__phone__submit active')]"));
        
        private IWebElement checkTel => 
            driver.FindElement(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]"));
>>>>>>> 0ad3217d38557a13568cb02c89b8941443f9b248

        public void UserTel(string text) => loginInputButton.SendKeys(text);
        public void ClickLoginBtn() => continueButton.Click();
        public string CheckUserTel() => checkTel.Text;

    }
}
