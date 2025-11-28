
using System;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Win32;


namespace NC800_Control
{

    public partial class MainForm : Form
    {
        public readonly int MaxNumRelays = 8;
        public readonly string nc800_default_ip = "192.168.1.4";
        public readonly string nc800_default_pdir = "30000";
        public readonly string RegKey = "HKEY_LOCAL_MACHINE\\SOFTWARE\\NC800";
        public readonly string subKeyIP = "IPaddress";
        public readonly string subKeyPortDir = "PortDir";
        public string nc800_ip, nc800_pdir;
        public string relayStatus = "";
        public string relayOnOffStatus = "";
        static readonly object OutIn = new object();

        HttpClient NC800client = new HttpClient();

        // ***** Main Program
        public MainForm()
        {
            InitializeComponent();

            // Read Registery stored IP & PortDirectory if exist otherwise set to defaults
            nc800_ip = (string)Registry.GetValue(RegKey, subKeyIP, null);
            if (nc800_ip == null)
                nc800_ip = nc800_default_ip;

            nc800_pdir = (string)Registry.GetValue(RegKey, subKeyPortDir, null);
            if (nc800_pdir == null)
                nc800_pdir = nc800_default_pdir;

            // Retrieve and process NC800 relay status
            lock(OutIn)
                NC800Status();

            // Continue running program until Exit button is pressed to exit

        }

        // ***** Get NC800 Relays Status
        public async void NC800Status()
        {
            int n;

            try
            {
                var responseMessage = await NC800client.GetAsync($"http://{nc800_ip}/{nc800_pdir}");
                if (responseMessage.IsSuccessStatusCode)
                    relayStatus = await NC800client.GetStringAsync($"http://{nc800_ip}/{nc800_pdir}/99");

            }
            catch (Exception e)
            {
                string msg = e.Message;
                string til = "NC800 Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult results = MessageBox.Show(msg, til, buttons, MessageBoxIcon.Error);
                return;
            }

            // Process returned status
            n = relayStatus.IndexOf("TUX");
            relayOnOffStatus = relayStatus.Substring(n - 16, 8);
            relayStatus = relayOnOffStatus;
            for (n = 0; n < MaxNumRelays; n++)
            {
                switch (n + 1)
                {
                    case 1: // Relay 1
                        if (relayOnOffStatus[n] == '1')
                        {
                            relay1button.BackColor = Color.Green;
                            relay1button.Text = "Relay 1 ON";
                        }
                        else
                        {
                            relay1button.BackColor = Color.DarkRed;
                            relay1button.Text = "Relay 1 OFF";
                        }
                        break;
                    case 2: // Relay 2
                        if (relayOnOffStatus[n] == '1')
                        {
                            relay2button.BackColor = Color.Green;
                            relay2button.Text = "Relay 2 ON";
                        }
                        else
                        {
                            relay2button.BackColor = Color.DarkRed;
                            relay2button.Text = "Relay 2 OFF";
                        }
                        break;
                    case 3: // Relay 3
                        if (relayOnOffStatus[n] == '1')
                        {
                            relay3button.BackColor = Color.Green;
                            relay3button.Text = "Relay 3 ON";
                        }
                        else
                        {
                            relay3button.BackColor = Color.DarkRed;
                            relay3button.Text = "Relay 3 OFF";
                        }
                        break;
                    case 4: // Relay 4
                        if (relayOnOffStatus[n] == '1')
                        {
                            relay4button.BackColor = Color.Green;
                            relay4button.Text = "Relay 4 ON";
                        }
                        else
                        {
                            relay4button.BackColor = Color.DarkRed;
                            relay4button.Text = "Relay 4 OFF";
                        }
                        break;
                    case 5: // Relay 5
                        if (relayOnOffStatus[n] == '1')
                        {
                            relay5button.BackColor = Color.Green;
                            relay5button.Text = "Relay 5 ON";
                        }
                        else
                        {
                            relay5button.BackColor = Color.DarkRed;
                            relay5button.Text = "Relay 5 OFF";
                        }
                        break;
                    case 6: // Relay 6
                        if (relayOnOffStatus[n] == '1')
                        {
                            relay6button.BackColor = Color.Green;
                            relay6button.Text = "Relay 6 ON";
                        }
                        else
                        {
                            relay6button.BackColor = Color.DarkRed;
                            relay6button.Text = "Relay 6 OFF";
                        }
                        break;
                    case 7: // Relay 7
                        if (relayOnOffStatus[n] == '1')
                        {
                            relay7button.BackColor = Color.Green;
                            relay7button.Text = "Relay 7 ON";
                        }
                        else
                        {
                            relay7button.BackColor = Color.DarkRed;
                            relay7button.Text = "Relay 7 OFF";
                        }
                        break;
                    case 8: // Relay 8
                        if (relayOnOffStatus[n] == '1')
                        {
                            relay8button.BackColor = Color.Green;
                            relay8button.Text = "Relay 8 ON";
                        }
                        else
                        {
                            relay8button.BackColor = Color.DarkRed;
                            relay8button.Text = "Relay 8 OFF";
                        }
                        break;
                }
            }
            // Set the status of All relays button
            if (relayOnOffStatus == "11111111") 
            {
                // If all relays are ON
                relayAllOnOffbutton.BackColor = Color.Green;
                relayAllOnOffbutton.Text = "All Relays ON";
            }
            else
            {
                // If not all relays are ON
                relayAllOnOffbutton.BackColor = Color.DarkRed;
                relayAllOnOffbutton.Text = "All Relays OFF";
            }
        }

