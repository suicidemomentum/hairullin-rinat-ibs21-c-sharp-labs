using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static int[] ReverseSortArray(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);

            return numbers;
        }
    }
}