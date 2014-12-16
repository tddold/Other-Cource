// Problem 13.	Average Load Time Calculator
// We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Print the output in the format given below. Use double doubleing-point precision. 


using System;
using System.Collections.Generic;
using System.Linq;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        var input = @"2014-Apr-01 02:01 http://softuni.bg 8.37725
2014-Apr-01 02:05 http://www.nakov.com 11.622
2014-Apr-01 02:06 http://softuni.bg 4.33
2014-Apr-01 02:11 http://www.google.com 1.94
2014-Apr-01 02:11 http://www.google.com 2.011
2014-Apr-01 02:12 http://www.google.com 4.882
2014-Apr-01 02:34 http://softuni.bg 4.885
2014-Apr-01 02:36 http://www.nakov.com 10.74
2014-Apr-01 02:36 http://www.nakov.com 11.75
2014-Apr-01 02:38 http://softuni.bg 3.886
2014-Apr-01 02:44 http://www.google.com 1.04
2014-Apr-01 02:48 http://www.google.com 1.4555
2014-Apr-01 02:55 http://www.google.com 1.977
".Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        string[][] reportMatrix = new string[input.Length][];
        for (int i = 0; i < input.Length; i++)
        {
            reportMatrix[i] = input[i].Split();
        }

        Dictionary<string, List<double>> elementsCount = new Dictionary<string, List<double>>();

        for (int row = 0; row< reportMatrix.GetLength(0); row++)
        {
            if (elementsCount.ContainsKey(reportMatrix[row][2]))
            {
                elementsCount[reportMatrix[row][2]].Add(double.Parse(reportMatrix[row][3]));
            }
            else
            {
                elementsCount.Add(reportMatrix[row][2], new List<double>(){double.Parse(reportMatrix[row][3])});
            }         
        }

        foreach (var item in elementsCount)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value.Average());
        }
    }
}
