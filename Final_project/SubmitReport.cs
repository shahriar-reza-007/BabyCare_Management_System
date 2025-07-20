using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Final_project
{
    public partial class SubmitReport : Form
    {
        public SubmitReport()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=SHAHRIAR-10\MSSQLSERVER01;Initial Catalog=Baby_Information;Integrated Security=True");

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string to = textBoxEmail.Text.Trim();
            string from = "managementbabysitter@gmail.com";
            string pass = "zhmn ijlu jved laff";
            string subject = "Report Feedback";
            string mail = "Dear " + textBoxName.Text.Trim() + "," +
                          "\nWe appreciate your feedback and are actively investigating the concerns raised." +
                          "\nThank you for bringing this to our attention," +
                          "\nBest Regards," +
                          "\nBabysitter Management Care LTD.";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(from);
            message.Subject = subject;
            message.Body = mail;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(from, pass)
            };

            // Validate email
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Would you like to report us Anonymously?");
                return;
            }

            if (string.IsNullOrWhiteSpace(to) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Missing Information!");
                return;
            }

            if (!IsValidEmail(to))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            message.To.Add(to);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Report (Name, Email, Complain) VALUES (@Name, @Email, @Report)", con);
                cmd.Parameters.AddWithValue("@Name", textBoxName.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Report", textBox1.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Insertion is successful");
                }

                smtp.Send(message);
                MessageBox.Show("Report Submitted Successfully. We will send you a feedback email soon.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
