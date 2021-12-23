using NodaTime;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Autotest_Multiplex
{
    public class MultiplexUrlBaseTest
    {
        protected IWebDriver driver;
        protected DefaultWait<IWebDriver> fluentWait;
        protected WebDriverWait wait;

        [SetUp]
        //вызывается перед тестом
        public void Setup()
        {
            driver = new ChromeDriver();
            fluentWait = new DefaultWait<IWebDriver>(driver);

            driver.Navigate().GoToUrl("https://multiplex.ua/");
            driver.Manage().Window.Maximize(); //метод позвляет открыть окно полностью
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            /* Ignore the exception - NoSuchElementException that indicates that the element is not present */
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";


        }



        [TearDown]
        //вызывается после теста. закрываем веб-приложение
        public void TearDown()
        {
            driver.Quit();
            
        }
        public void Kill()
        {
        }

    }
}
