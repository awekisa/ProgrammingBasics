using System;

class CalculateNFactorialKFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int factorialK = 1;
        int factorialN = 1;

        for (int count = 1; count <= n; count++)
        {

            factorialN *= count;
            if (count <= k)
            {
                factorialK *= count;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine((double)factorialN / factorialK);
    }
}

