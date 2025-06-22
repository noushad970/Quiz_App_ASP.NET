using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BiogenInventorySystem
{
    public partial class LoginForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BiogenPharmaConnection"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Role FROM Users WHERE Username = @Username AND Password = @Password", conn);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MainForm mainForm = new MainForm(result.ToString(), txtUsername.Text);
                    
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}