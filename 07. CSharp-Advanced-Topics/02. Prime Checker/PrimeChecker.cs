using System;
using System.Numerics;
namespace _02.Prime_Checker
{
    class PrimeChecker
    {
        static bool PrimeCheck(BigInteger inputNumber)
        {



            // works very slow for big prime numbers but so far result are correct!
            
            if (inputNumber == 1) return false;
            if (inputNumber == 2) return true;

            if (inputNumber % 2 == 0) return false;   

            for (long i = 3; i < inputNumber; i += 2)
            {
                if (inputNumber % i == 0) return false;
            }

            return true;


        }

        static void Main()
        {

            long inputNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(PrimeCheck(inputNumber));




        }
    }
}
