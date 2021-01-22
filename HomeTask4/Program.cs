using System;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            bool shouldContinue = true;

            do
            {
                a = GetNumber();
                b = GetNumber();

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("для сложения чисел нажмите (1)");
                Console.WriteLine("для вычитания чисел нажмите (2)");
                Console.WriteLine("для умножения чисел нажмите (3)");
                Console.WriteLine("для деления чисел нажмите (4)");
                Console.WriteLine("для выхода нажмите (0)");

                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("a + b = " + (a + b));
                        break;
                    case "2":
                        Console.WriteLine("a - b = " + (a - b));
                        break;
                    case "3":
                        Console.WriteLine("a * b = " + (a * b));
                        break;
                    case "4":
                        Console.WriteLine("a / b = " + (a / b));
                        break;
                    default:
                        Console.WriteLine("Вы нажали неизвестную цифру");
                        break;
                }

                Console.WriteLine("Хотите продожить? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    shouldContinue = false;
                }
                else if (answer!="y")
                {
                    Console.WriteLine("Вы ввели неизместную букву");
                }
            } while (shouldContinue);
        }
        static double GetNumber()
        {
            double a;
            bool isNumber = true;

            do
            {
                string number;

                Console.WriteLine("Введите число:");

                number = Console.ReadLine();
                isNumber = Double.TryParse(number, out double value);

                if (!isNumber)
                {
                    Console.WriteLine("Вы ввели не число, попробуйте снова");
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("Вы успешно ввели число");
                    isNumber = false;
                }
                a = value;

            } while (isNumber);

            return a;
        }
    }
}
