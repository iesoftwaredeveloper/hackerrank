using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

namespace frequencyqueries
{
    public class Program
    {
        // Complete the freqQuery function below.
        // Could be made faster by not using a List.  However, doesn't solve the underlying optimization
        public static List<int> freqQuery(List<List<int>> queries)
        {
            // Declare an empty list.
            List<int> results = new List<int>();
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            Dictionary<int, int> frequencyValues = new Dictionary<int, int>();

            // Given a list of operations, perform them.
            // We have to iterate through each operation.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach (List<int> query in queries)
            {
                int op = query[0];
                int val = query[1];
                int freq;
                switch (op)
                {
                    case 1: // Insert occurence
                        if (frequency.ContainsKey(val))
                        {
                            frequency[val] += 1; // Increment frequency
                        }
                        else
                        {
                            frequency[val] = 1; // Insert and set frequency
                        }
                        freq = frequency[val]; // Number of times val occurs.
                        if(frequencyValues.ContainsKey(freq)) // Does a value already have this frequency?
                        {
                            frequencyValues[freq] +=1; // This frequency occurs again.
                        }
                        else {
                            frequencyValues[freq] = 1; // First time it occurs
                        }
                        if(frequencyValues.ContainsKey(freq-1)) // Since frequency increase, decrement the lower frequency
                        {
                            frequencyValues[freq-1] -= 1; // This frequency occurs again.
                        }
                        else {
                            frequencyValues[freq-1] = 0; // First time it occurs
                        }
                        break;
                    case 2: // Delete occurrence
                        if (frequency.ContainsKey(val))
                        {
                            freq = frequency[val];
                            // The previous frequency is now 1 less, so decrement.
                            if(frequencyValues.ContainsKey(freq))
                            {
                                frequencyValues[freq] -=1;
                            } else {
                                frequencyValues[freq] = 0;
                            }

                            frequency[val] -= 1; // Decrement the current frequency

                            if(frequencyValues.ContainsKey(freq-1))
                            {
                                frequencyValues[freq-1] += 1;
                            } else {
                                frequencyValues[freq-1] = 1;
                            }
                            if (frequency[val] < 0)
                                frequency[val] = 0;
                        }
                        break;
                    case 3: // Check Frequency
                        // Select any values occur val times.
                        // Values take longer to find, so keep frequencies as keys instead.
                        if (frequencyValues.ContainsKey(val) && frequencyValues[val] > 0)
                        {
                            results.Add(1);
                        }
                        else
                        {
                            results.Add(0);
                        }
                        break;
                }
            }
            sw.Stop();
            Console.WriteLine($"Time: {sw.ElapsedTicks}");
            return results;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> ans = freqQuery(queries);

            textWriter.WriteLine(String.Join("\n", ans));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
