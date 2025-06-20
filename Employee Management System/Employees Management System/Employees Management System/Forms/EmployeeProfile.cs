using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class EmployeeProfile : Form
    {
        private int employeeId;
        private string employeeCode;
        private string name;
        private string email;
        private string phone;
        private int departmentId;
        private string secretCode;
        private decimal salary;

        public EmployeeProfile(int employeeId, string employeeCode, string name, string email, string phone, int departmentId, string secretCode, decimal salary)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.employeeCode = employeeCode;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.departmentId = departmentId;
            this.secretCode = secretCode;
            this.salary = salary;
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            lblEmployeeCode.Text = "Employee Code: " + employeeCode;
            lblName.Text = "Name: " + name;
            lblEmail.Text = "Email: " + email;
            lblPhone.Text = "Phone: " + phone;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT DepartmentName FROM Departments WHERE DepartmentId = @DepartmentId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                    string departmentName = cmd.ExecuteScalar()?.ToString() ?? "Unknown";
                    lblDepartment.Text = "Department: " + departmentName;
                }
            }
            lblSalary.Text = "Salary: " + salary.ToString("C");
        }

        private void btnLeaveRequest_Click(object sender, EventArgs e)
        {
            LeaveRequest leaveRequest = new LeaveRequest(employeeId, employeeCode);
            leaveRequest.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            GiveAttendance giveAttendance = new GiveAttendance(employeeId, employeeCode);
            giveAttendance.ShowDialog();
        }
    }
}