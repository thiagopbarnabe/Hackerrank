// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
using System;
using System.Collections.Generic;
using System.Linq;
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Program
{
    
        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public List<int> lengthEachScene(List<char> inputList)
    {
        var length = new List<int>();
        var index = 0;
        while (index<inputList.Count)
        {
            int count = 0;
            string abc = "";
            for (int i = index; i < inputList.Count; i++)
            {
                if (inputList[index] == inputList[i] ||  abc.Contains(inputList[i].ToString()))
                {
                    for (int j = (count+index); j < i; j++)
                    {
                        abc += inputList[j];
                    }
                    count = (i - index) + 1;
                    
                }

                
            }
            length.Add(count);
            index += count;
        }

        return length;
    }

    static void Main(String[] args)
    {
        //List<char> input = "abca".ToCharArray().ToList();
        List<char> input = "ababcbacadefegdehijhklij".ToCharArray().ToList();

        //List<char> input = new List<char> { 'a', 'b', 'a', 'b', 'c', 'b', 'a','c','a','d','e','f','e','g','d','e','h','i','j','h','k','l','i','j' };
        (new Program()).lengthEachScene(input.ToList());
    }
    // METHOD SIGNATURE ENDS
}