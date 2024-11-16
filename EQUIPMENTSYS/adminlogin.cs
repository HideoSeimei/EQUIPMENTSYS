using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace EQUIPMENTSYS
{
    
    public partial class adminlogin : Form
    {
        //Forms instances
        admin_items adminItems = new admin_items();
        //
        public adminlogin()
        {
            InitializeComponent();
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();// for opening the connection
            string query = "Select count(*) from Accounts where username = @username and password = @password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            int count = (int)cmd.ExecuteScalar();// variable if theres an account
            con.Close();//closing the connection since it's not needed
            if (count>0)// code if succesfully login
            {
                adminItems.Show();
                this.Hide();


            }
            else//if there's no account
            {
                label2.Text = "Wrong Username or Password";
                
            }
             
        }
    }
}
