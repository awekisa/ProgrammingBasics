using System;

class BonusScore
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        if (inputNumber >= 1 && inputNumber <= 3)
        {
            inputNumber *= 10;
            Console.WriteLine(inputNumber);
        }
        else if (inputNumber >= 4 && inputNumber <= 6)
        {
            inputNumber *= 100;
            Console.WriteLine(inputNumber);
        }
        else if (inputNumber >= 7 && inputNumber <= 9)
        {
            inputNumber *= 1000;
            Console.WriteLine(inputNumber);
        }
        else if (inputNumber < 1 || inputNumber > 9)
        {
            Console.WriteLine("invalid score");
        }
        
    }
}

