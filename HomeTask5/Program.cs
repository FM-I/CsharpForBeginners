using System;
using System.Collections.Generic;

namespace HomeTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[3] { "Роман", "Максим", "Александр" };
            //string[] phones = new string[3] { "9991110001", "9991110002", "9991110003" };
            //byte[] ages = new byte[3] { 24, 23, 27 };
            //int entitiesCount = names.Length;
            List<Contact> contacts = new List<Contact>(3);
            contacts.Add(new Contact("Роман", "9991110001", 24));
            contacts.Add(new Contact("Максим", "9991110002", 23));
            contacts.Add(new Contact("Александр", "9991110003", 27));

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("для просморта записной книжки нажмите (1)");
                Console.WriteLine("для добавления записи в книжку нажмите (2)");
                Console.WriteLine("для удаления записи в кнжику нажмите (3)");
                Console.WriteLine("длы выхода нажмите (0)");

                string userAnswer = Console.ReadLine();

                switch (userAnswer)
                {
                    case "1":
                        DisplayNotes(contacts);
                        break;
                    case "2":
                        AddNote(contacts);
                        break;

                    case "3":                                                                           //удаление записи из книжки
                        RemoveNote(contacts);
                        break;

                    case "0": //выход
                        return;

                    default:
                        Console.WriteLine("Вы нажали неизветсную цифру");

                        break;
                }
            }
        }
        static void DisplayNotes(List<Contact> contacts)
        {
            Console.WriteLine("Имя - номер телефона - возраст");
            contacts.ForEach(delegate (Contact contact)
            {
                contact.Get();
            });

        }
        static void AddNote(List<Contact> contacts)
        {
            Contact contact = new Contact();
            contact.Add();
            contacts.Add(contact);
        }
        static void RemoveNote(List<Contact> contacts)
        {
            bool shouldRemove = true;

            do
            {
                Console.WriteLine("Порядковый номер - Имя - номер телефона - возраст");
                int entitiesCount = 1;
                contacts.ForEach(delegate (Contact contact)
                {
                    Console.Write(entitiesCount + " - ");
                    contact.Get();
                    entitiesCount++;
                });

                Console.WriteLine("Для удаления записи введите порядковый номер");

                int i = Int32.Parse(Console.ReadLine());

                if (i<entitiesCount)
                { 
                contacts.RemoveAt(i - 1);

                Console.WriteLine("Вы успешно удалили запись");

                    shouldRemove = false;
                }
                else 
                {
                    Console.WriteLine("Вы ввели недопустимый порядковый номер, попробуйте еще раз");
                }

            } while (shouldRemove);
        }

    }
}
