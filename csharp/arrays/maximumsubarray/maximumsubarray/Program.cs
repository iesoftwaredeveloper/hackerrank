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
        // 
        // Since we are returning a sub array, we will need to 
        // create a new array and copy the contents from the
        // current array.  This means that the sub-array could be
        // as small as 1 or as large as n.
        // The best case space complexity is O(1), no extra space allocated
        // The worst case space complexity is that we need to create a completly
        // array that is the same size as the array passed in.
        // This would be a space complexity of O(n).
        // We could eliminate this extra space by returning 
        // a tuple that provides the beginning index and length.
        // The caller could then be required to reference the original
        // array instead of a new array being allocated and returned.
        public static int[] maxSubArray(int[] arr) // Time: O(n) Space: O(1)
        {
            int n = arr.Length; // Store so we don't have to recompute.
            if(n <= 0)
            {
                return new int[0];
            }

            int maxSum = Int32.MinValue; // To account for all negative array.
            int currentSum = 0;
            int currentStart = 0;
            int currentEnd = 0;
            int maxStart = 0, maxEnd = 0;

            // Iterate over the array
            for (int i = 0; i < n; i++) // Time: O(n)
            {
                currentSum += arr[i];
                currentEnd = i;

                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    maxStart = currentStart;
                    maxEnd = currentEnd;
                }
                if (currentSum < 0)
                {
                    currentSum = 0; // Reset the sum
                    currentStart = currentEnd + 1; // Restart the start index.
                }
            }
            Console.WriteLine($"Start: [{maxStart}] End: [{maxEnd}] Sum:{maxSum}");
            int subArrayLen = maxEnd - maxStart + 1;
            int[] maxSubArray = new int[subArrayLen];
            Array.Copy(arr, maxStart, maxSubArray, 0, subArrayLen);
            return maxSubArray;            
        }

        // We iterate over all elements of the array once.  This gives us a O(n) time complexity.
        // Other than the intialization of some integers, we do not create
        // any extra memory to process this.  The amount of memory used
        // to process the array is constant.  So space complexity is O(1).
        public static int maxSum(int[] arr)
        {
            int n = arr.Length; // Store so we don't have to recompute.

            // Edge case of empty array
            if (n <= 0)
            {
                return 0;
            }

            int maxSum = Int32.MinValue; // To account for all negative array.
            int currentSum = 0;

            // Iterate over the array
            for (int i = 0; i < n; i++)
            {
                currentSum += arr[i];

                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum < 0)
                {
                    currentSum = 0; // Reset the sum
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
