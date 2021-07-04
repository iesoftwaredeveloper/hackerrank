using System;
using System.Linq;
using System.Collections.Generic;

namespace newyearchaos
{
public class Result
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static int? minimumBribes(List<int> q)
    {
        int maxIndex = q.Count -1;
        int bribeCnt = 0;
        for(int i = maxIndex; i >= 0; i--)
        {
            // If the value in the current position is more than two ahead
            if(q[i] - (i+1) > 2)
            {
                Console.WriteLine("Too chaotic");
                return null;
            }

            // Compare anyone before me, if higher they must have bribed.
            // q[i] is where I should be.
            // However, they can only get two ahead of me if they were behind me.
            // Only need to look two before where I should have been.
            // q[i]-2
            // If two before me is before the beginning, then reset to beginning.
            // Keep comparing those between where the most left they could get 
            // and where i am.  IF they are higher than me, they must have bribed.
            for(int j = q[i]-2; j < i; j++)
            {
                if(j < 0)
                    continue;
                if(q[j] > q[i])
                    bribeCnt++;
            }
        }
        Console.WriteLine(bribeCnt);
        return bribeCnt;

    }
}
    class Program
    {
        public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
    }
}
