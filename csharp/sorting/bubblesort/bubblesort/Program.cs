using System;
using System.Collections.Generic;
using System.Linq;

namespace bubblesort
{
    public class Result
    {

        /*
         * Complete the 'countSwaps' function below.
         *
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int[] countSwaps(int[] items)
        {
            int numSwaps = 0;
            int n = items.Length;
            ref int firstElement = ref items[0], lastElement = ref items[n-1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (items[j] > items[j + 1])
                    {
                        swap(ref items[j], ref items[j + 1]);
                        numSwaps++;
                    }
                }
            }
            
            Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
            Console.WriteLine($"First Element: {firstElement}");
            Console.WriteLine($"Last Element: {lastElement}");
            return new int[3] { numSwaps, firstElement, lastElement };
        }

        private static void swap(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            Result.countSwaps(a.ToArray());
        }
    }
}
