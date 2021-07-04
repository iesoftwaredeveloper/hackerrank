using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace LeftRotation
{
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> result = Result.rotLeft(a, d);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

    public class Result
    {

        /*
         * Complete the 'rotLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER d
         */

        /// <summary>
        /// If we rotate the array a the same number of elements that are in the array
        /// the result is the same array.  Rather than rotate d times, determine
        /// how many are needed to get the result with the least number of rotations.
        /// 
        /// Specifically, how many times would the rotatation result in the same array?
        /// Do this by taking the modulus of the array.
        /// 
        /// Finally, rotating the remaining number of times would result in the same
        /// effect as taking the first n elements and appending them to the end of the array.
        /// 
        /// So get the elements from the front that would be rotated.
        /// Now create a new list with those elements on the end of the new list.
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static List<int> rotLeft(List<int> a, int d)
        {
            int rotations = d % a.Count;

            List<int> rotList = a.GetRange(0, rotations);
            List<int> retList = a.GetRange(rotations, a.Count - rotations);
            retList.AddRange(rotList);
            return retList;
        }

    }
}
