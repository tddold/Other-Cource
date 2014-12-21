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
            string[] numbers = Console.ReadLine().Split(' ');
            string input = string.Empty;
            string testCol = string.Empty;
            int val = 0;
            int mask;
            int bits;
            

            do
            {
                input = Console.ReadLine();

                if (input.Contains("check"))
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (Char.IsDigit(input[i]))
                        {
                            testCol = input[i].ToString();
                        }

                        if (testCol.Length > 0)
                        {
                            val = int.Parse(testCol);
                        }
                    }

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int testNumber = Convert.ToInt32(numbers[i]);

                        mask = 1 << val;
                        //if (testNumber & mask)
                        //{
                        //    bits++;
                        //}
                    }
                   
                }
                
            } while (input != "end");


           
        }
    }
}
