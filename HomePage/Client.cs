using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
         public string username, strmenu;
         public Client(string uname, string strmnu)
        {
            username = uname;
            strmenu = strmnu;
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            if (strmenu == "Add")
            {

                tabControl1.SelectedIndex = 0;
            }
            else if (strmenu == "Update")
            {
                tabControl1.SelectedIndex = 1;
            }
            else if (strmenu == "Delete")
            {
                tabControl1.SelectedIndex = 2;
            }
            else if (strmenu == "View")
            {
                tabControl1.SelectedIndex = 3;
            }
        }
    }
}
