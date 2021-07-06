using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace markandtoys
{
    public class Result
    {

        /*
         * Complete the 'maximumToys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY prices
         *  2. INTEGER k
         */

        public static int maximumToys(List<int> prices, int k)
        {
            // There are a few ways to approach this.
            //
            // Method 1:
            // Sort the list, then keep "purchasing" an item and keep a running sum as list is iterated.
            // If a purchase will result in spending more than budget, stop and return current item count.
            //
            // Method 2:
            // Implement a prefix sum.  Then find the index of the item that is > budget.
            // Since indexes are zero based, the index to the left will be the last item that can be purchased.
            // This means that the actual index of the over budget item will be the count.
            //
            // Method 3:
            // Another method would be to NOT sort, but find the minimum priced item.
            // Remove from the list.  Then find the next minimum item.  Repeat keeping a running sum and count.
            // This is the worst possible method from a performance perspective.

            // Implementation of Method 1.  Sort the list, then keep running sum.
            // This is "better" than method 2 since it is a basic prefix sum without the need to 
            // complete the entire sum.  The computation can stop once the budget is exceeded.

            int toyCount = 0;
            int sum = 0;
            // Edge case where there is no budget or items to purchase
            if (k <= 0 || prices.Count() == 0)
            {
                return toyCount;
            }
            prices.Sort();
            foreach (var price in prices)
            {
                if (sum + price < k)
                {
                    toyCount++;
                    sum += price;
                }
                else
                {
                    // Stop iterating, we are over budget
                    break;
                }
            }
            return toyCount;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> prices = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pricesTemp => Convert.ToInt32(pricesTemp)).ToList();

            int result = Result.maximumToys(prices, k);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
