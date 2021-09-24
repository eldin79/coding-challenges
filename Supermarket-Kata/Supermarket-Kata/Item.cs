namespace Supermarket_Kata
{
    public class Item
    {
        public Item()
        {
            SKU = "";
            SpecialPrice = new SpecialPrice();
        }

        public Item(string sku, int unitPrice, int spQuantity, int spPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;
            SpecialPrice = new SpecialPrice(spQuantity, spPrice);
        }

        public string SKU { get; set; }
        public int UnitPrice { get; set; }
        public SpecialPrice SpecialPrice { get; set; }
    }
}