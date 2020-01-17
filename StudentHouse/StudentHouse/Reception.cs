using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace StudentHouse
{
    public partial class Reception : Form
    {

        int white = 0;
        int black = 0;
        int orange = 0;
        int yellow = 0;
        int purple = 0;
        int red = 0;
        int green = 0;
        int blue = 0;

        void UpdateFood()
        {
            lbFood.Items.Clear();
            lbFood.Items.Add($"Cartons of Milk:{white}");
            lbFood.Items.Add($"Cola: {black}");
            lbFood.Items.Add($"Oranges: {orange}");
            lbFood.Items.Add($"Bananas: {yellow}");
            lbFood.Items.Add($"Eggplants: {purple}");
            lbFood.Items.Add($"Tomatoes: {red}");
            lbFood.Items.Add($"Lettuce: {green}");
            lbFood.Items.Add($"Blueberries: {blue}");
        }

        private RFID RFID_Chip;
        private readonly List<RFIDTag> RFID_Taglist;
        private enum RFID_ReadStates { DEFAULT, ADD, REMOVE };
        private RFID_ReadStates RFID_ReadState;

        public Reception()
        {
			// Initialization of components
            InitializeComponent();
			InitializeRFID();
            TryOpenSerialPorts();
			RFID_Taglist = new List<RFIDTag>();
            RFID_ReadState = RFID_ReadStates.DEFAULT;

            // Enable serial monitoring timer
            timerComms.Enabled = true;
        }

		private void InitializeRFID()
		{
            RFID_Chip = new RFID();
            RFID_Chip.Tag += Rfid0_Tag;
            TryOpenRFIDChip();
        }

        private void TryOpenRFIDChip()
        {
            try
            {
                RFID_Chip.Open();
            }
            catch (PhidgetException)
            {

            }
        }

        private void TryOpenSerialPorts()
        {
            try
            {
                if (!spColorArduino.IsOpen)
                {
                    spColorArduino.PortName = "COM3";
                    spColorArduino.Open();
                }
            }
            catch (System.IO.IOException) { }
            try
            {
                if (!spRFIDArduino.IsOpen)
                {
                    spRFIDArduino.PortName = "COM4";
                    spRFIDArduino.Open();
                }
            }
            catch (System.IO.IOException) { }
            try
            {
                if (!spAlarmArduino.IsOpen)
                {
                    spAlarmArduino.PortName = "COM8";
                    spAlarmArduino.Open();
                }
            }
            catch (System.IO.IOException) { }
            try
            {
                if (!spLightArduino.IsOpen)
                {
                    spLightArduino.PortName = "COM10";
                    spLightArduino.Open();
                }
            }
            catch (System.IO.IOException) { }
        }

		private void Rfid0_Tag(object sender, RFIDTagEventArgs e)
        {
            // Only register events if the arduino serial port is connected
            if (spRFIDArduino.IsOpen)
            {
                // Make new virtual RFID tag with values obtained from the tag reader
                RFIDTag newTag;
			    newTag.Protocol = e.Protocol;
			    newTag.TagString = e.Tag;

                switch (RFID_ReadState)
                {
                    //  In DEFAULT read state, check if the tag details exist in the tag database
                    //  If they do, allow access to the house. Else, lock the door
                    // (send signals to Arduino serial port)
                    case RFID_ReadStates.DEFAULT:
                        if (RFID_Taglist.Contains(newTag))
                        {
                            AddCommandToListBox("ACCESS GRANTED");
                            spRFIDArduino.WriteLine("ALLOWED");
                        }
                        else
                        {
                            AddCommandToListBox("ACCESS DENIED");
                            spRFIDArduino.WriteLine("DENIED");
                        }
                        break;

                    // In ADD read state, add new tag details to the tag database
                    case RFID_ReadStates.ADD:
                        if (!RFID_Taglist.Contains(newTag))
                        {
                            RFID_Taglist.Add(newTag);
                            lbTags.Items.Add(newTag.TagString + " " + newTag.Protocol.ToString());
                        }
                        break;

                    // In ADD read state, remove tag details (if present) from the tag database
                    case RFID_ReadStates.REMOVE:
                        if (RFID_Taglist.Contains(newTag))
                        {
                            int index = RFID_Taglist.IndexOf(newTag);
                            RFID_Taglist.Remove(newTag);
                            lbTags.Items.RemoveAt(index);
                        }
                        break;
                }
            }
            // After each tag reading, change the read state to DEFAULT and await new tag detection
            RFID_ReadState = RFID_ReadStates.DEFAULT;
		}

		private void TimerAlarm_Tick(object sender, EventArgs e)
        {
            if (spLightArduino.IsOpen)
            {
                String time = DateTime.Now.ToString("HH.mm");
                spLightArduino.WriteLine(time);
            }

            if (spColorArduino.IsOpen)
            {
                if (spColorArduino.BytesToRead > 0) 
                {
                    string line = spColorArduino.ReadLine().Trim();
                    lbFood.Items.Add(line);
                    line.Trim('\r');
                    
                    if (line.Contains("In"))
                    {
                        string[] secondLine = line.Split(',');
                        string color = secondLine[1];
                        switch (color)
                        {
                            case "WHITE":
                                white++;
                                break;
                            case "BLACK":
                                black++;
                                break;
                            case "ORANGE":
                                orange++;
                                break;
                            case "YELLOW":
                                yellow++;
                                break;
                            case "PURPLE":
                                purple++;
                                break;
                            case "RED":
                                red++;
                                break;
                            case "GREEN":
                                green++;
                                break;
                            case "BLUE":
                                blue++;
                                break;
                            default:
                                MessageBox.Show("unknown color");
                                break;
                        }
                        UpdateFood();
                    }
                    if (line.Contains("Out"))
                    {
                        string[] secondLine = line.Split(',');
                        string color = secondLine[1];
                        switch (color)
                        {
                            case "WHITE":
                                if (white > 0)
                                {
                                    white--;
                                }
                                break;
                            case "BLACK":
                                if (black > 0)
                                {
                                    black--;
                                }
                                break;
                            case "ORANGE":
                                if (orange > 0)
                                {
                                    orange--;
                                }
                                break;
                            case "YELLOW":
                                if (yellow > 0)
                                {
                                    yellow--;
                                }
                                break;
                            case "PURPLE":
                                if (purple > 0)
                                {
                                    purple--;
                                }
                                break;
                            case "RED":
                                if (red > 0)
                                {
                                    red--;
                                }
                                break;
                            case "GREEN":
                                if (green > 0)
                                {
                                    green--;
                                }
                                break;
                            case "BLUE":
                                if (blue > 0)
                                {
                                    blue--;
                                }
                                break;
                            default:
                                MessageBox.Show("unknown color");
                                break;
                        }
                        UpdateFood();
                    }
                    
                }
            }


            if (spAlarmArduino.IsOpen)
            {
                if (spAlarmArduino.BytesToRead > 0)
                {
                    if (spAlarmArduino.ReadLine().Contains("AlarmOn"))
                    {
                        pbAlarm.BackColor = Color.Red;
                    }
                    else
                    {
                        pbAlarm.BackColor = Color.Green;
                    }
                }
            }

            if (spRFIDArduino.IsOpen)
            {
                // Read the current (existing) serial data
                string command = spRFIDArduino.ReadExisting();
                command.Trim();
                if (String.IsNullOrEmpty(command) == false)
                {
                    // If there are outstanding commands in the serial port, treat each command separately
                    foreach (string line in command.Replace("\r", "").Split('\n'))
                    {
                        switch (line)
                        {
                            case "ADD_KEY":
                                RFID_ReadState = RFID_ReadStates.ADD;
                                break;

                            case "REMOVE_KEY":
                                RFID_ReadState = RFID_ReadStates.REMOVE;
                                break;
                        }
                    }

                    // If the command is not empty, log it for debugging purposes
                    AddCommandToListBox(command);
                }
            }

            // If the RFID chip is still not connected, keep trying to open communication with it
            if (!RFID_Chip.Attached)
                TryOpenRFIDChip();

            // If any of the comports are still not connected, keep trying to open communication with them
            TryOpenSerialPorts();
        }

        private void AddCommandToListBox(string command)
        {
            lbComms.Items.Add(command);
            // Automatically scroll listbox to the bottom element
            lbComms.SelectedIndex = lbComms.Items.Count - 1;
            lbComms.SelectedIndex = -1;
        }
    }
}
