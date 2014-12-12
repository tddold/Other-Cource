// Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them

using System;
using System.Collections.Generic;
using System.Linq;

class DifferenceBetweenDates
{
    static void Main()
    {
        //input
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        //logic
        TimeSpan daysBetween = secondDate - firstDate;

        //output
        Console.WriteLine(daysBetween.Days);
    }
}