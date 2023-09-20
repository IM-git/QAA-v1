using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA_v1.Elements
{
    public abstract class BaseElements
    {
        private IWebDriver _driver;
        protected By Locator { get; }
        protected string Name { get; }

        public void CheckValue(string value, string checker)
        {
            Assert.AreEqual(checker, value, $"Error. Expected value: {value}");
        }
        public object FindElement(string CssValue) => _driver.FindElement(By.CssSelector(CssValue));

        public string GetStringValue(string CssValue) => _driver.FindElement(By.CssSelector(CssValue)).Text;

        //protected IWebElement FindElement()
        //{
        //}
    }
}
