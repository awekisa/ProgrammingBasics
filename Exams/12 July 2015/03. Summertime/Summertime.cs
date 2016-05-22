using System;

class Summertime
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(new string(' ', input / 2) + new string('*', input + 1) + new string(' ', input / 2));

        for (int i = 0; i < input / 2+1; i++)
        {
            Console.WriteLine(new string(' ', input / 2) + "*" + new string(' ', input -1) + "*" + new string(' ', input - 1));
        }

        for (int i = 0; i < input / 2 - 1; i++)
        {
            Console.WriteLine(new string(' ', input / 2 - 1 - i) + "*" + new string(' ', input + 1 + 2* i) + "*" + new string(' ', input / 2 - 1 - i));
        }

        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("*" + new string('.', input * 2 - 2) + "*" );
        }
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("*" + new string('@', input * 2 - 2) + "*");
        }
        Console.WriteLine(new string('*', input * 2));

        
    }
}