        // ***** Exit Program
        public void ExitApp(object sender, EventArgs e)
        {
            NC800client.Dispose();
            Application.Exit();
        }

        // ***** Change relay state ON or OFF
        private async void ChangeRelayState(int RelayNumber)
        {
            int n;
            string OnOff;

            // If relay number = 9 for all do all relays
            if (RelayNumber == 9)
            {
                if (relayOnOffStatus == "11111111")
                    OnOff = "44"; // All relays OFF
                else
                    OnOff = "45"; // All relays ON
            }
            else
            {
                // Calculate relay state '00' to '15'
                n = RelayNumber * 2; // Double the relay number
                if (relayStatus[RelayNumber - 1] == '0') // Check the status of the relay
                    n -= 1; // If OFF then set it to turn ON
                else
                    n -= 2; // If ON then set it to turn OFF
                
                OnOff = string.Format("{0:00}", n);
            }

            // Send changed relay state
            try
            {
                var responseMessage = await NC800client.GetAsync($"http://{nc800_ip}/{nc800_pdir}/{OnOff}");
                if (responseMessage.IsSuccessStatusCode)
                    lock(OutIn)
                        NC800Status();
            }
            catch (Exception e)
            {
                string msg = e.Message;
                string til = "NC800 Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult results = MessageBox.Show(msg, til, buttons, MessageBoxIcon.Error);
                // return;
            }
        }

        // ***** Relay 1 change state
        private void relay1button_Click(object sender, EventArgs e)
        {
            ChangeRelayState(1);
        }

        // ***** Relay 2 change state
        private void relay2button_Click(object sender, EventArgs e)
        {
            ChangeRelayState(2);
        }

        // ***** Relay 3 change state
        private void relay3button_Click(object sender, EventArgs e)
        {
            ChangeRelayState(3);
        }

        // ***** Relay 4 change state
        private void relay4button_Click(object sender, EventArgs e)
        {
            ChangeRelayState(4);
        }

        // ***** Relay 5 change state
        private void relay5button_Click(object sender, EventArgs e)
        {
            ChangeRelayState(5);
        }

        // ***** Relay 6 change state
        private void relay6button_Click(object sender, EventArgs e)
        {
            ChangeRelayState(6);
        }

        // ***** Relay 7 change state
        private void relay7button_Click(object sender, EventArgs e)
        {
            ChangeRelayState(7);
        }

        // ***** Relay 8 change state
        private void relay8button_Click(object sender, EventArgs e)
        {
            ChangeRelayState(8);
        }

        // ***** Relay 9 All change state
        private void relayAllOnOffbutton_Click(object sender, EventArgs e)
        {
            ChangeRelayState(9);
        }

        // ***** Config IP address/port (Directory)
        private void configIpPortbutton_Click(object sender, EventArgs e)
        {
            FormChangeIPport changeIPport = new FormChangeIPport();
            changeIPport.regKey = RegKey;
            changeIPport.regKeyIP = subKeyIP;
            changeIPport.regKeyPort = subKeyPortDir;
            changeIPport.ShowDialog();
        }
    }
}
