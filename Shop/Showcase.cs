using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Showcase : ShopItem
    {
        public DateTime CreateDate { get; }
        public DateTime RemoveDate { get; set; }

        public Showcase(string name, int size) : base(name, size)
        {
            CreateDate = DateTime.Now;
        }

        public Showcase()
        {
        }

        public override void GetInfo()
        {
            Console.WriteLine(Id + ") " + "Название витрины: " + Name + ", Объем: " + Size);
        }
    }
}
