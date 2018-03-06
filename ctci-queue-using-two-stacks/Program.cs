using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution
{
    public class Queue<T>
    {
        private Stack<T> sTemp = new Stack<T>();
        private Stack<T> sFinal = new Stack<T>();

        public void Enqueue(T item)
        {
            sTemp.Push(item);
        }

        public T Dequeue()
        {
            if(sFinal.Count == 0)
                while (sTemp.Count > 0)
                {
                    sFinal.Push(sTemp.Pop());
                }

            return sFinal.Pop();
        }

        public T Peek()
        {
            if (sFinal.Count == 0)
                while (sTemp.Count > 0)
                {
                    sFinal.Push(sTemp.Pop());
                }

            return sFinal.Peek();
        }
    }

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int q = Convert.ToInt32(Console.ReadLine());
        Queue<int> queue = new Queue<int>();
        StringBuilder s = new StringBuilder();
        for (int i = 0; i < q; i++)
        {
            var query = Console.ReadLine().Split(' ');
            if(query[0] == "1")
                queue.Enqueue(int.Parse(query[1]));

            if(query[0] == "2")
                queue.Dequeue();

            if(query[0]== "3")
                s.AppendLine(queue.Peek().ToString());
        }

        Console.Write(s.ToString());
    }


}