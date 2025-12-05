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
        public int Gold = 0;
        public int Attack = 10;
        public int Armor = 5;
        public int Evasion = 0;

        public void AddGold(int goldAmount)
        {
            this.Gold += goldAmount;
        }
        public void RemoveGold(int goldAmount)
        {
            this.Gold += goldAmount;
        }
    }
}
