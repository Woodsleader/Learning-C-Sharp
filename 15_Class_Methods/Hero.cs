using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Class_Methods
{
    public class Hero
    {
        public string Name;
        public int Health;

        public void Heal(int amount)
        {
            this.Health += amount;
        }
        public void TakeDamage(int amount)
        {
            this.Health -= amount;
            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }
    }
}
