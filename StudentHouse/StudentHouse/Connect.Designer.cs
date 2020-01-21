namespace StudentHouse
{
    partial class Connect
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRemotePort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRemoteIP = new System.Windows.Forms.TextBox();
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLocalIP = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(94, 97);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(156, 53);
            this.btnConnect.TabIndex = 29;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRemotePort);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbRemoteIP);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(179, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 79);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote Connection";
            // 
            // tbRemotePort
            // 
            this.tbRemotePort.BackColor = System.Drawing.SystemColors.Control;
            this.tbRemotePort.Location = new System.Drawing.Point(46, 49);
            this.tbRemotePort.MaxLength = 5;
            this.tbRemotePort.Name = "tbRemotePort";
            this.tbRemotePort.Size = new System.Drawing.Size(101, 22);
            this.tbRemotePort.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "IP";
            // 
            // tbRemoteIP
            // 
            this.tbRemoteIP.BackColor = System.Drawing.SystemColors.Control;
            this.tbRemoteIP.Location = new System.Drawing.Point(46, 21);
            this.tbRemoteIP.MaxLength = 15;
            this.tbRemoteIP.Name = "tbRemoteIP";
            this.tbRemoteIP.Size = new System.Drawing.Size(101, 22);
            this.tbRemoteIP.TabIndex = 0;
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.tbLocalPort);
            this.gbConnect.Controls.Add(this.label8);
            this.gbConnect.Controls.Add(this.label7);
            this.gbConnect.Controls.Add(this.tbLocalIP);
            this.gbConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.gbConnect.Location = new System.Drawing.Point(12, 12);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Size = new System.Drawing.Size(156, 79);
            this.gbConnect.TabIndex = 27;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Local Connection";
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.BackColor = System.Drawing.SystemColors.Control;
            this.tbLocalPort.Location = new System.Drawing.Point(46, 49);
            this.tbLocalPort.MaxLength = 5;
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(101, 22);
            this.tbLocalPort.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "IP";
            // 
            // tbLocalIP
            // 
            this.tbLocalIP.BackColor = System.Drawing.SystemColors.Control;
            this.tbLocalIP.Location = new System.Drawing.Point(46, 21);
            this.tbLocalIP.MaxLength = 15;
            this.tbLocalIP.Name = "tbLocalIP";
            this.tbLocalIP.Size = new System.Drawing.Size(101, 22);
            this.tbLocalIP.TabIndex = 0;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(347, 161);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbConnect);
            this.Name = "Connect";
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.Connect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbConnect.ResumeLayout(false);
            this.gbConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRemotePort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRemoteIP;
        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLocalIP;
    }
}