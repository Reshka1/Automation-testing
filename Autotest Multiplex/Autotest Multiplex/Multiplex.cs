using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;

namespace Autotest_Multiplex
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _signInButton = By.ClassName("lk_link");
        private readonly By _loginInputButton = By.XPath("//input[@type='tel']");
        private readonly By _continueButton = By.XPath("//div[contains(@class, 'login__phone__submit active')]");
        private readonly By _usertel = By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]");

        private const string _login = "504542520";
        private const string _expectedtel = "+380 (50) 454 2520";

        [SetUp]
        //вызывается перед тестом
        public void Setup()
        {
            string path = Directory.GetCurrentDirectory();
            IWebDriver webDriver = new ChromeDriver();
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://multiplex.ua/");
            driver.Manage().Window.Maximize(); //метод позвляет открыть окно полностью

        }

        [Test]
        public void Test1()
        {
            var signIn = driver.FindElement(_signInButton);
            signIn.Click();

            var login = driver.FindElement(_loginInputButton);
            login.SendKeys(_login);

            var continueLogin = driver.FindElement(_continueButton);
            continueLogin.Click();

            Thread.Sleep(1000);
            var actualtel = driver.FindElement(_usertel).Text;
            Assert.AreEqual(_expectedtel, actualtel, "telephone is wrong, check it");
        }

        [TearDown]
        //вызывается после теста. закрываем веб-приложение
        public void TearDown()
        {
            driver.Quit();

        }
    }
}