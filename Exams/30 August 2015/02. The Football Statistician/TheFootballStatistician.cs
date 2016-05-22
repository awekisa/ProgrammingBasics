using System;
using System.Text.RegularExpressions;

class TheFootballStatistician
{
    static void Main()
    {
        decimal price = decimal.Parse(Console.ReadLine());
        decimal total = 0.0m;
        string[] info = new string[3];
        string input = Console.ReadLine();

        long arsenal = 0;
        long chelsea = 0;
        long everton = 0;
        long liverpool = 0;
        long manchesterCity = 0;
        long manchesterUtd = 0;
        long southampton = 0;
        long tottenham = 0;



        while (input != "End of the league.")
        {
            total += price;
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);
            input = regex.Replace(input, @" ");
            string[] entry = input.Split(' ');
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = input.Split(' ')[i];
            }
            if (info[1] == "1")              // home win
            {
                switch (info[0])
                {
                    case "Arsenal": arsenal += 3; break;
                    case "Chelsea": chelsea += 3; break;
                    case "Everton": everton += 3; break;
                    case "Liverpool": liverpool += 3; break;
                    case "ManchesterCity": manchesterCity += 3; break;
                    case "ManchesterUnited": manchesterUtd += 3; break;
                    case "Southampton": southampton += 3; break;
                    case "Tottenham": tottenham += 3; break;
                    default:
                        break;
                }
            }
            else if (info[1] == "2")             // away win
            {
                switch (info[2])
                {
                    case "Arsenal": arsenal += 3; break;
                    case "Chelsea": chelsea += 3; break;
                    case "Everton": everton += 3; break;
                    case "Liverpool": liverpool += 3; break;
                    case "ManchesterCity": manchesterCity += 3; break;
                    case "ManchesterUnited": manchesterUtd += 3; break;
                    case "Southampton": southampton += 3; break;
                    case "Tottenham": tottenham += 3; break;
                    default:
                        break;
                }
            }
            else                                 // draw
            {
                switch (info[0])
                {
                    case "Arsenal": arsenal += 1; break;
                    case "Chelsea": chelsea += 1; break;
                    case "Everton": everton += 1; break;
                    case "Liverpool": liverpool += 1; break;
                    case "ManchesterCity": manchesterCity += 1; break;
                    case "ManchesterUnited": manchesterUtd += 1; break;
                    case "Southampton": southampton += 1; break;
                    case "Tottenham": tottenham += 1; break;
                    default:
                        break;
                }
                switch (info[2])
                {
                    case "Arsenal": arsenal += 1; break;
                    case "Chelsea": chelsea += 1; break;
                    case "Everton": everton += 1; break;
                    case "Liverpool": liverpool += 1; break;
                    case "ManchesterCity": manchesterCity += 1; break;
                    case "ManchesterUnited": manchesterUtd += 1; break;
                    case "Southampton": southampton += 1; break;
                    case "Tottenham": tottenham += 1; break;
                    default:
                        break;
                }
            }
            input = Console.ReadLine();
        }
        Console.WriteLine("{0:0.00}lv.", total * 1.94m);
        Console.WriteLine("Arsenal - {0} points.", arsenal);
        Console.WriteLine("Chelsea - {0} points.", chelsea);
        Console.WriteLine("Everton - {0} points.", everton);
        Console.WriteLine("Liverpool - {0} points.", liverpool);
        Console.WriteLine("Manchester City - {0} points.", manchesterCity);
        Console.WriteLine("Manchester United - {0} points.", manchesterUtd);
        Console.WriteLine("Southampton - {0} points.", southampton);
        Console.WriteLine("Tottenham - {0} points.", tottenham);
    }
}

