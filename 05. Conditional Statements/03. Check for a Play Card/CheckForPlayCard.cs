using System;

class CheckForPlayCard
{
    static void Main()
    {

        string inputString = Console.ReadLine();
        int notFaceCard;
        bool checkInput = int.TryParse(inputString, out notFaceCard);
        

        if (notFaceCard >= 2 && notFaceCard <= 10)
        {

            Console.WriteLine("yes");
        }
        else if (inputString == "J" || inputString == "Q" || inputString == "K" || inputString == "A")
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}





