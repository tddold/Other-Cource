
/*Problem 7.	Quotes in Strings
Declare two string variables and assign them with following value:
(The "use" of quotations causes difficulties.)
Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.
*/
using System;

class Quotes_In_Strings
{
    static void Main()
    {
        string str = "The \"use\" of quotations causes difficulties.";
        string quot = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("Print string variables:");
        Console.WriteLine(new string('-',40));
        Console.WriteLine("First string variable  --> {0}", str);
        Console.WriteLine("Second string variable --> {0}", quot);
        Console.WriteLine(new string('-', 40));
    }
}