using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Inventory
    {
        public List<Item> Items = new List<Item>();

        public Inventory()
        {
            Sword rustySword = new Sword("Rusty sword", 0, 5);
            Items.Add(rustySword);
            Armor leatherArmor = new Armor("Leather armor", 10, 3);
            Items.Add(leatherArmor);
        }

        public void AddItem(Item item)
        {
            this.Items.Add(item);
        }
        public void RemoveItem(Item item)
        {
            this.Items.Remove(item);
        }
    }
}
