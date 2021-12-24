using Autotest_Multiplex.NewFolder;
using Autotest_Multiplex.PageObject;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.IO;
using System.Threading;

namespace Autotest_Multiplex.Tests
{
    public class Tests : MultiplexUrlBaseTest
    {
        #region Recently Code
         //private IWebDriver driver;
         //private readonly By _signInButton = By.ClassName("lk_link");
         //private readonly By _loginInputButton = By.XPath("//input[@type='tel']");
         //private readonly By _continueButton = By.XPath("//div[contains(@class, 'login__phone__submit active')]");
         //private readonly By _usertel = By.XPath("//p[contains(@class, 'login__submitted__phone__val ')]");
         //private const string _login = "504542520";
         //private const string _expectedtel = "+380 (50) 454 2520";
        #endregion

        InitPage init;
        LoginPage login;
        TestData testData;


        [SetUp]
        public void TeastSetups()
        {
            init = new InitPage(driver);
            login = new LoginPage();
            testData = new TestData();
        }


        [Test]
        public void AutotestMultiplex()
        {
            login.ClickLogin();
            login.UserTel("504542520");
            login.ClickLoginBtn();
            //Thread.Sleep(2000);
             bool actualTel = login.CheckUserTel();
             var expectedTel = testData.ExpectedTel;
             Assert.AreEqual(expectedTel, actualTel, $"{expectedTel} is not equal to {actualTel}");
 //            actualTel.Should().Contain(expectedTel);

            #region Recently Code
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
            #endregion
        }
    }
}