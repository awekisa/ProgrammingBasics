using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double moonGravity = 0.17;

        Console.WriteLine(weight * moonGravity);
    }
}

