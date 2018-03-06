using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    public static int calcWays(int n)
    {
        if (n < 1) return 0;
        if (n == 1) return 1;
        if (n == 2) return 2;
        if (n == 3) return 4;

        int[] ways = new int[] { 1, 2, 4 };

        for (int i = 4; i < n; i++)
        {
            int idx = (i - 1) % 3;
            ways[idx] = ways[0] + ways[1] + ways[2];
        }
        return ways[0] + ways[1] + ways[2];
    }


    static void Main(String[] args)
    {
        int s = Convert.ToInt32(Console.ReadLine());
        StringBuilder str = new StringBuilder();
        for (int a0 = 0; a0 < s; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            str.AppendLine(calcWays(n).ToString());
        }

        Console.WriteLine(str.ToString());
    }
}
