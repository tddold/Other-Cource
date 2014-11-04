// Create console application that prints your first and last name, each at a separate line.

using System;

class PrintNames
{
    static void Main(string[] args)
    {
        string firstName = "Todor";
        string lastName = "Dakov";

        Console.WriteLine("First name is: {0}\nLast name is : {1}", firstName, lastName);
    }
}