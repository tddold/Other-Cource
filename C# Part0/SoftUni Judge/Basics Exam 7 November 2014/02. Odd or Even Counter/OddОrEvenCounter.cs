using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_or_Even_Counter
{
    class OddОrEvenCounter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            string[] wordNumber = new string[10]
                                {"First", "Second", "Third", "Fourth", "Fifth", 
                                 "Sixth", "Seventh", "Eighth", "Ninth", "Tenth"};

            List<int> oddGroupCount = new List<int>();
            List<int> evenGroupCount = new List<int>();

            int[] input = new int[n * c];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            int oddNumber = 0;
            int evenNumber = 0;
            int indexMostOdd = 0;
            int indexMostEven = 0;

            int counter = 0;
            int oddCounter = 0;
            int evenCounter = 0;
            if (s == "odd")
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = counter; j < c + counter; j++)
                    {
                        if (input[j] % 2 != 0)
                        {
                            oddCounter++;
                        }
                    }
                    counter += c;
                    oddGroupCount.Add(oddCounter);
                    oddCounter = 0;
                }
            }
            else if (s == "even")
            {
                counter = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = counter; j < c + counter; j++)
                    {
                        if (input[j] % 2 == 0)
                        {
                            evenCounter++;
                        }
                    }
                    counter += c;
                    evenGroupCount.Add(evenCounter);
                    evenCounter = 0;
                }
            }

            if (s == "odd")
            {
                for (int i = 0; i < oddGroupCount.Count; i++)
                {
                    if (oddNumber < oddGroupCount[i])
                    {
                        oddNumber = oddGroupCount[i];
                        indexMostOdd = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < evenGroupCount.Count; i++)
                {
                    if (oddNumber < evenGroupCount[i])
                    {
                        evenNumber = evenGroupCount[i];
                        indexMostEven = i;
                    }
                }
            }

            if (oddNumber > 0 || evenNumber > 0)
            {
                if (s == "odd")
                {
                    Console.WriteLine("{0} set has the most {1} numbers: {2}", wordNumber[indexMostOdd], s, oddNumber);
                }
                else if (s == "even")
                {
                    Console.WriteLine("{0} set has the most {1} numbers: {2}", wordNumber[indexMostEven], s, evenNumber);
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
