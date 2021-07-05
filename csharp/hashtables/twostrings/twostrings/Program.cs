using System;
using System.IO;
using System.Text;

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
        // One approach is to take a substring of s1 of size 1
        // See if that is in s2.
        // Given that a substring can be as small as 1 character, we only need to find one matching character to say YES.
        

        // Brute force is to search for occurrence of a character in s1 in s2 using a loop.
        // This is O(n*m) and is horrible performance.
        foreach(var c1 in s1)
        {
            foreach(var c2 in s2)
            {
                if(c1 == c2)
                    return "YES";
            }
        }
        return "NO";
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
    }        }
    }
}
