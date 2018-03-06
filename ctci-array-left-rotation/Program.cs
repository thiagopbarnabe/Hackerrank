using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    public static void rotate(int n, int k , int[] a)
    {
        int[] result = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
            Console.Write(a[(i + k) % n]+" ");
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        rotate(n, k, a);
    }


}






