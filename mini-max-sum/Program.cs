using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void miniMaxSum(int[] arr)
    {
        int maiorIndex = 0, menorIndex = 0;
        long total=0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > arr[maiorIndex])
                maiorIndex = i;
            if (arr[i] < arr[menorIndex])
                menorIndex = i;

            total += arr[i];
        }

        Console.Write((total - arr[maiorIndex]) + " " + (total - arr[menorIndex]));
    }

    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        miniMaxSum(arr);
    }
}
