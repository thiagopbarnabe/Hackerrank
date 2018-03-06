using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int[][] arr = new int[6][];
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        }

        int? maxSum = null;
        for (int i = 0; i < arr.Length-2; i++)
        {
            for (int j = 0; j < arr[i].Length-2; j++)
            {
                int sum = 
                    arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + 
                    arr[i + 1][j + 1] +
                    arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                if (maxSum == null || sum > maxSum)
                    maxSum = sum;
            }
        }

        Console.Write(maxSum);
    }
}
