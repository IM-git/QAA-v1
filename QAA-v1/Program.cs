using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAA_v1
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;

        private const string _testwebsite = "https://www.saucedemo.com/";
        private const string _username = "user-name";
        private const string _password = "password";
        private const string _expecteAppLogoValue = "Swag Labs";

        private const string _loginButtonID = "login-button";
        private const string _appLogoClass = "app_logo";

        private readonly By _loginButton = By.Id(_loginButtonID);
        private readonly By _usernameValue = By.Id(_username);
        private readonly By _passwordValue = By.Id(_password);
        private readonly By _appLogoValue = By.ClassName(_appLogoClass);

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl(_testwebsite);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            int millisecondsToWait = 1000;
            Thread.Sleep(millisecondsToWait);

            var usernameField = driver.FindElement(_usernameValue);
            usernameField.SendKeys("standard_user");

            var passwordField = driver.FindElement(_passwordValue);
            passwordField.SendKeys("secret_sauce");

            var signInButton = driver.FindElement(_loginButton);
            signInButton.Click();

            var actualAppLogo = driver.FindElement(_appLogoValue).Text;

            Assert.AreEqual(_expecteAppLogoValue, actualAppLogo, $"Error. Expected value: {_expecteAppLogoValue}");
        }

        [TearDown]
        public void TearDown()
        {
            int millisecondsToWait = 1000;
            Thread.Sleep(millisecondsToWait);
            driver.Close();
            driver.Quit();
        }
    }
}
