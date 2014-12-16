// Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        List<string> names = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
        string[] namesToRemove = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        for (int i = 0; i < namesToRemove.Length; i++)
        {
            while (names.Remove(namesToRemove[i]))
            {                
            }
        }

        Console.WriteLine(String.Join(", ", names));
    }
}