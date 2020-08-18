using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>Inserts spaces before each capital letter in a string</summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result += letter;
                }
            }

            result = result.Trim();
            return result;
        }

        public static bool IsNull(string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNull(DateTimeOffset? date)
        {
            return date == null;
        }

        public static bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}