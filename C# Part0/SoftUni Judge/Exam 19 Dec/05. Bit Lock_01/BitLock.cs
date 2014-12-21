using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bit_Lock_01
{
    class BitLock
    {
        static void Main(string[] args)
        {
            string numbersLine1 = Console.ReadLine();
            List<string> input = new List<string>();
            List<string> commands = new List<string>();
            List<int> col = new List<int>();
            List<int> row = new List<int>();
            List<int> pos = new List<int>();
            string[] forSeparate = new string[3];

            while (Console.ReadLine() != "end")
            {
                input.Add(Console.ReadLine());
                forSeparate = Console.ReadLine().Split(' ');

                if (forSeparate.Length == 2)
                {
                    commands.Add(forSeparate[0]);
                    col.Add(int.Parse(forSeparate[1]));
                }
                else if(forSeparate.Length == 2)
                {
                    row.Add(int.Parse(forSeparate[0]));
                    commands.Add(forSeparate[1]);
                    col.Add(int.Parse(forSeparate[2]));
                }
                Console.WriteLine(" ");
                Console.WriteLine();
            }
        }
    }
}
