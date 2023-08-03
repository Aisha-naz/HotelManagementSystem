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
using System.Configuration;

namespace HotelManagementSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "Select Username From Registration where Username = '" + this.textBox2.Text + "'";
            if (command.ExecuteNonQuery() != null)
            {
                connection.Close();
                MessageBox.Show("Login Successful");
                VelvetHotel b1 = new VelvetHotel();
                b1.btnHome.Enabled = b1.btnStaff.Enabled = b1.btnRooms.Enabled = b1.btnFoods.Enabled = b1.customerbtn.Enabled = b1.btnbooking.Enabled = true;
            }
            else
                MessageBox.Show("Make sure you are registered");
        }
    }
}
