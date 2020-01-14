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
    public partial class DoorLockRFID : Form
    {
		private RFID RFID_Chip;
		private readonly List<RFIDTag> RFID_Taglist;
        private enum RFID_ReadStates { DEFAULT, ADD, REMOVE };
        private RFID_ReadStates RFID_ReadState;

        public DoorLockRFID()
        {
			// Initialization of components
            InitializeComponent();
			InitializeRFID();
			RFID_Taglist = new List<RFIDTag>();
            RFID_ReadState = RFID_ReadStates.DEFAULT;
        }

		private void InitializeRFID()
		{
            //spAlarmArduino.Open();
            RFID_Chip = new RFID();
            RFID_Chip.Tag += Rfid0_Tag;
            RFID_Chip.Open(5000);    
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

        private void CbComPort_DropDown(object sender, EventArgs e)
        {
			// Combo box with options for (dis)connecting the Arduino serial communication port
			cbComPort.Items.Clear();
			foreach (string port in SerialPort.GetPortNames())
			{
				cbComPort.Items.Add(port);
			}
			cbComPort.Items.Add("None");
		}

        private void CbComPort_SelectedValueChanged(object sender, EventArgs e)
        {
            //  Open or close the communication between the arduino and the application
            // depending on the selected choice
            if (cbComPort.SelectedItem.ToString() != "None")
            {
                if (spRFIDArduino.IsOpen == false)
                {
                    // Open serial communication port
                    spRFIDArduino.PortName = cbComPort.SelectedItem.ToString();
                    spRFIDArduino.Open();
                    AddCommandToListBox("Serial connected");

                    // Enable serial monitoring timer
                    timerComms.Enabled = true;
                }
            }
            else
            {
                // Close the serial connection and disable the serial monitoring timer
                timerComms.Enabled = false;
                spRFIDArduino.Close();
                AddCommandToListBox("Serial disconnected");
            }
        }

		private void TimerAlarm_Tick(object sender, EventArgs e)
        {
            
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
