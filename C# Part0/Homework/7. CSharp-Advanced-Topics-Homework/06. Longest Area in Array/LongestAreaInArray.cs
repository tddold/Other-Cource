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

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }

        // output
        //Console.WriteLine(string.Join("\n", array));
        //return;
        Console.WriteLine(string.Join("\n", CounterLongestArea(count, array)));

    }

    private static List<string> CounterLongestArea(int count, string[] array)
    {
        bool isFalse = false;
        int countMax = 0;
        List<string> result = new List<string>();
        result.Add(array[0]);

       
            for (int i = 1; i < array.Length; i++)
            {               
                if (array[i] == array[i - 1])
                {                    
                    result.Add(array[i]);
                    count++;
                }
                else
                {
                    if (countMax < count)
                    {
                        countMax = count;
                        result.RemoveAt(i);
                    }

                    count = 0;
                }
           }
        

        return result;
    }
}