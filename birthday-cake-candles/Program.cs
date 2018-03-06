using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int birthdayCakeCandles(int n, int[] ar)
    {
        int maior = 0, candles = 0;
        for (int i = 0; i < n; i++)
        {
            if (ar[i] > maior)
            {
                maior = ar[i];
                candles = 1;
            }
            else if (ar[i] == maior)
                candles++;
        }

        return candles;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
