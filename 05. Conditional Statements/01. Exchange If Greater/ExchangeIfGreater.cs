using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (Math.Max(a, b) == a)
        {
            Console.WriteLine("{0} {1}", b, a);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

