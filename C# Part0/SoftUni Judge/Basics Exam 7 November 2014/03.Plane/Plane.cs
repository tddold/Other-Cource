using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Plane
{
    class Plane
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string dotsOut = new string('.', 3 * n / 2);

            Console.WriteLine(dotsOut + "*" + dotsOut);

            string dotsIn;
            for (int i = 0; i < n-n / 3; i++)
            {
                dotsOut = new string('.', n + n / 3 - i);
                dotsIn = new string('.', 2 * i + 1);
                Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
            }

            for (int i = 0; i < n / 3; i++)
            {
                dotsOut = new string('.', n / 2 -1  - 2 * i);
                dotsIn = new string('.', ((3 * n) - (2 * (n-3))) - i);
                Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
                
            }
            Console.WriteLine(n / 4);
        }
    }
}
