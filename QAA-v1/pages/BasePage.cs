using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA_v1.pages
{
    public class BasePage
    {
        public IWebDriver _driver;
        public BasePage() => _driver = WebDriverSingleton.Instance;

        public const string _testwebsite = "https://www.saucedemo.com/";
    }
}
