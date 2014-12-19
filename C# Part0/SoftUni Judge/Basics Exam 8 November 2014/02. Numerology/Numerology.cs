using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numerology
{
    class Numerology
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            decimal multyplyBirthdate = Convert.ToDecimal(input[0]) * Convert.ToDecimal(input[1]) * Convert.ToDecimal(input[2]);

            if (Convert.ToDecimal(input[1]) % 2 != 0)
            {
                multyplyBirthdate *= multyplyBirthdate;
            }

            string selestialNumber = multyplyBirthdate.ToString();

            int sumAlfaBeta = 0;
            string name = input[3];
            string[] alfaBeta = new string[]
            {"a","b","c","d","i","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
               "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < alfaBeta.Length; j++)
                {
                    if (name[i].ToString() == alfaBeta[j] && j <= 25)
                    {
                        sumAlfaBeta += j + 1;
                    }
                    else if (name[i].ToString() == alfaBeta[j] && j > 25 && j < 52)
                    {
                        sumAlfaBeta += 2 * (j - 25);
                    }
                }
            }
            multyplyBirthdate = 0;
            multyplyBirthdate = decimal.Parse(selestialNumber) + sumAlfaBeta;
            selestialNumber = multyplyBirthdate.ToString();

            int sum = 0;
            for (int i = 0; i < selestialNumber.Length; i++)
            {
                sum += selestialNumber[i] - 48;
            }

            while (sum > 13)
            {
                selestialNumber = sum.ToString();
                int newsum = 0;
                for (int i = 0; i < selestialNumber.Length; i++)
                {
                    newsum += selestialNumber[i] - 48;
                }

                sum = newsum;
            }

            Console.WriteLine(sum);
        }
    }
}
