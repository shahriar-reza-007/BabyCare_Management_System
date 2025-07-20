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
    public partial class Babysitter_info : Form
    {
        public Babysitter_info()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (cID_textBox.Text == "" || cName_textBox.Text == "" || textBox1.Text == "" || Age_text.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Missing Information!");
                    return;
                }

                if (!int.TryParse(textBox1.Text, out int hourlyRate))
                {
                    MessageBox.Show("Please insert an integer value for the hourly rate.");
                    return;
                }

                con.Open();

                string checkIdQuery = "SELECT COUNT(*) FROM Babysitter_info WHERE ID = @ID";
                SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, con);
                checkIdCmd.Parameters.AddWithValue("@ID", int.Parse(cID_textBox.Text));

                int idExists = (int)checkIdCmd.ExecuteScalar();

                if (idExists > 0)
                {
                    MessageBox.Show("This ID already exists, please insert a new value.");
                    con.Close();
                    return;
                }

                string query = "INSERT INTO Babysitter_info (ID, Name, Hourly_rate, Experiemce, Certificate) VALUES (@ID, @Name, @Rate, @Exp, @Certificate)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", int.Parse(cID_textBox.Text));
                cmd.Parameters.AddWithValue("@Name", cName_textBox.Text);
                cmd.Parameters.AddWithValue("@Rate", hourlyRate);
                cmd.Parameters.AddWithValue("@Exp", Age_text.Text);
                cmd.Parameters.AddWithValue("@Certificate", comboBox1.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Registration is successful");
                }

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

            cID_textBox.Clear();
            cName_textBox.Clear();
            textBox1.Clear();
            Age_text.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            Babysitter_DashBoard bd = new Babysitter_DashBoard();
            bd.Show();
            this.Hide();
        }
    }
}
