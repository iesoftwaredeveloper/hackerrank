using System;
using System.IO;
using System.Text.RegularExpressions;

namespace alternatingcharacters
{
    public class Result
    {

        /*
         * Complete the 'alternatingCharacters' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int alternatingCharacters(string s)
        {
            int delCount = 0; // Initialize number of deletions to zero.

            // Edge case, if string is of length zero.
            if (s.Length <= 0)
                return delCount;

            // Define the regular expression for finding consecutive 'A', by default regex is greedy.
            Regex rxA = new Regex("A[A]+"); // Any patter than starts with 'A' and then has one or more 'A' following it.
            Regex rxB = new Regex("B[B]+"); // Any patter than starts with 'B' and then has one or more 'B' following it.

            // Find all matches for A that are 2 or more in length.
            foreach(Match match in rxA.Matches(s))
            {
                delCount += match.Length - 1; // Remove all but 1.
            }
            // Repeat regex for B
            foreach(Match match in rxB.Matches(s))
            {
                delCount += match.Length - 1; // Remove all but 1.
            }
            return delCount;
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

                int result = Result.alternatingCharacters(s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
