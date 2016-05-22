using System;

class DailyCalorieIntake
{
    static void Main()
    {
        long weight = long.Parse(Console.ReadLine());
        long height = long.Parse(Console.ReadLine());
        long age = long.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        long workouts = long.Parse(Console.ReadLine());

        double bmr = 0.0;
        if (gender == "m")
        {
            bmr = (66.5 + (13.75 * (weight / 2.2d)) + (5.003 * (height * 2.54d)) - (6.755 * age));
        }
        else
        {
            bmr = 655 + (9.563 * (weight / 2.2d) + (1.850 * (height * 2.54d) - (4.676 * age)));
        }
        long dci = 0;
        if (workouts < 1)
        {
            dci = Convert.ToInt64(Math.Floor(bmr * 1.2));
        }
        else if (workouts > 0 && workouts < 4)
        {
            dci = Convert.ToInt64(Math.Floor(bmr * 1.375));
        }
        else if (workouts > 3 && workouts < 7)
        {
            dci = Convert.ToInt64(Math.Floor(bmr * 1.55));
        }
        else if (workouts > 6 && workouts < 10)
        {
            dci = Convert.ToInt64(Math.Floor(bmr * 1.725));
        }
        else if (workouts > 9)
        {
            dci = Convert.ToInt64(Math.Floor(bmr * 1.9));
        }
        Console.WriteLine(dci);
    }
}

