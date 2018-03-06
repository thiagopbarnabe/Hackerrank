using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{

    static void staircase(int n)
    {
        StringBuilder final = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            StringBuilder spaces = new StringBuilder();
            StringBuilder symbols = new StringBuilder();
            for (int j = 0; j < n; j++)
            {
                if (j < n-i-1)
                    final.Append(" ");
                else
                    final.Append("#");

            }
            final.AppendLine();


        }
        Console.Write(final.ToString());
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}
