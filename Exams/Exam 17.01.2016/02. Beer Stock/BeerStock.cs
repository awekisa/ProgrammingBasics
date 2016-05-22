using System;
using System.Numerics;

class BeerStock
{
    static void Main()
    {
        ulong reserved = ulong.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        ulong beerCount = 0;
        while (input != "Exam Over")
        {
            string[] temp = input.Split(' ');
            if (temp[1] == "beers")
            {
                beerCount += ulong.Parse(temp[0]);
            }
            else if (temp[1] == "sixpacks")
            {
                beerCount += ulong.Parse(temp[0]) * 6;
            }
            else if (temp[1] == "cases")
            {
                beerCount += ulong.Parse(temp[0]) * 24;
            }
            input = Console.ReadLine();
        }
        if (beerCount >= 100)
        {
            beerCount -= beerCount / 100;
        }
        if (beerCount >= reserved)
        {
            ulong casesLeft = (beerCount - reserved) / 24;
            ulong sixPacksLeft = (beerCount - reserved) % 24 / 6;
            ulong beersLeft = (beerCount - reserved) % 24 % 6;
            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixPacksLeft, beersLeft);
        }
        else
        {
            ulong casesLeft = (reserved - beerCount) / 24;
            ulong sixPacksLeft = (reserved - beerCount) % 24 / 6;
            ulong beersLeft = (reserved - beerCount) % 24 % 6;
            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", casesLeft, sixPacksLeft, beersLeft);
        }
    }
}

