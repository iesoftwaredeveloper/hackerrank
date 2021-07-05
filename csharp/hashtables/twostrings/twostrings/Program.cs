using System;
using System.IO;
using System.Text;
using System.Linq;
namespace twostrings
{
    public class Result
    {

        /*
         * Complete the 'twoStrings' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s1
         *  2. STRING s2
         */

        public static string twoStrings(string s1, string s2)
        {
            // Provided the set of characters in s1 and s2 intersect by any number, then they share at least one substring.        
            return (s1.Intersect(s2).Count() > 0) ? "YES" : "NO";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int q = Convert.ToInt32(Console.ReadLine().Trim());

                for (int qItr = 0; qItr < q; qItr++)
                {
                    string s1 = Console.ReadLine();

                    string s2 = Console.ReadLine();

                    string result = Result.twoStrings(s1, s2);

                    textWriter.WriteLine(result);
                }

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
