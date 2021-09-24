using System;

namespace Supermarket_Kata
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Stock Keeping Unit list for the Week:");
            Console.WriteLine("SKU \t Unit Price \t Special Price");
            foreach (var item in checkout.GetSKUList())
            {
                Console.Write(item.SKU + " \t " + item.UnitPrice + " \t\t ");
                if (item.SpecialPrice.Quantity > 0)
                    Console.Write(item.SpecialPrice.Quantity + " for " +
                        item.SpecialPrice.Price);
                Console.Write("\n");
            }
            Console.WriteLine("\n");

            Console.Write("Scanning items:");
            Console.WriteLine("\nScan item A");
            checkout.Scan("A");
            Console.WriteLine("Total Price: " + checkout.GetTotalPrice());

            Console.WriteLine("\nScan item B");
            checkout.Scan("B");
            Console.WriteLine("Total Price: " + checkout.GetTotalPrice());

            Console.WriteLine("\nScan item A");
            checkout.Scan("A");
            Console.WriteLine("Total Price: " + checkout.GetTotalPrice());

            Console.WriteLine("\nScan item C");
            checkout.Scan("C");
            Console.WriteLine("Total Price: " + checkout.GetTotalPrice());

            Console.WriteLine("\nScan item B");
            checkout.Scan("B");
            Console.WriteLine("Total Price: " + checkout.GetTotalPrice());

            Console.WriteLine("\nScan item D");
            checkout.Scan("D");
            Console.WriteLine("Total Price: " + checkout.GetTotalPrice());

            Console.WriteLine("\nScan item A");
            checkout.Scan("A");
            Console.WriteLine("Total Price: " + checkout.GetTotalPrice());


        }
    }
}
