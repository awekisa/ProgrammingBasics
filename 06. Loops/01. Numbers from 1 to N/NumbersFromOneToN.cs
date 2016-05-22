using System;

class NumbersFromOneToN
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int count = 1; count <= inputNumber; count++)
        {
            Console.Write("{0} ", count);
        }
        Console.WriteLine();
    }
}

