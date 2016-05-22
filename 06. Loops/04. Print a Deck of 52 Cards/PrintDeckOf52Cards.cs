using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        char clubs = (char)5;
        char diamonds = (char)4;
        char hearts = (char)3;
        char spades = (char)6;
        string[] faceCards = { "T", "J", "Q", "K", "A" };

        for (int count = 2; count <= 9; count++)              // 2-9
        {
            
                Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", count, clubs, diamonds, hearts, spades);     
        }
        foreach (string value in faceCards)                  // face Cards
        {
            Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", value, clubs, diamonds, hearts, spades);
        }
    }
}

