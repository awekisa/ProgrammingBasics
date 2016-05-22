using System;

    class RandomNumbersInGivenRange
    {
        static void Main()
        {
        int numberOfNumbers = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random randomNumber = new Random();

        for (int count = 0; count < numberOfNumbers; count++)
        {
            Console.Write("{0} ", randomNumber.Next(min, max + 1));
        }
        
        }
    }

