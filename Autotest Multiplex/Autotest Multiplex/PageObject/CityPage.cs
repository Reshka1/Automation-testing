using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Autotest_Multiplex.PageObject
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class CityPage : BasePage
    {
        public CityPage() : base() { }

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        public readonly string _btnCity = "//*[contains(@class, 'geo')]";
        public readonly string _chooseCity = "//span[text()='Київ']";
        private readonly string _checkText = "//span[text()='ЦУМ']";


        public void ClickBurger() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_btnCity))).Click();
        public void ClickChooseCity() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_chooseCity))).Click();
        public void ChechText() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_checkText)));

        private IWebElement checkText => driver.FindElement(By.XPath(_checkText));
        public string Chechtext() => checkText.Text;

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
    [Parallelizable(ParallelScope.Fixtures)]
    public class LvivCity : BasePage
    {
        public LvivCity() : base() { }

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        private readonly string _btncity = "//*[contains(@class, 'geo')]";
        public readonly string _choosecity = "//span[text()='Львів']";
        private readonly string _checktext = "//span[text()='Spartak']";

        public void Clickburger() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_btncity))).Click();
        public void ClickchooseCity() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_choosecity))).Click();
        public void Checktext() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_checktext)));


        private IWebElement checktext => driver.FindElement(By.XPath(_checktext));
        public string Actualtext() => checktext.Text;

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
