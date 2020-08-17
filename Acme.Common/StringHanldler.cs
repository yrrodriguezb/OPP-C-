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
                        result = result.trim();
                        result += " ";
                    }

                    result += letter;
                }
            }

            result = result.trim();
            return result;
        }
    }
}