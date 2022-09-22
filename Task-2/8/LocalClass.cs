using System;

namespace LocalUtils
{
    public static class LocalClass
    {
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

        public static void PrintSearchNumbers(int findNum, int[] numbers)
        {
            bool is_num = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == findNum)
                {
                    Console.Write(" " + i);
                    if (!is_num)
                    {
                        is_num = true;
                    }
                }
            }

            if (!is_num)
            {
                Console.Write(" не найдено");
            }
        }
    }
}