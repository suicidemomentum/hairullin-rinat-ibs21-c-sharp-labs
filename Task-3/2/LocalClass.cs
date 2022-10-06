using Microsoft.VisualBasic;
using System;
using System.Text;

namespace LocalUtils
{
    internal static class LocalClass
    {
        internal static string NormalizeString(string s) //сделано
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

        internal static bool IsStringPalindrome(string s) //сделано
        {
            string rev_s = Strings.StrReverse(s);

            return s.Equals(rev_s);
        }
    }
}
