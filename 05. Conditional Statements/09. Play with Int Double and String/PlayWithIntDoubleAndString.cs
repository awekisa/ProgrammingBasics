using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1-- > int \n2-- > double \n3-- > string");
        string userChoice = Console.ReadLine();
        int userInt = 0;
        double userDouble = 0;
        string userString;

        switch (userChoice)
        {
            case "1":
                {
                    Console.WriteLine("Please enter an int:");
                    userInt = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(userInt + 1);
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Please enter a double:");
                    userDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(userDouble + 1);
                    break;
                }
            case "3":
                {
                    Console.WriteLine("Please enter a string:");
                    userString = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(userString + '*');
                    break;
                }

            default:
                break;
        }

    }
}

