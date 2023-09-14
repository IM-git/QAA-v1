﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using QAA_v1.pages;

namespace QAA_v1.Tests
{
    internal class InventoryTests : BaseTests
    {

        [Test, Category("Chrome"), Category("InventoryPageTests1")]
        public void CheckCartSauceLabsBackpackButton()
        {
            InventoryPage inventoryPage = new InventoryPage();
            LoginOnPage();
            inventoryPage.ClickAddToCartButton();
            //string value = inventoryPage.CheckExistShoppingCartBadgeItem();
            string value = GetStringValue(InventoryPage._shoppingCartBadge);
            CheckValue(value, "1");
        }

        [Test, Category("Chrome"), Category("InventoryPageTests2")]
        public void CheckCartSauceLabsBackpackItem()
        {
            InventoryPage inventoryPage = new InventoryPage();
            LoginOnPage();
            inventoryPage.ClickByInventoryItemSauceLabsBackpackItem();
        }

        [Test, Category("Chrome"), Category("InventoryPageTests3")]
        public void CheckShoppingCartLinkItem()
        {
            InventoryPage inventoryPage = new InventoryPage();
            LoginOnPage();
            inventoryPage.ClickByShoppingCartLinkItem();
            string value = GetStringValue(CartPage._yourCartTitle);
            CheckValue(value, "Your Cart");
        }
    }
}
