﻿/*Problem 3.	Variable in Hexadecimal Format
Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is “254”.
*/

using System;

class Variable_In_Hexadecimal_Format
{
    static void Main()
    {
        int number = 0xfe;

        Console.WriteLine("The number is:");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(number + " -> " +  "In hex format is:{0:X}", number);
    }
}