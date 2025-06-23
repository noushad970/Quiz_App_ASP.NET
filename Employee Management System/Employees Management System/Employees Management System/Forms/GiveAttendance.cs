using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class GiveAttendance : Form
    {
        private int employeeId;
        private string employeeCode;
        private string currentAdminKey; // Added to store the adminKey

        public GiveAttendance(int employeeId, string employeeCode, string currentAdminKey)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.employeeCode = employeeCode;
            this.currentAdminKey = currentAdminKey; // Store the adminKey
        }

        private void GiveAttendance_Load(object sender, EventArgs e)
        {
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE EmployeeId = @EmployeeId AND AttendanceDate = @AttendanceDate AND adminKey = @adminKey";
                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@EmployeeId", employeeId);
                    cmdCheck.Parameters.AddWithValue("@AttendanceDate", currentDate);
                    cmdCheck.Parameters.AddWithValue("@adminKey", currentAdminKey); // Add adminKey condition
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Attendance already marked for today!");
                        this.Close();
                        return;
                    }
                }

                string insertQuery = "INSERT INTO Attendance (EmployeeId, EmployeeCode, AttendanceDate, Status, adminKey) VALUES (@EmployeeId, @EmployeeCode, @AttendanceDate, @Status, @adminKey)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                    cmd.Parameters.AddWithValue("@AttendanceDate", currentDate);
                    cmd.Parameters.AddWithValue("@Status", "Present");
                    cmd.Parameters.AddWithValue("@adminKey", currentAdminKey); // Add adminKey to the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance marked successfully!");
                    this.Close();
                }
            }
        }
    }
}