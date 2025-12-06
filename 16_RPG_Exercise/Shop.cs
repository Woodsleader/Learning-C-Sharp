using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Shop
    {
        public List<Item> availableItems = new List<Item>();

        public Shop()
        {
            Sword steelSword = new Sword("Steel sword", 100, 25);
            Sword dragonSlayer = new Sword("Dragon slayer", 1000, 50);
            availableItems.Add(steelSword);
            availableItems.Add(dragonSlayer);
            Armor chainmail = new Armor("Chainmail", 100, 10);
            Armor plateArmor = new Armor("Plate armor", 1000, 25);
            availableItems.Add(chainmail);
            availableItems.Add(plateArmor);
            HealthPotion smallPotion = new HealthPotion("Small healing potion", 50, 25);
            HealthPotion largePotion = new HealthPotion("Large healing potion", 100, 50);
            availableItems.Add(smallPotion);
            availableItems.Add(largePotion);
        }

        public void CharacterBuys(Item itemToBuy, Hero character)
        {
            character.RemoveGold(itemToBuy.Price);
            character.Backpack.AddItem(itemToBuy);
            if (itemToBuy is not HealthPotion)
            {
                this.availableItems.Remove(itemToBuy);
            }
        }
        public void CharacterSells(Item itemToSell, Hero character)
        {
            this.availableItems.Add(itemToSell);
            character.AddGold(itemToSell.SellingPrice);
            character.Backpack.RemoveItem(itemToSell);
        }
    }
}
