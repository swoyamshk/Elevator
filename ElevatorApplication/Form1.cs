using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace ElevatorApplication
{
    public partial class Form1 : Form
    {
        dbCRUD dbCRUD = new dbCRUD();
        Door doorObj = new Door();
        Elevator elevatorObj = new Elevator();

        int xLeftDoorOpen = 878;
        int xLeftDoorClosed = 975;
        int xRightDoorOpen = 1165;
        int xRightDoorClosed = 1075;
        int yElevatorUp = 89;
        int yElevatorDown = 493;

        public bool goUpBoolean = false;
        public bool goDownBoolean = false;
        public bool doorClosedBoolean = true;

        private System.Windows.Forms.Timer updateTimer;

        public int count = 0;
        public Form1()
        {

            InitializeComponent();

            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 5000;
            updateTimer.Tick += UpdateLogTable;
            updateTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UpdateLogTable(object sender, EventArgs e)
        {

            dbCRUD.UpdateDatalog(logTable);
        }
        private void doorOpen()
        {
            dbCRUD dbCRUD = new dbCRUD();
            countTimer.Enabled = false;
            count = 0;
            if (elevatorUnit.Top >= yElevatorUp)
            {
                if (rightDoorGround.Left <= xRightDoorOpen && leftDoorGround.Left >= xLeftDoorOpen)
                {
                    doorObj.doorOpenGround(rightDoorGround, leftDoorGround);
                    disableButtons();


                }
                else
                {
                    doorClosedBoolean = false;
                    openDoorTimer.Enabled = false;
                    enableButtons();
                    count = 0;
                    countTimer.Enabled = true;
                    dbCRUD.InsertOpenDoorRecord(0, "Elevator is at Ground Floor");
                }
            }
            else
            {
                if (rightDoorFirst.Left <= xRightDoorOpen && leftDoorFirst.Left >= xLeftDoorOpen)
                {
                    doorObj.doorOpenFirst(rightDoorFirst, leftDoorFirst);
                    disableButtons();

                }
                else
                {
                    doorClosedBoolean = false;
                    openDoorTimer.Enabled = false;
                    enableButtons();
                    count = 0;
                    countTimer.Enabled = true;
                    dbCRUD.InsertOpenDoorRecord(1, "Elevator is at First Floor");
                }
            }
        }

        private void doorClose()
        {
            countTimer.Enabled = false;
            count = 0;
            if (elevatorUnit.Top >= yElevatorUp)
            {
                if (rightDoorGround.Left >= xRightDoorClosed && leftDoorGround.Left <= xLeftDoorClosed)
                {
                    doorObj.doorCloseGround(rightDoorGround, leftDoorGround);
                    disableButtons();
                }
                else
                {
                    closeDoorTimer.Enabled = false;
                    doorClosedBoolean = true;
                    checkDoorClosed();
                    enableButtons();
                }
            }
            else
            {
                if (rightDoorFirst.Left >= xRightDoorClosed && leftDoorFirst.Left <= xLeftDoorClosed)
                {
                    doorObj.doorCloseFirst(rightDoorFirst, leftDoorFirst);
                    disableButtons();
                }
                else
                {
                    closeDoorTimer.Enabled = false;
                    doorClosedBoolean = true;
                    checkDoorClosed();
                    enableButtons();
                }
            }
        }

        private void elevatorUp()
        {
            countTimer.Enabled = false;
            count = 0;
            if (elevatorUnit.Top >= yElevatorUp)
            {
                elevatorObj.elevatorUp(elevatorUnit, elevator);
                firstFloorPicture.Image = ElevatorApplication.Properties.Resources.uparrow;
                groundFloorPicture.Image = ElevatorApplication.Properties.Resources.uparrow;
                controlPanelPicture.Image = ElevatorApplication.Properties.Resources.uparrow;
                disableButtons();

            }
            else
            {
                goUpBoolean = false;
                goDownBoolean = false;
                goUpTimer.Enabled = false;
                openDoorTimer.Enabled = true;
                firstFloorPicture.Image = ElevatorApplication.Properties.Resources.one;
                groundFloorPicture.Image = ElevatorApplication.Properties.Resources.one;
                controlPanelPicture.Image = ElevatorApplication.Properties.Resources.one;
                enableButtons();
            }
        }

        //function to move the elevator down
        private void elevatorDown()
        {
            countTimer.Enabled = false;
            count = 0;
            if (elevatorUnit.Top <= yElevatorDown)
            {
                elevatorObj.elevatorDown(elevatorUnit, elevator);
                firstFloorPicture.Image = ElevatorApplication.Properties.Resources.downarrow;
                groundFloorPicture.Image = ElevatorApplication.Properties.Resources.downarrow;
                controlPanelPicture.Image = ElevatorApplication.Properties.Resources.downarrow;
                disableButtons();
            }
            else
            {
                goDownBoolean = false;
                goUpBoolean = false;
                goDownTimer.Enabled = false;
                openDoorTimer.Enabled = true;
                firstFloorPicture.Image = ElevatorApplication.Properties.Resources.groundDisplay;
                groundFloorPicture.Image = ElevatorApplication.Properties.Resources.groundDisplay;
                controlPanelPicture.Image = ElevatorApplication.Properties.Resources.groundDisplay;
                enableButtons();

            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void openDoorBtn_Click(object sender, EventArgs e)
        {
            openDoorTimer.Enabled = true;
            timer1.Start();
        }
        private void openDoorTimer_Tick(object sender, EventArgs e)
        {
            doorOpen();
        }

        private void closeDoorBtn_Click(object sender, EventArgs e)
        {
            closeDoorTimer.Enabled = true;
        }
        private void closeDoorTimer_Tick(object sender, EventArgs e)
        {
            doorClose();
        }


        private void checkDoorClosed()
        {
            if (!doorClosedBoolean)
            {
                closeDoorTimer.Enabled = true;
            }
            else
            {
                if (goUpBoolean)
                {
                    goUpTimer.Enabled = true;
                    timer1.Start();
                }
                else if (goDownBoolean)
                {
                    goDownTimer.Enabled = true;
                    timer1.Start();
                }
            }
        }
        private void goUpBtn_Click(object sender, EventArgs e)
        {
            goUpBoolean = true;
            checkDoorClosed();
        }
        private void goDownBtn_Click(object sender, EventArgs e)
        {
            goDownBoolean = true;
            checkDoorClosed();
        }
        private void goDownTimer_Tick(object sender, EventArgs e)
        {
            elevatorDown();
        }
        private void goUpTimer_Tick(object sender, EventArgs e)
        {
            elevatorUp();
        }


        private void callDownBtn_Click_1(object sender, EventArgs e)
        {
            goDownBoolean = true;
            checkDoorClosed();
            dbCRUD.InsertOpenDoorRecord(1, "Elevator is going Down");
        }

        private void callUpBtn_Click_1(object sender, EventArgs e)
        {
            goUpBoolean = true;
            checkDoorClosed();
            dbCRUD.InsertOpenDoorRecord(0, "Elevator is going Up");
        }
        public void disableButtons()
        {
            goUpBtn.Enabled = false;
            goDownBtn.Enabled = false;
            openDoorBtn.Enabled = false;
            closeDoorBtn.Enabled = false;
            callDownBtn.Enabled = false;
            callUpBtn.Enabled = false;
        }
        public void enableButtons()
        {
            goUpBtn.Enabled = true;
            goDownBtn.Enabled = true;
            openDoorBtn.Enabled = true;
            closeDoorBtn.Enabled = true;
            callDownBtn.Enabled = true;
            callUpBtn.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkDoorClosed();
        }


        public void clearLog()
        {


            DialogResult result = MessageBox.Show("Are you sure you want to clear the logs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                logTable.DataSource = null;
                MessageBox.Show("Logs cleared successfully", "Logs Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void emptyDatabase()
        {
            try
            {
                logTable.DataSource = null;
                dbCRUD.deleteRecords();
                MessageBox.Show("Successfully deleted records", "Database Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to delete Records", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emptyDatabaseBtn_Click_1(object sender, EventArgs e)
        {
            if (!deleteBackgroundWorker.IsBusy & !updateBackgroundWorker.IsBusy)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to empty the database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dbCRUD.deleteRecords();
                }
            }
            else if (deleteBackgroundWorker.IsBusy)
            {
                MessageBox.Show("Emptying out the database");
            }
            else if (updateBackgroundWorker.IsBusy)
            {
                MessageBox.Show("Please wait while other Database functions are run");
            }
        }


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }

        private void deleteBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            emptyDatabase();
        }

        private void clearLogBtn_Click(object sender, EventArgs e)
        {
            clearLog();
        }

        private void updateDatabaseBtn_Click(object sender, EventArgs e)
        {
            dbCRUD.UpdateDatalog(logTable);
        }
        private void logTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

    }
}