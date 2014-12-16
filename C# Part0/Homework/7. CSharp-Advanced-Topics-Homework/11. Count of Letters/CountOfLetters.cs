// Problem 11.	Count of Letters
// Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. Use the input and output format from the examples below. 

using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        string[] elements = Console.ReadLine().Split();        
        SortedDictionary<string,int> elementsCount = new SortedDictionary<string, int>(new Comparer<string>());

        for (int i = 0; i < elements.Length; i++)
        {
            if (elementsCount.ContainsKey(elements[i]))
            {
              elementsCount[elements[i]]++;
            }
            else
            {
                elementsCount.Add(elements[i], 1);
            }
        }

        foreach (var item in elementsCount)
        {
            Console.WriteLine("{0} -> {1}",item.Key,item.Value);
        }
    }
}

class Comparer<T> : IComparer<T> where T : IComparable<T>
{
    public int Compare(T x, T y)
    {
        return x.CompareTo(y);
    }
}