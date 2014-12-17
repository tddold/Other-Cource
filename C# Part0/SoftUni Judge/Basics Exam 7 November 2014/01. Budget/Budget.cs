using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Budget
{
    class Budget
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long p = long.Parse(Console.ReadLine());
            long h = long.Parse(Console.ReadLine());

            long normalWeekends= 4- h;
            long hometownWeekends = h;
            long normalWeekendsDay = normalWeekends * 2;
            long weekdaysOut = p;
            long weekdaysNormal = 22- weekdaysOut;
            long renta = 150;

            long expense = normalWeekendsDay * 20;
            expense += weekdaysOut * ((n * 3 / 100) + 10);
            expense += weekdaysNormal * 10 + renta;

            long total = n - expense;

            if (total == 0)
            {
                Console.WriteLine("Exact Budget.");
            }
            else if (total > 0 )
            {
                Console.WriteLine("Yes, leftover {0}.", total);
            }
            else
            {
                Console.WriteLine("No, not enough {0}.", Math.Abs(total));
            }
        }
    }
}
