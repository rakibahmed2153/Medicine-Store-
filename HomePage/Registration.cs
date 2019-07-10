using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomePage
{
    public partial class Registration : Form
    {
        String connectionString = "Data Source=DESKTOP-TL4IJDB;Initial Catalog=MedicalStore;User ID=SA;Password=12345";
        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection sql = new SqlConnection(connectionString);
                sql.Open();

                if (sql.State == ConnectionState.Open)
                {
                    if (password.Text == confirmpassword.Text)
                    {
                        string query = "Insert into Client (Username,Fullname,Gender,Email,Phoneno,Password,Sequrityquestion,Answer) values ('" + username.Text + "', '" + fullname.Text + "','" + gender.Text + "','" + email.Text + "','" + phoneno.Text + "','" + password.Text + "','" + sequrityquestion.Text + "','" + answer.Text + "') ";

                        SqlCommand q1 = new SqlCommand(query, sql);

                        q1.ExecuteNonQuery();
                        MessageBox.Show("Registration Successful. Please wait for admin verification!!! ");
                        this.Hide();
                        Form1 f = new Form1();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password & Confirm Password does not match!!!","Warning");

                    }

                }
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
