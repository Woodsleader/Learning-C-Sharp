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
            Sword steelSword = new Sword("Steel sword", 100, 25);
            Sword dragonSlayer = new Sword("Dragon slayer", 1000, 50);
            AvailableItems.Add(steelSword);
            AvailableItems.Add(dragonSlayer);
            Armor chainmail = new Armor("Chainmail", 100, 10);
            Armor plateArmor = new Armor("Plate armor", 1000, 25);
            AvailableItems.Add(chainmail);
            AvailableItems.Add(plateArmor);
            HealthPotion smallPotion = new HealthPotion("Small healing potion", 50, 25);
            HealthPotion largePotion = new HealthPotion("Large healing potion", 100, 50);
            AvailableItems.Add(smallPotion);
            AvailableItems.Add(largePotion);
        }
    }
}
