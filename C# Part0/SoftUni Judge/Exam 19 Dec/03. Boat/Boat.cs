using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Boat
{
    class Boat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string dotsLeft = new string('.', n - 1);
            string dotsRight = new string('.', n);
            string asterix = "*";
            Console.WriteLine(dotsLeft + asterix + dotsRight);
            for (int i = 0; i < n / 2; i++)
            {
                dotsLeft = new string('.', n - 3 - 2 * i);
                asterix = new string('*', 3 + 2 * i);
                Console.WriteLine(dotsLeft + asterix + dotsRight);
            }

            for (int i = 0; i < n / 2; i++)
            {
                dotsLeft = new string('.', 2 + 2 * i);
                asterix = new string('*', n - 2 - 2 * i);
                Console.WriteLine(dotsLeft + asterix + dotsRight);
            }

            for (int i = 0; i < n / 2; i++)
            {
                dotsLeft = new string('.', i);
                asterix = new string('*', 2*n - 2 * i);
                Console.WriteLine(dotsLeft + asterix + dotsLeft);
            }

        }
    }
}
