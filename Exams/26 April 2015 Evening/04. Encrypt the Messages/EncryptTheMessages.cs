using System;
using System.Collections.Generic;

class EncryptTheMessages
{
    static void Main()
    {
        int messageCount = 0;
        string message = string.Empty;
        List<string> encryptedMessages = new List<string>();
        string input = Console.ReadLine();
        while (input != "START" & input != "start")     // start recieving messages
        {
            input = Console.ReadLine();
        }
        input = Console.ReadLine();
        while (input != "END" & input != "end")     // end recieving
        {
            if (input == "")                       // check for empty messages
            {
                input = Console.ReadLine();
                continue;
            }
            messageCount++;
            char[] encrypted = new char[input.Length];
            for (int i = 0; i < encrypted.Length; i++)   // fill up array
            {
                encrypted[i] = input[i];
            }
            for (int i = 0; i < encrypted.Length; i++)   // converting
            {
                if (encrypted[i] >= 65 && encrypted[i] <= 77)       // A to M
                {
                    encrypted[i] = (char)(encrypted[i] + 13);                   
                }
                else if (encrypted[i] >= 78 && encrypted[i] <= 90)  // N to Z
                {
                    encrypted[i] = (char)(encrypted[i] - 13);
                }
                else if (encrypted[i] >= 97 && encrypted[i] <= 109)  // a to m
                {
                    encrypted[i] = (char)(encrypted[i] + 13);
                }
                else if (encrypted[i] >= 110 && encrypted[i] <= 122)  // n to z
                {
                    encrypted[i] = (char)(encrypted[i] - 13);
                }
                else
                {
                    switch (encrypted[i])            // symbols
                    {
                        case ' ': encrypted[i] = '+'; break;
                        case ',': encrypted[i] = '%'; break;
                        case '.': encrypted[i] = '&'; break;
                        case '?': encrypted[i] = '#'; break;
                        case '!': encrypted[i] = '$'; break;

                        default:
                            break;
                    }
                }
            }
            Array.Reverse(encrypted);                 // reverse chars
            for (int i = 0; i < encrypted.Length; i++)
            {
                message += encrypted[i];
            }
            encryptedMessages.Add(message.Trim());           // add messages to list
            message = string.Empty;
            input = Console.ReadLine();
        }
        if (messageCount != 0)
        {
            Console.WriteLine("Total number of messages: {0}", messageCount);     // printing results
            for (int i = 0; i < encryptedMessages.Count; i++)
            {
                Console.WriteLine(encryptedMessages[i]);
            }
        }
        else
        {
            Console.WriteLine("No messages sent.");
        }
        
    }
}

