using System;

class DivideBy7And5
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        bool devidable;
        
        if (inputNumber % 7 == 0 && inputNumber % 5 == 0 && inputNumber % 2 !=0)
        {
            devidable = true;
            Console.WriteLine(devidable);
        }
        else
        {
            devidable = false;
            Console.WriteLine(devidable);
        }
    }
}

