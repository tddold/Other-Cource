﻿// Write a program that prints at the console the numbers from 1 to 1000, each at a separate line. You might need to learn how to use loops (search in Internet). Set a breakpoint in the line, which prints the next number in the Visual Studio code editor. Run the program through the debugger using the [F5] key. When the debugger stops at the breakpoint trace the code execution with [F10] key. You do not have to submit anything in your homework for this problem. Just play with the debugger to learn how it works.

using System;

class PrintLongSequenceAndDebugg
{
    static void Main()
    {
        ushort counter = 1;

        do
        {
            Console.WriteLine(counter);
            counter++;
        } while (counter <= 1000);
    }
}