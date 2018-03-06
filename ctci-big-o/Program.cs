using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    public static int[] primes;
    public static int max;
    public static int lastTestedNumber;
    static void Main(String[] args)
    {
        
        int p = Convert.ToInt32(Console.ReadLine());
        primes = new int[2];
        max = 1;
        primes[0] = 2;
        primes[1] = 3;
        lastTestedNumber = 3;

        StringBuilder s = new StringBuilder();
        for (int a0 = 0; a0 < p; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            s.AppendLine(isPrime(n) ? "Prime" : "Not prime");
        }

        Console.Write(s.ToString());
    }

    private static bool isPrime(int n)
    {
        if (n == 1) return false;
        if (n == 2) return true;

        var sqrtn = Convert.ToInt32(Math.Sqrt(n));
        //if (primes[max] > sqrtn)
        //    return false;

        if (Array.BinarySearch(primes,n) >=0)
            return true;

        if ((sqrtn / 2) + 1 > primes.Length)
        {
            int[] newPrimes = new int[(sqrtn / 2) + 1];
            Array.Copy(primes, newPrimes, primes.Length);
            primes = newPrimes;
        }
        //int[] temp = new int[primes.Length+1];

        
        if (lastTestedNumber % 2 == 0)
            lastTestedNumber++;

        
        for (int i = lastTestedNumber; i<= sqrtn || i== lastTestedNumber; i+=2)
        {
            bool isPrime = true;
            for (int j = 0; j <= max; j++)
            {
                if (i == lastTestedNumber)
                {
                    isPrime = false;
                    if (n % primes[j] == 0)
                    {
                        
                        return false;                        
                    }
                }
                else
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            lastTestedNumber = i;

            if (isPrime)
            {
                primes[++max] = i;
                if (n % i == 0)
                    return false;
            }

            
        }

        return true;
        
    }
}
