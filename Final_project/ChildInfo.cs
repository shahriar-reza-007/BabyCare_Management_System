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
    public partial class ChildInfo : Form
    {
        public ChildInfo()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");
        private void View_button_Click(object sender, EventArgs e)
        {
            
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select Child_ID,Name,Age,DoB,Update_DoB,Gender from baby_information ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void View_button_Click_1(object sender, EventArgs e)
        {
            BindData();
            Search_textBox.Clear();
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from baby_information where Name Like '%" + Search_textBox.Text + "%'", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;            
        }
        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            ParentDashBoard d = new  ParentDashBoard();
            d.Show();
            this.Hide();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {

        }
    }

}
