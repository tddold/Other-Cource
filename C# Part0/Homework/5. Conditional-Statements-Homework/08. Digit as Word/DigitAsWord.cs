// Problem 8.	Digit as Word
// Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Print “not a digit” in case of invalid inut. Use a switch statement. 

using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Enter interger number [0-9]: ");
        string number = Console.ReadLine();

        switch (number)
        {
            case "0":
            Console.WriteLine("Rezult -->  zero");
            break;
            case "1":
            Console.WriteLine("Rezult -->  one");
            break;
            case "2":
            Console.WriteLine("Rezult -->  two");
            break;
            case "3":
            Console.WriteLine("Rezult -->  three");
            break;
            case "4":
            Console.WriteLine("Rezult -->  four");
            break;
            case "5":
            Console.WriteLine("Rezult -->  five");
            break;
            case "6":
            Console.WriteLine("Rezult: --> six");
            break;
            case "7":
            Console.WriteLine("Rezult -->  seven");
            break;
            case "8":
            Console.WriteLine("Rezult -->  eidht");
            break;
            case "9":
            Console.WriteLine("Rezult -->  nine");
            break;
            default:
            Console.WriteLine("not a digit");
            break;
        }
    }
}