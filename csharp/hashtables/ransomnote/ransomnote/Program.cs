using System;
using System.Collections.Generic;
using System.Linq;

namespace ransomnote
{
    public class Result
    {

        /*
         * Complete the 'checkMagazine' function below.
         *
         * The function accepts following parameters:
         *  1. STRING_ARRAY magazine
         *  2. STRING_ARRAY note
         */

        public static bool checkMagazine(List<string> magazine, List<string> note)
        {
            // Brute force method
            // Hint: Since title has "Hash Tables", probably should use a hash table.
            // Check each word in note to see if it exists in magazine.
            // And exists enough times.
            Dictionary<string, int> hashMag = new();

            foreach (var word in magazine)
            {
                if (hashMag.TryGetValue(word, out int cnt))
                {
                    hashMag[word] += 1;
                }
                else
                {
                    hashMag[word] = 1;
                }
            }
            foreach (var word in note)
            {
                if (!hashMag.Keys.Contains(word) || hashMag[word] <= 0)
                {
                    Console.WriteLine("No");
                    return false;
                }
                hashMag[word] -= 1;
            }
            Console.WriteLine("Yes");
            return true;
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(firstMultipleInput[0]);

            int n = Convert.ToInt32(firstMultipleInput[1]);

            List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

            List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

            Result.checkMagazine(magazine, note);
        }
    }
}
