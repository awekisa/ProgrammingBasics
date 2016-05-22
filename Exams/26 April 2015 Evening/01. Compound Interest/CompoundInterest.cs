using System;

class CompoundInterest
{
    static void Main()
    {
        double price = double.Parse(Console.ReadLine());
        int years = int.Parse(Console.ReadLine());
        double rate = double.Parse(Console.ReadLine());
        double friendRate = double.Parse(Console.ReadLine());

        double priceBank = price * Math.Pow((1 + rate), years);
        double friendPrice = price * (1 + friendRate);

        if (priceBank < friendPrice)
        {
            Console.WriteLine("{0:F2} Bank", priceBank);
        }
        else
        {
            Console.WriteLine("{0:F2} Friend", friendPrice);
        }
    }
}

