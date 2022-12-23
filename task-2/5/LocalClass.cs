using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static int[] RemoveNegativeElements(int[] f_numbers)
        {
            int size = 0;

            for (int i = 0; i < f_numbers.Length; i++)
            {
                if (f_numbers[i] > 0)
                {
                    size++;
                }
            }

            int[] s_numbers = new int[size];

            int index = 0;

            for (int i = 0; i < f_numbers.Length; i++)
            {
                if (f_numbers[i] > 0)
                {
                    s_numbers[index] = f_numbers[i];
                    index++;
                }
            }

            return s_numbers;
        }
    }
}