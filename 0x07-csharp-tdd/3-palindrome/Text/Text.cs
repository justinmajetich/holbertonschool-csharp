using System;

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
            var sLower = s.ToLower();

            // Create copy of string in reverse
            char[] sCharArray = sLower.ToCharArray();
            Array.Reverse(sCharArray);
            string sReverse = new string(sCharArray);

            return sLower == sReverse;
        }
    }
}
