using System;

class GrandTheftExamo
{
    static void Main()
    {
        int escapeAttempt = int.Parse(Console.ReadLine());
        long thieves = 0;
        long beers = 0;
        long thievesSlapped = 0;
        long thievesEscaped = 0;



        long beersTemp = 0;
        for (int i = 0; i < escapeAttempt; i++)
        {
             thieves = long.Parse(Console.ReadLine());
             beers = long.Parse(Console.ReadLine());
            if (thieves >= 5)
            {
                thievesSlapped += 5;
                thievesEscaped += (thieves - 5);
            }
            else
            {
                thievesSlapped += thieves;
            }
            
            
            beersTemp += beers;
        }
        Console.WriteLine("{0} thieves slapped.", thievesSlapped);
        Console.WriteLine("{0} thieves escaped.", thievesEscaped);
        Console.WriteLine("{0} packs, {1} bottles.", beersTemp / 6, beersTemp % 6);
    }
}

