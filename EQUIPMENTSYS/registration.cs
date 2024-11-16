using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace EQUIPMENTSYS
{
    public partial class registration : Form
    {
        //Forms instances
        adminlogin adminlogin = new adminlogin();
        //
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //for opening the adminlogin page 

            adminlogin.Show();
            this.Hide();
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for registration
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            con.Open();// for opening the connection
            string query = "Insert into accounts(username,password,Firstname,Lastname,Course,Year) values(@username,@password,@Firstname,@Lastname,@course,@year);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox3.Text);
            cmd.Parameters.AddWithValue("@password", textBox5.Text);
            cmd.Parameters.AddWithValue("@Firstname", textBox1.Text);
            cmd.Parameters.AddWithValue("@Lastname", textBox2.Text);
            cmd.Parameters.AddWithValue("@course", textBox3.Text);
            cmd.Parameters.AddWithValue("@year", comboBox1.Text);
            cmd.ExecuteNonQuery();//for executing the query
            MessageBox.Show("Registered Sucessfully");
            adminlogin.Show();
            this.Hide();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
