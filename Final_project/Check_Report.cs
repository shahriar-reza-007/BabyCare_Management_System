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
    public partial class Check_Report : Form
    {
        public Check_Report()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select Name,Email,Complain from Report ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void View_button_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
