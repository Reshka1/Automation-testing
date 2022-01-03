using NUnit.Framework;
using OpenQA.Selenium;

namespace Autotest_Multiplex.PageObject
{
    [TestFixture]
    [Parallelizable]
    public class CityPage : BasePage
    {
        public CityPage() : base() { }


        private readonly string _btnCity = "//*[contains(@class, 'geo')]";
        private readonly string _checkText = "//span[text()='ЦУМ']";

        private IWebElement btnCity => driver.FindElement(By.XPath(_btnCity));
        private IWebElement chooseCity = driver.FindElement(By.XPath("//span[text()='Київ']"));
        private IWebElement checkText => driver.FindElement(By.XPath(_checkText));

        public void ClickBurger() => btnCity.Click();
        public void ClickChooseCity() => chooseCity.Click();
        public string ChechText() => checkText.Text;

        public class ExpectedText
        {
            private object text = "ЦУМ";
            public object expectedtext
            {
                get { return text; }
            }
        }
    }

    [TestFixture]
    [Parallelizable]
    public class LvivCity : BasePage
    {
        public LvivCity() : base() { }

        private readonly string _btncity = "//*[contains(@class, 'geo')]";
        private readonly string _checktext = "//span[text()='Spartak']";

        private IWebElement btncity => driver.FindElement(By.XPath(_btncity));
        private IWebElement chooseсity = driver.FindElement(By.XPath("//span[text()='Львів']"));
        private IWebElement checktext => driver.FindElement(By.XPath(_checktext));

        public void Clickburger() => btncity.Click();
        public void ClickchooseCity() => chooseсity.Click();
        public string Checktext() => checktext.Text;

        public class Expectedtext
        {
            private object Text = "Spartak";
            public object expectedText
            {
                get { return Text; }
            }
        }

    }
}
