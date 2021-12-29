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
     //   public string Actualtext = driver.FindElement(By.XPath("//div[contains(@class, 'movie-name mobile-hidden')]")).Text;

        public LoginPage() : base() { }

        WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(10));
        public void ClickLogin()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(@class,'lk_link')]"))).Click();
        }
        public void UserTel(string text)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@type='tel']"))).SendKeys("504542520");
        }
        public void ClickLoginBtn()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class, 'login__phone__submit active')]"))).Click();
        }
        public void CheckUserTel()
        {
            IWebElement checkTel = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]")));
        }

        //IWebElement btnLogin = driver.FindElement(By.XPath("//a[contains(@class,'lk_link')]"));
        //IWebElement loginInputButton = driver.FindElement(By.XPath("//a[contains(@class,'lk_link')]"));
        //IWebElement continueButton = driver.FindElement(By.XPath("//a[contains(@class,'lk_link')]"));
        //IWebElement checkTel = driver.FindElement(By.XPath("//a[contains(@class,'lk_link')]"));

        //private readonly string btnLogin = "//a[contains(@class,'lk_link')]";
        //private readonly string loginInputButton = "//input[@type='tel']";
        //private readonly string continueButton = "//div[contains(@class, 'login__phone__submit active')]";
        //private readonly string _checkTel = "//p[contains(@class, 'login__submitted__phone__val ')]";

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


        //#region Pushing Button
        //public void ClickLogin() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(@class,'lk_link')]"))).Click();
        //public void UserTel(string text) => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@type='tel']"))).SendKeys(text);
        //public void ClickLoginBtn() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class, 'login__phone__submit active')]"))).Click();
        // public void CheckUserTel() => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]"))).Text;
        //#endregion
    }
}
