using Newtonsoft.Json;
using Shop.Controllers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;
using Shop.Models;

namespace Shop.View
{
    public static class Menu
    {
        public static void Show()
        {
            HttpResponseMessage responseMessage;
            
            using(var httpClient = new HttpClient())
            {

                do
                {
                    ShowMenu();

                    string operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "1":
                            {
                                var data = new StringContent(InputController.CreateProduct(), Encoding.UTF8, "application/json");
                                responseMessage = httpClient.PostAsync("http://localhost:8080/", data).Result;
                                //var responce = responseMessage.Content.ReadAsStringAsync().Result;


                                

                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Изменили товар");
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Удалили товар");
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Создали витрину");
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Изменили витрину");
                                break;
                            }
                        case "6":
                            {
                                Console.WriteLine("Удалили витрину");
                                break;
                            }
                        case "7":
                            {
                                
                                break;
                            }
                        case "8":
                            {
                                responseMessage = httpClient.GetAsync("http://localhost:8080/").Result;

                                var responce = responseMessage.Content.ReadAsStringAsync().Result;


                                var res = JsonConvert.DeserializeObject<List<Product>>(responce);


                                foreach (Product item in res)
                                {
                                    Console.WriteLine(item);
                                }


                                break;
                            }

                        case "0":
                            {
                                Console.WriteLine("Выход");
                                break;
                            }

                        default:
                            Console.WriteLine("Вы нажали неизветсную цифру");
                            break;
                    }
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadKey();
                    Console.Clear();

                } while (true);
            }
            

        }

        private static void ShowMenu()
        {
            Console.WriteLine("Добро пожаловать в магазин!");
            Console.WriteLine("1) Создать товар");
            Console.WriteLine("2) Изменить товар");
            Console.WriteLine("3) Удалить товар");
            Console.WriteLine("4) Создать витрину");
            Console.WriteLine("5) Изменить витрину");
            Console.WriteLine("6) Удалить витирну");
            Console.WriteLine("7) Разместить товар на витрине");
            Console.WriteLine("8) Просмотр товаров");
            Console.WriteLine("0) Выход");
            Console.Write("Введите номер операции, которую хотите совершить: ");
        }

        
    }
}
