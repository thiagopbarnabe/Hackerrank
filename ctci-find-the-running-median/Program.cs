using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    

    public static List<double> finalList;
    
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        finalList = new List<double>();
        
        StringBuilder s = new StringBuilder();
        for (int a_i = 0; a_i < n; a_i++)
        {
            add(Convert.ToDouble(Console.ReadLine()),1);
            s.AppendLine(media().ToString("N1",new CultureInfo("en-US")));
        }
        Console.Write(s.ToString());
    }

    public static double media()
    {
        if (finalList.Count() == 1)
            return finalList[0];

        if(finalList.Count() == 2)
            return (finalList[0]+finalList[1])/ 2;

        if(finalList.Count() == 3)
            return finalList[1];
        
        if(finalList.Count() == 4)
            return (finalList[1] + finalList[2]) / 2;

        return 0;
    }

    

    public static void add(double number, int indice)
    {
        if (finalList.Count() == 0 || number > finalList.Last())
        {
            finalList.Add(number);
            return;
        }

        if (number < finalList.First())
        {
            finalList.Insert(0, number);
            return;
        }

        

        if(number> finalList[indice] && number < finalList.Last())
        {
            if (number < finalList[indice + 1])
            {
                finalList.Insert(indice + 1, number);
            }
            else
            {
                add(number, (finalList.Count() - indice) / 2);
            }
        }

        if(number>finalList.First() && number < finalList[indice])
        {
            add(number,indice / 2);
        }


    }
}
