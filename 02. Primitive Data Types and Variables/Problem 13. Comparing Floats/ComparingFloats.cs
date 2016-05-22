using System;

class ComparingFloats
{
    static void Main()
    {
        // Write a program that safely compares floating - point numbers(double) with precision eps = 0.000001.Note that we cannot directly compare
        // two floating - point numbers a and b by a== b because of the nature of the floating - point arithmetic.Therefore, we assume two numbers
        // are equal if they are more closely to each other than a fixed constant eps.

        double eps = 0.000001;

        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());


        if (firstNumber > secondNumber)
        {
            if ((firstNumber - secondNumber) > eps)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
        if (secondNumber > firstNumber)
        {
            if ((secondNumber - firstNumber) > eps)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
        else
        {
            Console.WriteLine("same number");
        }

    }
}

