using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leapYear = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        int hometownPlays = h;
        double normalPlays = ((52 - h) * 2) / 3;
        double holdayPlays = p / 2;
        int leapPlays = 0;

        if (leapYear == "t")
        {
            leapPlays = 3;
            Console.WriteLine("{0:0}", (hometownPlays + normalPlays + holdayPlays + leapPlays));
        }
        else
        {
            Console.WriteLine("{0:0}", (hometownPlays + normalPlays + holdayPlays + leapPlays));
        }
    }
}