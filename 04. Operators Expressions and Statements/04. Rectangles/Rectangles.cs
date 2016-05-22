using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter;
        double area;

        perimeter = 2 * (width + height);
        area = width * height;

        Console.WriteLine("perimeter is {0}, area is {1}", perimeter, area);


    }
}

