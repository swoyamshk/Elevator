namespace ElevatorApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            rightDoorFirst = new PictureBox();
            leftDoorFirst = new PictureBox();
            elevator = new PictureBox();
            leftDoorGround = new PictureBox();
            rightDoorGround = new PictureBox();
            callDownBtn = new PictureBox();
            openDoorBtn = new PictureBox();
            closeDoorBtn = new PictureBox();
            openDoorTimer = new System.Windows.Forms.Timer(components);
            closeDoorTimer = new System.Windows.Forms.Timer(components);
            goDownTimer = new System.Windows.Forms.Timer(components);
            goUpTimer = new System.Windows.Forms.Timer(components);
            countTimer = new System.Windows.Forms.Timer(components);
            elevatorUnit = new PictureBox();
            firstFloorPicture = new PictureBox();
            groundFloorPicture = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox5 = new PictureBox();
            goUpBtn = new PictureBox();
            pictureBox3 = new PictureBox();
            controlPanelPicture = new PictureBox();
            goDownBtn = new PictureBox();
            callUpBtn = new PictureBox();
            logTable = new DataGridView();
            label1 = new Label();
            updateBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            deleteBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            emptyDatabaseBtn = new Button();
            clearLogBtn = new Button();
            updateDatabaseBtn = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)rightDoorFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)callDownBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openDoorBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeDoorBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstFloorPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groundFloorPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goUpBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controlPanelPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goDownBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)callUpBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rightDoorFirst
            // 
            rightDoorFirst.Image = Properties.Resources.door_right;
            rightDoorFirst.Location = new Point(1076, 138);
            rightDoorFirst.Name = "rightDoorFirst";
            rightDoorFirst.Size = new Size(101, 266);
            rightDoorFirst.SizeMode = PictureBoxSizeMode.StretchImage;
            rightDoorFirst.TabIndex = 2;
            rightDoorFirst.TabStop = false;
            // 
            // leftDoorFirst
            // 
            leftDoorFirst.Image = Properties.Resources.door_left;
            leftDoorFirst.Location = new Point(975, 138);
            leftDoorFirst.Name = "leftDoorFirst";
            leftDoorFirst.Size = new Size(101, 266);
            leftDoorFirst.SizeMode = PictureBoxSizeMode.StretchImage;
            leftDoorFirst.TabIndex = 3;
            leftDoorFirst.TabStop = false;
            leftDoorFirst.Click += pictureBox4_Click;
            // 
            // elevator
            // 
            elevator.Image = Properties.Resources.inside1;
            elevator.Location = new Point(979, 138);
            elevator.Name = "elevator";
            elevator.Size = new Size(194, 266);
            elevator.SizeMode = PictureBoxSizeMode.StretchImage;
            elevator.TabIndex = 4;
            elevator.TabStop = false;
            // 
            // leftDoorGround
            // 
            leftDoorGround.Image = Properties.Resources.door_left;
            leftDoorGround.Location = new Point(975, 545);
            leftDoorGround.Name = "leftDoorGround";
            leftDoorGround.Size = new Size(101, 266);
            leftDoorGround.SizeMode = PictureBoxSizeMode.StretchImage;
            leftDoorGround.TabIndex = 6;
            leftDoorGround.TabStop = false;
            // 
            // rightDoorGround
            // 
            rightDoorGround.Image = Properties.Resources.door_right;
            rightDoorGround.Location = new Point(1076, 545);
            rightDoorGround.Name = "rightDoorGround";
            rightDoorGround.Size = new Size(101, 266);
            rightDoorGround.SizeMode = PictureBoxSizeMode.StretchImage;
            rightDoorGround.TabIndex = 5;
            rightDoorGround.TabStop = false;
            // 
            // callDownBtn
            // 
            callDownBtn.Image = Properties.Resources.square;
            callDownBtn.Location = new Point(1310, 664);
            callDownBtn.Name = "callDownBtn";
            callDownBtn.Size = new Size(40, 36);
            callDownBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            callDownBtn.TabIndex = 7;
            callDownBtn.TabStop = false;
            callDownBtn.Click += callDownBtn_Click_1;
            // 
            // openDoorBtn
            // 
            openDoorBtn.Image = Properties.Resources.open;
            openDoorBtn.Location = new Point(789, 479);
            openDoorBtn.Name = "openDoorBtn";
            openDoorBtn.Size = new Size(39, 40);
            openDoorBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            openDoorBtn.TabIndex = 9;
            openDoorBtn.TabStop = false;
            openDoorBtn.Click += openDoorBtn_Click;
            // 
            // closeDoorBtn
            // 
            closeDoorBtn.Image = Properties.Resources.close;
            closeDoorBtn.Location = new Point(850, 479);
            closeDoorBtn.Name = "closeDoorBtn";
            closeDoorBtn.Size = new Size(39, 40);
            closeDoorBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeDoorBtn.TabIndex = 10;
            closeDoorBtn.TabStop = false;
            closeDoorBtn.Click += closeDoorBtn_Click;
            // 
            // openDoorTimer
            // 
            openDoorTimer.Interval = 10;
            openDoorTimer.Tick += openDoorTimer_Tick;
            // 
            // closeDoorTimer
            // 
            closeDoorTimer.Interval = 10;
            closeDoorTimer.Tick += closeDoorTimer_Tick;
            // 
            // goDownTimer
            // 
            goDownTimer.Interval = 10;
            goDownTimer.Tick += goDownTimer_Tick;
            // 
            // goUpTimer
            // 
            goUpTimer.Interval = 10;
            goUpTimer.Tick += goUpTimer_Tick;
            // 
            // countTimer
            // 
            countTimer.Interval = 10;
            // 
            // elevatorUnit
            // 
            elevatorUnit.Image = Properties.Resources.white;
            elevatorUnit.Location = new Point(1378, 88);
            elevatorUnit.Name = "elevatorUnit";
            elevatorUnit.Size = new Size(10, 287);
            elevatorUnit.SizeMode = PictureBoxSizeMode.StretchImage;
            elevatorUnit.TabIndex = 13;
            elevatorUnit.TabStop = false;
            // 
            // firstFloorPicture
            // 
            firstFloorPicture.Image = Properties.Resources.one;
            firstFloorPicture.Location = new Point(1050, 86);
            firstFloorPicture.Name = "firstFloorPicture";
            firstFloorPicture.Size = new Size(47, 41);
            firstFloorPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            firstFloorPicture.TabIndex = 14;
            firstFloorPicture.TabStop = false;
            // 
            // groundFloorPicture
            // 
            groundFloorPicture.Image = Properties.Resources.one;
            groundFloorPicture.Location = new Point(1051, 502);
            groundFloorPicture.Name = "groundFloorPicture";
            groundFloorPicture.Size = new Size(47, 41);
            groundFloorPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            groundFloorPicture.TabIndex = 15;
            groundFloorPicture.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 4000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.elevator_head;
            pictureBox5.Location = new Point(975, 488);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(201, 69);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // goUpBtn
            // 
            goUpBtn.Image = Properties.Resources.btn1;
            goUpBtn.Location = new Point(789, 426);
            goUpBtn.Name = "goUpBtn";
            goUpBtn.Size = new Size(39, 40);
            goUpBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            goUpBtn.TabIndex = 12;
            goUpBtn.TabStop = false;
            goUpBtn.Click += goUpBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.panel;
            pictureBox3.Location = new Point(766, 289);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(145, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // controlPanelPicture
            // 
            controlPanelPicture.Image = Properties.Resources.one;
            controlPanelPicture.Location = new Point(789, 305);
            controlPanelPicture.Name = "controlPanelPicture";
            controlPanelPicture.Size = new Size(100, 111);
            controlPanelPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            controlPanelPicture.TabIndex = 16;
            controlPanelPicture.TabStop = false;
            // 
            // goDownBtn
            // 
            goDownBtn.Image = Properties.Resources.gbtn;
            goDownBtn.Location = new Point(850, 426);
            goDownBtn.Name = "goDownBtn";
            goDownBtn.Size = new Size(39, 40);
            goDownBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            goDownBtn.TabIndex = 11;
            goDownBtn.TabStop = false;
            goDownBtn.Click += goDownBtn_Click;
            // 
            // callUpBtn
            // 
            callUpBtn.Image = Properties.Resources.square;
            callUpBtn.Location = new Point(1310, 213);
            callUpBtn.Name = "callUpBtn";
            callUpBtn.Size = new Size(40, 36);
            callUpBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            callUpBtn.TabIndex = 8;
            callUpBtn.TabStop = false;
            callUpBtn.Click += callUpBtn_Click_1;
            // 
            // logTable
            // 
            logTable.AllowUserToOrderColumns = true;
            logTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            logTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            logTable.Location = new Point(27, 12);
            logTable.Name = "logTable";
            logTable.RowHeadersWidth = 80;
            logTable.RowTemplate.Height = 29;
            logTable.RowTemplate.Resizable = DataGridViewTriState.False;
            logTable.Size = new Size(689, 677);
            logTable.TabIndex = 27;
            logTable.CellContentClick += logTable_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1348, -32);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 28;
            label1.Text = "Table";
            // 
            // updateBackgroundWorker
            // 
            updateBackgroundWorker.DoWork += backgroundWorker1_DoWork;
            // 
            // deleteBackgroundWorker
            // 
            deleteBackgroundWorker.DoWork += deleteBackgroundWorker_DoWork;
            // 
            // emptyDatabaseBtn
            // 
            emptyDatabaseBtn.Location = new Point(101, 712);
            emptyDatabaseBtn.Name = "emptyDatabaseBtn";
            emptyDatabaseBtn.Size = new Size(147, 46);
            emptyDatabaseBtn.TabIndex = 30;
            emptyDatabaseBtn.Text = "Delete Logs";
            emptyDatabaseBtn.UseVisualStyleBackColor = true;
            emptyDatabaseBtn.Click += emptyDatabaseBtn_Click_1;
            // 
            // clearLogBtn
            // 
            clearLogBtn.Location = new Point(753, 712);
            clearLogBtn.Name = "clearLogBtn";
            clearLogBtn.Size = new Size(136, 46);
            clearLogBtn.TabIndex = 31;
            clearLogBtn.Text = "Clear Logs";
            clearLogBtn.UseVisualStyleBackColor = true;
            clearLogBtn.Click += clearLogBtn_Click;
            // 
            // updateDatabaseBtn
            // 
            updateDatabaseBtn.Location = new Point(308, 712);
            updateDatabaseBtn.Name = "updateDatabaseBtn";
            updateDatabaseBtn.Size = new Size(153, 46);
            updateDatabaseBtn.TabIndex = 32;
            updateDatabaseBtn.Text = "Update Logs";
            updateDatabaseBtn.UseVisualStyleBackColor = true;
            updateDatabaseBtn.Click += updateDatabaseBtn_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.elevator_bg;
            pictureBox6.Location = new Point(744, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(663, 418);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 36;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.elevator_bg;
            pictureBox2.Location = new Point(744, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(663, 418);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bg;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(742, 839);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(519, 712);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 39;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 856);
            Controls.Add(button1);
            Controls.Add(groundFloorPicture);
            Controls.Add(goUpBtn);
            Controls.Add(goDownBtn);
            Controls.Add(closeDoorBtn);
            Controls.Add(openDoorBtn);
            Controls.Add(controlPanelPicture);
            Controls.Add(pictureBox3);
            Controls.Add(callDownBtn);
            Controls.Add(callUpBtn);
            Controls.Add(leftDoorGround);
            Controls.Add(rightDoorGround);
            Controls.Add(updateDatabaseBtn);
            Controls.Add(emptyDatabaseBtn);
            Controls.Add(label1);
            Controls.Add(logTable);
            Controls.Add(firstFloorPicture);
            Controls.Add(pictureBox5);
            Controls.Add(rightDoorFirst);
            Controls.Add(leftDoorFirst);
            Controls.Add(elevator);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox2);
            Controls.Add(elevatorUnit);
            Controls.Add(pictureBox1);
            Controls.Add(clearLogBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)rightDoorFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevator).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)callDownBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)openDoorBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeDoorBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstFloorPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)groundFloorPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)goUpBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)controlPanelPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)goDownBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)callUpBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)logTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox rightDoorFirst;
        private PictureBox leftDoorFirst;
        private PictureBox elevator;
        private PictureBox leftDoorGround;
        private PictureBox rightDoorGround;
        private PictureBox callDownBtn;
        private PictureBox openDoorBtn;
        private PictureBox closeDoorBtn;
        private System.Windows.Forms.Timer openDoorTimer;
        private System.Windows.Forms.Timer closeDoorTimer;
        private System.Windows.Forms.Timer goDownTimer;
        private System.Windows.Forms.Timer goUpTimer;
        private System.Windows.Forms.Timer countTimer;
        private PictureBox elevatorUnit;
        private PictureBox firstFloorPicture;
        private PictureBox groundFloorPicture;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox5;
        private PictureBox goUpBtn;
        private PictureBox pictureBox3;
        private PictureBox controlPanelPicture;
        private PictureBox goDownBtn;
        private PictureBox callUpBtn;
        private DataGridView logTable;
        private Label label1;
        private System.ComponentModel.BackgroundWorker updateBackgroundWorker;
        private System.ComponentModel.BackgroundWorker deleteBackgroundWorker;
        private Button emptyDatabaseBtn;
        private Button clearLogBtn;
        private Button updateDatabaseBtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}