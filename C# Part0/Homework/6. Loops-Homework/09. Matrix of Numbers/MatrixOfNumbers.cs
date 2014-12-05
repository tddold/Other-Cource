using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 0;
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write("{0} ", col + counter);
            }

            Console.WriteLine();
            counter++;
        }
    }
}