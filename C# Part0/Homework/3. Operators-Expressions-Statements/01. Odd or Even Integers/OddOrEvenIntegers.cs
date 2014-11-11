// Problem 1.	Odd or Even Integers
// Write an expression that checks if given integer is odd or even


using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 40));
        Console.Write("The entered number is odd! --> ");

        if (number%2 != 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}