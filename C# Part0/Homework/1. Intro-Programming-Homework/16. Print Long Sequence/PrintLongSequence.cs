//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintLongSequence
{
    static void Main()
    {
        //for (int i = 2; i < 1002; i++)
        //{
        //    Console.Write((i % 2 == 0 ? i : -i) + ",");
        //}
        //Console.WriteLine();

        ushort counter = 2;

        while (counter <= 1001)
        {
            Console.Write((counter % 2 == 0 ? counter : -counter) + ",");
            counter++;
        }
        Console.WriteLine();
    }
}