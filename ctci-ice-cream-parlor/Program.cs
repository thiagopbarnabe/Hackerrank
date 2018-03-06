using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{

    public static StringBuilder s;
    static void solve(int[] arr, int money)
    {
        
        
        int[] arrCopy = new int[arr.Length];
        Array.Copy(arr, arrCopy, arr.Length);
        Array.Sort(arrCopy);
        for (int i = 0; i < arr.Length-1; i++)
        {
            
            var index = Array.BinarySearch<int>(arrCopy,i+1, arrCopy.Length-(i+1),money - arrCopy[i]);

            if (index > 0)
            {
                var index1 = Array.IndexOf(arr, arrCopy[i]);
                var index2 = Array.IndexOf(arr, arrCopy[index], index1); 

                s.AppendLine(index1 + " " + index2);
                return;
            }

            //for (int j = i+1; j < arr.Length; j++)
            //{
            //    if ((arr[i] + arr[j]) == money)
            //        s.AppendLine(i+1 + " " + (j+1));
            //}
        }
    }

    static void Main(String[] args)
    {
        string[] lines = File.ReadAllLines(@"C:\Users\thiago.barnabe\Documents\Source\Hackerrank\teste.txt");
        
        s = new StringBuilder();
        int t = Convert.ToInt32(lines[0]);
        for (int a0 = 1; a0 < lines.Length; a0+=3)
        {
            int money = Convert.ToInt32(lines[a0]);
            //int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = lines[a0+2].Trim().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            solve(arr, money);
        }

        Console.Write(s.ToString());
    }
}
