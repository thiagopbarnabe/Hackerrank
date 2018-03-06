using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int[] leftRotation(int[] a, int d)
    {
        d = d % a.Length;

        int diff = a.Length % d;

        for (int i = 0; i < a.Length; i++)
        {
            //if ((a.Length - i) < diff)
            //{
            //    diff = a.Length - i;
            //}
            int temp = a[i];            
            var swapIndex = d+(diff>1 ? (i % d) : i+diff);

            if (swapIndex < i)
            {
                swapIndex = i + (i % (a.Length-1 - i));
            }
                
            
            a[i] = a[swapIndex];
            a[swapIndex] = temp;
        }

        return a;
        // Complete this function
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int d = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int[] result = leftRotation(a, d);
        Console.WriteLine(String.Join(" ", result));


    }
}
