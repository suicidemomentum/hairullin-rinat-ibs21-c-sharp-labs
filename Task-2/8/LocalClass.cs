using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static void PrintSearchNumbers(int[] numbers)
        {
            Console.Write("Вхождения искомого числа: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        public static int GetSearchNumber()
        {
            int findNum;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out findNum))
                {
                    Console.WriteLine("На вход принимаются только int значения и значения не больше чем " + int.MaxValue);
                }
                break;
            }

            return findNum;
        }

        public static int[] GetIndexesOfSearchNumbers(int findNum, int[] numbers)
        {
            int size = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == findNum)
                {
                    size++;
                }
            }

            int[] indexes = new int[size];
            int ind = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == findNum)
                {
                    indexes[ind] = i;
                    ind++;
                }
            }

            return indexes;
        }
    }
}