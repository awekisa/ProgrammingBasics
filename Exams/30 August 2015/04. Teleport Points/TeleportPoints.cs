using System;


class TeleportPoints
{
    static void Main()
    {
        string temp = Console.ReadLine();
        double[] pointA = new double[2];
        for (int i = 0; i < pointA.Length; i++)
        {
            pointA[i] = double.Parse(temp.Split(' ')[i]);
        }
        temp = Console.ReadLine();
        double[] pointB = new double[2];
        for (int i = 0; i < pointB.Length; i++)
        {
            pointB[i] = double.Parse(temp.Split(' ')[i]);
        }
        temp = Console.ReadLine();
        double[] pointC = new double[2];
        for (int i = 0; i < pointC.Length; i++)
        {
            pointC[i] = double.Parse(temp.Split(' ')[i]);
        }
        temp = Console.ReadLine();
        double[] pointD = new double[2];
        for (int i = 0; i < pointD.Length; i++)
        {
            pointD[i] = double.Parse(temp.Split(' ')[i]);
        }

        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());
        int count = 0;

        //Console.SetBufferSize(200, 200);
        //Console.SetCursorPosition(100, 100);                               // visual
        //Console.Write("@");
        if ((pointA[0] < 0 & pointC[0] > 0) & (pointA[1] < 0 & pointC[1] > 0))
        {
            if ((pointA[0] != 0 && pointA[1] != 0) & (pointB[0] != 0 && pointB[1] != 0) & (pointC[0] != 0 && pointC[1] != 0) & (pointD[0] != 0 && pointD[1] != 0))                                                    // check center
            {
                count++;
            }
            for (double y = 0 - step; y > pointA[1]; y -= step)                 // A + Y line down 
            {
                for (double x = 0; x > pointA[0]; x -= step)
                {
                    if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) < Math.Pow(radius, 2))
                    {
                        //Console.SetCursorPosition((int)(100+(x*10/2)),(int)(100-(y*10/2)));        //   visual
                        //Console.WriteLine("+");
                        count++;

                    }
                }
            }
            for (double x = step; x < pointB[0]; x += step)                 // B + X line right
            {
                for (double y = 0; y > pointB[1]; y -= step)
                {
                    if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) < Math.Pow(radius, 2))
                    {
                        //Console.SetCursorPosition((int)(100 + (x * 10 / 2)), (int)(100 - (y * 10 / 2)));        //   visual
                        //Console.Write("+");
                        count++;

                    }
                }
            }
            for (double y = step; y < pointC[1]; y += step)                 // c + y line up
            {
                for (double x = 0; x < pointC[0]; x += step)
                {
                    if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) < Math.Pow(radius, 2))
                    {
                        //Console.SetCursorPosition((int)(100 + (x * 10 / 2)), (int)(100 - (y * 10 / 2)));            //   visual
                        //Console.Write("+");
                        count++;

                    }
                }
            }
            for (double x = 0 - step; x > pointD[0]; x -= step)                 // D + X line left
            {
                for (double y = 0; y < pointD[1]; y += step)
                {
                    if (Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) < Math.Pow(radius, 2))
                    {
                        //Console.SetCursorPosition((int)(100 + (x * 10 / 2)), (int)(100 - (y * 10 / 2)));             //   visual
                        //Console.WriteLine("+");
                        count++;

                    }

                }
            }
        }
        

        
        Console.WriteLine();
        
        Console.WriteLine(count);
        



    }
}

