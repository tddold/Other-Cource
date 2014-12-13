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
        Console.WriteLine("Sorting by Selection Sort Algorithm: {0}", string.Join(",", SortingSequenceNumbersSelectionSort(sequenceNumbers)));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Sorting by Bubble Sort Algorithm: {0}", string.Join(",", SortingSequenceNumbersBubbleSort(sequenceNumbers)));
        Console.WriteLine(new string('-', 40));
    }

    private static IEnumerable<int> SortingSequenceNumbersBubbleSort(int[] sequenceNumbers)
    {
        List<int> result = new List<int>();

        bool isSorted = false;
        while (!isSorted)
        {
            isSorted = true;
            for (int i = 0; i < sequenceNumbers.Length - 1; i++)
            {
                if (sequenceNumbers[i] > sequenceNumbers[i + 1])
                {
                    isSorted = false;
                    var temp = sequenceNumbers[i];
                    sequenceNumbers[i] = sequenceNumbers[i + 1];
                    sequenceNumbers[i + 1] = temp;
                }
            }
        }

        for (int i = 0; i < sequenceNumbers.Length; i++)
        {
            if (i == 0)
            {
                result.Add(sequenceNumbers[i]);
            }
            else if (result[result.Count - 1] != sequenceNumbers[i])
            {
                result.Add(sequenceNumbers[i]);
            }
        }

        return result;
    }

    private static List<int> SortingSequenceNumbersSelectionSort(int[] sequenceNumbers)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < sequenceNumbers.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < sequenceNumbers.Length; j++)
            {
                if (sequenceNumbers[min] > sequenceNumbers[j])
                {
                    min = j;
                }
            }

            if (i == 0)
            {
                result.Add(sequenceNumbers[min]);
            }
            else if (result[result.Count - 1] != sequenceNumbers[min])
            {
                result.Add(sequenceNumbers[min]);
            }

            int temp = sequenceNumbers[min];
            sequenceNumbers[min] = sequenceNumbers[i];
            sequenceNumbers[i] = temp;
        }

        return result;
    }
}