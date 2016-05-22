using System;

class PrintTheASCIITable
{
    static void Main()
    {

        // Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints the entire 
        // ASCII table of characters at the console (characters from 0 to 255). Note that some characters have a special purpose and will not be
        // displayed as expected. You may skip them or display them differently. You may need to use for-loops (learn in Internet how).

        for (int a = 0; a <= 255; a++)
        {
            char asciiSymbols = (char)a;
            Console.WriteLine("DEC {0} -- > ascii character {1}", a, asciiSymbols);
        }

    }
}

