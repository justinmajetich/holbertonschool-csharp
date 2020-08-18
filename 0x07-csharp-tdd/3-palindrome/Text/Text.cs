using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Provides a collection of string utilities.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Check if string argument is a palindrome.
        /// </summary>
        /// <param name="s">A string to be tested as a palindrome.</param>
        /// <returns>Returns true if string is a palindrome; otherwise, returns false.</returns>
        public static bool IsPalindrome(string s)
        {
            // Standardize sting to lowercase
            s = s.ToLower();

            // Strip string of whitespace and punctuation
            List<char> sCleaned = new List<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    sCleaned.Add(s[i]);
                }
            }
            s = new string(sCleaned.ToArray());

            // Create copy of string in reverse
            char[] sCharArray = s.ToCharArray();
            Array.Reverse(sCharArray);
            string sReverse = new string(sCharArray);

            return s == sReverse;
        }
    }
}
