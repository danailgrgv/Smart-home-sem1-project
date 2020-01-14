namespace StudentHouse
{
    partial class DoorLockRFID
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
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbComms = new System.Windows.Forms.ListBox();
            this.spAlarmArduino = new System.IO.Ports.SerialPort(this.components);
            this.spColorArduino = new System.IO.Ports.SerialPort(this.components);
            this.pbAlarm = new System.Windows.Forms.PictureBox();
            this.lbAlarm = new System.Windows.Forms.Label();
            this.spSendTime = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // timerComms
            // 
            this.timerComms.Interval = 50;
            this.timerComms.Tick += new System.EventHandler(this.TimerAlarm_Tick);
            // 
            // cbComPort
            // 
            this.cbComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(9, 32);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(2);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(152, 28);
            this.cbComPort.TabIndex = 10;
            this.cbComPort.Text = "None";
            this.cbComPort.DropDown += new System.EventHandler(this.CbComPort_DropDown);
            this.cbComPort.SelectedValueChanged += new System.EventHandler(this.CbComPort_SelectedValueChanged);
            // 
            // lbTags
            // 
            this.lbTags.BackColor = System.Drawing.Color.DimGray;
            this.lbTags.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTags.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 18;
            this.lbTags.Location = new System.Drawing.Point(216, 10);
            this.lbTags.Margin = new System.Windows.Forms.Padding(2);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(175, 220);
            this.lbTags.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "RFID Arduino Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Message List";
            // 
            // lbComms
            // 
            this.lbComms.BackColor = System.Drawing.Color.DimGray;
            this.lbComms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComms.ForeColor = System.Drawing.SystemColors.Control;
            this.lbComms.FormattingEnabled = true;
            this.lbComms.ItemHeight = 16;
            this.lbComms.Location = new System.Drawing.Point(9, 104);
            this.lbComms.Margin = new System.Windows.Forms.Padding(2);
            this.lbComms.Name = "lbComms";
            this.lbComms.Size = new System.Drawing.Size(194, 132);
            this.lbComms.TabIndex = 15;
            // 
            // spAlarmArduino
            // 
            this.spAlarmArduino.PortName = "COM5";
            // 
            // spColorArduino
            // 
            this.spColorArduino.PortName = "COM3";
            // 
            // pbAlarm
            // 
            this.pbAlarm.BackColor = System.Drawing.Color.Green;
            this.pbAlarm.Location = new System.Drawing.Point(428, 9);
            this.pbAlarm.Name = "pbAlarm";
            this.pbAlarm.Size = new System.Drawing.Size(88, 84);
            this.pbAlarm.TabIndex = 16;
            this.pbAlarm.TabStop = false;
            // 
            // lbAlarm
            // 
            this.lbAlarm.AutoSize = true;
            this.lbAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarm.ForeColor = System.Drawing.Color.White;
            this.lbAlarm.Location = new System.Drawing.Point(428, 104);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(90, 20);
            this.lbAlarm.TabIndex = 17;
            this.lbAlarm.Text = "Alarm state";
            // 
            // spSendTime
            // 
            this.spSendTime.PortName = "COM6";
            // 
            // DoorLockRFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(689, 304);
            this.Controls.Add(this.lbAlarm);
            this.Controls.Add(this.pbAlarm);
            this.Controls.Add(this.lbComms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTags);
            this.Controls.Add(this.cbComPort);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoorLockRFID";
            this.Text = "Door Lock System";
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort spRFIDArduino;
        private System.Windows.Forms.Timer timerComms;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbComms;
        private System.IO.Ports.SerialPort spAlarmArduino;
        private System.IO.Ports.SerialPort spColorArduino;
        private System.Windows.Forms.PictureBox pbAlarm;
        private System.Windows.Forms.Label lbAlarm;
        private System.IO.Ports.SerialPort spSendTime;
    }
}

