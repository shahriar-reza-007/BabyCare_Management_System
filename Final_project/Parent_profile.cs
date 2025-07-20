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
    public partial class Parent_profile : Form
    {
        public Parent_profile()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");

        void BindData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID, Name, Phone, Email FROM Parent_Info", con);
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

        private bool CheckIfIDExists(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Parent_Info WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
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
            if (string.IsNullOrWhiteSpace(ID_textBox.Text) || string.IsNullOrWhiteSpace(Name_textBox.Text) ||
                string.IsNullOrWhiteSpace(mail_textBox.Text) || string.IsNullOrWhiteSpace(phone_textBox.Text))
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            try
            {
                int id = int.Parse(ID_textBox.Text);
                if (!CheckIfIDExists(id))
                {
                    MessageBox.Show("ID does not exist, please enter a valid ID.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Parent_Info SET Name = @Name, Email = @Email, Phone = @Phone WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", Name_textBox.Text);
                cmd.Parameters.AddWithValue("@Email", mail_textBox.Text);
                cmd.Parameters.AddWithValue("@Phone", phone_textBox.Text);

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

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID_textBox.Text))
            {
                MessageBox.Show("Please enter an ID to delete.");
                return;
            }

            try
            {
                int id = int.Parse(ID_textBox.Text);

                if (!CheckIfIDExists(id))
                {
                    MessageBox.Show("ID does not exist, please enter a valid ID.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Parent_Info WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", id);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Deletion is successful");
                }
                else
                {
                    MessageBox.Show("ID not found.");
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

        private void ClearFields()
        {
            ID_textBox.Clear();
            Name_textBox.Clear();
            mail_textBox.Clear();
            phone_textBox.Clear();
            ID_textBox.Focus();
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            ParentDashBoard pd = new ParentDashBoard();
            pd.Show();
            this.Hide();
        }
    }
}
