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
            long count = 0;
            long arrSize = arr.LongCount();
            // Condition where we don't have enough elements.
            //Console.WriteLine($"Array Size: {arrSize}");
            if (arrSize < 3)
                return count;

            Dictionary<long, int> left = arr.GroupBy(n => n).Select(x => new { k = x.Key, v = x.Count() }).ToDictionary(x => x.k, x => 0); // Initially all items with zero count
            Dictionary<long, int> right = arr.GroupBy(n => n).Select(x => new { k = x.Key, v = x.Count() }).ToDictionary(x => x.k, x => x.v); // Initially all items

            // Start pivoting at first item
            for (int j = 0; j < arrSize - 1; j++)
            {
                // Test if element is a factor
                // Test if left dictionary has any factor
                // Test if right dictionary has any factor
                right[arr[j]]--; // Current element
                bool lExists = left.TryGetValue(arr[j] / r, out int lcnt);
                bool rExists = right.TryGetValue(arr[j] * r, out int rcnt);
                //Console.Write($"pivot {j}:{arr[j]} left: [{string.Join(", ", arr.GetRange(0,j))}] right: [{string.Join(", ", arr.GetRange(j+1, arr.Count()-(j+1)))}]");
                if (lExists && rExists && arr[j] % r == 0)
                {
                    // We have a triplet
                    // Be sure to cast to long to avoid overflow
                    count += ((long)lcnt * (long)rcnt);
                }
                //Console.WriteLine($" count: {count}");
                left[arr[j]] += 1;
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
