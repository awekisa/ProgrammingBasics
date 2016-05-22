using System;

class BohemchoTheBadGhost
{
    static void Main()
    {
        string input = Console.ReadLine();
        ulong floor = 0;
        string apartments = string.Empty;
        ulong mask = 1;

        ulong count = 0;
        ulong countFloor = 0;
        
        while (input != "Stop, God damn it")
        {
            floor = uint.Parse(input);
            apartments = Console.ReadLine();
            string[] temp = apartments.Split(' ');
            byte[] appartmentsPos = new byte[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                appartmentsPos[i] = byte.Parse(temp[i]);
            }
            foreach (int position in appartmentsPos)
            {
                floor = floor ^ mask << position;                
            }
            countFloor += floor;
            count += SparseBitcount(floor);
            input = Console.ReadLine();
        }

        Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", count, countFloor);      
    }
    static ulong SparseBitcount(ulong n)
    {
        ulong count2 = 0;
        while (n != 0)
        {
            count2++;
            n &= (n - 1);
        }
        return count2;
    }
}

