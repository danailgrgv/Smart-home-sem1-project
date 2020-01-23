using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sendtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spArduino.Open();
            tmrTime.Start();
        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH.mm:ss");
            String time = DateTime.Now.ToString("HH.mm");
            spArduino.WriteLine(time);
        }
    }
}
