using System;

class EmergencyRepairs
{
    static void Main()
    {
        ulong wall = ulong.Parse(Console.ReadLine());
        ulong kits = ulong.Parse(Console.ReadLine());
        ulong attacks = ulong.Parse(Console.ReadLine());
        int[] targets = new int[attacks];
        ulong temp = 0;
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i] = int.Parse(Console.ReadLine());
            temp = wall >> targets[i];
            ulong bit = temp & (ulong)1;
            if (bit == 1)
            {
                wall = wall & ~((ulong)1 << targets[i]);
            }

        }

        //string final = Convert.ToString(wall, 2).PadLeft(63, '0');       // after attaks    
        //Console.WriteLine(final);
        for (int i = 0; i < 63; i++)
        {

            ulong bit = wall >> i & (ulong)1;
            ulong bitNext = (wall >> i + 1) & (ulong)1;
            if (bit == 0 && bitNext == 0 && kits > 0)
            {
                wall = wall | ((ulong)1 << i);
                kits--;
               
                while (kits > 0 && bitNext != 1)
                {
                    wall = wall | ((ulong)1 << i + 1);
                    kits--;
                    i++;
                    temp = wall >> i+1;                                       
                    bitNext = temp & (ulong)1;
                    
                    
                }
                
            }

            else if (kits == 0)
            {
                break;
            }
        }
        Console.WriteLine(wall);
        //Console.WriteLine(Convert.ToString(wall, 2).PadLeft(63, '0'));
    }

}


