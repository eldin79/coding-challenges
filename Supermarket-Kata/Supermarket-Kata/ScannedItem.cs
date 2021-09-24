namespace Supermarket_Kata
{
    public class ScannedItem
    {
        public ScannedItem()
        {
            SKU = "";
        }

        public ScannedItem(string sku, int quantity)
        {
            SKU = sku;
            Quantity = quantity;
        }

        public string SKU { get; set; }
        public int Quantity { get; set; }
    }
}