using System;
using System.Collections.Generic;
using System.Text;

namespace _16_RPG_Exercise
{
    public class Item
    {
        public string Name;
        public int Price;
        public int SellingPrice => Price / 2;
        public Item(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
