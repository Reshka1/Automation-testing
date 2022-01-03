using Autotest_Multiplex.PageObject;
using FluentAssertions;
using NUnit.Framework;
using System.Diagnostics;
using System.Threading;
using static Autotest_Multiplex.PageObject.CityPage;
using static Autotest_Multiplex.PageObject.LoginPage;
using static Autotest_Multiplex.PageObject.LvivCity;

namespace Autotest_Multiplex.Tests
{
    [TestFixture]
    [Parallelizable]
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
        public void ChooseKiew()
        {
            burger.ClickBurger();
            Thread.Sleep(1000);
            burger.ClickChooseCity();
            Thread.Sleep(1000);
            burger.ChechText();

            ExpectedText v = new ExpectedText();
            var actualText = burger.ChechText(); 
            var expectedText = v.expectedtext;

           // Assert.AreEqual(expected: v.expectedtext, actualText, $"{v.expectedtext} is not equal to {actualText}");
            actualText.Should().Contain((string)v.expectedtext);
            //c.checkusertel.Should().Contain(expectedTel);// TODO update
        }
    }


    [TestFixture]
    [Parallelizable]
    public class PageChoosecinemaTest : MultiplexUrlBaseTest
    {
        LoginPage login;
        InitPage init;
        LvivCity burger;

        [SetUp]
        public void SetUp()
        {
            login = new LoginPage();
            init = new InitPage(driver);
            burger = new LvivCity();
        }

        [Test]
        public void ChooseLviv()
        {
            burger.Clickburger();
            Thread.Sleep(1000);
            burger.ClickchooseCity();
            Thread.Sleep(1000);
            burger.Checktext();

            Expectedtext v = new Expectedtext();
            var actualText = burger.Checktext();
            var expectedTExt = v.expectedText;

            // Assert.AreEqual(expected: v.expectedtext, actualText, $"{v.expectedtext} is not equal to {actualText}");
            actualText.Should().Contain((string)v.expectedText);
            //c.checkusertel.Should().Contain(expectedTel);// TODO update
        }
    }
}

