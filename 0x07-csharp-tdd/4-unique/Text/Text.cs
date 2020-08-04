using System;

namespace Text
{
    /// <summary>
    /// Provides a string operation.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines the the first unique character in a string.
        /// </summary>
        /// <param name="s">String to inspect.</param>
        /// <returns>
        /// The index of the first unique character in the string, or -1 if no unique character exists.
        /// </returns>
        public static int UniqueChar(string s)
        {
            if (s.Length == 1)
            {
                return 0;
            }

            for (var i = 0; i < s.Length; i++)
            {
                // If current character does not appear elsewhere in string
                if (s.Substring(i + 1).Contains(s[i].ToString()) == false &&
                    s.Substring(0, i).Contains(s[i].ToString()) == false)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
