using System;

class BitsExchange
{
    static void Main()
    {
        uint inputNumber = uint.Parse(Console.ReadLine());
        uint mask = 7;

        uint firstBits = inputNumber & (mask << 3);
        firstBits >>= 3;
        uint lastBits = inputNumber & (mask << 24);
        lastBits >>= 24;

        uint result = inputNumber;
        result = result & ~(mask << 3);
        result = result & ~(mask << 24);
        

        result = result | (firstBits << 24);
        result = result | (lastBits << 3);




        Console.WriteLine();
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine();
        Console.WriteLine(result);
    }
}

