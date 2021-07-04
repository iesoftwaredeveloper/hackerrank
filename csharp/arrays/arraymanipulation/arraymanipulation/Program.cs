using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Numerics;

namespace arraymanipulation
{
    /// <summary>
    /// Starting with a 1-indexed array of zeros and a list of operations, 
    /// for each operation add a value to each the array element between two 
    /// given indices, inclusive. Once all operations have been performed, 
    /// return the maximum value in the array. 
    /// </summary>
    public class Result
    {

        /*
         * Complete the 'arrayManipulation' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            // Initialize array
            long[] arr = new long[n];
            long max = 0;

            // Iterate over each set of instructions.
            foreach(var abk in queries)
            {
                
                // Start at index a, iterate till index b
                // Add k to the value at the index.
                // Is there a faster way to do this than a for loop?
                for(int i = abk[0]-1; i <=abk[1]-1 && i < n; i++)
                {
                    arr[i] += abk[2];
                }
            }
            return arr.Max();
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            long result = Result.arrayManipulation(n, queries);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
