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
    public partial class NonVegForm : Form
    {
        public NonVegForm()
        {
            InitializeComponent();
        }

        private void customeButtonControl1_Load(object sender, EventArgs e)
        {
            this.panel1.Size = new Size(717, 400);
        }

        private void customeButtonControl2_Load(object sender, EventArgs e)
        {
            this.panel1.Size = new Size(129, 400);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
