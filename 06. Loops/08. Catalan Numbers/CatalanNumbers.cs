using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());

        // (2n)! / (n+1)!n! - formula
        BigInteger factorialInputNumberTimesTwo = 1;
        BigInteger factorialInputNumberPlusOne = 1;
        BigInteger factorialInputNumber = 1;        
        
        for (int count = 1; count <= inputNumber; count++)
        {
            factorialInputNumber *= count;
        }
        for (int count = 1; count <= inputNumber + 1; count++)
        {
            factorialInputNumberPlusOne *= count;
        }
        for (int count = 1; count <= inputNumber *2; count++)
        {
            factorialInputNumberTimesTwo *= count;
        }
        Console.WriteLine(factorialInputNumberTimesTwo / (factorialInputNumberPlusOne * factorialInputNumber));

    }
}

