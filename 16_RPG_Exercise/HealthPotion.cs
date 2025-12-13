using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RPG_Exercise
{
    public class HealthPotion : Item
    {
        public int Healing { get; private set; }

        public HealthPotion(string name, int price, int healing) : base(name, price)
        {
            this.Healing = healing;
        }
        public void UsePotion(Hero character)
        {
            character.AddHealth(this.Healing);
        }
        public HealthPotion Clone()
        {
            return new HealthPotion(this.Name, this.Price, this.Healing);
        }
    }
}