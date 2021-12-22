using NodaTime;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Autotest_Multiplex
{
    public class MultiplexUrlBaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        //вызывается перед тестом
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://multiplex.ua/");
            driver.Manage().Window.Maximize(); //метод позвляет открыть окно полностью
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            //вынести урлу, переименовать
        }

        [TearDown]
        //вызывается после теста. закрываем веб-приложение
        public void TearDown()
        {
            driver.Quit();
            //Kill.Process();
            //https://docs.microsoft.com/ru-ru/dotnet/api/system.diagnostics.process.kill?view=net-6.0
        }
    }
}
