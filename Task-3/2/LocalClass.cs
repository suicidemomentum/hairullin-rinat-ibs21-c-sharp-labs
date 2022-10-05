using System;

namespace LocalUtils
{
    internal static class LocalClass
    {
        internal static string NormalizeString(string s)
        { 
            return (s.Replace(" ", "")).ToLower();
        }

        internal static bool IsStringPalindrome(string s)
        {
            int j = s.Length - 1;

            for (int i = 0; i <= j; i++)
            {
                if (s[i] != s[j])
                {
                    return false;
                }

                j--;
            }

            return true;
        }
    }
}
