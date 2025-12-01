using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NC800_Control
{
    public partial class FormChangeIPport : Form
    {
        public bool _form_status;
        public string DefaultIP;
        public string DefaultPort;
        public string _ipAddress;
        public string _portNumber;
        public string regKey;
        public string regKeyIP;
        public string regKeyPort;
        public string postStrIP;
        public string postStrPort;


        public FormChangeIPport()
        {
            InitializeComponent();
        }

        // ***** Make changes to IP/Port
        private void buttonChangeStore_Click(object sender, EventArgs e)
        {
            if (checkInputValues())
            {
                postStrIP = textBoxIPaddress.Text;
                postStrPort = textBoxPortNumber.Text;
                _form_status = true;
                Close();
            }
        }

        // ***** Check the Input values
        private bool checkInputValues()
        {
            ushort[] IPnum = new ushort[] { 0, 0, 0, 0, 0 };
            string[] IPsplit = textBoxIPaddress.Text.Split('.');
            ushort n = 0;

            foreach (string num in IPsplit)
            {
                IPnum[n] = Convert.ToUInt16(num);
                if ((IPnum[n] > 254) || (IPnum[n] < 1) || (n > 3) || (textBoxIPaddress.Text == ""))
                {
                    MessageBox.Show("Enter numbers 1 to 254 like NNN.NNN.NNN.NNN", "IP Address Error", MessageBoxButtons.OK);
                    return false;
                }
                n++;
            }
            if ((textBoxPortNumber.Text == "") || (Convert.ToInt32(textBoxPortNumber.Text) == 0))
            {
                MessageBox.Show("Enter numbers 1 to 65535", "Port Number Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        // ***** Cancel changes
        private void buttonCancelChanges_Click(object sender, EventArgs e)
        {
            _form_status = false;
            Close();
        }

        // ***** Set default values
        private void buttonSetDefaults_Click(object sender, EventArgs e)
        {
            textBoxIPaddress.Text = DefaultIP;
            textBoxPortNumber.Text = DefaultPort;
        }

        private void FormChangeIPport_Load(object sender, EventArgs e)
        {
            _form_status = false;
            textBoxIPaddress.Text = _ipAddress;
            textBoxPortNumber.Text = _portNumber;
        }
    }
}
