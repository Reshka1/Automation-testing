using Autotest_Multiplex.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Autotest_Multiplex.Tests.Rozetka.PageObject
{
    public partial class FindPan : BasePage
    {
        public FindPan() : base() { }

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        public void WritingPan() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_seacher))).SendKeys("сковорода");
        public void ClickBtn() => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(_btnsearch))).Click();


        //private IWebElement actualTel => driver.FindElement(By.XPath());
       // public string ActualTel() => actualTel.Text;
    }
}
