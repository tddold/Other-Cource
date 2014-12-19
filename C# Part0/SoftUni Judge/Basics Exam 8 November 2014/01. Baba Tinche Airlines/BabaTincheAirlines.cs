using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Baba_Tinche_Airlines
{
    class BabaTincheAirlines
    {
        static void Main(string[] args)
        {
            string[] firstClass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] businessClass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] economyClass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int firstClassTicket = 7000;
            int businessClassTicket = 3500;
            int economyClassTicket = 1000;

            double actualCastFirstClass =   
                                        ((int.Parse(firstClass[0]) - int.Parse(firstClass[1])) * firstClassTicket) +
                                        (int.Parse(firstClass[1]) * (firstClassTicket * 30 / 100)) +
                                        (int.Parse(firstClass[2]) * (firstClassTicket * 5 / 1000));

            double actualCastBusinessClass =
                                        ((int.Parse(businessClass[0]) - int.Parse(businessClass[1])) * businessClassTicket) +
                                        (int.Parse(businessClass[1]) * (businessClassTicket * 0.3)) +
                                        (int.Parse(businessClass[2]) * (businessClassTicket * 0.005));

            double actualCastEconomyClass = 
                                        ((int.Parse(economyClass[0]) - int.Parse(economyClass[1])) * economyClassTicket) +
                                        (int.Parse(economyClass[1]) * (economyClassTicket * 30 / 100)) +
                                        (int.Parse(economyClass[2]) * (economyClassTicket * 5 / 1000));
            double actualaCast = actualCastFirstClass + actualCastBusinessClass + actualCastEconomyClass;

            Console.WriteLine( (int)actualaCast);

            double maxCastFirstClass = (7000 * 12) + (7000 * 0.005 * 12);
            double maxCastBusinessClass = (3500 * 28) + (3500 * 0.005 * 28);
            double maxCastEconomyClass = (1000 * 50) + (1000 * 0.005 * 50);
            double maxCast = maxCastFirstClass + maxCastBusinessClass +maxCastEconomyClass;
           
            Console.WriteLine("{0:0}", maxCast - actualaCast);
        }
    }
}