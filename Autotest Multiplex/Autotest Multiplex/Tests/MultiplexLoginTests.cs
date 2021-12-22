using Autotest_Multiplex.PageObject;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace Autotest_Multiplex.Tests
{
    public class Tests : MultiplexUrlBaseTest
    {
        //private IWebDriver driver;

        //private readonly By _signInButton = By.ClassName("lk_link");
        //private readonly By _loginInputButton = By.XPath("//input[@type='tel']");
        //private readonly By _continueButton = By.XPath("//div[contains(@class, 'login__phone__submit active')]");
        //private readonly By _usertel = By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]");

        //private const string _login = "504542520";
        //private const string _expectedtel = "+380 (50) 454 2520";

        InitPage init;
        LoginPage login;

        [SetUp]
        public void TeastSetups()
        {
            init = new InitPage(driver);
            login = new LoginPage();
        }


        [Test]
        public void AutotestMultiplex()
        {
            init.ClickLogin();
            //Thread.Sleep(1000);

            login.UserTel("504542520");
            // Thread.Sleep(2000);

            login.ClickLoginBtn();
            //Thread.Sleep(2000);


            string actualTel = login.CheckUserTel();
            string expectedTel = "+380 (50) 454 2520";
            Assert.AreEqual(expectedTel, actualTel, $"{expectedTel} is not equal to {actualTel}");

            actualTel.Should().NotBeEmpty(); //сделать как и ассерт

            //var signIn = driver.FindElement(_signInButton);
            //signIn.Click();

            //Thread.Sleep(1000);
            //var login = driver.FindElement(_loginInputButton);
            //login.SendKeys(_login);

            //Thread.Sleep(1000);
            //var continueLogin = driver.FindElement(_continueButton);
            //continueLogin.Click();

            //Thread.Sleep(1000);
            //var actualtel = driver.FindElement(_usertel).Text;
            //Assert.AreEqual(_expectedtel, actualtel, "telephone is wrong, check it");
        }


    }
}