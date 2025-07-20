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
    public partial class DaycareCenter : Form
    {
        public DaycareCenter()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select Branch_Id,Area,Assign_Worker from Boshundhara ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void BindData1()
        {
            SqlCommand cmd = new SqlCommand("select Branch_Id,Area,Assign_Worker from Bonani ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        void BindData2()
        {
            SqlCommand cmd = new SqlCommand("select Branch_Id,Area,Assign_Worker from Gulshan ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            sd.Fill(dt2);
            dataGridView1.DataSource = dt2;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                BindData();
            }
        }

        private void Banani_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(Banani_radioButton.Checked==true)
            {
                BindData1();
            }
        }

        private void Gulshan_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(Gulshan_radioButton.Checked==true)
            {
                BindData2();
            }
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
