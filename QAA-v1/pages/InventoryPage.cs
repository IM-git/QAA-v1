using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAA_v1.pages
{
    public class InventoryPage
    {
        public const string _addToCartSauceLabsBackpackButtonID = "add-to-cart-sauce-labs-backpack";

        public const string _inventoryItemSauceLabsBackpack = "(// div[@class =\"inventory_item_name\"])[1]";
        public const string _inventoryItem2 = "(// div[@class =\"inventory_item_name\"])[2]";
        public const string _inventoryItem3 = "(// div[@class =\"inventory_item_name\"])[3]";
        public const string _inventoryItem4 = "(// div[@class =\"inventory_item_name\"])[4]";
        public const string _inventoryItem5 = "(// div[@class =\"inventory_item_name\"])[5]";
        public const string _inventoryItem6 = "(// div[@class =\"inventory_item_name\"])[6]";

        public const string _shoppingCartLink = ".shopping_cart_link";
        public const string _shoppingCartBadge = ".shopping_cart_badge";


        private readonly By _addToCartSauceLabsBackpackButtonIDValue = By.Id(_addToCartSauceLabsBackpackButtonID);
        private readonly By _inventoryItemSauceLabsBackpackItemXpath = By.XPath(_inventoryItemSauceLabsBackpack);
        private readonly By _shoppingCartBadgeClass = By.ClassName(_shoppingCartBadge);
        private readonly By _shoppingCartLinkCssSelector = By.CssSelector(_shoppingCartLink);

        public InventoryPage(IWebDriver webDriver) => driver = webDriver;
        public IWebDriver driver { get; }

        IWebElement addToCartSauceLabsBackpackButtonField => driver.FindElement(_addToCartSauceLabsBackpackButtonIDValue);
        IWebElement inventoryItemSauceLabsBackpackItemXpathField => driver.FindElement(_inventoryItemSauceLabsBackpackItemXpath);
        IWebElement shoppingCartBadgeItem => driver.FindElement(_shoppingCartBadgeClass);
        IWebElement shoppingCartLinkItem => driver.FindElement(_shoppingCartLinkCssSelector);

        public void ClickAddToCartButton() => addToCartSauceLabsBackpackButtonField.Click();
        public void ClickByInventoryItemSauceLabsBackpackItem() => inventoryItemSauceLabsBackpackItemXpathField.Click();
        public void ClickByShoppingCartLinkItem() => shoppingCartLinkItem.Click();
        public string CheckExistShoppingCartBadgeItem() => shoppingCartBadgeItem.Text;
    }
}
