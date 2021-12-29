using Autotest_Multiplex.PageObject;
using NUnit.Framework;
using System.Diagnostics;

namespace Autotest_Multiplex.Tests
{
    public class PageofPopcornTest : MultiplexUrlBaseTest
    {
        LoginPage login;

        [SetUp]
        public void Setup()
        {
            login = new LoginPage();

        }
        public class ExpectedText
        {
            private object text;
            //    public object expectedtext
            //    {
            //        get { text = "Ваше замовлення"; }

            //    }
            //}

            [Test]
            public void BuyPopcorn()
            {
                ExpectedText v = new ExpectedText();

                //Assert.AreEqual(v.expectedtext, login.Actualtext, $"{v.expectedtext} is not equal to {login.Actualtext}");
            }
        }
    }
}
