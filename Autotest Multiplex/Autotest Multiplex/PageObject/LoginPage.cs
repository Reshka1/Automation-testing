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

        private readonly string _btnBurger = "//img[contains(@class, 'menu-btn')]";
        private readonly string _btnPopcorn = "//a[contains(@class, 'menu_item yellow')]";
        private readonly string _Actualtext = "//div[contains(@class, 'movie-name mobile-hidden')]";

        IWebElement btnBurger => driver.FindElement(By.XPath(_btnBurger));
        IWebElement btnPopcorn = driver.FindElement(By.XPath("//a[contains(@class, 'menu_item yellow')]"));
        public class ActualText
        {
            private object Actualtext => driver.FindElement(By.XPath("//div[contains(@class, 'movie-name mobile-hidden')]"));
            public object actualtext
            {
                get { return Actualtext; }
            }
        }
        public class ExpectedText
        {
            private object text = "Ваше замовлення";
            public object expectedtext
            {
                get { return text; }
            }
        }

        public LoginPage() : base() { }

        WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(15));
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

        public void CheckUserTe()
        {
            _ = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]"))).Text;
        }

        public class CheckUserTel
        {
            private object CheckUsertel => driver.FindElement(By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]")).Text;
            public object checkusertel
            {
                get { return CheckUsertel; }
            }
        }

        public void ClickBurger()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//img[contains(@class, 'menu-btn')]"))).Click();
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
