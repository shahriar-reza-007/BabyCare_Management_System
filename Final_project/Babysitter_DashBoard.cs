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
    public partial class Babysitter_DashBoard : Form
    {
        public Babysitter_DashBoard()
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
        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Babysitter_info());
        }

        private void manage_button_Click(object sender, EventArgs e)
        {
            loadform(new Babysitter_Profile());
        }

        private void certificate_button_Click(object sender, EventArgs e)
        {
            loadform(new Certificate());
        }

        private void Cinfo_button_Click(object sender, EventArgs e)
        {
            loadform(new ChildInfo());
        }

        private void Babysitter_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }
    }
}
