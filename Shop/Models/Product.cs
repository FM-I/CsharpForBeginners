using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return $"{Id} ) Название витрины: { Name }, Объем: {Size}";
        }

    }
}
