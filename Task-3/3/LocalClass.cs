using System;
using System.Text.RegularExpressions;

namespace LocalUtils
{
    internal static class LocalClass
    {
        internal static bool IsStringEmail(string s)
        {
            string pattern = @"(^[a-zA-Z0-9]+[a-zA-Z0-9\.\-_]+[a-zA-Z0-9]+@[a-zA-Z0-9\.\-_]+\.[a-zA-Z]{2,6})"; //нельзя точки в ряд

            if (Regex.IsMatch(s, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
