using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace fraudulentactivitynotifications
{
    public class Result
    {
        /*
         * Complete the 'activityNotifications' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY expenditure
         *  2. INTEGER d
         */

        public static int activityNotifications(List<int> expenditure, int d)
        {
            int notificationCount = 0;

            Console.WriteLine($"<<< {d}");
            Console.WriteLine(string.Join(", ",  expenditure.Select(x => x)));
            for (int i = 0; i < expenditure.Count() - d; i++)
            {
                // Check for even case
                decimal median = 0;
                var arr = expenditure.Skip(i).Take(d).OrderBy(x => x).ToArray();
                if (d % 2 != 0)
                {
                    median = arr[d / 2];
                }
                else
                {
                    median = (arr[(d-1)/2] + arr[d/2]) / 2.0M;
                }
                if(expenditure[d+i] >= (median*2))
                    notificationCount++;
                Console.WriteLine($"{i}: {median*2} {expenditure[i+d]} {notificationCount}");
            }

            return notificationCount;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> expenditure = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(expenditureTemp => Convert.ToInt32(expenditureTemp)).ToList();

            int result = Result.activityNotifications(expenditure, d);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
