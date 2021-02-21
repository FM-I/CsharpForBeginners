using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Product : ShopItem
    {
        public Product(string name, int size) : base(name, size)
        {

        }

        public Product()
        {

        }

        public override void GetInfo()
        {
            Console.WriteLine(Id + ") " + "Название витрины: " + Name + ", Объем: " + Size);
        }
    }
}
