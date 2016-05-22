using System;

class BeerTime
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        DateTime beertime;
        bool parseTime = DateTime.TryParse(inputString, out beertime);



        if (parseTime)
        {
            if (beertime.Hour >= 13 || beertime.Hour < 3)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }

}


