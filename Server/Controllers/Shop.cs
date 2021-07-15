using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Shop
    {
        public ShopItemsList<Product> ProductList => _productList;
        

        private ShopItemsList<Product> _productList;
        private ShopItemsList<Showcase> _showcaseList;


        public Shop()
        {
            _productList = new ShopItemsList<Product>();
            _productList.Add(new Product("Простоквашино", 1));
            _productList.Add(new Product("Эссойла", 1));
            _productList.Add(new Product("Славмо", 2));
            _productList.Add(new Product("Окский", 2));
            _productList.Add(new Product("Шведские хлебцы", 1));
            _productList.Add(new Product("Батон нарезной", 1));
            _productList.Add(new Product("Батон к чаю", 1));

            _showcaseList = new ShopItemsList<Showcase>();

            _showcaseList.Add(new Showcase("Молочные продукты", 4));
            _showcaseList.Add(new Showcase("Хлеб", 10));

            ProductOnShowcaseList productOnShowcaseList = new ProductOnShowcaseList();


            //bool isContinue = true;

            //do
            //{
            //    ShowMenu();

            //    string operation = Console.ReadLine();

            //    switch (operation)
            //    {
            //        case "1":
            //            {
            //                _productList.Add(CreateProduct());
            //                break;
            //            }

            //        case "2":
            //            {
            //                Console.WriteLine("Изменили товар");
            //                break;
            //            }

            //        case "3":
            //            {
            //                Console.WriteLine("Удалили товар");
            //                break;
            //            }

            //        case "4":
            //            {
            //                Console.WriteLine("Создали витрину");
            //                break;
            //            }

            //        case "5":
            //            {
            //                Console.WriteLine("Изменили витрину");
            //                break;
            //            }

            //        case "6":
            //            {
            //                Console.WriteLine("Удалили витрину");
            //                break;
            //            }
            //        case "7":
            //            {
            //                _productList.GetList();

            //                Console.WriteLine("Введите порядковый номер товара для размещения на витрине");

            //                int productId = Int32.Parse(Console.ReadLine());
            //                ShopItem product = _productList.GetShopItem(productId);

            //                _showcaseList.GetList();

            //                Console.WriteLine("Введите порядковый номер витрины, на которую разместить товар");

            //                int showcaseId = Int32.Parse(Console.ReadLine());
            //                ShopItem showcase = _showcaseList.GetShopItem(showcaseId);

            //                ProductsOnShowcase productsOnShowcase = new ProductsOnShowcase();

            //                if (product.Size <= showcase.Size)
            //                {
            //                    productsOnShowcase.Size = product.Size;
            //                    productsOnShowcase.ProductName = product.Name;
            //                    productsOnShowcase.ProductId = productId;
            //                    productsOnShowcase.ShowcaseId = showcaseId;
            //                    productsOnShowcase.ShowcaseName = showcase.Name;

            //                    Console.Write("Введите стоимость товара: ");

            //                    decimal cost = decimal.Parse(Console.ReadLine());
            //                    productsOnShowcase.Cost = cost;
            //                }
            //                else Console.WriteLine("Этот товар не помещается на эту витрину, выберите другую витрину или создайте новую");

            //                productOnShowcaseList.PlaceProduct(productsOnShowcase);
            //                _showcaseList.ChangeShowcaseSize(showcaseId, product.Size);

            //                Console.WriteLine("Размеситили товар не витрине");

            //                productOnShowcaseList.GetList();
            //                break;
            //            }
            //        case "8":
            //            {
            //                _productList.GetList();
            //                _showcaseList.GetList();
            //                break;
            //            }

            //        case "0":
            //            {
            //                isContinue = false;
            //                Console.WriteLine("Выход");
            //                break;
            //            }

            //        default:
            //            Console.WriteLine("Вы нажали неизветсную цифру");
            //            break;
            //    }
            //    if (isContinue)
            //    {
            //        Console.WriteLine("Нажмите любую клавишу для продолжения");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }

            //} while (isContinue);

        }


    }
}
