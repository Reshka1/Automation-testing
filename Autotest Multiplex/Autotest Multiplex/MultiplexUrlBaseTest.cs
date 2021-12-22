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
<<<<<<< HEAD:Autotest Multiplex/Autotest Multiplex/MultiplexUrl.cs
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
           
=======
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            //вынести урлу, переименовать
>>>>>>> 0ad3217d38557a13568cb02c89b8941443f9b248:Autotest Multiplex/Autotest Multiplex/MultiplexUrlBaseTest.cs
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
