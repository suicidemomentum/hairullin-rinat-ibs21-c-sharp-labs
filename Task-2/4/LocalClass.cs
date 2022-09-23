using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static int[,] GetArray(int minValue, int maxValue, int a, int b)
        {
            int[,] numbers = new int[a, b];

            Random random = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    numbers[i, j] = random.Next(minValue, maxValue);
                }
            }

            return numbers;
        }

        public static void PrintArray(int[,] numbers, int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < b; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
            }
        }

        public static int GetSumEvenPositions(int[,] numbers, int a, int b)
        {
            int sum = 0;

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += numbers[i, j];
                    }
                }
            }

            return sum;
        }
    }
}