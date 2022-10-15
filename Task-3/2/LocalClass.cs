using System;
using System.Text;

namespace LocalUtils
{
    internal static class LocalClass
    {
        internal static string NormalizeString(string s)
        { 
            StringBuilder temp = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    temp.Append(char.ToLower(s[i]));
                }
            }

            return temp.ToString();
        }

        internal static bool IsStringPalindrome(string s)
        {
            StringBuilder temp = new StringBuilder();

            for (int i = s.Length - 1; i > -1; i--)
            {
                temp.Append(s[i]);
            }

            return s.Equals(temp.ToString());
        }
    }
}
