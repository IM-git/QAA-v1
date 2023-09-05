using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAA_v1.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAA_v1.Tests
{
    internal class BaseTests
    {
        //public IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        public IWebDriver driver = null;

        public const string _testwebsite = "https://www.saucedemo.com/";

        [SetUp]
        public void Open()
        {
            //driver.Url = _testwebsite;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(_testwebsite);
            driver.Manage().Window.Maximize();
        }

        public void LoginOnPage()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginOnPage();

        }

        [TearDown]
        public void TearDown()
        {
            int millisecondsToWait = 1000; // 1 секунда = 1000 миллисекунд
            Thread.Sleep(millisecondsToWait);
            //driver.Close();
            driver.Quit();
        }
    }
}
