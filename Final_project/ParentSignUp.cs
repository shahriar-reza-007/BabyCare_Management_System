using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Final_project
{
    public partial class ParentSignUp : Form
    {
        public ParentSignUp()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Login_Table;Integrated Security=True");

        private void signUp_button_Click(object sender, EventArgs e)
        {
            if (user_textBox.Text == "" || pass_textBox.Text == "")
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            string to = user_textBox.Text;
            string from = "managementbabysitter@gmail.com";
            string pass = "zhmn ijlu jved laff";
            string subject = "Registration Successful";
            string mail = $"Dear {name_textBox.Text},\n\nWe are pleased to inform you that your registration has been successfully completed.\n\nThank you for choosing Our Babysitter Management Care LTD. We look forward to providing you with exceptional service.\n\nShould you have any questions or require further assistance, please do not hesitate to contact us.\n\nBest regards,\n\n'Khudro-A Babysitter Management Care LTD'";

            try
            {
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Subject = subject;
                message.Body = mail;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(from, pass)
                };

                smtp.Send(message);

                MessageBox.Show("Registration email sent successfully!");

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Login_Table (Email, Password, User_type) VALUES (@UserEmail, @UserPassword, @UserType)", con);
                cmd.Parameters.AddWithValue("@UserEmail", user_textBox.Text);
                cmd.Parameters.AddWithValue("@UserPassword", pass_textBox.Text);
                cmd.Parameters.AddWithValue("@UserType", usertype_comboBox.Text);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Registration successful. Now login with this Email & password.");
                }

                con.Close();
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"Error sending email: {smtpEx.Message}");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void usertype_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void usertype_label_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }

        private void showpassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            pass_textBox.UseSystemPasswordChar = showpassword_checkBox.Checked;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            ln.Show();
            this.Hide();
        }
    }
}
