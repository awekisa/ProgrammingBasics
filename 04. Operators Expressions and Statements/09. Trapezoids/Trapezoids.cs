using System;

    class Trapezoids
    {
        static void Main()
        {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double area = ((a + b) * c) / 2;
        Console.WriteLine(area);
    }
    }

