using System;


class BinaryToDecimalNumber
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long positionValue = 0;
        long binaryMultiplier = 2;
        long result = 0;
        for (int positionLeftToRight = 0; positionLeftToRight <= binaryNumber.Length - 1; positionLeftToRight++)
        {
            positionValue = (Int64)(binaryNumber[positionLeftToRight] - '0');
            result = result * binaryMultiplier + positionValue;                                       
        }
        Console.WriteLine();
        Console.WriteLine(result);


    }
}

