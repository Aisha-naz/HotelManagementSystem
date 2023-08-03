using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class finalform : Form
    {
        public finalform()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 733)
            {
                timer1.Stop();
                this.Hide();
                VelvetHotel v = new VelvetHotel();
               // v.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
