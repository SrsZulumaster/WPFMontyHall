using System;

namespace DoorBrain
{
    public class DoorLogic
    {
        public void Logic(int WinningDoor)
        {
            if (Door1Selected = true)
            {
                if (WinningDoor ==1)//decides which door opens if player selects a winning door
                {
                    Random random = new Random();
                    int Randomnumber = random.Next(2, 3);
                    if (Randomnumber == 2)
                    {
                        Door2.Text = Goat;
                    }
                    if (Randomnumber == 3)
                    {
                        Door3.Text = Goat;
                    }
                }
                if (WinningDoor == 2)
                {
                    Door3.Text = Goat;
                }
                if (WinningDoor ==3)
                {
                    Door2.Text = Goat;
                }
            }
            if (Door2Selected = true)
            {
                if (WinningDoor == 1)
                {
                    if (WinningDoor == 2)//decides which door opens if player selects a winning door
                    {
                        Random random = new Random();
                        int Randomnumber = random.Next(2, 3);
                        if (Randomnumber == 2)
                        {
                            Door1.Text = Goat;
                        }
                        if (Randomnumber == 3)
                        {
                            Door3.Text = Goat;
                        }

                    }
                    if (WinningDoor == 1)
                    {
                        Door3.Text = Goat;
                    }
                    if (WinningDoor == 3)
                    {
                        Door1.Text = Goat;
                    }
                }
                if (Door3Selected = true)
                {
                    if (WinningDoor == 3) //decides which door opens if player selects a winning door
                    {
                        Random random = new Random();
                        int Randomnumber = random.Next(2, 3);
                        if (Randomnumber == 2)
                        {
                            Door2.Text = Goat;
                        }
                        if (Randomnumber == 3)
                        {
                            Door1.Text = Goat;
                        }

                    }
                    if (WinningDoor == 2)
                    {
                        Door1.Text = Goat;
                    }
                    if (WinningDoor == 1)
                    {
                        Door2.Text = Goat;
                    }
                }
            }
        }
    }
}