using Autotest_Multiplex.Tests.Rozetka.Preparing;
using NUnit.Framework;
using System;


namespace Autotest_Multiplex.Tests.Rozetka.PageObject
{
    public class PanTest : Url
    {
        FindPan findPan;
        [SetUp]
        public void TeastSetups()
        {
            findPan = new FindPan();
        }

        [Test]
        public void AutotestMultiplex()
        {
            findPan.WritingPan();
            findPan.ClickBtn();
        }

    }
}
