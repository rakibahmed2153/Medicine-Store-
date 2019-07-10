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
    public partial class StorePanel : Form
    {
        public StorePanel()
        {
            InitializeComponent();
        }

        private void cLINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Client();
            additem.MdiParent = this;
            additem.Show();
        }

      

       
        private void closeExistingForm()
        {
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception)
            {

            }

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Stock();
            additem.MdiParent = this;
            additem.Show();
        }

        private void cOMPANYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new Company();
            additem.MdiParent = this;
            additem.Show();
        }

        private void mANAGEUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeExistingForm();
            Form additem = new ManageUser();
            additem.MdiParent = this;
            additem.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

       
    }
}
