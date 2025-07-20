using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            CustomizeDesign();

        }
        private void CustomizeDesign()
        {
            panelDropDown.Visible = false;
            panelOurServices.Visible = false;
        }
        private void hideSubMenu()
        {
            if(panelDropDown.Visible==true)
            {
                panelDropDown.Visible = false;
            }
            if(panelOurServices.Visible==true)
            {
                panelOurServices.Visible = false;
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible==false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
       

        private void panelDropDown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDropDown);
        }

        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            openChildForm(new AboutUs());
            hideSubMenu();
        }

        private void buttonBabyShop_Click(object sender, EventArgs e)
        {
            openChildForm(new Baby_Shop());
            hideSubMenu();

            /*Baby_Shop bs = new Baby_Shop();
            bs.Show();
            this.Hide();*/

        }

        private void buttonPetShop_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonPetCare_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOurServices_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOurServices);
        }

        private void buttonHomeNursingService_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonCriticalCare_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonNeuroPatientCare_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonAutismBabyCare_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonContactUs_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            { activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormPanel.Controls.Add(childForm);
            panelChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void P_DashBoard_button_Click(object sender, EventArgs e)
        {
            
            ParentDashBoard pd = new ParentDashBoard();
            pd.Show();
            this.Hide();
        }

        private void buttonBabyShop_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Baby_Shop());
            hideSubMenu();
        }
    }
}
