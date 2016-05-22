using System;

class IncideCircleOutsideRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        // circle ({1, 1}, 1.5)
        // rectangle (top=1, left=-1, width=6, height=2). 
        bool insideCircle = false;
        bool insideRectangle = false;

        if (((Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(1.5, 2)))
        {
            insideCircle = true;
        }
        if ((y >= (1 - 2) && y <= 1) && (x >= -1 && (x <= (-1 + 6))))
        {
            insideRectangle = true;
        }

        if (insideCircle == true && insideRectangle != true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}


