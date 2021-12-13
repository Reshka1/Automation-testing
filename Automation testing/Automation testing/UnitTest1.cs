using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_testing
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver(@"E:\Work");
            webDriver.Navigate().GoToUrl("https://www.yakaboo.ua/");

            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("Увійти до особистого кабінету"));
            lnkLogin.Click();

            var txtUzerName = webDriver.FindElement(By.Name("login[username]"));


            Assert.That(txtUzerName.Displayed, Is.True);

            txtUzerName.SendKeys("0504542520");

            webDriver.FindElement(By.Name("login[password]")).SendKeys("password");
            webDriver.FindElement(By.XPath("//input[@value='Увійти']")).Submit();

            var lnkProYakaboo = webDriver.FindElement(By.LinkText("Про Yakaboo"));

            Assert.That(lnkProYakaboo.Displayed, Is.True);
        }

    }
}