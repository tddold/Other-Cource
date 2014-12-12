//Write a program that reads a number n and a sequence of n integers, sorts them and prints them.

using System;
using System.Collections.Generic;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());
        int[] sequenceNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            sequenceNumbers[i] = int.Parse(Console.ReadLine()); 
        }


        // output        
        Console.WriteLine(string.Join(",", SortingSequenceNumbers(sequenceNumbers)));
    }

    private static int[] SortingSequenceNumbers(int[] sequenceNumbers)
    {
        for (int i = 0; i < sequenceNumbers.Length; i++)
        {
            for (int j = i+1; j < sequenceNumbers.Length; j++)
            {
                if (sequenceNumbers[i] > sequenceNumbers[j])
                {
                    int temp = sequenceNumbers[i];
                    sequenceNumbers[i] = sequenceNumbers[j];
                    sequenceNumbers[j] = temp;
                }
            }
        }

        return sequenceNumbers;
    }
}