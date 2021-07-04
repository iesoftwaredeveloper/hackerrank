using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Diagnostics;

public class Solution
{

    // Complete the minimumSwaps function below.
    /// <summary>
    /// The key to this solution is that the elements in the array are always 1 to n.
    /// Each element should always be in a specific position.
    /// 
    /// Best case is that zero swaps are needed.
    /// Worst case, n-1 swaps are needed.
    /// 
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="textWriter"></param>
    /// <returns></returns>

    public static int minimumSwaps(int[] arr, StreamWriter textWriter = null)
    {
        int arrSize = arr.Count();
        int left_index = 0;
        int right_index = arrSize - 1;
        int swap_count = 0;
        int temp;


        if (arrSize == 0)
            return swap_count;


        while (left_index < arrSize && left_index < right_index && right_index > 0)
        {
            // Check the if current index is in right place
            // If not move it to where it belongs and place other here.
            // Then check the new value for same condition.
            if (arr[left_index] != left_index + 1)
            {
                temp = arr[left_index];
                arr[left_index] = arr[temp - 1];
                arr[temp - 1] = temp;
                swap_count++;
                continue;
            }

            // The current index and value match, move to next.
            left_index++;
        }
        return swap_count;    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), false);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int res = minimumSwaps(arr, (StreamWriter)textWriter);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
