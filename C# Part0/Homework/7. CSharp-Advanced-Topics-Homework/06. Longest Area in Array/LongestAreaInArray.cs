// Problem 6.	Longest Area in Array
// Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them. 


using System;
using System.Collections.Generic;
using System.Linq;

class LongestAreaInArray
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }

        // logic
        int maxElementsCount = 0;
        int elementIndex = 0;
        int currentElementCount = 0;

        for (int i = 0; i < n; i++)
        {
            if (i < n - 1 && array[i] == array[i + 1])
            {
                currentElementCount++;
            }
            else
            {
                if (currentElementCount > maxElementsCount)
                {
                    maxElementsCount = currentElementCount;
                    elementIndex = i;
                }

                currentElementCount = 0;
            }
        }
        maxElementsCount++;

        // print
        Console.WriteLine(maxElementsCount);
        for (int i = 0; i < maxElementsCount; i++)
        {
            Console.WriteLine(array[elementIndex]);
        }
    }
}