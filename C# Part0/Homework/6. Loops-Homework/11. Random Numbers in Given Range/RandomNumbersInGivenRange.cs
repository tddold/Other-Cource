// Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 
using System;
using System.Threading;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: n, min and max");
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        while (min > max)
        {
            Console.WriteLine("You are need to enter number where is  min <= max");
            min = int.Parse(Console.ReadLine());
            max = int.Parse(Console.ReadLine());
        }

        Random random = new Random();
        //Thread.Sleep(50);
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", random.Next(min, max + 1));
        }

        Console.WriteLine();
    }
}