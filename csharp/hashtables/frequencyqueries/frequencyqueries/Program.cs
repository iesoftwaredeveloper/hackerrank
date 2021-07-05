using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace frequencyqueries
{
    public class Program
    {
        // Complete the freqQuery function below.
        public static List<int> freqQuery(List<List<int>> queries)
        {
            // Declare an empty list.
            List<int> frequencies = new List<int>();
            Dictionary<int, int> data = new Dictionary<int, int>();

            // Given a list of operations, perform them.
            // We have to iterate through each operation.
            foreach (List<int> xy in queries)
            {
                int op = xy[0];
                int val = xy[1];
                switch (op)
                {
                    case 1: // Insert val
                        if (data.Keys.Contains(val))
                        {
                            data[val] += 1; // Increment frequency
                        }
                        else
                        {
                            data.Add(val, 1); // Insert and set frequency
                        }
                        break;
                    case 2: // Delete occurrence
                        if (data.Keys.Contains(val))
                        {
                            data[val] -= 1;
                            if (data[val] < 0)
                                data[val] = 0;
                        }
                        break;
                    case 3: // Check Frequency
                        // Select any values == 2.
                        if (data.Values.Any(x => x==val))
                        {
                            frequencies.Add(1);
                        }
                        else
                        {
                            frequencies.Add(0);
                        }
                        break;
                }
            }
            return frequencies;
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
