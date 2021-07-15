using System;

namespace Shop
{
    public class Product : ShopItem
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
