using System;
using System.Linq;

namespace maximumsubarray
{
    public class Kadanes
    {
        // https://en.wikipedia.org/wiki/Maximum_subarray_problem
        // Find sub array with the largest possible sum
        // Input array: [−2, 1, −3, 4, −1, 2, 1, −5, 4]
        // Largest array: [4, −1, 2, 1]
        // Sum: 6
        //
        // Note, this algorithm requires that there be at least one positive value in the array.
        //
        // We iterate over all elements of the array once.  This gives us a O(n) time complexity.
        // Other than the intialization of some integers, we do not create
        // any extra memory to process this.  The amount of memory used
        // to process the array is constant.  So space complexity is O(1).
        public static int[] maxSubArray(int[] arr) // Time: O(n) Space: O(1)
        {
            int maxSum = Int32.MinValue; // To account for all negative array.
            int currentSum = 0;
            int currentStart = 0;
            int currentEnd = 0;
            int maxStart = 0, maxEnd = 0;
            int n = arr.Length; // Store so we don't have to recompute.

            // Iterate over the array
            for (int i = 0; i < n; i++) // Time: O(n)
            {
                currentSum += arr[i];
                currentEnd = i;

                if (currentSum < 0)
                {
                    currentSum = 0; // Reset the sum
                    currentStart = currentEnd + 1; // Restart the start index.
                }
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    maxStart = currentStart;
                    maxEnd = currentEnd;
                }
            }
            Console.WriteLine($"Start: [{maxStart}] End: [{maxEnd}] Sum:{maxSum}");
            return arr.ToList().GetRange(maxStart, maxEnd - maxStart + 1).ToArray();
        }

        public static int maxSum(int[] arr)
        {
            int maxSum = Int32.MinValue; // To account for all negative array.
            int currentSum = 0;
            int n = arr.Length; // Store so we don't have to recompute.

            // Edge case of empty array
            if(n <= 0)
            {
                return maxSum;
            }

            // Iterate over the array
            for (int i = 0; i < n; i++)
            {
                currentSum += arr[i];

                if (currentSum < 0)
                {
                    currentSum = 0; // Reset the sum
                }
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
            }
            return maxSum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
