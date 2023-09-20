using NUnit.Framework;
using OpenQA.Selenium;
using QAA_v1.pages;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAA_v1.Tests
{
    [TestFixture]
    public class LoginTests : BaseTests
    {
        //[TestCase("locked_out_user", "secret_sauce")]
        [TestCase("standard_user", "secret_sauce")]
        [TestCase("problem_user", "secret_sauce")]
        [TestCase("performance_glitch_user", "secret_sauce")]
        [Test, Category("Chrome"), Category("LoginPageTest1")]
        public void Login1(string username, string password)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.EnterUserName(username);
            loginPage.EnterPassword(password);
            loginPage.ClickSignInButton();
        }
    }
}