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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }
           else if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
            }
           else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
           else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
           Admin a = new Admin();
            a.ShowDialog();
            
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn s = new SignIn();
            s.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Search s1 = new Search();
            s1.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration r = new Registration();
            r.ShowDialog();
        }

        private void Color(object sender, EventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            SignIn s = new SignIn();
            s.ShowDialog();
        }


        
    }
}
