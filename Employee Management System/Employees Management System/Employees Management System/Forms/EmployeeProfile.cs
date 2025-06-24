﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
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
        private string currentAdminKey;

        public EmployeeProfile(int employeeId, string employeeCode, string name, string email, string phone, int departmentId, string secretCode, decimal salary, string currentAdminKey)
        {
            if (string.IsNullOrEmpty(employeeCode) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(currentAdminKey))
            {
                throw new ArgumentNullException("One or more required parameters are null or empty.");
            }
            InitializeComponent();
            this.employeeId = employeeId;
            this.employeeCode = employeeCode;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.departmentId = departmentId;
            this.secretCode = secretCode;
            this.salary = salary;
            this.currentAdminKey = currentAdminKey;
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            try
            {
                lblEmployeeCode.Text = "Employee Position: " + employeeCode;
                lblName.Text = "Name: " + name;
                lblEmail.Text = "Email: " + email;
                lblPhone.Text = "Phone: " + phone;

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    if (conn == null) throw new Exception("Database connection is null.");
                    conn.Open();
                    string query = "SELECT DepartmentName FROM Departments WHERE DepartmentId = @DepartmentId AND adminKey = @adminKey";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                        cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        string departmentName = cmd.ExecuteScalar()?.ToString() ?? "Unknown";
                        lblDepartment.Text = "Department: " + departmentName;
                    }

                    string imageQuery = "SELECT EmployeeImage FROM Employees WHERE EmployeeId = @EmployeeId AND adminKey = @adminKey";
                    using (SqlCommand imgCmd = new SqlCommand(imageQuery, conn))
                    {
                        imgCmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                        imgCmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        using (SqlDataReader imgReader = imgCmd.ExecuteReader())
                        {
                            if (imgReader.Read() && !imgReader.IsDBNull(0))
                            {
                                byte[] imageData = (byte[])imgReader["EmployeeImage"];
                                using (var ms = new MemoryStream(imageData))
                                {
                                    pictureBoxProfile.Image = System.Drawing.Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                pictureBoxProfile.Image = null;
                            }
                        }
                    }
                }
                lblSalary.Text = "Salary: " + salary.ToString("C");
                LoadLeaveRequests();
                UpdateAttendanceSummary();
                LoadNotices();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadLeaveRequests()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT RequestId, RequestType, Reason, RequestDate, Status FROM EmployeeRequests WHERE EmployeeCode = @EmployeeCode AND adminKey = @adminKey";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                    da.SelectCommand.Parameters.AddWithValue("@adminKey", currentAdminKey);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLeaveRequests.DataSource = dt;
                    dgvLeaveRequests.Columns["RequestId"].Visible = false;
                    dgvLeaveRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void btnThisMonthSchedule_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            StringBuilder schedule = new StringBuilder($"Schedule for {firstDayOfMonth:MMMM yyyy}:\n");
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT WorkDate, IsWorkingDay FROM WorkingDates WHERE WorkDate BETWEEN @StartDate AND @EndDate AND adminKey = @adminKey";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", firstDayOfMonth);
                    cmd.Parameters.AddWithValue("@EndDate", lastDayOfMonth);
                    cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime date = reader.GetDateTime(0);
                            bool? isWorkingDay = reader.IsDBNull(1) ? (bool?)null : reader.GetBoolean(1);
                            schedule.AppendLine($"{date:yyyy-MM-dd}: {(isWorkingDay == true ? "Work" : isWorkingDay == false ? "Off" : "Unassigned")}");
                        }
                    }
                }
            }
            MessageBox.Show(schedule.ToString());
        }

        private void UpdateAttendanceSummary()
        {
            DateTime now = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string dutyQuery = "SELECT COUNT(*) FROM WorkingDates WHERE WorkDate BETWEEN @StartDate AND @EndDate AND IsWorkingDay = 1 AND adminKey = @adminKey";
                using (SqlCommand cmdDuty = new SqlCommand(dutyQuery, conn))
                {
                    cmdDuty.Parameters.AddWithValue("@StartDate", firstDayOfMonth);
                    cmdDuty.Parameters.AddWithValue("@EndDate", lastDayOfMonth);
                    cmdDuty.Parameters.AddWithValue("@adminKey", currentAdminKey);
                    int totalDutyDays = (int)cmdDuty.ExecuteScalar();
                    lblTotalDutyDays.Text = $"Total Duty Days: {totalDutyDays}";

                    string attendanceQuery = "SELECT COUNT(*) FROM Attendance WHERE EmployeeCode = @EmployeeCode AND AttendanceDate BETWEEN @StartDate AND @EndDate AND IsWorkingDay = 1 AND adminKey = @adminKey";
                    using (SqlCommand cmdAttendance = new SqlCommand(attendanceQuery, conn))
                    {
                        cmdAttendance.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                        cmdAttendance.Parameters.AddWithValue("@StartDate", firstDayOfMonth);
                        cmdAttendance.Parameters.AddWithValue("@EndDate", lastDayOfMonth);
                        cmdAttendance.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        int attendanceDays = (int)cmdAttendance.ExecuteScalar();

                        int unexcusedAbsences = Math.Max(0, totalDutyDays - attendanceDays);
                        lblUnexcusedAbsences.Text = $"Unexcused Absences: {unexcusedAbsences}";

                        decimal fine = unexcusedAbsences * 200;
                        lblFine.Text = $"Fine: {fine} Taka";
                    }
                }
            }
        }

        private void btnLeaveRequest_Click(object sender, EventArgs e)
        {
            LeaveRequest leaveRequest = new LeaveRequest(employeeId, employeeCode, currentAdminKey);
            leaveRequest.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            GiveAttendance giveAttendance = new GiveAttendance(employeeId, employeeCode, currentAdminKey);
            giveAttendance.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadLeaveRequests();
                UpdateAttendanceSummary();
                LoadNotices();
                MessageBox.Show("Data refreshed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing data: " + ex.Message);
            }
        }

        private void LoadNotices()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT NoticeId, NoticeText, PublishDate FROM Notices WHERE DepartmentId = @DepartmentId";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@DepartmentId", departmentId);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNotices.DataSource = dt;
                    dgvNotices.Columns["NoticeId"].Visible = false;
                    dgvNotices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (dgvNotices.Columns.Contains("NoticeText"))
                        dgvNotices.Columns["NoticeText"].HeaderText = "Notice";
                    if (dgvNotices.Columns.Contains("PublishDate"))
                        dgvNotices.Columns["PublishDate"].HeaderText = "Published On";
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginSelection loginForm = new LoginSelection();
            loginForm.ShowDialog();
        }
    }
}