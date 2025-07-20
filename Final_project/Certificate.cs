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
    public partial class Certificate : Form
    {
        public Certificate()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");
        private void submit_Click(object sender, EventArgs e)
        {
            if(certificate_comboBox.Text=="")
            {
                MessageBox.Show("Please Fill the ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("update Babysitter_info set Certificate ='" + certificate_comboBox.Text + "'  Where ID ='" + int.Parse(ID_textBox.Text) + "' ", con);
            if (con.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Update is successfull");
            }
            con.Close();
        }
    }
}
