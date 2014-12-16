using System;
using System.Collections.Generic;
using System.Linq;

class MatrixOfPalindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);

        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = string.Format("{0}{1}{2}", (char)( row + 'a'), (char) (col + row +'a'), (char) (row + 'a'));
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row,col] + " ");
            }

            Console.WriteLine();
        }
    }
}