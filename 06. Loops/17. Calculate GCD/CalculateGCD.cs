using System;

class CalculateGCD
{
    static void Main()
    {
        int inputA = int.Parse(Console.ReadLine());
        int inputB = int.Parse(Console.ReadLine());

        int biggerNumber = Math.Max(inputA, inputB);
        int smallerNumber = Math.Min(inputA, inputB);
        int temp;
        do
        {
            temp = biggerNumber % smallerNumber;
            biggerNumber = smallerNumber;
            smallerNumber = temp;
        } while (biggerNumber % smallerNumber != 0);
        Console.WriteLine(temp);
    }
}

