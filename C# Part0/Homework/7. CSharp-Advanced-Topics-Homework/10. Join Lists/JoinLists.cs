//Problem 10.	Join Lists
// Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. 


using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        List<string> firstList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> secondList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        List<int> joinedList = firstList.Concat(secondList).Distinct().Select(n => int.Parse(n)).OrderBy(n => n).ToList();

        Console.WriteLine(String.Join(" ", joinedList));
    }
}