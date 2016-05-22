using System;

class WaveBits
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        string initialNumber = Convert.ToString((long)input, 2).PadLeft(64, '0');
        int waveCount = 0;
        int longestWave = 0;
        int waveIndex = 0;
        int longestIndex = 0;
        int bitsRemove = 0;
        ulong mask = 0;
        ulong wavelessNumber = 0;

        char[] array = initialNumber.ToCharArray();

        for (int i = 0; i < array.Length; i++)                             // color representation
        {
            if (array[i] == '1')
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(array[i]);
                Console.ResetColor();
            }
            else
            {
                Console.Write(array[i]);
            }
        }
        Console.WriteLine();
        Array.Reverse(array);
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == '1' && array[i + 1] == '0' && array[i + 2] == '1' && i <= 61)                             // wave and not last bits
            {                                    
                        i += 1;
                        if (waveCount == 0)                      // index wave
                        {
                            waveIndex = i - 1;
                        }
                        waveCount++;                                   
            }
            //else if (array[i] == '1' && array[i + 1] == '0' && array[i + 2] == '1' && i == 61)             // end
            //{
            //    i += 1;
            //    if (waveCount == 0)                      
            //    {
            //        waveIndex = i - 1;
            //    }
            //    waveCount++; if (waveCount > longestWave)                 // new longest wave found
            //    {
            //        longestWave = waveCount;
            //        longestIndex = waveIndex;
            //    }
            //}
            else                                             // no wave
            {
                if (waveCount > longestWave)                 // new longest wave found
                {
                    longestWave = waveCount;
                    longestIndex = waveIndex;
                }
                waveCount = 0;
            }
        }
        if (waveCount > longestWave)
        {
            longestWave = waveCount;
            longestIndex = waveIndex;
        }
        if (longestWave != 0)
        {

            //if (longestIndex != 0)                             // number of bits to remove
            //{
                bitsRemove = longestWave * 2 + 1;
            //}
            //else                            // MISTAKE????
            //{
            //    bitsRemove = 3;
            //}
            wavelessNumber = input;                          // removing longest wave
            for (int i = 0; i < bitsRemove; i++)
            {
                mask = ~((ulong)1 << longestIndex + i);
                wavelessNumber = input & mask;
                input = wavelessNumber;

            }
            // color representation of the 
            string wavelessString = Convert.ToString((long)wavelessNumber, 2).PadLeft(64, '0');
            char[] wavelessArray = wavelessString.ToCharArray();

            for (int i = 0; i < wavelessArray.Length; i++)
            {
                if (wavelessArray[i] == '1')
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(wavelessArray[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(wavelessArray[i]);
                }
            }
            Console.WriteLine();
            ulong lastBits = wavelessNumber;
            for (int i = 0; i < longestIndex + bitsRemove - 1; i++)           // getting last bits
            {
                mask = ~((ulong)1 << i);
                lastBits = lastBits & mask;              
            }
            lastBits >>= longestIndex + bitsRemove;
            // color representation of the rest of the number after removing the longest wave
            string restnumber = Convert.ToString((long)lastBits, 2).PadLeft(64, '0');
            char[] restArray = restnumber.ToCharArray();
            for (int i = 0; i < restArray.Length; i++)
            {
                if (restArray[i] == '1')
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(restArray[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(restArray[i]);
                }
            }
            Console.WriteLine();

            ulong tempRight = wavelessNumber;                         // getting before wave bits
            for (int i = longestIndex; i < 64; i++)           // getting last bits
            {
                mask = ~((ulong)1 << i);
                tempRight = tempRight & mask;
            }            

            string rightString = Convert.ToString((long)tempRight, 2).PadLeft(64, '0');   // before wave visual
            char[] rightChar = rightString.ToCharArray();
            for (int i = 0; i < restArray.Length; i++)
            {
                if (rightChar[i] == '1')
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(rightChar[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(rightChar[i]);
                }
            }
            Console.WriteLine();

            ulong result = (wavelessNumber & tempRight) | lastBits << longestIndex;         // concatination of binary numbers

            Console.WriteLine(result);

        }
        else
        {
            Console.WriteLine("No waves found!");
        }





    }
}

