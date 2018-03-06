using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void plusMinus(int[] arr)
    {
        decimal positives =0, zeros=0, negatives = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                positives++;
            else if (arr[i] == 0)
                zeros++;
            else if(arr[i]<0)
                negatives++;
        }
        Console.WriteLine(positives/ arr.Length);
        Console.WriteLine(negatives/ arr.Length);
        Console.WriteLine(zeros / arr.Length);
        
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        plusMinus(arr);


    }
}
