using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAA_v1
{
    [TestFixture]
    public class Tests1
    {
        private IWebDriver _driver;
        public const string _testwebsite = "https://www.saucedemo.com/";
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
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(_testwebsite);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); //adding implicit wait

            // WebDriverWait waitObj = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // create webdriver object with timeout 10 seconds
            // IWebElement click_button = waitObj.Until(e => e.FindElement(_loginButton)); // caused internally by Element not found exception. else it will execute further. 
            // click_button.Click();
            _driver.Manage().Window.Maximize();
        }

        [Test, Category("FireFox"), Category("Sepate example")]
        public void Test()
        {
            int millisecondsToWait = 1000;
            Thread.Sleep(millisecondsToWait);

            string title = _driver.Title;
            Console.WriteLine($"The title of the site is: {title}''");
            Assert.AreEqual(_expecteAppLogoValue, title, $"Error. Expected value: {_expecteAppLogoValue}");

            var usernameField = _driver.FindElement(_usernameValue);
            usernameField.SendKeys("standard_user");

            var passwordField = _driver.FindElement(_passwordValue);
            passwordField.SendKeys("secret_sauce");

            var signInButton = _driver.FindElement(_loginButton);
            signInButton.Click();

            var actualAppLogo = _driver.FindElement(_appLogoValue).Text;

            Assert.AreEqual(_expecteAppLogoValue, actualAppLogo, $"Error. Expected value: {_expecteAppLogoValue}");
        }

        [TestCase("standard_user", "secret_sauce")]
        //[TestCase("locked_out_user", "secret_sauce")]
        [TestCase("problem_user", "secret_sauce")]
        [TestCase("performance_glitch_user", "secret_sauce")]
        [Test, Category("FireFox"), Category("Sepate example")]
        public void Test2(string username, string password)
        {
            int millisecondsToWait = 1000;
            Thread.Sleep(millisecondsToWait);

            string title = _driver.Title;
            Console.WriteLine($"The title of the site is: {title}''");
            Assert.AreEqual(_expecteAppLogoValue, title, $"Error. Expected value: {_expecteAppLogoValue}");

            var usernameField = _driver.FindElement(_usernameValue);
            usernameField.SendKeys(username);

            var passwordField = _driver.FindElement(_passwordValue);
            passwordField.SendKeys(password);

            var signInButton = _driver.FindElement(_loginButton);
            signInButton.Click();

            var actualAppLogo = _driver.FindElement(_appLogoValue).Text;

            Assert.AreEqual(_expecteAppLogoValue, actualAppLogo, $"Error. Expected value: {_expecteAppLogoValue}");
        }

        [TearDown]
        public void TearDown()
        {
            int millisecondsToWait = 3000;
            Thread.Sleep(millisecondsToWait);
            _driver.Close();
            _driver.Quit();
        }
    }
}
