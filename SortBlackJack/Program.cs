using System;

namespace SortBlackJack
{
    class Program
    {
        private static int[] Shuffle(int[] cards)
        {
            int[] result = new int[cards.Length];

            Array.ConstrainedCopy(cards, 0, result, 0, cards.Length);

            Random random = new Random();

            for (int i = 0; i < cards.Length; i++)
            {
                
                int index = random.Next(0, cards.Length-i);
                int temp = result[index];

                result[index] = result[cards.Length - index]; //переносим выбранный элемент в конец массива
                result[cards.Length - index] = temp ;
                result[i] = cards[index];
                
            }
        }
}
