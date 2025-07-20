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
    public partial class ParentDashBoard : Form
    {
        public ParentDashBoard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.main_panel.Controls.Count > 0)
                this.main_panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();
        }
        private void parent_dashboard_logout_button_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }

        private void add_child_button_Click(object sender, EventArgs e)
        {           
            loadform(new Baby_Information());
        }

        private void baby_sitter_search_button_Click(object sender, EventArgs e)
        {           
            loadform(new ViewBabysitter());
        }

        private void parent_profile_button_Click(object sender, EventArgs e)
        {          
            loadform(new Parent_profile());

        }

        private void booking_history_button_Click(object sender, EventArgs e)
        {           
            loadform(new DaycareCenter());
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            loadform(new SubmitReport());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Registration());
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
    }
}
