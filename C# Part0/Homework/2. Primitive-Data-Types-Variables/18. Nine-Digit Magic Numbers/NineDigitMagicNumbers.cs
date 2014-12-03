using System;
using System.Collections.Generic;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int[] abc = new int[3];
        int[] def = new int[3];
        int[] ghi = new int[3];

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 7; j++)
            {
                for (int k = 1; k <= 7; k++)
                {
                    abc[0] = i;
                    abc[1] = j;
                    abc[2] = k;
                    def[0] = j;
                    def[1] = k;
                    def[2] = i;
                    ghi[0] = k;
                    ghi[1] = i;
                    ghi[2] = j;

                    int intAbc = abc[0] * 100 + abc[1] * 10 + abc[2];
                    int intDef = def[0] * 100 + def[1] * 10 + def[2];
                    int intGhi = ghi[0] * 100 + ghi[1] * 10 + ghi[2];


                    int sumM = intDef - intAbc;
                    int sumN = intGhi - intDef;

                    //string strAbc = abc.ToString();
                    //string strDef = def.ToString();
                    //string strGhi = ghi.ToString();

                    int sumAbc = abc[0] + abc[1] + abc[2];
                    int sumDef = def[0] + def[1] + def[2];
                    int sumGhi = ghi[0] + ghi[1] + ghi[2];

                    int sumSequensNumber = sumAbc + sumDef + sumGhi;

                    if (sumSequensNumber == sum)
                    {
                        if (sumM == diff && sumN == diff || intAbc <= intDef ||intDef <= intGhi)
                        {
                            Console.WriteLine("{0} - {1} = {4,-5} {1} - {2} = {3}", intGhi, intDef, intAbc, sumM, sumN);
                        }
                    }
                }
            }
        }


    }
}