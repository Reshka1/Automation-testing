using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.IO;

namespace AutotestBuyPopcorn
{
    public class PageofPopcorn
    {
        protected IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://multiplex.ua/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//img[contains(@class, 'menu-btn')]")).Click();
            driver.FindElement(By.XPath("//a[contains(@class, 'menu_item yellow')]")).Click();

        }
        public class ExpectedText
        {
            private object text;
            public object expectedtext
            {
                get { return text; }
                set { text = value; }
            }
        }

        [Test]
        public void Test1()
        {
            ExpectedText v = new ExpectedText();
            v.expectedtext = "Ваше замовлення";

            var actualtext = driver.FindElement(By.XPath("//div[contains(@class, 'movie-name mobile-hidden')]")).Text;
            Assert.AreEqual(v.expectedtext, actualtext, $"{v.expectedtext} is not equal to {actualtext}");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            foreach (Process proc in Process.GetProcesses())
            {
                proc.Kill();
            }

            try
            {
                Directory.Delete(@"C:\Users\acer\Desktop\chromedriver");

                //foreach (Process proc in Process.GetProcesses())
                //{
                //    proc.Kill();
                //}
            }
            catch
            {
                System.Console.WriteLine("chromedriver уже удален");
            }

        }
    }
}