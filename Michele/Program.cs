using System;

using System.Collections.Generic;
using System.Linq;

// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM

// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED

// DEFINE ANY CLASS AND METHOD NEEDED

// CLASS BEGINS, THIS CLASS IS REQUIRED

public class Solution

{

    // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED

    public List<string> subStringsKDist(string inputStr, int num)

    {
        var strings = new List<String>();        
        for (int i = 0; i <= inputStr.Length-num; i++)
        {
            string input = inputStr.Substring(i, num);
            if (isDistinct(input))
                strings.Add(input);
        }
        return strings.Distinct().ToList();
        // WRITE YOUR CODE HERE

    }

    public bool isDistinct(string s)
    {
        for (int i = 0; i < s.Length-1; i++)
        {
            for (int j = i+1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                    return false;
            }
        }

        return true;
    }

    // METHOD SIGNATURE ENDS

}