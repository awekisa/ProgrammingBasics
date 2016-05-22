using System;

class PointInCircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int radius = 2;
        // circle {0, 0}, 2 

        if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }


    }
}

