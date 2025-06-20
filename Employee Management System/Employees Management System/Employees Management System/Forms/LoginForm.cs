using System;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class LoginForm : Form
    {
        private double opacityIncrement = 0.05;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += opacityIncrement;
            }
            else
            {
                fadeTimer.Stop();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "Noushad97" && password == "1234") // Replace with DB check later
            {
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Navigate to Main Form
                AdminDashboard dashboard = new AdminDashboard("Noushad");
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
