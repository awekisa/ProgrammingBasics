using System;

class MasterHerbalist
{
    static void Main()
    {
        decimal dailyExp = decimal.Parse(Console.ReadLine());
        string[] infoDay = new string[3];
        string input = Console.ReadLine();
        uint hours = 0;
        string path = string.Empty; 
        decimal price = 0;
        uint herbCount = 0;
        decimal profitDay = 0;
        uint dayCount = 0;

        while (input != "Season Over")                  // daily routine
        {
            infoDay = input.Split(' ');
            hours = uint.Parse(infoDay[0]);
            path = infoDay[1];
            string[] pathDetail = new string[path.Length];
            for (int i = 0; i < pathDetail.Length; i++)
            {
                pathDetail[i] = Convert.ToString(path[i]);     // filling the path
            }
            price = uint.Parse(infoDay[2]);

            while (hours > 0)
            {
                for (int i = 0; i < pathDetail.Length; i++)
                {
                    if (pathDetail[i] == "H" && hours > 0)
                    {
                        herbCount++;
                        hours--;
                    }
                    else if (pathDetail[i] != "H" && hours > 0)
                    {
                        hours--;
                    }
                    if (i == pathDetail.Length - 1 && hours > 0)
                    {
                    i = -1;
                    }
                    else if (hours <= 0)
                    {
                        profitDay += (herbCount * price);
                        herbCount = 0;
                        dayCount++;
                        break;
                    }                    
                }
            }
            input = Console.ReadLine();
        }
        if (profitDay / dayCount >= dailyExp)
        {
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", Math.Round((profitDay / dayCount) - dailyExp, 2));
        }
        else
        {
            Console.WriteLine("We are in the red. Money needed: {0}.", Math.Ceiling(dailyExp * dayCount - (profitDay /dayCount) * dayCount));
        }
    }
}

