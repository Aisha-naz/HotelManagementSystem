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
    public partial class VelvetHotel : Form
    {
        public VelvetHotel()
        {
            InitializeComponent();
            CustomeDesigning();
           
        }
       
        public void CustomeDesigning()
        {
            this.panelFood.Visible = false;
            this.panelRoom.Visible = false;
            this.panelStaff.Visible = false;
        }
        public void HideSubMenus()
        {
            if (panelFood.Visible == true)
                panelFood.Visible = false;
            if (panelRoom.Visible == true)
                panelRoom.Visible = false;
            if (panelStaff.Visible == true)
                panelStaff.Visible = false;

        }
        public void showSubMenu(Panel p)
        {
            if (p.Visible == false)
            {
                HideSubMenus();
                p.Visible = true;
            }
            else
            {
                p.Visible = false;
            }
        }

       

        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStaff);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideSubMenus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideSubMenus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Employees());
            HideSubMenus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new LuxRoom());
            HideSubMenus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new FormalRoom());
            HideSubMenus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new vegForm());
            HideSubMenus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new NonVegForm());
            HideSubMenus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRoom);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFood);
        }
        private Form ActiveForm = null;
        public void openChildForm(Form child)
        { 
            if(ActiveForm != null)
            {
                 ActiveForm.Close(); 
                
            }
            ActiveForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelChild.Controls.Add(child);
            panelChild.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //myForm m2 = new myForm();
            //m2.Show();
            openChildForm(new myForm());
            HideSubMenus();
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            openChildForm(new loginForm());
            HideSubMenus();
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            openChildForm(new Booking());
            HideSubMenus();
        }
    }
}
