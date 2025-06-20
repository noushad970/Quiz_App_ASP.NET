using System;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class LoginSelection : Form
    {
        public LoginSelection()
        {
            InitializeComponent();
        }

        private void LoginSelection_Load(object sender, EventArgs e)
        {
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLogin = new AdminLoginForm();
            adminLogin.Show();
            this.Hide();
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            EmployeeLogin employeeLogin = new EmployeeLogin();
            employeeLogin.Show();
            this.Hide();
        }
    }
}