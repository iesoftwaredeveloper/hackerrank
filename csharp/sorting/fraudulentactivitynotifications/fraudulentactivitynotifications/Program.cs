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
            // Compute the size of the array used to store median values.
            decimal[] median = new decimal[expenditure.Count() - d];
            decimal[] threshold = new decimal[expenditure.Count() - d];
            int notificationCount = 0;

            // Compute the median for each day.
            // We start with the first item and take up to the number of lookback days.
            Console.WriteLine(">>>>>");
            Console.WriteLine(string.Join(", ",  expenditure.Select(x => x)));
            for (int i = 0; i + d < expenditure.Count(); i++)
            {
                // Skip the first i elements and take the next d.
                median[i] = computeMedian(expenditure.Skip(i).Take(d).ToList());
                // Now compute each days notification threshold
                threshold[i] = computeThreshold(median[i]);
                if(expenditure[d+i] >= threshold[i])
                {
                    notificationCount++;
                }
                Console.WriteLine($"{median[i]} {threshold[i]} {expenditure[d+i]}");
            }

            return notificationCount;
        }

        // Given a list of expenditures, return the median
        // We use decimal instead of float for accuracy purposes.
        static decimal computeMedian(List<int> expenditure)
        {
            return expenditure.Average(num => Convert.ToDecimal(num));
        }

        static decimal computeThreshold(decimal expenditure)
        {
            return expenditure * 2;
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
