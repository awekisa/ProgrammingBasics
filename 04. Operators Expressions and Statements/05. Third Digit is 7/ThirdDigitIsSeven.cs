using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        inputNumber = inputNumber / 100;
        int thirdNumber = inputNumber % 10;
        Console.WriteLine(thirdNumber);
        if (thirdNumber == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }


    }
}

