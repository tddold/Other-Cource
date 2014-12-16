// Problem 14.	Longest Word in a Text
// Write a program to find the longest word in a text. 


using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] {'.',' ','\"','!','?',';',':','\'',},StringSplitOptions.RemoveEmptyEntries);

        int max = 0;
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length > max)
            {
                max = input[i].Length;
                index = i;
            }            
        }

        Console.WriteLine(input[index]);
    }
}