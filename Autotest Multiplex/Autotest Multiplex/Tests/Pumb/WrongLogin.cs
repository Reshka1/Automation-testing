using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Autotest_Multiplex.Tests.Pumb
{
    public class WrongLogin
    {
        #region 
        protected IWebDriver driver;
        protected DefaultWait<IWebDriver> fluentWait;
        protected WebDriverWait wait;
        #endregion

        private readonly string _login = "//input[contains(@name, 'username')]";
        private readonly string _password = "//input[contains(@name, 'password')]";
        private readonly string _enter = "//button[contains(@class, 'hn-button login-form__button content__item_4')]";

        private readonly string _supervisor = "//div[contains(@class, 'username')]";// найти хпас для неверного входа
        private readonly string _expectedresult = "";// найти хпас для неверного входа

        public void СheckLogin()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_supervisor)));
        }

        [SetUp]
        public void SetUp()
        {
            #region Window of Browser
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://cawp.stage-fuib.com/");
            driver.Manage().Window.Maximize();
            #endregion
        }

        [Test]
        public void Login()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement sendUsername = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_login)));
            sendUsername.SendKeys("svc_cawp_spv_tst");
            IWebElement sendPassword = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_password)));
            sendPassword.SendKeys("p5X6H5s59Acp3CZTJQ3Mky2bc\"!CTQzi");
            IWebElement сlickEnter = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_enter)));
            сlickEnter.Click();
            IWebElement сheckLogin = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_supervisor)));

            var actualresult = driver.FindElement(By.XPath(_supervisor)).Text;
            Assert.AreEqual(_expectedresult, actualresult);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var item in chromeDriverProcesses)
            {
                item.Kill();
            }
        }
    }
}

