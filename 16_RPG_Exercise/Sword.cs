using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Sword : Item
    {
        public int Damage;

        public Sword(string name, int price, int damage)
        {
            this.Name = name;
            this.Price = price;
            this.Damage = damage;
        }
    }
}
