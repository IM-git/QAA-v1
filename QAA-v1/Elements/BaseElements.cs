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
        protected By Locator { get; }
        protected string Name { get; }
        //protected IWebElement FindElement()
        //{
        //}
    }
}
