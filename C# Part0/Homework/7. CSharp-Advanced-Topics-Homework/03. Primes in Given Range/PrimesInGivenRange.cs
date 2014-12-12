using System;
using System.Collections.Generic;
using System.Linq;

class PrimesInGivenRange
{
    static void Main()
    {
        // input
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        // logic
        var primesInRange = FindPrimesInRange(startNumber, endNumber);

        if (primesInRange.Count == 0)
        {
            Console.WriteLine("empty list");
            return;
        }

        Console.WriteLine(string.Join(",", primesInRange));
    }

    private static List<int> FindPrimesInRange(int startNumber, int endNumber)
    {
        List<int> primeNumbers = new List<int>();

        for (int i = startNumber; i <= endNumber; i++)
        {
            if (IsPrime(i))
            {
                primeNumbers.Add(i);
            }
        }

        return primeNumbers;
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
            if (n % i == 0)
            {
                return false;
            }
        }

        return result;
    }
}