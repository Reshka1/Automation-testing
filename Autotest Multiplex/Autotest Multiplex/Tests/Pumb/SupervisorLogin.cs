using Autotest_Multiplex.Service;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace Autotest_Multiplex.Tests.Pumb
{
    class SupervisorLogin
    {
        #region 
        protected IWebDriver driver;
        protected DefaultWait<IWebDriver> fluentWait;
        protected WebDriverWait wait;
        protected Processes proc;
        #endregion
        public readonly string _login = "//input[(@class, 'hn-input__input')]";
        public readonly string _password = "//input[contains(@class, 'hn-input__input')]";

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
            var login = driver.FindElement(By.XPath(_login));
            login.SendKeys("svc_cawp_spv_tst1");

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
