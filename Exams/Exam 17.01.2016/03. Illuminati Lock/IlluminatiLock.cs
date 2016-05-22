using System;

class IlluminatiLock
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int loop = (input + 1) / 2;
        int height = input + 1;

        Console.WriteLine(new string('.', input) + new string('#', input) + new string('.', input));    // top

        Console.WriteLine(new string('.', input - 2) + new string('#', 3) + new string('.', input - 2) + new string('#', 3) + new string('.', input - 2));  // 2nd top
        for (int i = 0; i < (height - 6) / 2; i++)           // top loop
        {
            Console.WriteLine(new string('.', input - 4 - (i*2)) + "##" + new string('.', 1*2 + (i*2)) + "#" + new string('.', input - 2) + "#" + new string('.', 1 * 2 + (i * 2)) + "##" + new string('.', input - 4 - (i * 2)));
        }
        Console.WriteLine("." + "##" + new string('.', input - 3) + "#" + new string('.', input - 2) + "#" + new string('.', input - 3) + "##" + ".");         // middle top
        Console.WriteLine("." + "##" + new string('.', input - 3) + "#" + new string('.', input - 2) + "#" + new string('.', input - 3) + "##" + ".");   // middle down
        for (int i = 0; i < (height - 6) / 2; i++)               // down loop
        {
            Console.WriteLine(new string('.', 3 + (i*2)) + "##" + new string('.', input - 2 - (3 + i*2)) + "#" + new string('.', input - 2) + "#" + new string('.', input - 2 - (3 + i * 2)) + "##" + new string('.', 3 + (i * 2)));
        }
        Console.WriteLine(new string('.', input - 2) + new string('#', 3) + new string('.', input - 2) + new string('#', 3) + new string('.', input - 2)); // 2nd bottom
        Console.WriteLine(new string('.', input) + new string('#', input) + new string('.', input));    // bottom


    }
}

