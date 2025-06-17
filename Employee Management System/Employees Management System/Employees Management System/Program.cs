using Employees_Management_System.Forms;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // <-- This should be your login form
        }
    }
}
