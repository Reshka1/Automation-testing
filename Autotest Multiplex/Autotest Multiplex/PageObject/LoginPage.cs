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

        #region ExpectedCondition waitting
        WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(35));
        //IWebElement btnLogin = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName("lk_link")));
        //IWebElement btnLogin1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@type='tel']")));
        // IWebElement btnLogin2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'login__phone__submit active')]")));
        // IWebElement btnLogin3 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]")));
        #endregion

        private readonly string _btnLogin = "//a[contains(@class,'lk_link')]"; 
        private readonly string _loginInputButton = "//input[@type='tel']";
        private readonly string _continueButton = "//div[contains(@class, 'login__phone__submit active')]";
        private readonly string _checkTel = "//p[contains(@class, 'login__submitted__phone__val ')]";

        #region Driver for ExpectedCondition waitting
        //private IWebElement btnLoginX => driver.FindElement(By.ClassName("lk_link"));
        //private IWebElement loginInputButton => driver.FindElement(By.XPath("//input[@type='tel']"));
        //private IWebElement continueButton => driver.FindElement(By.XPath(_continueButton));
        //private IWebElement checkTel "//p[contains(@class, 'login__submitted__phone__val ')=> driver.FindElement(By.XPath(]"));
        #endregion

        #region Pushing Button
        public void ClickLogin() => wait.Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(_btnLogin))).Click();
        public void UserTel(string text) => wait.Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(_loginInputButton))).SendKeys(text);
        public void ClickLoginBtn() => wait.Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(_continueButton))).Click();
        public bool CheckUserTel() => wait.Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(_checkTel))).Displayed;
        #endregion
    }
}
