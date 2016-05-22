using System;
using System.Numerics;
class CalculateComboFactorialThing
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger factorialK = 1;
        BigInteger factorialN = 1;
        BigInteger factorialCombo = 1;

        for (ulong count = 1; count <= n; count++)
        {

            factorialN *= count;
            if (count <= k)
            {
                factorialK *= count;
            }
            if (count <= (n- k))
            {
                factorialCombo *= count;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine(factorialN / (factorialK * factorialCombo));

    }
}

