using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    public const string OpeningBrackets = "{[(";
    public const string ClosingBrackets = "}])";
    static void Main(String[] args)
    {
        //int t = Convert.ToInt32(Console.ReadLine());
        //StringBuilder s = new StringBuilder();
        //for (int a0 = 0; a0 < t; a0++)
        //{
        //    string expression = Console.ReadLine();
        //    s.AppendLine(isBracketBalanced(expression) ? "YES" : "NO");
        //}

        //Console.Write(s.ToString());

        StringBuilder s = new StringBuilder();
        string[] lines = File.ReadAllLines(@"C:\Users\thiago.barnabe\Documents\Source\Hackerrank\input06.txt");
        string[] outputLines = File.ReadAllLines(@"C:\Users\thiago.barnabe\Documents\Source\Hackerrank\output06.txt");
        for (int i = 1; i < lines.Length; i++)
        {
            string expression = lines[i];
            string result = isBracketBalanced(expression) ? "YES" : "NO";
            string exprectedOutput = outputLines[i-1];
            bool tabelaVerdade = result == exprectedOutput;

            s.AppendLine(result+ " " + exprectedOutput + " " + (tabelaVerdade ? "YES" : "NO"));
        }

        
        

        Console.Write(s.ToString());
    }

    private static bool isBracketBalanced(string expression)
    {   
        if(expression.Length%2 != 0 || string.IsNullOrEmpty(expression)) return false;

        Stack<char> brackets = new Stack<char>();
        for (int i = 0; i < expression.Length; i++)
        {   
            

            if(brackets.Count() > 0 && OpeningBrackets.IndexOf(brackets.Peek()) == ClosingBrackets.IndexOf(expression[i]))
            {
                brackets.Pop();
            }
            else 
            {
                if (OpeningBrackets.IndexOf(expression[i]) >= 0)
                    brackets.Push(expression[i]);
                else
                    return false;
            }
        }

        return brackets.Count() == 0;
    }
    
}
