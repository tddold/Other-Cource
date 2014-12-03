// Problem 7.	Calculate N! / (K! * (N-K)!)
// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: 
// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. 

using System;
using System.Numerics;

class CalculateCombination
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFacturelN = 1;
        BigInteger nFacturelK = 1;
        BigInteger sumFacturiel = 1;
        BigInteger div = 1;
        int counter = 1;

        while (counter <= n)
        {
            nFacturelN *= counter;
            if (counter <= k)
            {
                nFacturelK *= counter;
            }
            counter++;            
        }

        counter = 1;
        while (counter <= (n-k))
        {
            sumFacturiel *= counter;
            counter++;
        }

        div = (nFacturelN / (nFacturelK * sumFacturiel));
       
        Console.WriteLine("n!/k!*(n-k)! = {0}", div);
    }
}