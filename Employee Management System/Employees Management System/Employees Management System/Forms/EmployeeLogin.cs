using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string secretCode = txtSecretCode.Text.Trim();
            if (string.IsNullOrEmpty(secretCode))
            {
                MessageBox.Show("Please enter your secret code!");
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT EmployeeId, EmployeeCode, Name, Email, Phone, DepartmentId, SecretCode, Salary FROM Employees WHERE SecretCode = @SecretCode";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SecretCode", secretCode);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int employeeId = reader.GetInt32(0);
                            string employeeCode = reader.GetString(1);
                            string name = reader.GetString(2);
                            string email = reader.GetString(3);
                            string phone = reader.GetString(4);
                            int departmentId = reader.GetInt32(5);
                            decimal salary = reader.GetDecimal(7);

                            EmployeeProfile profile = new EmployeeProfile(employeeId, employeeCode, name, email, phone, departmentId, secretCode, salary);
                            profile.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid secret code!");
                        }
                    }
                }
            }
        }

        private void txtSecretCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}