using System;

class PlaidTowel
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char background = char.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        


        Console.WriteLine(new string(background, size) + symbol + new string(background, size * 2 - 1) + symbol + new string(background, size));
        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine(new string(background, size - i - 1) + symbol + new string(background, i*2+1) + symbol + new string(background, size*2 - (3+i*2)) + symbol + new string(background, i * 2 + 1) + symbol + new string(background, size - i - 1));            
        }
        Console.WriteLine(symbol + new string(background, size * 2 - 1) + symbol + new string(background, size * 2 - 1) + symbol);
        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine(new string(background, i + 1) + symbol + new string(background, (size * 2 - 3) - i*2) + symbol + new string(background, 1 + i*2) + symbol + new string(background, (size *2 - 3) - i * 2) + symbol + new string(background, i + 1));
        }
        Console.WriteLine(new string(background, size) + symbol + new string(background, size * 2 - 1) + symbol + new string(background, size));
        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine(new string(background, size - i - 1) + symbol + new string(background, i * 2 + 1) + symbol + new string(background, size * 2 - (3 + i * 2)) + symbol + new string(background, i * 2 + 1) + symbol + new string(background, size - i - 1));
        }
        Console.WriteLine(symbol + new string(background, size * 2 - 1) + symbol + new string(background, size * 2 - 1) + symbol);
        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine(new string(background, i + 1) + symbol + new string(background, (size * 2 - 3) - i * 2) + symbol + new string(background, 1 + i * 2) + symbol + new string(background, (size * 2 - 3) - i * 2) + symbol + new string(background, i + 1));
            
        }
        Console.WriteLine(new string(background, size) + symbol + new string(background, size * 2 - 1) + symbol + new string(background, size));
    }
}

