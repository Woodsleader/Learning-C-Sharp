using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Shop
    {
        public Inventory ShopItems = new Inventory();
        public Shop()
        {
            Sword steelSword = new Sword("Steel sword", 100, 25);
            Sword dragonSlayer = new Sword("Dragon slayer", 1000, 50);
            ShopItems.AddItem(steelSword);
            ShopItems.AddItem(dragonSlayer);
            Armor chainmail = new Armor("Chainmail", 100, 10);
            Armor plateArmor = new Armor("Plate armor", 1000, 25);
            ShopItems.AddItem(chainmail);
            ShopItems.AddItem(plateArmor);
            HealthPotion smallPotion = new HealthPotion("Small healing potion", 50, 25);
            HealthPotion largePotion = new HealthPotion("Large healing potion", 100, 50);
            ShopItems.AddItem(smallPotion);
            ShopItems.AddItem(largePotion);
        }
        public void ShopBuy(Hero character)
        {
            Console.WriteLine("Available items:");
            for (int i = 0; i < this.ShopItems.Items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {this.ShopItems.Items[i].Name}: {this.ShopItems.Items[i].Price} gold coins");
                if (i == this.ShopItems)
            }
            Console.WriteLine("What item do you want to buy?");
            int userChoice = InputHelper.ReadInt(1, this.ShopItems.Items.Count);
            character.Backpack.AddItem(this.ShopItems.Items[userChoice]);
            this.ShopItems.RemoveItem(this.ShopItems.Items[userChoice]);
        }
    }
}
