﻿using System;
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
    public partial class Admin_Control : Form
    {
        public Admin_Control()
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
        private void parentbutton_Click(object sender, EventArgs e)
        {
            loadform(new Parent_profile());
        }

        private void manage_button_Click(object sender, EventArgs e)
        {
            loadform(new Babysitter_Profile());
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            AdminDashBoard ad = new AdminDashBoard();
            ad.Show();
            this.Hide();
        }
    }
}
