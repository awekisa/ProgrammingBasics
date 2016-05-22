using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long inputDecimalNumber = long.Parse(Console.ReadLine());
        long positionValue = 0;
        
        
        string result = "";

        do
        {
            if (inputDecimalNumber % 2 == 0)
            {
                result += "0";
            }
            else
            {
                result += "1";
            }
            inputDecimalNumber /= 2;
        } while (inputDecimalNumber != 0);

        char[] reversedResult = result.ToCharArray();
        Array.Reverse(reversedResult);
        string finalString = new string(reversedResult);
        Console.WriteLine();
        Console.WriteLine(finalString);
    }
}

