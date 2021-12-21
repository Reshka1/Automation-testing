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
    public class MultiplexUrl
    {
        protected IWebDriver driver;

        [SetUp]
        //вызывается перед тестом
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://multiplex.ua/");
            driver.Manage().Window.Maximize(); //метод позвляет открыть окно полностью
            

        }

        [TearDown]
        //вызывается после теста. закрываем веб-приложение
        public void TearDown()
        {
            driver.Quit();

        }

    }
}
