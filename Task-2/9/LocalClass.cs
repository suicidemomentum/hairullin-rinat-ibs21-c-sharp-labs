using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static bool IsElementRepeatInArray(int i, int number, int[] numbers)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] == number)
                {
                    return true;
                }
            }

            return false;
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
                    else if (IsElementRepeatInArray(i, element, numbers))
                    {
                        Console.Write("Замечено повторение\n");
                        continue;
                    }
                    numbers[i] = element;
                    break;
                }
            }

            return numbers;
        }

        public static bool IsSameArrays(int[] f_numbers, int[] s_numbers)
        {
            Array.Sort(f_numbers);
            Array.Sort(s_numbers);

            for (int i = 0; i < f_numbers.Length; i++)
            {
                if (f_numbers[i] != s_numbers[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}