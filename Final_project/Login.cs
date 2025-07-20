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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Login_Table;Integrated Security=True");

        private void login_button_Click(object sender, EventArgs e)
        {
            if (usertype_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a user type.");
                return;
            }

            string query = "Select * from Login_Table where Email = @Email and Password = @Password";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@Email", user_textBox.Text);
            sda.SelectCommand.Parameters.AddWithValue("@Password", pass_textBox.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                string cmbItemValue = usertype_comboBox.SelectedItem.ToString();
                bool userTypeMatch = false;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["User_type"].ToString() == cmbItemValue)
                    {
                        userTypeMatch = true;
                        MessageBox.Show("You are logged in as " + dt.Rows[i]["User_type"]);

                        if (usertype_comboBox.SelectedIndex == 0)
                        {
                            AdminDashBoard ad = new AdminDashBoard();
                            ad.Show();
                            this.Hide();
                        }
                        else if (usertype_comboBox.SelectedIndex == 1)
                        {
                            Babysitter_DashBoard bd = new Babysitter_DashBoard();
                            bd.Show();
                            this.Hide();
                        }
                        else if (usertype_comboBox.SelectedIndex == 2)
                        {
                            Home h = new Home();
                            h.Show();
                            this.Hide();
                        }
                        else if (usertype_comboBox.SelectedIndex == 3)
                        {
                            
                        }

                        break;
                    }
                }

                if (!userTypeMatch)
                {
                    MessageBox.Show("Error: User type does not match!");
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid email or password!");
            }
        }

        private void pass_textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void showPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            pass_textBox.UseSystemPasswordChar = showPassword_checkBox.Checked;
        }

        private void usertype_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ParentSignUp ps = new ParentSignUp();
            ps.Show();
            this.Hide();
        }
    }
}
