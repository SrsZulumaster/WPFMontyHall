using System;

namespace DoorBrain
{
    public class DoorLogic
    {
        public static int Logic(int WinningDoor, int ChosenDoor)
        {
            int OpenDoor;
            if (ChosenDoor == 1)
            {
                if (WinningDoor ==1)//decides which door opens if player selects a winning door
                {
                    Random random = new Random();
                    int Randomnumber = random.Next(2, 3);
                    if (Randomnumber == 2)
                    {
                        OpenDoor = 2;
                        return OpenDoor;
                    }
                    if (Randomnumber == 3)
                    {
                        OpenDoor = 3;
                        return OpenDoor;
                    }
                }
                if (WinningDoor==2)
                {
                    OpenDoor = 3;
                    return OpenDoor;
                }
                if (WinningDoor == 3)
                {
                    OpenDoor = 2;
                    return OpenDoor;
                }
            }
            if (ChosenDoor== 2)
            {
                if (WinningDoor == 2)//decides which door opens if player selects a winning door
                {
                    Random random = new Random();
                    int Randomnumber = random.Next(2, 3);
                    if (Randomnumber == 2)
                    {
                        OpenDoor = 1;
                        return OpenDoor;
                    }
                    if (Randomnumber == 3)
                    {
                        OpenDoor = 3;
                        return OpenDoor;
                    }
                }   
                    if (WinningDoor==1)
                    {
                    OpenDoor = 3;
                    return OpenDoor;
                }
                    if (WinningDoor==3)
                    {
                    OpenDoor = 1;
                    return OpenDoor;
                }
                }
            if (ChosenDoor ==3)
                {
                    if (WinningDoor==3) //decides which door opens if player selects a winning door
                    {
                        Random random = new Random();
                        int Randomnumber = random.Next(2, 3);
                        if (Randomnumber == 2)
                        {
                        OpenDoor = 1;
                        return OpenDoor;
                    }
                        if (Randomnumber == 3)
                        {
                        OpenDoor = 2;
                        return OpenDoor;
                    }

                    }
                    if (WinningDoor ==2)
                    {
                    OpenDoor = 1;
                    return OpenDoor;
                }
                    if (WinningDoor==1)
                    {
                    OpenDoor = 2;
                    return OpenDoor;
                }
                }
            return 0;
        }
    }
}
