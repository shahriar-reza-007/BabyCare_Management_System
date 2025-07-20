using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Babysitter_Profile : Form
    {
        public Babysitter_Profile()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");

        void BindData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Babysitter_info", con);
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
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Babysitter_info WHERE ID = @ID", con);
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

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cID_textBox.Text) || string.IsNullOrWhiteSpace(cName_textBox.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            int id;
            if (!int.TryParse(cID_textBox.Text, out id))
            {
                MessageBox.Show("Please enter a valid integer for the ID.");
                return;
            }

            if (CheckIfIDExists(id))
            {
                MessageBox.Show("This ID exists, please try a new one.");
                return;
            }

            int hourlyRate;
            if (!int.TryParse(textBox1.Text, out hourlyRate))
            {
                MessageBox.Show("Please enter an integer value for the Hourly Rate.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Babysitter_info (ID,Name,Hourly_rate,Experiemce, Certificate) VALUES (@ID,@Name, @Hourly_rate,@Experience,  @Certificate)", con);
                cmd.Parameters.AddWithValue("@ID", cID_textBox.Text);
                cmd.Parameters.AddWithValue("@Name", cName_textBox.Text);
                cmd.Parameters.AddWithValue("@Hourly_rate", textBox1.Text);
                cmd.Parameters.AddWithValue("@Experience", Age_text.Text);
                cmd.Parameters.AddWithValue("@Certificate", comboBox1.Text);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Insertion is successful");
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

        private void Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cID_textBox.Text) || string.IsNullOrWhiteSpace(cName_textBox.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            int id;
            if (!int.TryParse(cID_textBox.Text, out id))
            {
                MessageBox.Show("Please enter a valid integer for the ID.");
                return;
            }

            int hourlyRate;
            if (!int.TryParse(textBox1.Text, out hourlyRate))
            {
                MessageBox.Show("Please enter an integer value for the Hourly Rate.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Babysitter_info SET Name = @Name, Hourly_rate = @Hourly_rate,Experiemce=@Experience , Certificate = @Certificate WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", cID_textBox.Text);
                cmd.Parameters.AddWithValue("@Name", cName_textBox.Text);                
                cmd.Parameters.AddWithValue("@Hourly_rate", textBox1.Text);
                cmd.Parameters.AddWithValue("@Experience", Age_text.Text);
                cmd.Parameters.AddWithValue("@Certificate", comboBox1.Text);

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

        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cID_textBox.Text))
            {
                MessageBox.Show("Please enter an ID to delete.");
                return;
            }

            int id;
            if (!int.TryParse(cID_textBox.Text, out id))
            {
                MessageBox.Show("Please enter a valid integer for the ID.");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Babysitter_info WHERE ID = @ID", con);
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

        private void ClearFields()
        {
            cID_textBox.Clear();
            cName_textBox.Clear();
            textBox1.Clear();
            Age_text.Clear();
            comboBox1.SelectedIndex = -1;
            cID_textBox.Focus();
        }

        private void bName_button_Click(object sender, EventArgs e)
        {

        }

        private void cID_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bID_button_Click(object sender, EventArgs e)
        {
        }

        private void back_pictureBox_Click(object sender, EventArgs e)
        {
            Babysitter_DashBoard bd = new Babysitter_DashBoard();
            bd.Show();
            this.Hide();
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
