using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA_v1.pages
{
    public class CartPage
    {
        private IWebDriver _driver;
        public CartPage() => _driver = WebDriverSingleton.Instance;

        public const string _yourCartTitle = ".header_secondary_container .title";
    }
}
