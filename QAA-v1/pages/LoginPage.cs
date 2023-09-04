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
        private const string _username = "user-name";
        private const string _password = "password";
        private const string _loginButtonID = "login-button";

        private readonly By _usernameValue = By.Id(_username);
        private readonly By _passwordValue = By.Id(_password);
        private readonly By _loginButton = By.Id(_loginButtonID);

        public LoginPage(IWebDriver webDriver) => Driver = webDriver;

        private IWebDriver Driver { get; }

        IWebElement usernameField => Driver.FindElement(_usernameValue);
        IWebElement passwordField => Driver.FindElement(_passwordValue);
        IWebElement signInButton => Driver.FindElement(_loginButton);

        public void EnterUserName() => usernameField.SendKeys("standard_user");
        public void EnterPassword() => passwordField.SendKeys("secret_sauce");
        public void ClickSignInButton() => signInButton.Click();
        public void ClosePage() => Driver.Close();
    }
}
