using Autotest_Multiplex.PageObject;
using NUnit.Framework;
using System.Diagnostics;
using System.Threading;
using static Autotest_Multiplex.PageObject.CityPage;
using static Autotest_Multiplex.PageObject.LoginPage;

namespace Autotest_Multiplex.Tests
{
    public class PageChooseCinemaTest : MultiplexUrlBaseTest
    {
        LoginPage login;
        InitPage init;
        CityPage burger;

        [SetUp]
        public void SetUp()
        {
            login = new LoginPage();
            init = new InitPage(driver);
            burger = new CityPage();
        }

        [Test]
        public void BuyPopcorn()
        {
            burger.ClickBurger();
            Thread.Sleep(1000);
            burger.ClickBuyPopcorn();
            Thread.Sleep(1000);
            burger.ChechText();

            ExpectedText v = new ExpectedText();
            var actualText = burger.ChechText(); 
            var expectedText = v.expectedtext;

            Assert.AreEqual(expected: v.expectedtext, actualText, $"{v.expectedtext} is not equal to {actualText}");
        }
    }
}

