using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {

        double radius = double.Parse(Console.ReadLine());

        double pi = 3.1415926;
        double perimeter = pi * 2 * radius;

        double area = pi * (radius * radius);

        Console.WriteLine("Perimeter is {0:F2}, area is {1:F2}", perimeter, area);
        }
    }

