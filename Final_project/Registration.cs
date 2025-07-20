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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "" || Name_textBox.Text == "" || Email_textBox.Text == "" || Phone_textBox.Text == "" || Pass_textBox.Text == "")
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            try
            {
                int id = int.Parse(id_textBox.Text);

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Parent_Info (Id, Name, Email, Phone, Password) VALUES (@Id, @Name, @Email, @Phone, @Password)", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", Name_textBox.Text);
                    cmd.Parameters.AddWithValue("@Email", Email_textBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", Phone_textBox.Text);
                    cmd.Parameters.AddWithValue("@Password", Pass_textBox.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Your Registration is successful");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID cannot contain a string value. Please insert an integer.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            ParentDashBoard pd = new ParentDashBoard();
            pd.Show();
            this.Hide();
        }
    }
}
