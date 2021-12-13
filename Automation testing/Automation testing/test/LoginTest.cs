using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Automation_testing.test
{
    class LoginTest
    {
        WebDriver webDriver = new ChromeDriver(@"E:\Work");

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("https://www.yakaboo.ua/");

        }

        [Test]
        public void Login()
        {
            //webDriver.Navigate().GoToUrl("https://www.yakaboo.ua/");
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("0504542520", "password");

            Assert.That(homePage.IsProYakabooExist, Is.True);

            Console.WriteLine("Is it execcuting second");

        }
    }
}
