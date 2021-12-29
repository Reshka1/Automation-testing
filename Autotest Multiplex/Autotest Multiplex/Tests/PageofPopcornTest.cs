using Autotest_Multiplex.PageObject;
using NUnit.Framework;
using System.Diagnostics;
using static Autotest_Multiplex.PageObject.LoginPage;

namespace Autotest_Multiplex.Tests
{
    public class PageofPopcornTest : MultiplexUrlBaseTest
    {
        LoginPage login;

        [SetUp]
        public void SetuP()
        {
            login = new LoginPage();
        }

        [Test]
        public void BuyPopcorn()
        {
            login.ClickBurger();
            ExpectedText v = new ExpectedText();
            ActualText a = new ActualText();

            Assert.AreEqual(expected: v.expectedtext, actual: a.actualtext, $"{v.expectedtext} is not equal to {a.actualtext}");
        }
    }
}

