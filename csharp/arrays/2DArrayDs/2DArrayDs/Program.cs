using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _2DArrayDs
{
    /// <summary>
    /// Problem: https://www.hackerrank.com/interview/interview-preparation-kit/arrays/challenges
    /// 
    /// This problem is a specific implementation of matrix.  The general problem is given 
    /// an N x N matrix, find the sum of all hour-glass matrices.  In this problem, the
    /// size of N is limted to a 6 x 6 grid at all times.
    /// 
    /// This means that the first hourg-glass is at (0,0) and the the last is at (3,3)
    /// There will always be 16 hour-glass matrices.
    /// 
    /// This puts the complexity at O(1) for the specific case, but O(n) for the general case.
    /// 
    /// To solve, compute the sum of each hour-glass matrix.  Track the largest sum.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

    public class Result
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int maxSum = Int32.MinValue;

            for (int row = 0; row >= 0 && row <= 3; row++)
            {
                for (int col = 0; col >= 0 && col <= 3; col++)
                {
                    int curSum = arr[row].GetRange(col, 3).Sum() + arr[row + 1].GetRange(col + 1, 1).Sum() + arr[row + 2].GetRange(col, 3).Sum();
                    if (curSum > maxSum)
                    {
                        maxSum = curSum;
                    }
                }
            }
            return maxSum;
        }
    }
}
