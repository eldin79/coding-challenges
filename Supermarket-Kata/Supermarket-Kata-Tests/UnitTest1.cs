using NUnit.Framework;
using Supermarket_Kata;
using System.Collections.Generic;

namespace Supermarket_Kata_Tests
{
    public class Tests
    {
        [Test]
        public void DefaultTest()
        {
            Assert.Pass();
        }

        [Test]
        public void SpecialPriceConstructorTest()
        {
            var sp = new SpecialPrice();
            Assert.IsInstanceOf<SpecialPrice>(sp);
            Assert.AreEqual(0, sp.Quantity);
            Assert.AreEqual(0, sp.Price);
        }

        [Test]
        public void SpecialPriceParameterizedConstructorTest()
        {
            var sp = new SpecialPrice(2, 45);
            Assert.IsInstanceOf<SpecialPrice>(sp);
            Assert.AreEqual(2, sp.Quantity);
            Assert.AreEqual(45, sp.Price);
        }

        [Test]
        public void ItemConstructorTest()
        {
            var i = new Item();
            Assert.AreEqual("", i.SKU);
            Assert.AreEqual(0, i.UnitPrice);
            Assert.IsInstanceOf<SpecialPrice>(i.SpecialPrice);
            Assert.AreEqual(0, i.SpecialPrice.Quantity);
            Assert.AreEqual(0, i.SpecialPrice.Price);
        }

        [Test]
        public void ItemParameterisedConstructorTest()
        {
            var i = new Item("A", 50, 2, 45);
            Assert.AreEqual("A", i.SKU);
            Assert.AreEqual(50, i.UnitPrice);
            Assert.IsInstanceOf<SpecialPrice>(i.SpecialPrice);
            Assert.AreEqual(2, i.SpecialPrice.Quantity);
            Assert.AreEqual(45, i.SpecialPrice.Price);
        }

        [Test]
        public void CheckoutTest()
        {
            var checkout = new Checkout();
            Assert.IsInstanceOf<Checkout>(checkout);
        }

        [Test]
        public void CheckoutHasScanMethodTest()
        {
            var checkout = new Checkout();
            Assert.IsInstanceOf<Checkout>(checkout);
            checkout.Scan("");
        }

        [Test]
        public void CheckoutHasGetTotalPriceMethodTest()
        {
            var checkout = new Checkout();
            Assert.IsInstanceOf<Checkout>(checkout);
            Assert.AreEqual(0, checkout.GetTotalPrice());
        }

        [Test]
        public void CheckoutHasGetSKUListMethodTest()
        {
            var checkout = new Checkout();
            Assert.IsInstanceOf<Checkout>(checkout);
            Assert.IsInstanceOf<List<Item>>(checkout.GetSKUList());
        }

        [Test]
        public void CheckoutHasAddSKUMethodTest()
        {
            var checkout = new Checkout();
            Assert.IsInstanceOf<Checkout>(checkout);
            var item = new Item("A", 50, 2, 45);
            checkout.AddSKU(item);
            var itemList = checkout.GetSKUList();
            var itemFromList = itemList[0];
            Assert.AreEqual("A", itemFromList.SKU);
            Assert.AreEqual(50, itemFromList.UnitPrice);
            Assert.AreEqual(2, itemFromList.SpecialPrice.Quantity);
            Assert.AreEqual(45, itemFromList.SpecialPrice.Price);
        }

