using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[(2 * n)];
        int sumN1 = 0;
        int sumN2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            sumN1 += array[i];
        }
        for (int i = n; i < array.Length; i++)
        {
            sumN2 += array[i];
        }
        if (sumN1 == sumN2)
        {
            Console.WriteLine("Yes, sum={0}", sumN1);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumN1 - sumN2));
        }
    }
}