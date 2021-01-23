using System;
using System.Text;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] cards = new int[]
            {
                2, 3, 4, 5, 6, 7, 8, 9, 10, // - цифры
                10, 10, 10, // - картинки
                11, // - туз

                2, 3, 4, 5, 6, 7, 8, 9, 10, // - цифры
                10, 10, 10, // - картинки
                11, // - туз

                2, 3, 4, 5, 6, 7, 8, 9, 10, // - цифры
                10, 10, 10, // - картинки
                11, // - туз

                2, 3, 4, 5, 6, 7, 8, 9, 10, // - цифры
                10, 10, 10, // - картинки
                11, // - туз
            };

            cards = Shuffle(cards);

            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine(cards[i]);
            }

            Console.WriteLine();

            //cards = Shuffle(cards);
            //cards = Shuffle(cards);

            //bool isPlayerContinue = true;
            //bool isComputerContinue = true;

            //Random random = new Random();

            //do
            //{
            //    isPlayerContinue = AskPlayer(isPlayerContinue);

            //    isComputerContinue = AskComputer(isComputerContinue, random);

            //} while (isPlayerContinue || isComputerContinue);
        }

        private static int[] Shuffle(int[] cards)
        {
            Random random = new Random();

            int l = cards.Length;

            for (int i = 0; i < l; i++)
            {
                int index = random.Next(0, l - i);
                int temp = cards[index];

                cards[index] = cards[l - index - 1]; //переносим выбранный элемент в конец массива
                cards[l - index - 1] = temp;
            }

            return cards;
        }

        private static bool Contains(int[] values, int value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == value)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool AskComputer(bool isComputerContinue, Random random)
        {
            int decisionNumber = 0;

            if (isComputerContinue)
            {
                decisionNumber = random.Next(0, 2);
            }

            if (decisionNumber == 0)
            {
                Console.WriteLine("Компьютер тянет карту");
            }

            if (decisionNumber == 1)
            {
                Console.WriteLine("Компьютер пасует");
                isComputerContinue = false;
            }

            return isComputerContinue;
        }

        private static bool AskPlayer(bool isPlayerContinue)
        {
            Console.WriteLine("Будешь тянуть карту? (y/n)");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine("Вы тянете карту");
            }

            if (answer == "n")
            {
                Console.WriteLine("Вы пасуете");
                isPlayerContinue = false;
            }



            return isPlayerContinue;
        }
    }
}