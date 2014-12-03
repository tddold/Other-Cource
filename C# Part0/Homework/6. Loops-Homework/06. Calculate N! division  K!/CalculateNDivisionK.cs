// Problem 6.	Calculate N! / K!
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 

using System;

class CalculateNDivisionK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int nFacturelN = 1;
        int nFacturelK = 1;
        int div = 1;
        int counter = 1;

        while (counter <= n)
        {
            nFacturelN *= counter;
            if (counter <= k)
            {
                nFacturelK *= counter;
            }

            div = (nFacturelN / nFacturelK);
            counter++;
        }

        Console.WriteLine("n!/k! = {0}", div);
    }
}