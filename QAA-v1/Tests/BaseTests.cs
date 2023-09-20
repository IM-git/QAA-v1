using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAA_v1.pages;
using QAA_v1.Elements;
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
        private IWebDriver _driver;

        //public BaseTests() => _driver = WebDriverSingleton.Instance;
        private const string _username = "standard_user";
        private const string _password = "secret_sauce";

        public const string _testwebsite = "https://www.saucedemo.com/";

        [SetUp]
        public void Open()
        {
            _driver = WebDriverSingleton.Instance;
            _driver.Navigate().GoToUrl(_testwebsite);
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            int millisecondsToWait = 1000;
            Thread.Sleep(millisecondsToWait);
        }
        public void LoginOnPage()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.EnterUserName(_username);
            loginPage.EnterPassword(_password);
            loginPage.ClickSignInButton();

        }

        public void CheckValue(string value, string checker)
        {
            Assert.AreEqual(checker, value, $"Error. Expected value: {value}");
        }

        public object FindElement(string CssValue) => _driver.FindElement(By.CssSelector(CssValue));

        public string GetStringValue(string CssValue) => _driver.FindElement(By.CssSelector(CssValue)).Text;

    }
}
