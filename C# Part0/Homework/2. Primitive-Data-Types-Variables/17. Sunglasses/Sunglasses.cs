using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int frame = 2 * n;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= 2 * frame + n - 1; j++)
            {
                if (i == 0 || i == n - 1)
                {
                    if (j < frame || j >= frame + n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else if (i == ((n / 2)))
                {
                    if (j == 0 || j == frame - 1 || j == frame + n || j == 2 * frame + n - 1)
                    {
                        Console.Write("*");
                    }
                    else if (j >= frame && j < frame + n)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
                else
                {
                    if (j > 0 && j < frame - 1 || j > frame + n && j < 2 * frame + n - 1)
                    {
                        Console.Write("/");
                    }
                    else if (j >= frame && j <= frame + n - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}