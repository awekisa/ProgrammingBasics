using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        bool numberIsOdd;

        if (number % 2 == 0)
        {
            numberIsOdd = false;
            Console.WriteLine(numberIsOdd);
        }
        else
        {
            numberIsOdd = true;
            Console.WriteLine(numberIsOdd);
        }
    }
}

