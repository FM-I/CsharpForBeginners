using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ShopItem
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }


        public ShopItem(string name, int size)
        {
            Name = name;
            Size = size;
            Id = 1;

        }

        public ShopItem()
        {
            Name = null;
            Size = 0;
            Id = 1;
        }
       public virtual void GetInfo()
        {

        }
    }
}
