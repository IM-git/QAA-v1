using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA_v1.pages
{
    internal class InventoryPage
    {
        private const string _addToCartSauceLabsBackpackButtonID = "add-to-cart-sauce-labs-backpack";

        private const string _inventoryItemSauceLabsBackpack = "(// div[@class =\"inventory_item_name\"])[1]";
        private const string _inventoryItem2 = "(// div[@class =\"inventory_item_name\"])[2]";
        private const string _inventoryItem3 = "(// div[@class =\"inventory_item_name\"])[3]";
        private const string _inventoryItem4 = "(// div[@class =\"inventory_item_name\"])[4]";
        private const string _inventoryItem5 = "(// div[@class =\"inventory_item_name\"])[5]";
        private const string _inventoryItem6 = "(// div[@class =\"inventory_item_name\"])[6]";

        private readonly By _addToCartSauceLabsBackpackButtonIDValue = By.Id(_addToCartSauceLabsBackpackButtonID);

        private readonly By _InventoryItemSauceLabsBackpackItemXpath = By.XPath(_inventoryItemSauceLabsBackpack);

        public InventoryPage(IWebDriver webDriver) => driver = webDriver;
        public IWebDriver driver { get; }

        IWebElement addToCartSauceLabsBackpackButtonField => driver.FindElement(_addToCartSauceLabsBackpackButtonIDValue);
        IWebElement inventoryItemSauceLabsBackpackItemXpathField => driver.FindElement(_InventoryItemSauceLabsBackpackItemXpath);
        public void ClickAddToCartButton() => addToCartSauceLabsBackpackButtonField.Click();
        public void ClickByInventoryItemSauceLabsBackpackItem() => inventoryItemSauceLabsBackpackItemXpathField.Click();
    }
}
