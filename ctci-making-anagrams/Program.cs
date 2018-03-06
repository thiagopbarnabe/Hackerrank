using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        string big;
        string small;
        if (a.Length > b.Length)
        {
            big = a;
            small = b;
        }
        else
        {
            big = b;
            small = a;
        }

        int mustDelete = 0;
        for (int i = 0; i < small.Length; i++)
        {
            mustDelete++;
            for (int j = 0; j < big.Length; j++)
            {
                if (small[i] == big[j])
                {
                    mustDelete--;
                    big = big.Remove(j,1);
                    break;
                }
            }
        }

        Console.Write(mustDelete + big.Length);
    }
}
