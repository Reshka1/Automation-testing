using NodaTime;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.PageObject
{
    public class LoginPage : BasePage
    {
        public LoginPage() : base() { }


        private IWebElement loginInputButton => driver.FindElement(By.XPath("//input[@type='tel']"));

        private IWebElement continueButton => driver.FindElement(By.XPath("//div[contains(@class, 'login__phone__submit active')]"));

        private IWebElement checkTel => driver.FindElement(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]"));

        public void UserTel(string text) => loginInputButton.SendKeys(text);

        //перенести и запустить
        public void ClickLoginBtn() => continueButton.Click();
        public string CheckUserTel() => checkTel.Text;

    }
}
