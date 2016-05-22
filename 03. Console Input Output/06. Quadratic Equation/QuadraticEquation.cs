using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double first = (-b - (Math.Sqrt((Math.Pow(b, 2) - 4 * a * c)))) / (2 * a);
        double second = (-b + (Math.Sqrt((Math.Pow(b, 2) - 4 * a * c)))) / (2 * a);
        
        Console.WriteLine();
        if (second == first)
        {

            Console.WriteLine("x\u2081=x\u2082={0}", first);
        }
        else if (double.IsNaN(first) && double.IsNaN(second))
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            Console.WriteLine("x\u2081={0}; x\u2082={1}", first, second);
            
        }
    }
}

