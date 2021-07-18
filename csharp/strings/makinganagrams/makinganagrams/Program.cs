using System;
using System.Linq;
using System.IO;

namespace makinganagrams
{
    public class Result
    {

        /*
         * Complete the 'makeAnagram' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING a
         *  2. STRING b
         */

        public static int makeAnagram(string a, string b)
        {
            // To make an anagram, they must have common characters.
            // So remove any characters not in common.

            // Get the frequency of each character in a
            // Get the frequency of each character in b
            // Remove any characters in a that are not in b
            // Remove any characters in b that are not in a
            // Remove any extra characters until the freqency is the same.
            int delCount = 0;

            var dictA = a.GroupBy(c => c).Select(x => new { letter = x.Key, count = x.Count() }).ToDictionary(x => x.letter, x => x.count);
            var dictB = b.GroupBy(c => c).Select(x => new { letter = x.Key, count = x.Count() }).ToDictionary(x => x.letter, x => x.count);

            Console.WriteLine($"{a} {string.Join(",", dictA.Select(kv => $"{kv.Key}={kv.Value}"))}");
            Console.WriteLine($"{b} {string.Join(",", dictB.Select(kv => $"{kv.Key}={kv.Value}"))}");

            // Compare each letter in A against B
            foreach (var keyA in dictA.Keys.ToList())
            {
                // If the key is in a and NOT in b, then, frequency del.
                if (!dictB.ContainsKey(keyA))
                {
                    delCount += dictA[keyA];
                    dictA.Remove(keyA); // Remove key so we don't recompare later.
                    continue;
                }

                // If there is common key, then are the counts the same.
                if (dictA[keyA] != dictB[keyA])
                {
                    delCount += Math.Abs(dictA[keyA] - dictB[keyA]);
                }
            }

            // Now compare remaining keys in B against A
            foreach (var keyB in dictB.Keys)
            {
                if (!dictA.ContainsKey(keyB))
                {
                    delCount += dictB[keyB];
                }
            }
            Console.WriteLine(delCount);
            return delCount;
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string a = Console.ReadLine();

            string b = Console.ReadLine();

            int res = Result.makeAnagram(a, b);

            textWriter.WriteLine(res);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
