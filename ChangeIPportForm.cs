using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NC800_Control
{
    public partial class FormChangeIPport : Form
    {
        public string ipAddress;
        public string portNumber;
        public string regKey;
        public string regKeyIP;
        public string regKeyPort;

        public FormChangeIPport()
        {
            InitializeComponent();
        }

        // ***** Make changes to IP/Port
        private void buttonChangeStore_Click(object sender, EventArgs e)
        {
            ushort[] IPnum = new ushort[] { 0, 0, 0, 0, 0 };
            string[] IPsplit = textBoxIPaddress.Text.Split('.');
            ushort n = 0;
            foreach (string num in IPsplit)
            {
                IPnum[n] = Convert.ToUInt16(num);
                if ((IPnum[n] > 254) || (n > 3) || (textBoxIPaddress.Text == ""))
                {
                    MessageBox.Show("Enter numbers 1 to 254 like NNN.NNN.NNN.NNN", "IP Address Error", MessageBoxButtons.OK);
                    return;
                }
                n++;
            }
            if ((textBoxPortNumber.Text == "") || (Convert.ToInt32(textBoxPortNumber.Text) == 0))
            {

                return;
            }
            string _post = "";

        }

        // ***** Cancel changes
        private void buttonCancelChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ***** Set default values
        private void buttonSetDefaults_Click(object sender, EventArgs e)
        {
            textBoxIPaddress.Text = regKeyIP;
            textBoxPortNumber.Text = regKeyPort;

        }

        private void FormChangeIPport_Load(object sender, EventArgs e)
        {
            // Read Registery stored IP & PortDirectory if exist otherwise set to defaults
            ipAddress = (string)Registry.GetValue(regKey, regKeyIP, "");
            if (ipAddress != "")
                textBoxIPaddress.Text = ipAddress;

            portNumber = (string)Registry.GetValue(regKey, regKeyPort, "");
            if (portNumber != "")
                textBoxPortNumber.Text = portNumber;

        }
    }
}
