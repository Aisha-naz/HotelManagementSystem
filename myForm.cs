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
    public partial class myForm : Form
    {
        
        public myForm()
        {
            InitializeComponent();
        }

        private void customTextBox5_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            this.txtAddress.Texts = this.txtCnic.Texts = this.txtCntct.Texts = "";
            this.txtname.Texts = this.txtPwd.Texts = this.txtUser.Texts = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText =  "INSERT INTO Registration (Name,CNIC,Username,Password,ContactNo,Adress)VALUES ('" + this.txtname.Texts + "','" + this.txtCnic.Texts + "','" + this.txtUser.Texts + "','" + this.txtPwd.Texts + "','" + this.txtCntct.Texts + "','" + this.txtAddress.Texts + "')";
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Registered Successfully" );
            VelvetHotel b1 = new VelvetHotel();
            b1.btnHome.Enabled = b1.btnStaff.Enabled = b1.btnRooms.Enabled = b1.btnFoods.Enabled = b1.customerbtn.Enabled = b1.btnbooking.Enabled = true;

        }

        private void myForm_Load(object sender, EventArgs e)
        {
        }
    }
}
