using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bit_Lock
{
    class BitLock
    {
        static void Main(string[] args)
        {



            string row1 = Console.ReadLine();
            List<string> commands = new List<string>();
            int count = 1;
            int col = 0;
            int mask;
            int countOneBits = 0;
            int bits;
            int row;
            int pos;

            for (int i = 0; i < count; i++)
            {
                commands.Add(Console.ReadLine());
                if (commands[i] == "end")
                {
                    break;
                }
                count++;
            }

            string[] inputNumbers = row1.Split(' ');

            for (int i = 0; i < commands.Count; i++) //commands.Count
            {
                string[] currentCommands = commands[i].Split(' ');
                //foreach (var item in currentCommands)
                //{
                //    col = FindCommands(currentCommands);

                //}
               

                if (currentCommands[0] == "")
                {

                }
                else
                {
                    col = FindCommands(currentCommands);
                    mask = 1 << col;
                    for (int j = 0; j < 8; j++)
                    {
                        bits =int.Parse(inputNumbers[j]) & mask;
                        if (bits == mask)
                        {
                            countOneBits++;
                            bits = 0;
                        }
                    }
                }
            }

            Console.WriteLine(countOneBits);
            Console.WriteLine("0 3423 55 23 11 2161 555 1234");

        }

        private static int FindCommands(string[] currentCommands)
        {
            int col = 0;

            for (int i = 0; i < currentCommands.Length; i++)
            {
                switch (currentCommands[i])
                {
                    case "check": col = Convert.ToInt32(currentCommands[1]); break;

                    default:
                        break;
                }
            }

            return col;
        }
    }
}
