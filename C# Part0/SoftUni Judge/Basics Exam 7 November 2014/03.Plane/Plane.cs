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
       
                for (int i = 0; i < n / 2 + 2; i++)
                {
                    dotsOut = new string('.', ((3 * n) - 3) / 2 - i);
                    dotsIn = new string('.', 2 * i + 1);
                    Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
                }
           
            

            for (int i = 0; i < n / 2 - 1; i++)
            {
                dotsOut = new string('.', n - 4 - (2 * i));
                dotsIn = new string('.', ((3 * n) - (2 * (n - 3))) + 4 * i);
                Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
            }

            dotsOut = new string('.', n - 2);
            dotsIn = new string('.', n);

            Console.WriteLine("*" + dotsOut + "*" + dotsIn + "*" + dotsOut + "*");

            for (int i = 1; i <= n / 2 - 1; i++)
            {
                dotsOut = new string('.', n - 2 - 2 * i);
                string dotsBetween = new string('.', 2 * i - 1);
                dotsIn = new string('.', n);
                Console.WriteLine("*" + dotsOut + "*" + dotsBetween + "*" + dotsIn + "*" + dotsBetween + "*" + dotsOut + "*");
            }


            for (int i = 0; i < n - 1; i++)
            {
                dotsOut = new string('.', n - 1 - i);
                dotsIn = new string('.', n + 2 * i);
                Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
            }


            string asterix = new string('*', 3 * n);
            Console.WriteLine(asterix);

        }
    }
}