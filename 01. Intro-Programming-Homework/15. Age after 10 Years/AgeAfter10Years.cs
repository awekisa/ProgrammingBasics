using System;


class AgeAfter10Years
{
    static void Main()
    {
        //Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

        DateTime today = DateTime.Now;
        //Console.WriteLine("Enter your birth date in format month-day-year");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        int currentAge = today.Year - birthDate.Year;
        int ageIn10Years = currentAge + 10;

        Console.WriteLine("Now: {0}", currentAge);
        Console.WriteLine("After 10 years: {0}", ageIn10Years);

    }
}

