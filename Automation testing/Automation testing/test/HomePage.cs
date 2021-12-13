using OpenQA.Selenium;

namespace Automation_testing.test
{
    internal class HomePage
    {
        private WebDriver webDriver;

        public HomePage(WebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}