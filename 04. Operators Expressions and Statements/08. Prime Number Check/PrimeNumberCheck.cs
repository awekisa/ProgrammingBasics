using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        bool isPrime;


        if (inputNumber <= 0)
        {
            isPrime = false;
            Console.WriteLine(isPrime);
        }
        for (int a = 1; a <= inputNumber; a++)
        {
            if (a == inputNumber)
            {
                if (inputNumber < 3)
                {
                    if (inputNumber == 2)
                    {
                        isPrime = true;
                        Console.WriteLine(isPrime);
                        break;
                    }
                    else
                    {
                        isPrime = false;
                        Console.WriteLine(isPrime);
                    }
                }
                else if (inputNumber % 2 == 0)
                {
                    isPrime = false;
                    Console.WriteLine(isPrime);
                }
                else if (inputNumber % 3 == 0 && inputNumber != 3)
                {
                    isPrime = false;
                    Console.WriteLine(isPrime);
                }
                else if (inputNumber % 5 == 0 && inputNumber != 5)
                {
                    isPrime = false;
                    Console.WriteLine(isPrime);

                }
                else if (inputNumber % 7 == 0 && inputNumber != 7)
                {
                    isPrime = false;
                    Console.WriteLine(isPrime);
                }
                else if (inputNumber % 9 == 0 && inputNumber != 9)
                {
                    isPrime = false;
                    Console.WriteLine(isPrime);
                }
                else
                {
                    isPrime = true;
                    Console.WriteLine(isPrime);
                }
            }
        }
    }
}

