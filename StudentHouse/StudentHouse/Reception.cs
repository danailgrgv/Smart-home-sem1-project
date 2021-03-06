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
using StudentHouseReception;
using Websocket;

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

        public readonly WebSocket ws = new WebSocket();
        public bool isConnected = false;

        private RFID RFID_Chip;
        private readonly List<RFIDTag> RFID_Taglist;
        private enum RFID_ReadStates { DEFAULT, ADD, REMOVE };
        private RFID_ReadStates RFID_ReadState;

        readonly List<StudentRegistration> registrations = new List<StudentRegistration>();
        private readonly List<Room> rooms = new List<Room>();
        public Reception()
        {
            // Initialize hotel rooms
            for (uint number = 1; number <= 150; number++)
            {
                rooms.Add(new Room(number));
            }

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
                    spColorArduino.PortName = "COM9";
                    spColorArduino.Open();
                }
            }
            catch (System.IO.IOException) { }
            try
            {
                if (!spRFIDArduino.IsOpen)
                {
                    spRFIDArduino.PortName = "COM10";
                    spRFIDArduino.Open();
                }
            }
            catch (System.IO.IOException) { }
            catch (UnauthorizedAccessException) { }
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
                    spLightArduino.PortName = "COM7";
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
                            lbTags.Items.Add(newTag.TagString);
                            tbRFID.Text = newTag.TagString;
                            if (isConnected)
                            {
                                ws.SendMsg(newTag.TagString); // Send tag via network
                            }
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string birthday = tbBirthday.Text;
            string rfidTag = tbRFID.Text;
            UInt32.TryParse(tbRoomNr.Text, out uint roomNr);
            UInt64.TryParse(tbStudentNr.Text, out ulong studentNumber);
            Room room = new Room(roomNr);

            if (room != null)
            {
                Student student = new Student(firstName, lastName, birthday, studentNumber);
                StudentRegistration stureg = new StudentRegistration(rfidTag, student, room);
                registrations.Add(stureg);
                lbRegistrations.Items.Add(firstName + " " + lastName + ", SN " +
                    studentNumber.ToString() + ", Room " + roomNr.ToString() + " RFID " + rfidTag);
            }

            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbBirthday.Text = "";
            tbRFID.Text = "";
            tbRoomNr.Text = "";
            tbStudentNr.Text = "";
        }

        //private Room GetRoom(uint number)
        //{
        //    foreach (Room room in rooms)
        //    {
        //        if (room.RoomNumber == number)
        //        {
        //            return room;
        //        }
        //    }
        //    return null;
        //}

        private void TimerComms_Tick(object sender, EventArgs e)
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

            for (int i = 0; i < ws.messages.Count; i++)
            {
                lbConnect.Items.Add(ws.messages[i]);
                //if (ws.messages[i].Contains("ORDER_"))
                //{
                //    AddOrder(ws.messages[i].Replace("ORDER_", ""));
                //    ws.messages.RemoveAt(i);
                //    i--;
                //}
            }
            ws.messages.Clear();
        }

        private void AddCommandToListBox(string command)
        {
            lbComms.Items.Add(command);
            // Automatically scroll listbox to the bottom element
            lbComms.SelectedIndex = lbComms.Items.Count - 1;
            lbComms.SelectedIndex = -1;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Connect connectForm = new Connect(this);
            connectForm.Show();
        }

        private void BtnAddKey_Click(object sender, EventArgs e)
        {
            RFID_ReadState = RFID_ReadStates.ADD;
        }

        private void BtnRemoveKey_Click(object sender, EventArgs e)
        {
            RFID_ReadState = RFID_ReadStates.REMOVE;
        }
    }
}
