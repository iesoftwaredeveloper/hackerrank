using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace sherlockvalidstring
{
    public class Result
    {

        /*
         * Complete the 'isValid' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string isValid(string s)
        {
            const string NO = "NO";
            const string YES = "YES";

            // Edge case
            if (s.Length <= 0)
            {
                return NO;
            }

            // Get the frequency of each character in the string
            Dictionary<char, int> cFreq = s.GroupBy(c => c).Select(x => new { Letter = x.Key, Count = x.Count() }).ToDictionary(x => x.Letter, x => x.Count);

            // Get the frequency of frequency
            Dictionary<int, int> freqFreq = cFreq.Values.GroupBy(n => n).Select(x => new { Freq = x.Key, Count = x.Count() }).ToDictionary(x => x.Freq, x => x.Count);

            // Debug output.
            Console.Write("Character frequencies: ");
            Console.WriteLine(string.Join(", ", cFreq.Select(kv => $"[{kv.Key}, {kv.Value}]")));

            Console.Write("Frequency frequencies: ");
            Console.WriteLine(string.Join(", ", freqFreq.Select(kv => $"[{kv.Key}, {kv.Value}]")));

            // Now we need to find the outlier
            // If we only have one frequency, then they are all the same and we are valid
            if (freqFreq.Keys.Count == 1)
            {
                return YES;
            }

            // We have more than one frequency, but if we have more than 2, we can't fix by removing 1 character.
            if (freqFreq.Keys.Count > 2)
            {
                return NO;
            }

            // At this point, we have only two different types of frequencies.
            // The only way there could possibly be a valid string is if we can remove a single character
            // from the non-conforming frequency.

            // If reducing the minFreq occurs only once
            // OR
            // If the maxFreq occurs only once.
            // AND
            // If the number of occurences of the most frequent character (maxFreq) is only 1 higher than the
            // number of occurences of the least frequent character.
            var maxFreq = freqFreq.Keys.Max();
            var minFreq = freqFreq.Keys.Min();

            Console.WriteLine($"{freqFreq[minFreq] == 1} {freqFreq[maxFreq] == 1} {(maxFreq - minFreq) == 1}");
            if ((minFreq == 1 && freqFreq[minFreq] == 1) || ((freqFreq[minFreq] == 1 || freqFreq[maxFreq] == 1) && (maxFreq - minFreq) == 1))
            {
                return YES;
            }

            return NO;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.isValid(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
