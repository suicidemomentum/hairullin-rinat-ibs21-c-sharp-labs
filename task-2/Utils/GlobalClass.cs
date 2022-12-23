using System;

namespace GlobalUtils
{
    public static class GlobalClass
    {
        public static int[] GetArray(int minValue, int maxValue, int arrayLength)
        {
            Random random = new Random(); //объект для генерации

            int[] numbers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                numbers[i] = random.Next(minValue, maxValue); //диапазон генерации от до
            }

            return numbers;
        }

        public static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        public static int GetArraySize()
        {
            int n = 0;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("На вход принимаются только int значения и значения не больше чем " + int.MaxValue);
                }
                else if (n < 1)
                {
                    Console.WriteLine("Массив не может быть меньше единицы");
                }
                else
                {
                    break;
                }
            }

            return n;
        }

        public static int[] FullArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int element = 0;
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    if (!int.TryParse(Console.ReadLine(), out element))
                    {
                        Console.WriteLine("На вход принимаются только int значения и значения не больше чем " + int.MaxValue);
                        continue;
                    }
                    numbers[i] = element;
                    break;
                }
            }

            return numbers;
        }
    }
}