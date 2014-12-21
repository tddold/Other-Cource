using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Piggy_Bank
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            double price = int.Parse(Console.ReadLine());
            int partyDay = int.Parse(Console.ReadLine());

            int month = 30;
            int yers = 12;

            int saveCashMonth = (month - partyDay) * 2;
            int neededPartyCadh = partyDay * 5;
            int average = saveCashMonth - neededPartyCadh;

            double neededMonth = price / average;
            double neededYars = neededMonth / 12.0;

            double realNumber = neededMonth * 100;
            
            int twoNumberAfterDot = (int)realNumber % 10;
            int firstNumberAfterDot = ((int)realNumber / 10) % 10;


            int monthForNeededYars = (int)neededYars * 12;
            double resultMount = Convert.ToInt32( neededMonth) - monthForNeededYars;
            if (twoNumberAfterDot > 0)
            {
                resultMount += 1;
            }

            int resultYears = (int)neededYars;
           
            if (neededYars >=  0 && resultMount >= 0 )
            {
                Console.WriteLine("{0:0} years, {1} months", resultYears, resultMount);
            }
            else
            {
                Console.WriteLine("never");
            }

        }
    }
}
