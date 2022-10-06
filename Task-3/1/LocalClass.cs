using System;

namespace LocalUtils
{
    public static class LocalClass
    {
        public static string[] GetSplittedString(string s)
        {
            return s.Split(new char[] { ' ', ',', ':', '.', '!', '?', '-', '(', ')', '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static double GetAverageWordLength(string[] mas)
        {
            int allWordLength = 0;

            foreach (string b in mas)
            {
                allWordLength += b.Length;
            }

            if (mas.Length > 0) //need check because we cant divide on zero
            {
                return (double)allWordLength / mas.Length;
            }
            else
            {
                return 0;
            }
        }
    }
}

