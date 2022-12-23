using System;
using System.Text;
using System.Text.RegularExpressions;

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
            StringBuilder builder_s = new StringBuilder();
            int index = 0;

            while (true)
            {
                int indexOne = s.IndexOf("<", index);
                int indexTwo = s.IndexOf(">", index);
                if (indexOne == -1 || indexTwo == -1)
                {
                    builder_s.Append(s.Substring(index, s.Length - index));
                    break;
                }

                builder_s.Append(s.Substring(index, indexOne - index) + "_");
                index = indexTwo + 1;
            }

            return builder_s.ToString();
        }
    }
}
