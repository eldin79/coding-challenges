using System.Collections.Generic;

namespace Supermarket_Kata
{
    public class Checkout : ICheckout
    {
        private int totalPrice;

        private List<Item> skuList;
        private List<ScannedItem> scannedItemsList;

        public Checkout()
        {
            skuList = new List<Item>();
            scannedItemsList = new List<ScannedItem>();
        }

        public void Scan(string item)
        {
            if (ContainsItem(item))
            {
                AddScannedItem(item);
            }
        }

        public int GetTotalPrice()
        {
            totalPrice = 0;
            foreach (var scannedItem in scannedItemsList)
            {
                foreach (var item in skuList)
                {
                    if (item.SKU == scannedItem.SKU)
                    {
                        if (item.SpecialPrice.Quantity > 0)
                        {
                            if (scannedItem.Quantity >= item.SpecialPrice.Quantity)
                            {
                                var numTimesApplyOffer = scannedItem.Quantity / item.SpecialPrice.Quantity;
                                var numToChargeSingle = scannedItem.Quantity - (item.SpecialPrice.Quantity / numTimesApplyOffer);
                                totalPrice += item.SpecialPrice.Price * numTimesApplyOffer;
                                totalPrice += item.UnitPrice * numToChargeSingle;
                            }
                            else
                            {
                                totalPrice += item.UnitPrice * scannedItem.Quantity;
                            }
                        }
                        else
                        {
                            totalPrice += item.UnitPrice * scannedItem.Quantity;
                        }
                        break;
                    }
                }
            }
            return totalPrice;
        }

        public List<Item> GetSKUList()
        {
            return skuList;
        }

        public void AddSKU(Item item)
        {
            skuList.Add(item);
        }

        public void SetSKUList(List<Item> itemList)
        {
            foreach (var item in itemList)
                skuList.Add(item);
        }

        public bool ContainsItem(string item)
        {
            var result = false;

            foreach(var sku in skuList)
            {
                if (sku.SKU.Equals(item))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public List<ScannedItem> GetScannedItemsList()
        {
            return scannedItemsList;
        }

        public void AddScannedItem(string item)
        {
            foreach (var scannedItem in scannedItemsList)
            {
                if (scannedItem.SKU.Equals(item))
                {
                    scannedItem.Quantity++;
                    return;
                }
            }
            scannedItemsList.Add(new ScannedItem(item, 1));
        }
    }
}