using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{



    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    count++;
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }

        Console.WriteLine(string.Format("Array is sorted in {0} swaps.", count));
        Console.WriteLine(string.Format("First Element: {0}", a[0]));
        Console.WriteLine(string.Format("Last Element: {0}", a[a.Length-1]));
    }
}
