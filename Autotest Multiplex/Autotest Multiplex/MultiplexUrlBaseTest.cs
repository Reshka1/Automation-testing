using Autotest_Multiplex.Service;
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
using System.Threading;

namespace Autotest_Multiplex
{
    public class MultiplexUrlBaseTest
    {
        #region 
        protected IWebDriver driver;
        protected DefaultWait<IWebDriver> fluentWait;
        protected WebDriverWait wait;
        protected Processes proc;
        #endregion


        [SetUp]
        //вызывается перед тестом
        public void Setup()
        {
            #region Window of Browser
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://multiplex.ua/");
            driver.Manage().Window.Maximize(); //метод позвляет открыть окно полностью
            Thread.Sleep(1000);
            #endregion

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            #region Comment Fluent Wait
            //fluentWait = new DefaultWait<IWebDriver>(driver);
            //fluentWait.Timeout = TimeSpan.FromSeconds(10);
            //fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            //fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            //fluentWait.Message = "Element to be searched not found";
            #endregion
        }

        [TearDown]
        //вызывается после теста. закрываем веб-приложение
        public void TearDown()
        {
          //  driver.Quit();
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var item in chromeDriverProcesses)
            {
                item.Kill();
            }
        }
    }
}
