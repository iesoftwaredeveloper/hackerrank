using System;
using System.Linq;
using System.IO;

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
            // The complexity of this approach is too time consuming.
            // O((n-1)^2*(n-1)

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
            // Check for anagrams of length 1 to n-1
            for (int n = 1; n < slen; n++)
            {
                // Start at first index length of n
                for (int i = 0; i < slen; i++)
                {
                    // Look for n length matches
                    // Must not include all chars of i
                    for (int j = i + 1; j + (n - 1) < slen; j++)
                    {
                        var s1 = String.Concat(s.Substring(i, n).OrderBy(a => a));
                        var s2 = String.Concat(s.Substring(j, n).OrderBy(a => a));
                        // If two sorted strings match, then is anagram
                        if(s1.Equals(s2))
                        {
                            pairCnt += 1;
                        }
                    }
                }
            }

            return pairCnt;
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
