using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Controllers
{
    public static class InputController
    {
        public static string CreateProduct()
        {
            Console.Write("Введите название продукта: ");
            string _name = Console.ReadLine();

            Console.Write("Введите объем: ");
            int _size = Int32.Parse(Console.ReadLine());

            return JsonConvert.SerializeObject(new { name = _name, size = _size });
        }
    }
}
