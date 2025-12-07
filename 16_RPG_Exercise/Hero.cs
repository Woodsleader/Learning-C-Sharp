using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Hero
    {
        public string Name;
        public int Health = 100;
        public int Level = 1;
        public int Experience = 0;
        public int Gold = 1000;
        public int Attack = 10;
        public int Armor = 5;
        public int Evasion = 0;

        public Inventory Backpack = new Inventory();

        public Hero()
        {
            Sword rustySword = new Sword("Rusty sword", 0, 5);
            this.Backpack.AddItem(rustySword);
            Armor leatherArmor = new Armor("Leather armor", 10, 3);
            this.Backpack.AddItem(leatherArmor);
        }

        //Add/remove gold
        public void AddGold(int amount)
        {
            this.Gold += amount;
        }
        public void RemoveGold(int amount)
        {
            this.Gold -= amount;
        }
        //Add/remove health
        public void AddHealth(int amount)
        {
            this.Health += amount;
        }
        public void RemoveHealth(int amount)
        {
            this.Health -= amount;
        }
    }
}
