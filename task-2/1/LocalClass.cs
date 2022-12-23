using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static int GetMax(int[] numbers)
        {
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        public static int GetMin(int[] numbers)
        {
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public static void SortMass(int[] numbers)
        {
            int temp;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

        }
    }
}