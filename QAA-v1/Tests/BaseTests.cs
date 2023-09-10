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
    public class BaseTests
    {
        //public IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        public IWebDriver driver = null;

        public const string _testwebsite = "https://www.saucedemo.com/";

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(_testwebsite);
            driver.Manage().Window.Maximize();
        }

        public void LoginOnPage()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginOnPage();

        }

        public void CheckValue(string value, string checker)
        {
            Assert.AreEqual(checker, value, $"Error. Expected value: {value}");
        }

        public object FindElement(string CssValue) => driver.FindElement(By.CssSelector(CssValue));

        public string GetStringValue(string CssValue) => driver.FindElement(By.CssSelector(CssValue)).Text;

        [TearDown]
        public void TearDown()
        {
            int millisecondsToWait = 1000;
            Thread.Sleep(millisecondsToWait);
            driver.Quit();
        }
    }
}
