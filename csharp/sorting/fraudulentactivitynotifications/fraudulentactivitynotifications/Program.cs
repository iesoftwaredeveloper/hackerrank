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
            decimal[] lookback = new decimal[d]; // Store current look back values.


            int notificationCount = 0;

            // Edge case
            // If the number of previous days i <= total days
            if (d >= expenditure.Count())
                return notificationCount;

            // Compute the median for each day.
            // We start with the first item and take up to the number of lookback days.
            Console.WriteLine(">>>>>");
            Console.WriteLine(string.Join(", ", expenditure.Select(x => x)));

            int ma_index = 0;
            for (int i = 0; i < expenditure.Count()-1; i++)
            {
                lookback[ma_index] = expenditure[i] / Convert.ToDecimal(d);
                decimal ma = 0.0M;
                for (int j = 0; j < d; j++)
                {
                    ma += lookback[j];
                }
                if(i >= d-1 && expenditure[i+1] >= (ma*2))
                {
                    notificationCount++;
                }
                Console.WriteLine($"{i+1}: {ma} {ma*2} {expenditure[i+1]} {notificationCount}");
                ma_index = (ma_index+1) % d;                
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
