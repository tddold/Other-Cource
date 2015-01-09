using System;

class CurrentDateAndTime
{
    static void Main()
    {
        Console.WriteLine(new string('-', 60));
        DateTime now = DateTime.Now;       
        Console.WriteLine("The current date and time is: {0}", now);
        Console.WriteLine(new string('-', 60));
    }
}