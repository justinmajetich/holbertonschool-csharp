using System;

namespace Text
{
    /// <summary>
    /// Provides a utility method to the Str class.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Counts the number of words in a camelCase string.
        /// </summary>
        /// <returns>The word count of a given string.</returns>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length <= 0)
            {
                return 0;
            }

            int wordCount = 1;
            int i = 0;

            // Check if first char is upper (acronym case)
            if (s[0] >= 'A' || s[0] <= 'Z')
            {
                i++;
            }

            while (i < s.Length)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    wordCount++;
                }
                i++;
            }

            return wordCount;
        }
    }
}
