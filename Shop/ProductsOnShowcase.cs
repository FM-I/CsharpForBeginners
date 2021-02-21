using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ProductsOnShowcase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ShowcaseId { get; set; }
        public string ShowcaseName { get; set; }
        public int Id { get; set; }
        public int Size { get; set; }
        public decimal Cost { get; set; }

        public void GetInfo()
        {
            Console.WriteLine(Id + ") " + "Название витрины: " + ShowcaseName + ", Название товара: " + ProductName + ", Объем: " + Size);
        }
    }
}
