using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Provides a math operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Finds the max value in a list of integers
        /// </summary>
        /// <param name="nums">A list of integers</param>
        /// <returns>The max value in a list of integers</returns>
        public static int Max(List<int> nums)
        {
            // If list is null or empty, return 0
            if (nums == null || nums.Count <= 0)
            {
                return 0;
            }

            // Init max value with first item in list
            int max = nums[0];

            // Compare all values in list
            foreach (var value in nums)
            {
                max = Math.Max(max, value);
            }

            // Return max value
            return max;
        }
    }
}
