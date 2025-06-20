using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class GiveAttendance : Form
    {
        private int employeeId;
        private string employeeCode;

        public GiveAttendance(int employeeId, string employeeCode)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.employeeCode = employeeCode;
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
                string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE EmployeeId = @EmployeeId AND AttendanceDate = @AttendanceDate";
                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@EmployeeId", employeeId);
                    cmdCheck.Parameters.AddWithValue("@AttendanceDate", currentDate);
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Attendance already marked for today!");
                        this.Close();
                        return;
                    }
                }

                string insertQuery = "INSERT INTO Attendance (EmployeeId, EmployeeCode, AttendanceDate, Status) VALUES (@EmployeeId, @EmployeeCode, @AttendanceDate, @Status)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                    cmd.Parameters.AddWithValue("@AttendanceDate", currentDate);
                    cmd.Parameters.AddWithValue("@Status", "Present");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance marked successfully!");
                    this.Close();
                }
            }
        }
    }
}