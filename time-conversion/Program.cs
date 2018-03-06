using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string timeConversion(string s)
    {
        var hour = int.Parse(s.Substring(0, 2));
        if (s.Substring(8, 2) == "PM")
        {
            hour += 12;
            if (hour == 24)
                hour = 12;
        }
        else if (hour == 12)
            hour = 0;

        return hour.ToString("00") + s.Substring(2, 6);
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
