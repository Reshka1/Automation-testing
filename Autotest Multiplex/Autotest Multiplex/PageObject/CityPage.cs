using OpenQA.Selenium;

namespace Autotest_Multiplex.PageObject
{
    public class CityPage : BasePage
    {
        public CityPage() : base() { }


        private readonly string _btnCity = "//*[contains(@class, 'geo')]";
        private readonly string _checkText = "//span[text()='ЦУМ']";

        private IWebElement btnCity => driver.FindElement(By.XPath(_btnCity));
        private IWebElement chooseCity = driver.FindElement(By.XPath("//span[text()='Київ']"));
        private IWebElement checkText => driver.FindElement(By.XPath(_checkText));

        public void ClickBurger() => btnCity.Click();
        public void ClickBuyPopcorn() => chooseCity.Click();
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
}
