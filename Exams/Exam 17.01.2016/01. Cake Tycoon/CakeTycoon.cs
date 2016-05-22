using System;
using System.Numerics;

class CakeTycoon
{
    static void Main()
    {
        ulong wantedCakes = ulong.Parse(Console.ReadLine());
        decimal flourNeeded = decimal.Parse(Console.ReadLine());
        ulong availableFlour = ulong.Parse(Console.ReadLine());
        ulong trufflesAvailable = ulong.Parse(Console.ReadLine());
        ulong priceTruffle = ulong.Parse(Console.ReadLine());
        bool products = true;
        decimal cakeDiff = 0;
        decimal finalFlour = (decimal)wantedCakes * flourNeeded - (decimal)availableFlour;

        decimal cakes = (availableFlour / flourNeeded);
        if (cakes >= wantedCakes)
        {
            cakes = wantedCakes;            
        }
        else
        {
            cakeDiff = wantedCakes - cakes;
            products = false;
        }     
        ulong truffleCost = trufflesAvailable * priceTruffle;
        decimal cakePrice = (truffleCost / cakes) * 1.25M;
        if (products)
        {
            Console.WriteLine("All products available, price of a cake: {0:F2}", Math.Round(cakePrice, 2));
        }
        else
        {
            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", Math.Floor(cakes), Math.Round(finalFlour, 2));
        }
    }
}

