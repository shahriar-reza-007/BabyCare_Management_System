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
    public partial class Branches : Form
    {
        public Branches()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");
        private void Insert_button_Click(object sender, EventArgs e)
        {
        }
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select ID,Area,Manager_Fname,Manager_Lname,Assign_Worker from Branch ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Insert_button_Click_1(object sender, EventArgs e)
        {

            if (ID_textBox.Text == "" || Area_textBox.Text == "" || Fname_textBox.Text == "" || Lname_textbox.Text == "" || Worker_textBox.Text == "")
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Branch values('" + int.Parse(ID_textBox.Text) + "','" + Area_textBox.Text + "','" + Fname_textBox.Text + "','" + Lname_textbox.Text + "','" + Worker_textBox.Text + "')", con);
                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Insertion is successfull");
                }
                con.Close();
                BindData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            ID_textBox.Clear();
            Area_textBox.Clear();
            Fname_textBox.Clear();
            Lname_textbox.Clear();
            Worker_textBox.Clear();
            ID_textBox.Focus();
        }

        private void Update_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Branch set Area ='" + Area_textBox.Text + "',Manager_Fname ='" + Fname_textBox.Text + "',Manager_Lname = '" + Lname_textbox.Text + "',Assign_Worker = '" + Worker_textBox.Text + "' Where ID ='" + int.Parse(ID_textBox.Text) + "' ", con);
                if (con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Update is successfull");
                }
                con.Close();
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            ID_textBox.Clear();
            Area_textBox.Clear();
            Fname_textBox.Clear();
            Lname_textbox.Clear();
            Worker_textBox.Clear();
            ID_textBox.Focus();

        }

        private void Delete_button_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete Branch  Where ID ='" + int.Parse(ID_textBox.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfull");
                con.Close();
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            ID_textBox.Clear();
            Area_textBox.Clear();
            Fname_textBox.Clear();
            Lname_textbox.Clear();
            Worker_textBox.Clear();
            ID_textBox.Focus();
        }

        private void Search_button_Click_1(object sender, EventArgs e)
        {

        }

        private void View_button_Click_1(object sender, EventArgs e)
        {
            BindData();
        }

        private void Search_textBox_TextChanged_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from baby_information where Name Like '%" + Search_textBox.Text + "%'", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

