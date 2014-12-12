// Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 

using System;
using System.Collections.Generic;
using System.Linq;

class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n));
    }

    private static bool IsPrime(long n)
    {
        bool result = true;

        if (n == 0 || n == 1)
        {
            return false;
        }

        for (long i = 2; i <= (long) Math.Sqrt(n); i++)
        {            
            if (n % i == 0 )
            {
                return false;
            }
        }

        return result;
    }
}