        [Test]
        public void CheckoutHasSetSKUListMethodTest()
        {
            var checkout = new Checkout();
            Assert.IsInstanceOf<Checkout>(checkout);
            
            var item1 = new Item("A", 50, 3, 130);
            var item2 = new Item("B", 30, 2, 45);
            var itemList = new List<Item>();

            itemList.Add(item1);
            itemList.Add(item2);

            checkout.SetSKUList(itemList);

            var skuList = checkout.GetSKUList();
            var skuOne = skuList[0];
            var skuTwo = skuList[1];

            Assert.AreEqual("A", skuOne.SKU);
            Assert.AreEqual(50, skuOne.UnitPrice);
            Assert.AreEqual(3, skuOne.SpecialPrice.Quantity);
            Assert.AreEqual(130, skuOne.SpecialPrice.Price);

            Assert.AreEqual("B", skuTwo.SKU);
            Assert.AreEqual(30, skuTwo.UnitPrice);
            Assert.AreEqual(2, skuTwo.SpecialPrice.Quantity);
            Assert.AreEqual(45, skuTwo.SpecialPrice.Price);
        }

        [Test]
        public void CheckoutHasContainsItemMethodTest()
        {
            var checkout = new Checkout();
            var item1 = new Item("A", 50, 3, 130);
            checkout.AddSKU(item1);
            Assert.True(checkout.ContainsItem("A"));
            Assert.False(checkout.ContainsItem("B"));
        }

        [Test]
        public void ScannedItemConstructorTest()
        {
            var si = new ScannedItem();
            Assert.IsInstanceOf<ScannedItem>(si);
            Assert.IsInstanceOf<string>(si.SKU);
            Assert.IsInstanceOf<int>(si.Quantity);
            Assert.AreEqual("", si.SKU);
            Assert.AreEqual(0, si.Quantity);
        }

        [Test]
        public void ScannedItemParameterisedConstructorTest()
        {
            var si = new ScannedItem("A", 1);
            Assert.IsInstanceOf<ScannedItem>(si);
            Assert.IsInstanceOf<string>(si.SKU);
            Assert.IsInstanceOf<int>(si.Quantity);
            Assert.AreEqual("A", si.SKU);
            Assert.AreEqual(1, si.Quantity);
        }

        [Test]
        public void CheckoutHasGetScannedItemsListTest()
        {
            var checkout = new Checkout();
            Assert.IsInstanceOf<Checkout>(checkout);
            Assert.IsInstanceOf<List<ScannedItem>>(checkout.GetScannedItemsList());
        }

        [Test]
        public void CheckoutHasAddScannedItemMethodTest()
        {
            var checkout = new Checkout();
            Assert.IsInstanceOf<Checkout>(checkout);
            Assert.IsInstanceOf<List<ScannedItem>>(checkout.GetScannedItemsList());

            checkout.AddScannedItem("A");
            var si = checkout.GetScannedItemsList()[0];

            Assert.IsInstanceOf<ScannedItem>(si);
            Assert.AreEqual("A", si.SKU);
            Assert.AreEqual(1, si.Quantity);

            checkout.AddScannedItem("A");
            Assert.AreEqual("A", si.SKU);
            Assert.AreEqual(2, si.Quantity);
        }

        [Test]
        public void ScanMethodTest()
        {
            var checkout = new Checkout();
            var item1 = new Item("A", 50, 3, 130);
            var item2 = new Item("B", 30, 2, 45);
            var item3 = new Item("C", 20, 0, 0);
            var item4 = new Item("D", 15, 0, 0);

            checkout.AddSKU(item1);
            checkout.AddSKU(item2);
            checkout.AddSKU(item3);
            checkout.AddSKU(item4);

            checkout.Scan("A");
            Assert.AreEqual(50, checkout.GetTotalPrice());

            checkout.Scan("B");
            Assert.AreEqual(80, checkout.GetTotalPrice());

            checkout.Scan("A");
            Assert.AreEqual(130, checkout.GetTotalPrice());

            checkout.Scan("C");
            Assert.AreEqual(150, checkout.GetTotalPrice());

            checkout.Scan("B");
            Assert.AreEqual(165, checkout.GetTotalPrice());

            checkout.Scan("D");
            Assert.AreEqual(180, checkout.GetTotalPrice());

            checkout.Scan("A");
            Assert.AreEqual(210, checkout.GetTotalPrice());
        }
    }
}