using Autotest_Multiplex.PageObject;
using FluentAssertions;
using NUnit.Framework;
using System.Diagnostics;
using System.Threading;
using static Autotest_Multiplex.PageObject.CityPage;
using static Autotest_Multiplex.PageObject.LvivCity;

namespace Autotest_Multiplex.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class PageChooseCinemaTest : MultiplexUrlBaseTest
    {
        InitPage init;
        CityPage burger;

        [SetUp]
        public void SetUp()
        {
            init = new InitPage(driver);
            burger = new CityPage();
        }

        [Test]
        public void ChooseKiew()
        {
            burger.ClickBurger();
            burger.ClickChooseCity();
            burger.ChechText();

            ExpectedText v = new ExpectedText();
            var actualtext = burger.Chechtext();
            var expectedText = v.expectedtext;

            // Assert.AreEqual(expected: v.expectedtext, actualText, $"{v.expectedtext} is not equal to {actualText}");
            actualtext.Should().Contain((string)v.expectedtext);
        }
    }


    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class PageChoosecinemaTest : MultiplexUrlBaseTest
    {
        InitPage init;
        LvivCity burger;

        [SetUp]
        public void SetUp()
        {
            init = new InitPage(driver);
            burger = new LvivCity();
        }

        [Test]
        public void ChooseLviv()
        {
            burger.Clickburger();
            burger.ClickchooseCity();
            burger.Checktext();

            Expectedtext v = new Expectedtext();
            var actualText = burger.Actualtext();
            var expectedTExt = v.expectedText;

            // Assert.AreEqual(expected: v.expectedtext, actualText, $"{v.expectedtext} is not equal to {actualText}");
            actualText.Should().Contain((string)v.expectedText);

        }
    }
}

