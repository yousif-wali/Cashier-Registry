using System.Collections.Generic;
using System.Linq;

namespace Cashier_Registry
{
    public static class Registration
    {
        private static List<Item> list = new List<Item>();
        public static void Add(Item item)
        {
            Item itemToUpdate = list.FirstOrDefault(i => i.Id == item.Id);
            if(itemToUpdate != null)
            {
                itemToUpdate.Amount += item.Amount;
                itemToUpdate.Price += item.Price;
            }
            else
            {
                list.Add(item);
            }
            
        }
        public static List<Item> getList()
        {
            return list;
        }
        public static void RemoveItem(Item item)
        {
            Item itemToRemove = list.FirstOrDefault(i => i.Id == item.Id);

            if (itemToRemove != null)
            {
                list.Remove(itemToRemove);
            }
        }
        public static void DecreaseItem(Item item)
        {
            Item itemToUpdate = list.FirstOrDefault(i => i.Id == item.Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.Amount -= item.Amount;
                itemToUpdate.Price -= item.Price;
            }
        }
        public static void Payment()
        {
            list.Clear();
        }
    }
}
