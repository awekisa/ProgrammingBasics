using System;

class FourFactors
{
    static void Main()
    {
        uint FG = uint.Parse(Console.ReadLine());
        uint FGA = uint.Parse(Console.ReadLine());
        uint ThreeP = uint.Parse(Console.ReadLine());
        uint TOV = uint.Parse(Console.ReadLine());
        uint ORB = uint.Parse(Console.ReadLine());
        uint OppDRB = uint.Parse(Console.ReadLine());
        uint FT = uint.Parse(Console.ReadLine());
        uint FTA = uint.Parse(Console.ReadLine());

        double eFGPerc = (FG + 0.5 * ThreeP) / FGA;
        double TOVPerc = TOV / (FGA + 0.44 * FTA + TOV);
        double ORBPerc = (double)ORB / (ORB + OppDRB);
        double FTPerc = (double)FT / FGA;

        Console.WriteLine("eFG% {0:F3}", eFGPerc);
        Console.WriteLine("TOV% {0:F3}", TOVPerc);
        Console.WriteLine("ORB% {0:F3}", ORBPerc);
        Console.WriteLine("FT% {0:F3}", FTPerc);

    }
}

