using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace counttriplets
{

    public class Program
    {
        public static long countTriplets(List<long> arr, long r)
        {
            // Brute force method.
            // Start at first index, then check remaining for match.
            // Stop if get to 3 matches or end of list.
            // Horrible performance
            long count = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                for (int j = i + 1; j < arr.Count(); j++)
                {
                    if (arr[j] == arr[i] * r)
                    {
                        for (int k = j + 1; k < arr.Count(); k++)
                        {
                            if (arr[k] == arr[j] * r)
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nr = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nr[0]);

            long r = Convert.ToInt64(nr[1]);

            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

            long ans = countTriplets(arr, r);

            textWriter.WriteLine(ans);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
