﻿// Problem 4.	Rectangles
// Write an expression that calculates rectangle’s perimeter and area by given width and height


using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle's perimer=ter, width and height.");
        Console.Write("Width --> ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height --> ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine(new string('-',40));
        Console.WriteLine("Rentangle perimeter is --> {0}", (2 * width + 2 * height));
        Console.WriteLine("Rentangle area is --> {0}", (width * height));
    }
}