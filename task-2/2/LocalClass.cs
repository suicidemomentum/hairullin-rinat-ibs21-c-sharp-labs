using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static int[,,] GetArray(int minValue, int maxValue, int a, int b, int c)
        {
            Random random = new Random(); //объект для генерации

            int[,,] numbers = new int[a, b, c];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int g = 0; g < c; g++)
                    {
                        numbers[i, j, g] = random.Next(minValue, maxValue); //диапазон генерации от до
                    }
                }
            }

            return numbers;
        }

        public static void PrintArray(int[,,] numbers, int a, int b, int c)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < b; j++)
                {
                    Console.Write("\n");
                    for (int g = 0; g < c; g++)
                    {
                        Console.Write(numbers[i, j, g] + " ");
                    }
                }
            }
        }

        public static void ChangeArray(int[,,] numbers, int a, int b, int c)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int g = 0; g < c; g++)
                    {
                        if (numbers[i, j, g] > 0)
                        {
                            numbers[i, j, g] = 0;
                        }
                    }
                }
            }
        }
    }
}