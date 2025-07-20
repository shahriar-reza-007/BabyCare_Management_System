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
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void back_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void req_button_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void manageuser_button_Click(object sender, EventArgs e)
        {

        }

        private void checkpay_button_Click_1(object sender, EventArgs e)
        {
            loadform(new Check_Report ());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();

        }

        private void manageBranch_button_Click(object sender, EventArgs e)
        {
           
            loadform(new Branches());
        }

        private void req_button_Click_1(object sender, EventArgs e)
        {
            

            loadform(new salary());
        }

        private void manageuser_button_Click_1(object sender, EventArgs e)
        {
            Admin_Control ac = new Admin_Control();
            ac.Show();
            this.Hide();
        }

        private void back_pictureBox_Click_1(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }
    }
}
