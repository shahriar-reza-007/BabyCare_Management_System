using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_project
{
    public partial class Baby_Information : Form
    {
        public Baby_Information()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");

        private void Insert_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cID_textBox.Text) || string.IsNullOrWhiteSpace(cName_textBox.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO baby_information (Child_Id, Name, Age, DoB, Update_DoB, Gender) VALUES (@Child_Id, @Name, @Age, GETDATE(), GETDATE(), @Gender)", con);
                cmd.Parameters.AddWithValue("@Child_Id", int.Parse(cID_textBox.Text));
                cmd.Parameters.AddWithValue("@Name", cName_textBox.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Insertion is successful");
                }
                con.Close();
                BindData();
                fillcombo();
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

            ClearFields();
        }

        private void fillcombo()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Babysitter_info", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                babysitterCB.ValueMember = "Name";
                babysitterCB.DataSource = dt;

                con.Close();
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
        }

        void BindData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Child_Id, Name, Age, Gender FROM baby_information", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
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
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cID_textBox.Text) || string.IsNullOrWhiteSpace(cName_textBox.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE baby_information SET Name = @Name, Age = @Age, Update_DoB = GETDATE(), Gender = @Gender WHERE Child_Id = @Child_Id", con);
                cmd.Parameters.AddWithValue("@Child_Id", int.Parse(cID_textBox.Text));
                cmd.Parameters.AddWithValue("@Name", cName_textBox.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Update is successful");
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

            ClearFields();
        }

        private void View_button_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM baby_information WHERE Name LIKE @SearchText", con);
                cmd.Parameters.AddWithValue("@SearchText", "%" + Search_textBox.Text + "%");
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
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
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cID_textBox.Text))
            {
                MessageBox.Show("Please enter the Child ID to delete.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM baby_information WHERE Child_Id = @Child_Id", con);
                cmd.Parameters.AddWithValue("@Child_Id", int.Parse(cID_textBox.Text));

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Delete successful");
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

            ClearFields();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
           
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            ParentDashBoard pd = new ParentDashBoard();
            pd.Show();
            this.Hide();
        }

        private void Baby_Information_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void ClearFields()
        {
            cID_textBox.Clear();
            cName_textBox.Clear();
            textBox1.Clear();
            comboBox1.SelectedIndex = -1; // Clear selection
            cID_textBox.Focus();
        }

        private void babysitterCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
