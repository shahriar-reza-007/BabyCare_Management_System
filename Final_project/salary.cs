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
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");

        int row;

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID, Name,Working_Hour, Hourly_rate, Total_Salary FROM Salary", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            DGV.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, name, gender;
            double working_hour, hourly_rate, total_salary;
            id = idtextBox.Text;
            name = name_textbox.Text;
            if (maleradiobutton.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            working_hour = double.Parse(WHtextBox.Text);
            if (!double.TryParse(HRtextBox.Text, out hourly_rate))
            {
                MessageBox.Show("Please insert a valid integer value for the Hourly rate.");
                return;
            }
            total_salary = working_hour * hourly_rate;
            Totalsal.Text = total_salary.ToString();

            try
            {
                con.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Salary WHERE ID = @ID", con);
                checkCmd.Parameters.AddWithValue("@ID", int.Parse(id));
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This ID already exists, please try a new one.");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Salary (ID, Name,Working_Hour, Hourly_rate, Total_Salary) VALUES (@ID, @Name, @Working_Hour, @Hourly_rate, @Total_Salary)", con);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(id));
                    cmd.Parameters.AddWithValue("@Name", name);               
                    cmd.Parameters.AddWithValue("@Working_Hour", working_hour);
                    cmd.Parameters.AddWithValue("@Hourly_rate", hourly_rate);
                    cmd.Parameters.AddWithValue("@Total_Salary", total_salary);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
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
        }

        private void View_button_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void HRtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(HRtextBox.Text, out _))
            {
                MessageBox.Show("Please insert an integer value for the Hourly rate.");
            }
        }

        private void WHtextBox_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(WHtextBox.Text, out _))
            {
                MessageBox.Show("Working Hour should be in Number ");
            }
        }

        private void salary_Load(object sender, EventArgs e)
        {

        }

        private void ID_label_Click(object sender, EventArgs e)
        {

        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }

        private void Glabel_Click(object sender, EventArgs e)
        {

        }

        private void WRlabel_Click(object sender, EventArgs e)
        {

        }

        private void hrlabel_Click(object sender, EventArgs e)
        {

        }

        private void sallabel_Click(object sender, EventArgs e)
        {

        }
    }
}
