using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Shop
    {
        public List<Item> AvailableItems = new List<Item>();

        public Shop()
        {
            Sword steelSword = new Sword("Stel sword", 100, 25);
            Sword dragonSlayer = new Sword("Dragon slayer", 1000, 50);
            AvailableItems.Add(steelSword);
            AvailableItems.Add(dragonSlayer);
            AvailableItems.Add(chainmail);
            AvailableItems.Add(plateArmor);
            AvailableItems.Add(smallPotion);
            AvailableItems.Add(largePotion);
        }
    }
}
