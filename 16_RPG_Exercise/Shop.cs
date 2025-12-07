using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Shop
    {
        public Inventory shopItems = new Inventory();
        public Shop()
        {
            Sword steelSword = new Sword("Steel sword", 100, 25);
            Sword dragonSlayer = new Sword("Dragon slayer", 1000, 50);
            shopItems.AddItem(steelSword);
            shopItems.AddItem(dragonSlayer);
            Armor chainmail = new Armor("Chainmail", 100, 10);
            Armor plateArmor = new Armor("Plate armor", 1000, 25);
            shopItems.AddItem(chainmail);
            shopItems.AddItem(plateArmor);
            HealthPotion smallPotion = new HealthPotion("Small healing potion", 50, 25);
            HealthPotion largePotion = new HealthPotion("Large healing potion", 100, 50);
            shopItems.AddItem(smallPotion);
            shopItems.AddItem(largePotion);
        }

        public void CharacterBuys(Item itemToBuy, Hero character)
        {
            if (itemToBuy.Price <= character.Gold)
            {
                character.RemoveGold(itemToBuy.Price);
                character.Backpack.AddItem(itemToBuy);
                if (itemToBuy is not HealthPotion)
                {
                    this.shopItems.RemoveItem(itemToBuy);
                }
            }
            else
            {
                Console.WriteLine($"You need {itemToBuy.Price - character.Gold} gold more to affort the item!");
            }
        }
        public void CharacterSells(Item itemToSell, Hero character)
        {
            this.shopItems.AddItem(itemToSell);
            character.AddGold(itemToSell.SellingPrice);
            character.Backpack.RemoveItem(itemToSell);
        }
    }
}
