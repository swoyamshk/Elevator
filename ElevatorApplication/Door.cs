using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApplication
{
    class Door
    {
        public void doorOpenFirst(PictureBox rightDoorFirst, PictureBox leftDoorFirst)
        {
            leftDoorFirst.Left -= 1;
            rightDoorFirst.Left += 1;
        }
        public void doorCloseFirst(PictureBox rightDoorFirst, PictureBox leftDoorFirst)
        {

            leftDoorFirst.Left += 1;
            rightDoorFirst.Left -= 1;

        }

        public void doorOpenGround(PictureBox rightDoorGround, PictureBox leftDoorGround)
        {
            leftDoorGround.Left -= 1;
            rightDoorGround.Left += 1;
        }

        public void doorCloseGround(PictureBox rightDoorGround, PictureBox leftDoorGround)
        {
            leftDoorGround.Left += 1;
            rightDoorGround.Left -= 1;
        }
    }
}
