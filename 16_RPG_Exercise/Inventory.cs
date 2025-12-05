using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Inventory
    {
        public List<Item> Items = new List<Item>();

        public void AddItem(Item item)
        {
            this.Items.Add(item);
        }
        public void SellItem(Item item, Hero heroRecievingGold)
        {
            this.Items.Remove(item);
            heroRecievingGold.Gold += item.Price;
        }
    }
}
