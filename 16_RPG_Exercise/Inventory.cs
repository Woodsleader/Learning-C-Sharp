using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Inventory
    {
        public List<Item> characterInventory = new List<Item>();

        public Inventory()
        {
            Sword rustySword = new Sword("Rusty sword", 0, 5);
            characterInventory.Add(rustySword);
            Armor leatherArmor = new Armor("Leather armor", 10, 3);
            characterInventory.Add(leatherArmor);
        }

        public void AddItem(Item item)
        {
            this.characterInventory.Add(item);
        }
        public void SellItem(Item item, Hero heroRecievingGold)
        {
            this.characterInventory.Remove(item);
            heroRecievingGold.Gold += item.Price;
        }
    }
}
