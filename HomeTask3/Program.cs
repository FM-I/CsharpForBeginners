using System;

namespace HomeTask3
{
    class Program
    {
        /*Записаня книжка
        В себе содержит:
            Имя, номер телефона, возраст
        Функционал: 
            просмотр книжки
            добавление записи
            удаление записи */

        static void Main(string[] args)
        {
            string[] names = new string[3] { "Роман", "Максим", "Александр" };
            long[] phoneNumbers = new long[3] { 9991110001, 9991110002, 9991110003 };
            byte[] ages = new byte[3] { 24, 23, 27 };
            int entitiesCount = names.Length;
            bool shouldContinue = true;

            while (shouldContinue == true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("для просморта записной книжки нажмите (1)");
                Console.WriteLine("для добавления записи в книжку нажмите (2)");
                Console.WriteLine("для удаления записи в кнжику нажмите (3)");
                Console.WriteLine("длы выхода нажмите (0)");

                string userAnswer = Console.ReadLine();

                switch (userAnswer)
                {
                    case "1":                                                                       //Просмотр книжки
                        Console.WriteLine("Порядковый номер - Имя - номер телефона - возраст");
                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.WriteLine($" {i + 1} - {names[i]} - {phoneNumbers[i]} - {ages[i]}");
                        }
                        break;
                    case "2":                                                                       //Добалвение новой записи в книжку
                        entitiesCount++;

                        Array.Resize(ref names, entitiesCount);
                        Console.WriteLine("Введите имя");

                        names[entitiesCount - 1] = Console.ReadLine();

                        Array.Resize(ref phoneNumbers, entitiesCount);
                        Console.WriteLine("Введите номер телефона");

                        phoneNumbers[entitiesCount - 1] = Int64.Parse(Console.ReadLine());

                        Array.Resize(ref ages, entitiesCount);
                        Console.WriteLine("Введите возраст");

                        ages[entitiesCount - 1] = Byte.Parse(Console.ReadLine());

                        break;

                    case "3":                                                                           //Удаление записи из книжки
                        bool shouldRemove = true;

                        do
                        {
                            for (int i = 0; i < names.Length; i++)
                            {
                                Console.WriteLine($" {i + 1} - {names[i]} - {phoneNumbers[i]} - {ages[i]}");
                            }

                            Console.WriteLine("Для удаления записи введите порядковый номер записи");

                            int numberOfContact = Int32.Parse(Console.ReadLine());

                            if ((0 < numberOfContact) && (numberOfContact <= entitiesCount))
                            {
                                for (int i = numberOfContact; i < names.Length; i++)
                                {
                                    names[i - 1] = names[i];
                                    phoneNumbers[i - 1] = phoneNumbers[i];
                                    ages[i - 1] = ages[i];
                                }

                                entitiesCount--;

                                Array.Resize(ref names, entitiesCount);
                                Array.Resize(ref phoneNumbers, entitiesCount);
                                Array.Resize(ref ages, entitiesCount);
                                Console.WriteLine($"Вы успешно удалили запись номер {numberOfContact} из книжки");

                                shouldRemove = false;

                            }
                            else
                            {
                                Console.WriteLine("Вы ввели несуществующий номер");
                                Console.WriteLine("Выйти из функции удаления записей? (y/n) ");

                                string answer = Console.ReadLine();

                                if (answer == "y")
                                {
                                    shouldRemove = false;
                                }

                            }
                        } while (shouldRemove);

                        break;

                    case "0": //выход
                        shouldContinue = false;

                        return;

                    default:
                        Console.WriteLine("Вы нажали неизветсную цифру");

                        break;
                }
            }
        }
    }
}
