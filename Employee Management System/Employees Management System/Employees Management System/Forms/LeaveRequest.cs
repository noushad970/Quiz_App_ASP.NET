using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class LeaveRequest : Form
    {
        private int employeeId;
        private string employeeCode;

        public LeaveRequest(int employeeId, string employeeCode)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.employeeCode = employeeCode;
        }

        private void LeaveRequest_Load(object sender, EventArgs e)
        {
            cmbRequestType.SelectedIndex = 0; // Default to "Leave"
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string reason = txtReason.Text.Trim();
            DateTime startDate = dateTimePicker1.Value;
            string requestType = cmbRequestType.SelectedItem.ToString();

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please enter a reason for your request!");
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO EmployeeRequests (EmployeeId, EmployeeCode, RequestType, Reason, RequestDate, Status) VALUES (@EmployeeId, @EmployeeCode, @RequestType, @Reason, @RequestDate, @Status)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                    cmd.Parameters.AddWithValue("@RequestType", requestType);
                    cmd.Parameters.AddWithValue("@Reason", reason);
                    cmd.Parameters.AddWithValue("@RequestDate", startDate);
                    cmd.Parameters.AddWithValue("@Status", "Pending");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{requestType} request submitted successfully!");
                    this.Close();
                }
            }
        }
    }
}