namespace Supermarket_Kata
{
    public class SpecialPrice
    {
        public SpecialPrice()
        {
        }

        public SpecialPrice(int quantity, int price)
        {
            Quantity = quantity;
            Price = price;
        }

        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}