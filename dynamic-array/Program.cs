using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        var nQ = Console.ReadLine().Split(" ");
        int n = int.Parse(nQ[0]);
        int[][] q = new int[int.Parse(nQ[1])][];
        int lastAnswer = 0;
        int[][] s = new int[n][];

        const int type = 0;
        const int x = 1;
        const int y = 2;

        StringBuilder str = new StringBuilder();
        for (int i = 0; i < q.Length; i++)
        {
            q[i] = Array.ConvertAll<string,int>(Console.ReadLine().Split(" "),Int32.Parse);
            var sIndex = (q[i][x] ^ lastAnswer) % n;
            if (q[i][type] == 1)
            {
                
                var sResult = s[sIndex];
                if (sResult == null)
                {
                    sResult = new int[1];
                    sResult[0] = q[i][y];
                }
                else
                {
                    int[] sResultTemp = new int[sResult.Length+1];
                    sResult.CopyTo(sResultTemp,0);
                    sResultTemp[sResultTemp.Length - 1] = q[i][y];
                    sResult = sResultTemp;
                }

                s[sIndex] = sResult;
            }
            else if(q[i][type] == 2)
            {
                var yIndex = (q[i][y] % s[sIndex].Length);
                lastAnswer = s[sIndex][yIndex];
                str.AppendLine(lastAnswer.ToString());
            }
                
        }

        Console.Write(str.ToString());

        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    }
}