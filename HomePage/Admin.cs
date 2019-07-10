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
    public partial class Admin : Form
    {

        String connectionString = "Data Source=DESKTOP-TL4IJDB;Initial Catalog=MedicalStore;User ID=SA;Password=12345";
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        

       

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();

            if (sql.State == ConnectionState.Open)
            {

                string query = "Select * from Admin where Username ='" + username.Text.Trim() + "', Password ='" + password.Text.Trim() + "'";
                SqlDataAdapter q1 = new SqlDataAdapter(query, sql);
                DataTable d = new DataTable();
                q1.Fill(d);
                
                if(d.Rows.Count == 1)
                {
                    this.Hide();
                    StorePanel sp = new StorePanel();
                    sp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your Username Or Password Is Incorrect", "Warning");
                }
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword sp = new ForgotPassword();
            sp.ShowDialog();

        }
    }
}
