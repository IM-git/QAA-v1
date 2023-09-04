using NUnit.Framework;
using QAA_v1.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA_v1.Tests
{
    internal class LoginTests : BaseTests
    {

        [Test, Category("Chrome")]
        public void Login0()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUserName();
            loginPage.EnterPassword();
            loginPage.ClickSignInButton();


        }

        [Test, Category("Chrome")]
        public void Login1()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUserName();
            loginPage.EnterPassword();
            loginPage.ClickSignInButton();


        }

        [Test, Category("Chrome")]
        public void Login2()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUserName();
            loginPage.EnterPassword();
            loginPage.ClickSignInButton();


        }
    }
}