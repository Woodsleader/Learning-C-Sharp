using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RPG_Exercise
{
    public class HealthPotion : Item
    {
        public int Healing;

        public HealthPotion(string name, int price, int healing)
        {
            this.Name = name;
            this.Price = price;
            this.Healing = healing;
        }
    }
}
