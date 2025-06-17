using System;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
            this.Opacity = 0; // Start with 0 opacity for fade-in effect
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            fadeTimer.Start(); // Start the fade-in animation
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
            else
            {
                fadeTimer.Stop(); // Stop timer when fully visible
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password!");
                return;
            }

            if (DatabaseHelper.ValidateAdminLogin(username, password))
            {
                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}