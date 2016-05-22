using System;

class IsoscelesTriangle
{
    static void Main()
    {
        // Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

        char block = '\u00A9';

        Console.SetCursorPosition(3, 0);
        Console.WriteLine(block);
        Console.SetCursorPosition(2, 1);
        Console.WriteLine(block);
        Console.SetCursorPosition(4, 1);
        Console.WriteLine(block);
        Console.SetCursorPosition(1, 2);
        Console.WriteLine(block);
        Console.SetCursorPosition(5, 2);
        Console.WriteLine(block);
        Console.SetCursorPosition(0, 3);
        Console.WriteLine(block);
        Console.SetCursorPosition(2, 3);
        Console.WriteLine(block);
        Console.SetCursorPosition(4, 3);
        Console.WriteLine(block);
        Console.SetCursorPosition(6, 3);
        Console.WriteLine(block);
    }
}

