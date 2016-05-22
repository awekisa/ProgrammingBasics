using System;

    class SumOfFiveNumbers
    {
        static void Main()
        {
        Console.WriteLine("Enter 5 numbers separated by space");
        string lineOfNumbers = Console.ReadLine();
        double first = double.Parse(lineOfNumbers.Split(' ')[0]);
        double second = double.Parse(lineOfNumbers.Split(' ')[1]);
        double third = double.Parse(lineOfNumbers.Split(' ')[2]);
        double fourth = double.Parse(lineOfNumbers.Split(' ')[3]);
        double fifth = double.Parse(lineOfNumbers.Split(' ')[4]);
        Console.WriteLine();
        Console.WriteLine("Sum = " + (first + second + third + fourth + fifth));




    }
    }

