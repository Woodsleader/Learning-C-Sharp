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
        //Buy items
        public void ShopBuy(Hero character)
        {
            Console.WriteLine("Available items:");
            for (int i = 0; i < this.ShopItems.Items.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {this.ShopItems.Items[i].Name}: {this.ShopItems.Items[i].Price} gold coins");
            }
            Console.WriteLine($"{this.ShopItems.Items.Count + 1} - Leave");
            Console.WriteLine("What item do you want to buy?");
            int userChoice = InputHelper.ReadInt(1, this.ShopItems.Items.Count + 1) - 1;
            if (userChoice == this.ShopItems.Items.Count)
            {
                return;
            }
            if (character.EnoughGold(this.ShopItems.Items[userChoice].Price))
            {
                if (this.ShopItems.Items[userChoice] is HealthPotion)
                {
                    if
                }
                character.Backpack.AddItem(this.ShopItems.Items[userChoice]);
                character.RemoveGold(this.ShopItems.Items[userChoice].Price);
                if (this.ShopItems.Items[userChoice] is Sword || this.ShopItems.Items[userChoice] is Armor)
                {
                    this.ShopItems.RemoveItem(this.ShopItems.Items[userChoice]);
                }
            }
            else
            {
                Console.WriteLine($"You don't have enough gold! {this.ShopItems.Items[userChoice].Price - character.Gold} gold pieces missing.");
            }
        }
        
        //Sell items
        public void ShopSell(Hero character)
        {
            if (character.Backpack.Items.Count >= 1)
            {
                Console.WriteLine("Choose wich item to sell: ");
                for (int i = 0; i < character.Backpack.Items.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {character.Backpack.Items[i].Name} {character.Backpack.Items[i].SellingPrice} gold coins.");
                }
                Console.WriteLine($"{character.Backpack.Items.Count + 1} - Leave.");
                int userChoice = InputHelper.ReadInt(1, character.Backpack.Items.Count + 1) - 1;
                if (userChoice == character.Backpack.Items.Count)
                {
                    return;
                }
                this.ShopItems.AddItem(character.Backpack.Items[userChoice]);
                character.AddGold(character.Backpack.Items[userChoice].SellingPrice);
                if (character.Backpack.Items[userChoice] is Sword || character.Backpack.Items[userChoice] is Armor)
                character.Backpack.RemoveItem(character.Backpack.Items[userChoice]);
            }
            else
            {
                Console.WriteLine("You don't have anything to sell!");
                return;
            }
        }
    }
}
