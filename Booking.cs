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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = this.textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "INSERT INTO Registration (Name,Check-In,Check-Out,Room_No,Food_Unit,Food_Type)VALUES ('" + this.textBox1.Text + "','" + this.dateTimePicker2.Text + "','" + this.dateTimePicker1.Text + "','" + this.comboBox2.SelectedItem.ToString() + "','" + this.textBox6.Text + "','" + this.comboBox1.SelectedItem.ToString() + "')";
            
            command.ExecuteNonQuery();
            connection.Close();

            VelvetHotel v = new VelvetHotel();
           
            finalform f = new finalform();
            v.Dispose();
           f.Show();
            


        }
    }
}
