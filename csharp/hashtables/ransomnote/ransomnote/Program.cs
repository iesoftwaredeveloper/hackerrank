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
            // Use Linq
            Dictionary<string, int> wordCntMagazine = magazine.GroupBy(w => w).Select(w => new { Word = w.Key, Count = w.Count() }).ToDictionary(w => w.Word, w => w.Count);
            Dictionary<string, int> wordCntNote = note.GroupBy(w => w).Select(w => new { Word = w.Key, Count = w.Count() }).ToDictionary(w => w.Word, w => w.Count);

            foreach(var word in wordCntNote.Keys)
            {
                if(!wordCntMagazine.TryGetValue(word, out int wordCnt) || wordCntNote[word] > wordCnt)
                {
                    Console.WriteLine("No");
                    return false;
                }
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
