using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        BigInteger zeros = 0;

        for (BigInteger count = 1; count <= inputNumber; count++)
        {

            factorial *= count;
        }
        string factorialAsString = Convert.ToString(factorial);

        char[] reverse = factorialAsString.ToCharArray();
        Array.Reverse(reverse);
        string final = new string(reverse);
        

        for (int count2 = 0; count2 < final.Length; count2++)
            if (final[count2] == '0')
            {
                
                
                
                
            }
            else
            {
                break;
            }
        //Console.WriteLine(factorial);
        //Console.WriteLine(final);
        Console.WriteLine(zeros);
    }

}


