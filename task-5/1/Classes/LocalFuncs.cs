using System.Text.RegularExpressions;

using Exceptions;
using Configs;
using System.Text;

namespace LocalClasses
{
    internal static class LocalFuncs
    {
        public static DateTime StringToDate(string date)
        {
            if (DateTime.TryParse(date, out DateTime result))
                return result;
            else
                throw new UserException(UserConfig.ErrorStart + UserConfig.DateFormat);
        }

    }
}
