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
            double price = double.Parse(Console.ReadLine());
            int partyDay = int.Parse(Console.ReadLine());

            int saveCash = (30 - partyDay) * 2;
            int partyCash = partyDay * 5;
            int average = saveCash - partyCash;

            int counCash = 0;
            int years = 0;
            int month = 0;
            //int countYears = 0;
            //int countmonth = 0;

            double neededMonth = price / average;

            int twoDigitsAfterDots = (int) ((neededMonth / 12) * 100) % 10;
            int firstDigitsAfterDots = (int) ((neededMonth / 12) * 10) % 10;

            if (twoDigitsAfterDots > 0 && twoDigitsAfterDots < 5)
            {
                firstDigitsAfterDots++;
                month = firstDigitsAfterDots;
            }
            else
            {                
                firstDigitsAfterDots = firstDigitsAfterDots++ + 2;
                month = firstDigitsAfterDots;
            }

            month = firstDigitsAfterDots;
            years = (int) neededMonth / 12;
            if (years < 0 || month < 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                Console.WriteLine("{0} years, {1} months", years, month);
            }
           
        }
    }
}
