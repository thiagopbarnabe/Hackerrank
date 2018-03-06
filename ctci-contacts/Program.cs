using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> contacts = new Dictionary<string, int>();
        for (int a0 = 0; a0 < n; a0++)
        {
            string[] tokens_op = Console.ReadLine().Split(' ');
            string op = tokens_op[0];
            string contact = tokens_op[1];

            if (op == "add")
            {
                if(!contacts.ContainsKey(contact))
                    contacts.Add(contact, 0);

                contacts[contact]++;
            }
            else
            {
                int contactsNumber = 0;
                contacts.TryGetValue(contact, out contactsNumber);
                Console.WriteLine(contactsNumber);
            }




        }
    }
}
