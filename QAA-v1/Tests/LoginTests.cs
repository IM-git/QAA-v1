using NUnit.Framework;
using QAA_v1.pages;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA_v1.Tests
{
    [TestFixture]
    public class LoginTests
    {

        [Test, Category("Chrome"), Category("LoginPageTest1")]
        public void Login1()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.EnterUserName();
            loginPage.EnterPassword();
            loginPage.ClickSignInButton();


        }

        [Test, Category("Chrome"), Category("LoginPageTest2")]
        public void Login2()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.EnterUserName();
            loginPage.EnterPassword();
            loginPage.ClickSignInButton();


        }

        [Test, Category("Chrome"), Category("LoginPageTest3")]
        public void Login3()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.EnterUserName();
            loginPage.EnterPassword();
            loginPage.ClickSignInButton();


        }

        [Test, Category("Chrome"), Category("LoginPageTest4")]
        public void Login4()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.LoginOnPage();

        }
    }
}