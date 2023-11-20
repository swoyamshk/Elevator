using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Elevator
    {
        public void elevatorUp(PictureBox elevator, PictureBox elevatorPosition)
        {
            elevatorPosition.Top -= 1;
            elevator.Top -= 1;

        }
        public void elevatorDown(PictureBox elevator, PictureBox elevatorPosition)
        {
            elevatorPosition.Top += 1;
            elevator.Top += 1;
        }
    }
}

