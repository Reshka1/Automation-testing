using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace MsT
{
    class SupervisorLogin
    {
        #region 
        protected IWebDriver driver;
        protected DefaultWait<IWebDriver> fluentWait;
        protected WebDriverWait wait;
        protected Processes proc;
        #endregion
        private readonly string _login = "//input[contains(@name, 'username')]";
        private readonly string _password = "//input[contains(@name, 'password')]";
        private readonly string _enter = "//button[contains(@class, 'hn-button login-form__button content__item_4')]";

        private readonly string _supervisor = "//div[contains(@class, 'username')]";
        private readonly string _expectedresult = "svc_cawp_spv_tst1";

        public void ÑheckLogin()
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
            #region Resently
            //var login = driver.FindElement(By.XPath(_login));
            //login.SendKeys("svc_cawp_spv_tst1");
            //var password = driver.FindElement(By.XPath(_password));
            //password.SendKeys("p5X6H5s59Acp3CZTJQ3Mky2bc\"!CTQzi");
            //var enter = driver.FindElement(By.XPath(_enter));
            //enter.Click(); 
            #endregion

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement sendUsername = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_login)));
            sendUsername.SendKeys("svc_cawp_spv_tst1");
            IWebElement sendPassword = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_password)));
            sendPassword.SendKeys("p5X6H5s59Acp3CZTJQ3Mky2bc\"!CTQzi");
            IWebElement ñlickEnter = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_enter)));
            ñlickEnter.Click();
            IWebElement ñheckLogin = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_supervisor)));

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
