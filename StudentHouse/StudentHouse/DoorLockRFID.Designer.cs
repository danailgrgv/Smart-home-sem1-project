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
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.timerComms = new System.Windows.Forms.Timer(this.components);
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbComms = new System.Windows.Forms.ListBox();
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
            this.cbComPort.Location = new System.Drawing.Point(12, 40);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(201, 33);
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
            this.lbTags.ItemHeight = 23;
            this.lbTags.Location = new System.Drawing.Point(288, 12);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(232, 280);
            this.lbTags.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "RFID Arduino Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 90);
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
            this.lbComms.Location = new System.Drawing.Point(12, 128);
            this.lbComms.Name = "lbComms";
            this.lbComms.Size = new System.Drawing.Size(257, 164);
            this.lbComms.TabIndex = 15;
            // 
            // DoorLockRFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.lbComms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTags);
            this.Controls.Add(this.cbComPort);
            this.Name = "DoorLockRFID";
            this.Text = "Door Lock System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort spArduino;
        private System.Windows.Forms.Timer timerComms;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbComms;
    }
}

