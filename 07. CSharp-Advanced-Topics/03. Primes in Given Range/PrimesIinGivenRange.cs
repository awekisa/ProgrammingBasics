using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Primes_in_Given_Range
{
    class PrimesIinGivenRange
    {
        static bool PrimeCheck(long inputNumber)   // Prime check method
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
        static List<long> PrimesInRange(long first, long last)     // list method
        {
            List<long> listOfPrimes = new List<long>();
            for (long i = first; i <= last; i++)
            {
                if (PrimeCheck(i) == true)
                {
                    listOfPrimes.Add(i);
                }
            }
            
            Console.WriteLine(string.Join(", ", listOfPrimes));
            
            return listOfPrimes;
        }

        static void Main()        // Main method
        {

            long first = long.Parse(Console.ReadLine());
            long last = long.Parse(Console.ReadLine());
                          
                PrimesInRange(first, last);                          
        }
    }
}
