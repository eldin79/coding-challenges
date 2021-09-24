using System.Collections.Generic;

namespace Supermarket_Kata
{
    public interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
        List<Item> GetSKUList();
        void AddSKU(Item item);
        void SetSKUList(List<Item> itemList);
        bool ContainsItem(string item);
    }
}