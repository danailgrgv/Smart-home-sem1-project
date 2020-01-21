namespace StudentHouse
{
    partial class Reception
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spRFIDArduino = new System.IO.Ports.SerialPort(this.components);
            this.timerComms = new System.Windows.Forms.Timer(this.components);
            this.lbTags = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbComms = new System.Windows.Forms.ListBox();
            this.spAlarmArduino = new System.IO.Ports.SerialPort(this.components);
            this.spColorArduino = new System.IO.Ports.SerialPort(this.components);
            this.pbAlarm = new System.Windows.Forms.PictureBox();
            this.lbAlarm = new System.Windows.Forms.Label();
            this.spLightArduino = new System.IO.Ports.SerialPort(this.components);
            this.lbFood = new System.Windows.Forms.ListBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRoomNr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStudentNr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbRegistrations = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbConnect = new System.Windows.Forms.ListBox();
            this.btnAddKey = new System.Windows.Forms.Button();
            this.btnRemoveKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerComms
            // 
            this.timerComms.Interval = 50;
            this.timerComms.Tick += new System.EventHandler(this.TimerComms_Tick);
            // 
            // lbTags
            // 
            this.lbTags.BackColor = System.Drawing.Color.DimGray;
            this.lbTags.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTags.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 23;
            this.lbTags.Location = new System.Drawing.Point(429, 431);
            this.lbTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(135, 165);
            this.lbTags.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(158, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Message List";
            // 
            // lbComms
            // 
            this.lbComms.BackColor = System.Drawing.Color.DimGray;
            this.lbComms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComms.ForeColor = System.Drawing.SystemColors.Control;
            this.lbComms.FormattingEnabled = true;
            this.lbComms.ItemHeight = 20;
            this.lbComms.Location = new System.Drawing.Point(163, 432);
            this.lbComms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbComms.Name = "lbComms";
            this.lbComms.Size = new System.Drawing.Size(235, 164);
            this.lbComms.TabIndex = 15;
            // 
            // pbAlarm
            // 
            this.pbAlarm.BackColor = System.Drawing.Color.Green;
            this.pbAlarm.Location = new System.Drawing.Point(13, 443);
            this.pbAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.pbAlarm.Name = "pbAlarm";
            this.pbAlarm.Size = new System.Drawing.Size(117, 103);
            this.pbAlarm.TabIndex = 16;
            this.pbAlarm.TabStop = false;
            // 
            // lbAlarm
            // 
            this.lbAlarm.AutoSize = true;
            this.lbAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarm.ForeColor = System.Drawing.Color.White;
            this.lbAlarm.Location = new System.Drawing.Point(14, 414);
            this.lbAlarm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(110, 25);
            this.lbAlarm.TabIndex = 17;
            this.lbAlarm.Text = "Alarm state";
            // 
            // lbFood
            // 
            this.lbFood.BackColor = System.Drawing.Color.DimGray;
            this.lbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFood.ForeColor = System.Drawing.SystemColors.Control;
            this.lbFood.FormattingEnabled = true;
            this.lbFood.ItemHeight = 20;
            this.lbFood.Location = new System.Drawing.Point(714, 34);
            this.lbFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(257, 344);
            this.lbFood.TabIndex = 18;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(130, 21);
            this.tbFirstName.Multiline = true;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(201, 29);
            this.tbFirstName.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbRFID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbRoomNr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbStudentNr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbBirthday);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 304);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "RFID tag";
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(130, 261);
            this.tbRFID.Multiline = true;
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(201, 29);
            this.tbRFID.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Room number";
            // 
            // tbRoomNr
            // 
            this.tbRoomNr.Location = new System.Drawing.Point(130, 213);
            this.tbRoomNr.Multiline = true;
            this.tbRoomNr.Name = "tbRoomNr";
            this.tbRoomNr.Size = new System.Drawing.Size(201, 29);
            this.tbRoomNr.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Student number";
            // 
            // tbStudentNr
            // 
            this.tbStudentNr.Location = new System.Drawing.Point(130, 165);
            this.tbStudentNr.Multiline = true;
            this.tbStudentNr.Name = "tbStudentNr";
            this.tbStudentNr.Size = new System.Drawing.Size(201, 29);
            this.tbStudentNr.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Birthday";
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(130, 117);
            this.tbBirthday.Multiline = true;
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(201, 29);
            this.tbBirthday.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "First name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(130, 69);
            this.tbLastName.Multiline = true;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(201, 29);
            this.tbLastName.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(347, 38);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "ADD REGISTRATION";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lbRegistrations
            // 
            this.lbRegistrations.BackColor = System.Drawing.Color.DimGray;
            this.lbRegistrations.ForeColor = System.Drawing.SystemColors.Control;
            this.lbRegistrations.FormattingEnabled = true;
            this.lbRegistrations.ItemHeight = 16;
            this.lbRegistrations.Location = new System.Drawing.Point(376, 34);
            this.lbRegistrations.Name = "lbRegistrations";
            this.lbRegistrations.Size = new System.Drawing.Size(332, 324);
            this.lbRegistrations.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(376, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "List of registrations";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(711, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Food items";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(424, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tag List";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(581, 396);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(101, 43);
            this.btnConnect.TabIndex = 26;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // lbConnect
            // 
            this.lbConnect.BackColor = System.Drawing.Color.DimGray;
            this.lbConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConnect.FormattingEnabled = true;
            this.lbConnect.ItemHeight = 16;
            this.lbConnect.Location = new System.Drawing.Point(581, 448);
            this.lbConnect.Name = "lbConnect";
            this.lbConnect.Size = new System.Drawing.Size(207, 148);
            this.lbConnect.TabIndex = 27;
            // 
            // btnAddKey
            // 
            this.btnAddKey.Location = new System.Drawing.Point(688, 396);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(115, 42);
            this.btnAddKey.TabIndex = 28;
            this.btnAddKey.Text = "ADD KEY";
            this.btnAddKey.UseVisualStyleBackColor = true;
            this.btnAddKey.Click += new System.EventHandler(this.BtnAddKey_Click);
            // 
            // btnRemoveKey
            // 
            this.btnRemoveKey.Location = new System.Drawing.Point(809, 396);
            this.btnRemoveKey.Name = "btnRemoveKey";
            this.btnRemoveKey.Size = new System.Drawing.Size(129, 42);
            this.btnRemoveKey.TabIndex = 29;
            this.btnRemoveKey.Text = "REMOVE KEY";
            this.btnRemoveKey.UseVisualStyleBackColor = true;
            this.btnRemoveKey.Click += new System.EventHandler(this.BtnRemoveKey_Click);
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(988, 617);
            this.Controls.Add(this.btnRemoveKey);
            this.Controls.Add(this.btnAddKey);
            this.Controls.Add(this.lbConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbRegistrations);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbFood);
            this.Controls.Add(this.lbAlarm);
            this.Controls.Add(this.pbAlarm);
            this.Controls.Add(this.lbComms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTags);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reception";
            this.Text = "Student House Reception";
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort spRFIDArduino;
        private System.Windows.Forms.Timer timerComms;
        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbComms;
        private System.IO.Ports.SerialPort spAlarmArduino;
        private System.IO.Ports.SerialPort spColorArduino;
        private System.Windows.Forms.PictureBox pbAlarm;
        private System.Windows.Forms.Label lbAlarm;
        private System.IO.Ports.SerialPort spLightArduino;
        private System.Windows.Forms.ListBox lbFood;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStudentNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRoomNr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbRegistrations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lbConnect;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.Button btnRemoveKey;
    }
}

