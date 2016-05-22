using System;
using System.Globalization;

namespace _04.Difference_between_Dates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string format = "d.MM.yyyy";
            DateTime firstDate = DateTime.ParseExact(first, format, CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(second, format, CultureInfo.InvariantCulture);
            
            TimeSpan days = secondDate.Subtract(firstDate);
            Console.WriteLine(days.Days);
        }
    }
}
