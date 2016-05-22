using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int finish = int.Parse(Console.ReadLine());
        int p = 0;
        Console.WriteLine();

        for (int number = start; number <= finish; number++)
        {
            if (number % 5 == 0)
            {
                p = number;
                Console.WriteLine(p);
            }
        }
    }
}

