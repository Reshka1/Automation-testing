using NodaTime;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Autotest_Multiplex.PageObject
{
    public class LoginPage : BasePage
    {
        public LoginPage() : base() { }

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        public readonly string _btnLogin = "//a[contains(@class,'lk_link')]";
        private readonly string _writeTel = "//input[@type='tel']";
        private readonly string _btnContin = "//div[contains(@class, 'login__phone__submit active')]";
        private readonly string _checkUserTel = "//p[contains(@class, 'login__submitted__phone__val ')]";

        public void ClickLogin()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_btnLogin))).Click();
        }
        public void UserTel(string text)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_writeTel))).SendKeys("504542520");
        }
        public void ClickLoginBtn()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_btnContin))).Click();
        }
        public void CheckUserTeL()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_checkUserTel)));
        }


        //private IWebElement btnLogin => driver.FindElement(By.XPath(_btnLogin));
        //private IWebElement writeTel => driver.FindElement(By.XPath(_writeTel));
        //private IWebElement btnContin => driver.FindElement(By.XPath(_btnContin));
        //private IWebElement checkUserTel => driver.FindElement(By.XPath(_checkUserTel));

        //public void ClickLogin() => btnLogin.Click();
        //public void UserTel(string text) => writeTel.SendKeys("504542520");
        //public void ClickLoginBtn() => btnContin.Click();
        //public string CheckUserTeL() => checkUserTel.Text;


        //public void ExpectedConditions()
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(10));
        //    IWebElement btnLogin = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(@class,'lk_link')]")));
        //    IWebElement loginInputButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@type='tel']")));
        //    IWebElement continueButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class, 'login__phone__submit active')]")));
        //    IWebElement checkTel = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]")));
        //    btnLogin.Click();
        //    loginInputButton.SendKeys("504542520");
        //    continueButton.Click();
        //    checkTel.ToString();
        //}

        #region Pushing Button
        //public void ClickLogin() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(@class,'lk_link')]"))).Click();
        //public void UserTel(string text) => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@type='tel']"))).SendKeys(text);
        //public void ClickLoginBtn() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class, 'login__phone__submit active')]"))).Click();
        // public void CheckUserTel() => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]"))).Text;
        #endregion
    }
}
