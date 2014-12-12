// Define a method Fib(n) that calculates the nth Fibonacci number.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Threading;                                 // for timer

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var watch = new Stopwatch();                    //variable for timer
        watch.Start();
        Console.WriteLine("Iteractive metod --> {0}", CalculateFibonacciNumber(n));
       
        Console.WriteLine("Time for exequting iteractive metod: {0}ms", watch.ElapsedMilliseconds);
        watch.Reset();
        Console.WriteLine(new string('-', 40));
        watch.Start();
        Console.WriteLine("Recursive metod --> {0}", CalculateFibonacciNumberRecursive(n));
        Console.WriteLine("Time for exequting recursive  metod: {0}ms", watch.ElapsedMilliseconds);
        Console.WriteLine(new string('-', 40));

    }

    private static BigInteger CalculateFibonacciNumberRecursive(int n)
    {
        BigInteger result = 0;
        if (n == 0)
        {
            return 1;
        }

        for (int i = n; i > 0; i--)
        {
            result = CalculateFibonacciNumberRecursive(n - 1) + CalculateFibonacciNumberRecursive(n - 2);
        }

        return result;
    }

    private static BigInteger CalculateFibonacciNumber(int n)
    {
        BigInteger result = 0;
        BigInteger first = 0;
        BigInteger second = 1;

        if (n == 0)
        {
            return 1;
        }

        for (int i = 0; i < n; i++)
        {
            result = first + second;
            first = second;
            second = result;
        }

        return result;
    }
}