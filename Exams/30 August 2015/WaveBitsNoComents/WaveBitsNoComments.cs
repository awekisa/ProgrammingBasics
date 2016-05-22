using System;

class WaveBitsNoComments
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
            bitsRemove = longestWave * 2 + 1;          // number of bits to remove

            wavelessNumber = input;                          // removing longest wave
            for (int i = 0; i < bitsRemove; i++)
            {
                mask = ~((ulong)1 << longestIndex + i);
                wavelessNumber = input & mask;
                input = wavelessNumber;

            }
            ulong lastBits = wavelessNumber;
            for (int i = 0; i < longestIndex + bitsRemove - 1; i++)           // getting last bits
            {
                mask = ~((ulong)1 << i);
                lastBits = lastBits & mask;
            }
            lastBits >>= longestIndex + bitsRemove;
            ulong tempRight = wavelessNumber;                         // getting before wave bits

            for (int i = longestIndex; i < 64; i++)           // getting last bits
            {
                mask = ~((ulong)1 << i);
                tempRight = tempRight & mask;
            }
            ulong result = (wavelessNumber & tempRight) | lastBits << longestIndex;         // concatination of binary numbers

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("No waves found!");
        }
    }

}