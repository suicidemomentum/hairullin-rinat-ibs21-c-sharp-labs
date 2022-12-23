using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static int GetSumPositiveNumbers(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }
    }
}