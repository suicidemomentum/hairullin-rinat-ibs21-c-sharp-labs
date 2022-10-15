using System;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace LocalUtils
{
    internal static class LocalClass
    {
        internal static string RegexReplaceTags(string s)
        {
            string pattern = @"(\<([^\>]+)\>)";
            string target = "_";

            Regex regex = new Regex(pattern);

            return regex.Replace(s, target);
        }

        internal static string NoRegexReplaceTags(string s)
        {
            StringBuilder builder_s = new StringBuilder(s);
            int index = 0;

            while (true)
            {
                int indexOne = s.IndexOf("<", index);
                int indexTwo = s.IndexOf(">", index);
                if (indexOne == -1 || indexTwo == -1)
                {
                    break;
                }

                builder_s.Insert(indexTwo + 1, "_");
                builder_s.Remove(indexOne, indexTwo - indexOne + 1);
                index = indexOne;
            }

            return builder_s.ToString();
        }
    }
}
