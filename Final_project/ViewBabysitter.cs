using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class ViewBabysitter : Form
    {
        public ViewBabysitter()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select Name,Hourly_rate,Experiemce from Babysitter_info ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
 
        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void View_button_Click(object sender, EventArgs e)
        {
            BindData();
            Search_textBox.Clear();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {

        }

        private void Search_textBox_TextChanged_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Babysitter_info where Name Like '%" + Search_textBox.Text + "%'", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
