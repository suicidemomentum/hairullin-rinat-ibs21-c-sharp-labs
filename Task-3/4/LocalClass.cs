using System;
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
            while (true)
            {
                int indexOne = s.IndexOf("<");
                int indexTwo = s.IndexOf(">");
                if (indexOne == -1 || indexTwo == -1)
                {
                    break;
                }

                string temp_s = "";

                s = s.Insert(indexTwo + 1, "_");
                temp_s = s.Substring(0, indexOne);
                s = s.Substring(indexTwo + 1, s.Length - indexTwo - 1);
                s = temp_s + s;
            }

            return s;
        }
    }
}
