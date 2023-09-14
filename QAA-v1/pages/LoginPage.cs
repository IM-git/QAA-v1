using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA_v1.pages
{
    internal class LoginPage
    {
        private const string _username = "standard_user";
        private const string _password = "secret_sauce";

        private const string _usernameID = "user-name";
        private const string _passwordID = "password";
        private const string _loginButtonID = "login-button";

        private readonly By _usernameValue = By.Id(_usernameID);
        private readonly By _passwordValue = By.Id(_passwordID);
        private readonly By _loginButton = By.Id(_loginButtonID);

        //public LoginPage(IWebDriver webDriver) => driver = webDriver;

        //public IWebDriver driver { get; }
        private IWebDriver _driver;
        public LoginPage() => _driver = WebDriverSingleton.Instance;

        IWebElement usernameField => _driver.FindElement(_usernameValue);
        IWebElement passwordField => _driver.FindElement(_passwordValue);
        IWebElement signInButton => _driver.FindElement(_loginButton);

        public void EnterUserName() => usernameField.SendKeys(_username);
        public void EnterPassword() => passwordField.SendKeys(_password);
        public void ClickSignInButton() => signInButton.Click();
        public void ClosePage() => _driver.Close();

        public void LoginOnPage()
        {
            EnterUserName();
            EnterPassword();
            ClickSignInButton();
        }
    }
}
