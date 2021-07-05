using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;
namespace sherlockandanagrams
{
    public class Result
    {

        /*
         * Complete the 'sherlockAndAnagrams' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int sherlockAndAnagrams(string s)
        {
            // The brute force method
            // Compare each possible substring and see 
            // if it can be found in the existing string.
            //
            // Still time consuming, but acceptable if size is small enough.
            // Improves by reducing the number of loops.

            // Need to check for two things
            // Are the letters matching?
            // How many ways can they be arranged?

            // Check for n-1 letter anagrams
            // Check for n-2 letter anagrams
            // ...
            // Check for 1 letter anagrams

            // Initialize as zero matches
            int pairCnt = 0;
            int slen = s.Length;
            Dictionary<string, int> hash = new Dictionary<string, int>();
            // Check for anagrams of length 1 to n-1
            for (int n = 1; n < slen; n++)
            {

                // Start at first index length of n
                for (int i = 0; i+n <= slen; i++)
                {
                    // Get the current substring and sort.
                    var s1 = String.Concat(s.Substring(i, n).OrderBy(a => a));

                    // If we have seen this before, increment count.
                    // Otherwise, add it to hash as it is the first instance.
                    if(hash.TryGetValue(s1, out int count))
                    {
                        pairCnt += count;
                        hash[s1]++;
                        continue;
                    }
                    hash.Add(s1, 1);
                }
            }

            return pairCnt;
        }

/// <summary>
/// Determine if s1 and s2 are anagrams
/// </summary>
/// <param name="s1"></param>
/// <param name="s2"></param>
/// <returns></returns>
        static bool isAnagram(string s1, string s2)
        {
            if(s1.Length != s2.Length)
                return false;
            
            if(String.Concat(s1.OrderBy(a => a)).Equals(String.Concat(s2.OrderBy(a => a))))
                return true;
            return false;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = Result.sherlockAndAnagrams(s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
