using System;

class LightTheTorches
{
    static void Main()
    {
        int rooms = int.Parse(Console.ReadLine());
        string lightsSequence = Console.ReadLine();
        lightsSequence.ToCharArray();
        string[] roomsLighted = new string[rooms];
        int index = 0;

        for (int i = 0; i < roomsLighted.Length; i++)
        {
            if (index < lightsSequence.Length)
            {
                roomsLighted[i] = Convert.ToString(lightsSequence[index]);
                index++;
            }
            else
            {
                index = 0;
                roomsLighted[i] = Convert.ToString(lightsSequence[index]);
                index++;
            }

        }
        int currentRoom = rooms / 2;
        int roomTemp = 0;

        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] directionAndStep = command.Split(' ');
            roomTemp = currentRoom;
            if (directionAndStep[0] == "LEFT")
            {

                if (currentRoom - int.Parse(directionAndStep[1]) - 1 >= 0)                // in range
                {
                    if ((currentRoom - int.Parse(directionAndStep[1]) - 1 != roomTemp))    // move
                    {
                        switch (roomsLighted[currentRoom - int.Parse(directionAndStep[1]) - 1])
                        {
                            case "L": roomsLighted[currentRoom - int.Parse(directionAndStep[1]) - 1] = "D"; break;
                            case "D": roomsLighted[currentRoom - int.Parse(directionAndStep[1]) - 1] = "L"; break;

                            default:
                                break;
                        }
                    }
                    currentRoom = currentRoom - int.Parse(directionAndStep[1]) - 1;
                }
                else                                    // out of range
                {
                    if (currentRoom != 0)
                    {
                        switch (roomsLighted[0])
                        {
                            case "L": roomsLighted[0] = "D"; break;
                            case "D": roomsLighted[0] = "L"; break;

                            default:
                                break;
                        }
                    }
                    currentRoom = 0;
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////
            else if (directionAndStep[0] == "RIGHT")
            {

                if (currentRoom + int.Parse(directionAndStep[1]) + 1 < rooms)    // in range
                {
                    if ((currentRoom + int.Parse(directionAndStep[1]) + 1 != roomTemp))    // move
                    {
                        switch (roomsLighted[currentRoom + int.Parse(directionAndStep[1]) + 1])
                        {
                            case "L": roomsLighted[currentRoom + int.Parse(directionAndStep[1]) + 1] = "D"; break;
                            case "D": roomsLighted[currentRoom + int.Parse(directionAndStep[1]) + 1] = "L"; break;

                            default:
                                break;
                        }
                    }
                    currentRoom = currentRoom + int.Parse(directionAndStep[1]) + 1;
                }
                else                                                  // out of range
                {
                    if (currentRoom != rooms - 1)
                    {
                        switch (roomsLighted[rooms - 1])
                        {
                            case "L": roomsLighted[rooms - 1] = "D"; break;
                            case "D": roomsLighted[rooms -1] = "L"; break;

                            default:
                                break;
                        }
                    }
                    currentRoom = rooms - 1;
                }
            }

            command = Console.ReadLine();
        }

        int darkRooms = 0;
        for (int i = 0; i < roomsLighted.Length; i++)
        {
            if (roomsLighted[i] == "D")
            {
                darkRooms++;
            }
        }
        Console.WriteLine(darkRooms * (int)'D');
    }
}

