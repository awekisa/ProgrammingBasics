using System;

class FirefightingOrganization
{
    static void Main()
    {
        int fireFighters = int.Parse(Console.ReadLine());
        int fireFightersTemp = 0;
        string input = Console.ReadLine();
        
        int children = 0;
        int childrenSaved = 0;
        int adults = 0;
        int adoultsSaved = 0;
        int seniors = 0;
        int seniorsSaved = 0;

        while (input != "rain")
        {
            char[] people = input.ToCharArray();
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == 'K')
                {
                    children++;
                }
                else if (people[i] == 'A')
                {
                    adults++;
                }
                else if (people[i] == 'S')                
                {
                    seniors++;
                }
            }
            fireFightersTemp = fireFighters;
            while (fireFightersTemp != 0)
            {
                
                if (fireFightersTemp >= children)
                {
                    childrenSaved += children;
                    fireFightersTemp -= children;
                }
                else
                {
                    childrenSaved += fireFightersTemp;
                    fireFightersTemp -= fireFightersTemp;
                }
                
                if (fireFightersTemp >= adults)
                {
                    adoultsSaved += adults;
                    fireFightersTemp -= adults;
                }
                else
                {
                    adoultsSaved += fireFightersTemp;
                    fireFightersTemp -= fireFightersTemp;
                }
                if (fireFightersTemp >= seniors)
                {
                    seniorsSaved += seniors;
                    fireFightersTemp -= seniors;
                }
                else
                {
                    seniorsSaved += fireFightersTemp;
                    fireFightersTemp -= fireFightersTemp;
                }
                fireFightersTemp = 0;
                children = 0;
                adults = 0;
                seniors = 0;
            }
            
            input = Console.ReadLine();
        }
        Console.WriteLine("Kids: {0}", childrenSaved);
        Console.WriteLine("Adults: {0}", adoultsSaved);
        Console.WriteLine("Seniors: {0}", seniorsSaved);






    }
}


