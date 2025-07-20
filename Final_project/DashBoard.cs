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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashBoard ad = new AdminDashBoard();
            ad.Show();
            this.Hide();
        }

        private void parent_button_Click(object sender, EventArgs e)
        {
            ParentDashBoard pd = new ParentDashBoard();
            pd.Show();
            this.Hide();
        }

        private void babysitter_button_Click(object sender, EventArgs e)
        {
            Babysitter_DashBoard bd = new Babysitter_DashBoard();
            bd.Show();
            this.Hide();
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
