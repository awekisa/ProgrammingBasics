using System;

class Sunlight
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int temp = input + (input / 2);

        Console.WriteLine(new string('.', temp) + "*" + new string('.', temp));   // top
        for (int i = 0; i < input - 1; i++)       //beams up
        {
            Console.WriteLine(new string('.', i + 1) + "*" + new string('.', temp - 2 - i) + "*" + new string('.', temp - 2 - i) + "*" + new string('.', i + 1));
        }
        for (int i = 0; i < input/2; i++)         // even up
        {
            Console.WriteLine(new string('.', input) + new string('*', input) + new string('.', input));
        }
        Console.WriteLine(new string('*', input * 3));   // middle
        for (int i = 0; i < input / 2; i++)              // even down
        {
            Console.WriteLine(new string('.', input) + new string('*', input) + new string('.', input));
        }
         
        for (int i = 0; i < input - 1; i++)     //beams down    
        {
            Console.WriteLine(new string('.', input - i - 1) + "*" + new string('.', input /2 + i) + "*" + new string('.', input / 2 + i) + "*" + new string('.', input - i - 1));          
        }
        Console.WriteLine(new string('.', temp) + "*" + new string('.', temp));   // bottom
    }
}

