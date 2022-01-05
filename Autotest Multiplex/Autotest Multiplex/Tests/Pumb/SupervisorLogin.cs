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
        private readonly string _login = "//input[@class='hn-input__input')]";
        //private readonly string _login = "//input[@class='hn-input__input')]/@title";
        //private readonly string _login = "//*[@name='username')]";
        private readonly string _password = "//input[contains(@class, 'hn-input__input')]";
        //private readonly string _password = "//*[@name='password')]";
        private readonly string _enter = "//input[contains(@class, 'hn-input__input')]";

        private readonly string _supervisor = "//";
        private readonly string _expectedresult = "";


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

            const string quote = "\"";
            var password = driver.FindElement(By.XPath(_password));
            login.SendKeys("p5X6H5s59Acp3CZTJQ3Mky2bc"+ quote +"!CTQzi");
            //login.SendKeys("p5X6H5s59Acp3CZTJQ3Mky2bc\"!CTQzi");

            var enter = driver.FindElement(By.XPath(_enter));
            login.Click();

            var actualresult = driver.FindElement(By.XPath(_supervisor));
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
