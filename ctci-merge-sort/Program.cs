using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static long countInversions(int[] arr)
    {
        MergeSortAlgorithm.MergeSort(arr);
        return MergeSortAlgorithm.inversions;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            long result = countInversions(arr);
            Console.WriteLine(result);
        }
    }




}



class MergeSortAlgorithm
{
    public static int inversions = 0;
    public static void MergeSort(int[] input, int low, int high)
    {
        if (low < high)
        {
            int middle = (low / 2) + (high / 2);
            MergeSort(input, low, middle);
            MergeSort(input, middle + 1, high);
            Merge(input, low, middle, high);
        }

        
    }

    public static void MergeSort(int[] input)
    {
        MergeSort(input, 0, input.Length - 1);
    }

    private static void Merge(int[] input, int low, int middle, int high)
    {

        int left = low;
        int right = middle + 1;
        int[] tmp = new int[(high - low) + 1];
        int tmpIndex = 0;

        while ((left <= middle) && (right <= high))
        {
            if (input[left] < input[right])
            {
                inversions++;
                tmp[tmpIndex] = input[left];
                left = left + 1;
            }
            else
            {
                inversions++;
                tmp[tmpIndex] = input[right];
                right = right + 1;
            }
            tmpIndex = tmpIndex + 1;
        }

        if (left <= middle)
        {
            while (left <= middle)
            {
                inversions++;
                tmp[tmpIndex] = input[left];
                left = left + 1;
                tmpIndex = tmpIndex + 1;
            }
        }

        if (right <= high)
        {
            while (right <= high)
            {
                //inversions++;
                tmp[tmpIndex] = input[right];
                right = right + 1;
                tmpIndex = tmpIndex + 1;
            }
        }

        for (int i = 0; i < tmp.Length; i++)
        {
            inversions++;
            input[low + i] = tmp[i];

        }

    }

    public static string PrintArray(int[] input)
    {
        string result = String.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            result = result + input[i] + " ";
        }
        if (input.Length == 0)
        {
            result = "Array is empty.";
            return result;
        }
        else
        {
            return result;
        }
    }
}
