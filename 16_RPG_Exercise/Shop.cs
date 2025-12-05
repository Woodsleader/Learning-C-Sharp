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
            Sword steelSword = new Sword();
            steelSword.Name = "Steel sword";
            steelSword.Price = 100;
            steelSword.Damage = 25;
            Sword dragonSlayer = new Sword();
            dragonSlayer.Name = "Dragon slayer";
            dragonSlayer.Price = 1000;
            dragonSlayer.Damage = 50;
            Armor chainmail = new Armor();
            chainmail.Name = "Chainmail";
            chainmail.Price = 50;
            chainmail.ArmorStat = 10;
            Armor plateArmor = new Armor();
            plateArmor.Name = "Plate armor";
            plateArmor.Price = 1000;
            plateArmor.ArmorStat = 50;
            HealthPotion smallPotion = new HealthPotion();
            smallPotion.Name = "Small health potion";
            smallPotion.Price = 100;
            smallPotion.Healing = 25;
            HealthPotion largePotion = new HealthPotion();
            largePotion.Name = "Large health potion";
            largePotion.Price = 200;
            largePotion.Healing = 50;
            AvailableItems.Add(steelSword);
            AvailableItems.Add(dragonSlayer);
            AvailableItems.Add(chainmail);
            AvailableItems.Add(plateArmor);
            AvailableItems.Add(smallPotion);
            AvailableItems.Add(largePotion);
        }
    }
}
