﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class AdminDashboard : Form
    {
        private int selectedEmployeeId = -1;
        private int selectedDepartmentId = -1;
        private string currentUsername;
        private string currentAdminKey; // Added to store the adminKey

        public AdminDashboard(string username)
        {
            InitializeComponent();
            currentUsername = username;
            lblWelcome.Text = $"Welcome, {currentUsername}!";
            LoadAdminKey(); // Load the adminKey based on username
            InitializeWorkingDatesPanel();
        }

        private void LoadAdminKey()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT adminKey FROM Admins WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", currentUsername);
                    object result = cmd.ExecuteScalar();
                    currentAdminKey = result?.ToString();
                    if (string.IsNullOrEmpty(currentAdminKey))
                    {
                        MessageBox.Show("Admin key not found. Please log in again.");
                        this.Close();
                    }
                }
            }
        }

        private void InitializeWorkingDatesPanel()
        {
            monthCalendar = new MonthCalendar();
            monthCalendar.Location = new Point(10, 10);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.Size = new Size(300, 250);
            monthCalendar.TabIndex = 14;
            monthCalendar.DateChanged += new DateRangeEventHandler(monthCalendar_DateChanged);
            panelWorkingDates.Controls.Add(monthCalendar);

            btnAddAsWorkingDay = new Button();
            btnAddAsWorkingDay.Location = new Point(10, 200);
            btnAddAsWorkingDay.Name = "btnAddAsWorkingDay";
            btnAddAsWorkingDay.Size = new Size(120, 30);
            btnAddAsWorkingDay.TabIndex = 15;
            btnAddAsWorkingDay.Text = "Add as Working Day";
            btnAddAsWorkingDay.UseVisualStyleBackColor = true;
            btnAddAsWorkingDay.Click += new EventHandler(btnAddAsWorkingDay_Click);
            panelWorkingDates.Controls.Add(btnAddAsWorkingDay);

            btnAddAsOffDay = new Button();
            btnAddAsOffDay.Location = new Point(140, 200);
            btnAddAsOffDay.Name = "btnAddAsOffDay";
            btnAddAsOffDay.Size = new Size(120, 30);
            btnAddAsOffDay.TabIndex = 16;
            btnAddAsOffDay.Text = "Add as Off Day";
            btnAddAsOffDay.UseVisualStyleBackColor = true;
            btnAddAsOffDay.Click += new EventHandler(btnAddAsOffDay_Click);
            panelWorkingDates.Controls.Add(btnAddAsOffDay);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadEmployeeDetails();
            LoadDepartmentManagement();
            LoadRequestManagement();
            LoadDepartments();
            LoadEmployeeCodes();
            panelEmployeeDetails.Visible = true;
            ApplyDataGridViewStyling();
        }

        private void LoadEmployeeDetails()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT EmployeeId, EmployeeCode, Name, Email, Phone, DepartmentId, SecretCode, Salary FROM Employees WHERE adminKey = @adminKey";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvEmployeeDetails.DataSource = null;
                        dgvEmployeeDetails.Columns.Clear();
                        dgvEmployeeDetails.Columns.Add("EmployeeId", "Employee ID");
                        dgvEmployeeDetails.Columns["EmployeeId"].Visible = false;
                        dgvEmployeeDetails.Columns.Add("EmployeeCode", "Employee Code");
                        dgvEmployeeDetails.Columns.Add("Name", "Name");
                        dgvEmployeeDetails.Columns.Add("Email", "Email");
                        dgvEmployeeDetails.Columns.Add("Phone", "Phone");
                        dgvEmployeeDetails.Columns.Add("DepartmentId", "Department ID");
                        dgvEmployeeDetails.Columns["DepartmentId"].Visible = false;
                        dgvEmployeeDetails.Columns.Add("SecretCode", "Secret Code");
                        dgvEmployeeDetails.Columns.Add("Salary", "Salary");
                        dgvEmployeeDetails.Columns.Add(new DataGridViewButtonColumn { HeaderText = "Update", Name = "UpdateButton", Text = "Update", UseColumnTextForButtonValue = true });
                        dgvEmployeeDetails.Columns.Add(new DataGridViewButtonColumn { HeaderText = "Delete", Name = "DeleteButton", Text = "Delete", UseColumnTextForButtonValue = true });

                        foreach (DataRow row in dt.Rows)
                        {
                            dgvEmployeeDetails.Rows.Add(
                                row["EmployeeId"],
                                row["EmployeeCode"],
                                row["Name"],
                                row["Email"],
                                row["Phone"],
                                row["DepartmentId"],
                                row["SecretCode"],
                                row["Salary"],
                                "Update",
                                "Delete"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee details: {ex.Message}");
            }
            ApplyDataGridViewStyling();
        }

        private void LoadDepartmentManagement()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT DepartmentId, DepartmentName FROM Departments WHERE adminKey = @adminKey";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDepartmentManagement.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}");
            }
        }

        private void LoadRequestManagement()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT RequestId, EmployeeCode, RequestType, Reason, RequestDate, Status FROM EmployeeRequests WHERE Status = 'Pending' AND adminKey = @adminKey";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRequestManagement.DataSource = dt;
                        if (!dgvRequestManagement.Columns.Contains("Accept"))
                        {
                            DataGridViewButtonColumn acceptBtn = new DataGridViewButtonColumn();
                            acceptBtn.Name = "Accept";
                            acceptBtn.HeaderText = "Accept";
                            acceptBtn.Text = "Accept";
                            acceptBtn.UseColumnTextForButtonValue = true;
                            dgvRequestManagement.Columns.Add(acceptBtn);
                        }
                        if (!dgvRequestManagement.Columns.Contains("Decline"))
                        {
                            DataGridViewButtonColumn declineBtn = new DataGridViewButtonColumn();
                            declineBtn.Name = "Decline";
                            declineBtn.HeaderText = "Decline";
                            declineBtn.Text = "Decline";
                            declineBtn.UseColumnTextForButtonValue = true;
                            dgvRequestManagement.Columns.Add(declineBtn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading requests: {ex.Message}");
            }
        }

        private void LoadDepartments()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT DepartmentId, DepartmentName FROM Departments WHERE adminKey = @adminKey";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmbDepartment.DataSource = dt;
                        cmbDepartment.DisplayMember = "DepartmentName";
                        cmbDepartment.ValueMember = "DepartmentId";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}");
            }
        }

        private void LoadEmployeeCodes()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT EmployeeCode FROM Employees WHERE adminKey = @adminKey";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmbEmployeeCode.DataSource = dt;
                        cmbEmployeeCode.DisplayMember = "EmployeeCode";
                        cmbEmployeeCode.ValueMember = "EmployeeCode";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee codes: {ex.Message}");
            }
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = true;
            panelDepartmentManagement.Visible = false;
            panelRequestManagement.Visible = false;
            panelEmployeeSection.Visible = false;
            panelEmployeeReport.Visible = false;
            panelAttendanceSummary.Visible = false;
            panelWorkingDates.Visible = false;
            LoadEmployeeDetails();
        }

        private void btnEmployeeSection_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = false;
            panelDepartmentManagement.Visible = false;
            panelRequestManagement.Visible = false;
            panelEmployeeSection.Visible = true;
            panelEmployeeReport.Visible = false;
            panelAttendanceSummary.Visible = false;
            panelWorkingDates.Visible = false;
            ClearEmployeeFields();
            selectedEmployeeId = -1;
        }

        private void btnDepartmentManagement_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = false;
            panelDepartmentManagement.Visible = true;
            panelRequestManagement.Visible = false;
            panelEmployeeSection.Visible = false;
            panelEmployeeReport.Visible = false;
            panelAttendanceSummary.Visible = false;
            panelWorkingDates.Visible = false;
            LoadDepartmentManagement();
            txtDepartmentName.Text = "";
            selectedDepartmentId = -1;
        }

        private void btnRequestManagement_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = false;
            panelDepartmentManagement.Visible = false;
            panelRequestManagement.Visible = true;
            panelEmployeeSection.Visible = false;
            panelEmployeeReport.Visible = false;
            panelAttendanceSummary.Visible = false;
            panelWorkingDates.Visible = false;
            LoadRequestManagement();
        }

        private void btnEmployeeReport_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = false;
            panelDepartmentManagement.Visible = false;
            panelRequestManagement.Visible = false;
            panelEmployeeSection.Visible = false;
            panelEmployeeReport.Visible = true;
            panelAttendanceSummary.Visible = false;
            panelWorkingDates.Visible = false;
            txtSearchSecretCode.Text = "";
            LoadEmployeeReport();
        }

        private void btnAttendanceSummary_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = false;
            panelDepartmentManagement.Visible = false;
            panelRequestManagement.Visible = false;
            panelEmployeeSection.Visible = false;
            panelEmployeeReport.Visible = false;
            panelAttendanceSummary.Visible = true;
            panelWorkingDates.Visible = false;
            LoadAttendanceSummary();
        }

        private void btnWorkingDates_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = false;
            panelDepartmentManagement.Visible = false;
            panelRequestManagement.Visible = false;
            panelEmployeeSection.Visible = false;
            panelEmployeeReport.Visible = false;
            panelAttendanceSummary.Visible = false;
            panelWorkingDates.Visible = true;
        }

        private void dgvEmployeeDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployeeDetails.Rows[e.RowIndex];
                selectedEmployeeId = Convert.ToInt32(row.Cells["EmployeeId"].Value);
                txtEmployeeCode.Text = row.Cells["EmployeeCode"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                cmbDepartment.SelectedValue = row.Cells["DepartmentId"].Value;
                txtSecretCode.Text = row.Cells["SecretCode"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string employeeCode = txtEmployeeCode.Text.Trim();
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            int departmentId = (int)cmbDepartment.SelectedValue;
            string secretCode = txtSecretCode.Text.Trim();
            decimal salary;
            byte[] employeeImage = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        stream.CopyTo(memoryStream);
                        employeeImage = memoryStream.ToArray();
                    }
                }
            }

            if (!decimal.TryParse(txtSalary.Text.Trim(), out salary))
            {
                MessageBox.Show("Please enter a valid salary!");
                return;
            }
            if (string.IsNullOrEmpty(employeeCode) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(secretCode))
            {
                MessageBox.Show("All fields are required!");
                return;
            }
            if (secretCode.Length < 6)
            {
                MessageBox.Show("Secret code must be at least 6 characters long!");
                return;
            }
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Employees WHERE SecretCode = @SecretCode AND EmployeeId != @EmployeeId AND adminKey = @adminKey";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@SecretCode", secretCode);
                        cmdCheck.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId == -1 ? 0 : selectedEmployeeId);
                        cmdCheck.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("The secret code is already in use by another employee!");
                            return;
                        }
                    }
                    string query = "INSERT INTO Employees (EmployeeCode, Name, Email, Phone, DepartmentId, SecretCode, Salary, EmployeeImage, adminKey) VALUES (@EmployeeCode, @Name, @Email, @Phone, @DepartmentId, @SecretCode, @Salary, @EmployeeImage, @adminKey)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                        cmd.Parameters.AddWithValue("@SecretCode", secretCode);
                        cmd.Parameters.AddWithValue("@Salary", salary);
                        cmd.Parameters.AddWithValue("@EmployeeImage", employeeImage ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Employee added successfully!");
                LoadEmployeeDetails();
                ClearEmployeeFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}");
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId == -1)
            {
                MessageBox.Show("Please select an employee to update!");
                return;
            }

            string employeeCode = txtEmployeeCode.Text.Trim();
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            int departmentId = (int)cmbDepartment.SelectedValue;
            string secretCode = txtSecretCode.Text.Trim();
            decimal salary;
            if (!decimal.TryParse(txtSalary.Text.Trim(), out salary))
            {
                MessageBox.Show("Please enter a valid salary!");
                return;
            }

            if (string.IsNullOrEmpty(employeeCode) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(secretCode))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            if (secretCode.Length < 6)
            {
                MessageBox.Show("Secret code must be at least 6 characters long!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM Employees WHERE SecretCode = @SecretCode AND EmployeeId != @EmployeeId AND adminKey = @adminKey";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@SecretCode", secretCode);
                        cmdCheck.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                        cmdCheck.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("The secret code is already in use by another employee!");
                            return;
                        }
                    }

                    string query = "UPDATE Employees SET EmployeeCode = @EmployeeCode, Name = @Name, Email = @Email, Phone = @Phone, DepartmentId = @DepartmentId, SecretCode = @SecretCode, Salary = @Salary WHERE EmployeeId = @EmployeeId AND adminKey = @adminKey";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                        cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                        cmd.Parameters.AddWithValue("@SecretCode", secretCode);
                        cmd.Parameters.AddWithValue("@Salary", salary);
                        cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Employee updated successfully!");
                LoadEmployeeDetails();
                ClearEmployeeFields();
                selectedEmployeeId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeId == -1)
            {
                MessageBox.Show("Please select an employee to delete!");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string deleteRequestsQuery = "DELETE FROM EmployeeRequests WHERE EmployeeCode = (SELECT EmployeeCode FROM Employees WHERE EmployeeId = @EmployeeId AND adminKey = @adminKey)";
                        using (SqlCommand cmdDeleteRequests = new SqlCommand(deleteRequestsQuery, conn))
                        {
                            cmdDeleteRequests.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                            cmdDeleteRequests.Parameters.AddWithValue("@adminKey", currentAdminKey);
                            cmdDeleteRequests.ExecuteNonQuery();
                        }

                        string deleteEmployeeQuery = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId AND adminKey = @adminKey";
                        using (SqlCommand cmdDeleteEmployee = new SqlCommand(deleteEmployeeQuery, conn))
                        {
                            cmdDeleteEmployee.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                            cmdDeleteEmployee.Parameters.AddWithValue("@adminKey", currentAdminKey);
                            cmdDeleteEmployee.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Employee deleted successfully!");
                    LoadEmployeeDetails();
                    ClearEmployeeFields();
                    selectedEmployeeId = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting employee: {ex.Message}");
                }
            }
        }

        private void ClearEmployeeFields()
        {
            txtEmployeeCode.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtSecretCode.Text = "";
            txtSalary.Text = "";
            cmbDepartment.SelectedIndex = -1;
        }

        private void dgvDepartmentManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDepartmentManagement.Rows[e.RowIndex];
                selectedDepartmentId = Convert.ToInt32(row.Cells["DepartmentId"].Value);
                txtDepartmentName.Text = row.Cells["DepartmentName"].Value.ToString();
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text.Trim();
            if (string.IsNullOrEmpty(departmentName))
            {
                MessageBox.Show("Department name is required!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Departments (DepartmentName, adminKey) VALUES (@DepartmentName, @adminKey)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DepartmentName", departmentName);
                        cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Department added successfully!");
                LoadDepartmentManagement();
                LoadDepartments();
                txtDepartmentName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding department: {ex.Message}");
            }
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentId == -1)
            {
                MessageBox.Show("Please select a department to update!");
                return;
            }

            string departmentName = txtDepartmentName.Text.Trim();
            if (string.IsNullOrEmpty(departmentName))
            {
                MessageBox.Show("Department name is required!");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Departments SET DepartmentName = @DepartmentName WHERE DepartmentId = @DepartmentId AND adminKey = @adminKey";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DepartmentName", departmentName);
                        cmd.Parameters.AddWithValue("@DepartmentId", selectedDepartmentId);
                        cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Department updated successfully!");
                LoadDepartmentManagement();
                LoadDepartments();
                txtDepartmentName.Text = "";
                selectedDepartmentId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating department: {ex.Message}");
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentId == -1)
            {
                MessageBox.Show("Please select a department to delete!");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Departments WHERE DepartmentId = @DepartmentId AND adminKey = @adminKey";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@DepartmentId", selectedDepartmentId);
                            cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Department deleted successfully!");
                    LoadDepartmentManagement();
                    LoadDepartments();
                    txtDepartmentName.Text = "";
                    selectedDepartmentId = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting department: {ex.Message}");
                }
            }
        }

        private void ApplyDataGridViewStyling()
        {
            foreach (DataGridView dgv in new DataGridView[] { dgvEmployeeDetails, dgvDepartmentManagement, dgvRequestManagement, dgvEmployeeReport })
            {
                if (dgv != null)
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                        else
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 52, 54);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    dgv.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                    dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                    dgv.BorderStyle = BorderStyle.FixedSingle;
                    dgv.RowHeadersVisible = false;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void dgvEmployeeDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvEmployeeDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            }
        }

        private void dgvEmployeeDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                    dgvEmployeeDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                else
                    dgvEmployeeDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void dgvEmployeeDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployeeDetails.Rows[e.RowIndex];
                selectedEmployeeId = Convert.ToInt32(row.Cells["EmployeeId"].Value);

                if (e.ColumnIndex == dgvEmployeeDetails.Columns["UpdateButton"].Index)
                {
                    panelEmployeeDetails.Visible = false;
                    panelEmployeeSection.Visible = true;
                    txtEmployeeCode.Text = row.Cells["EmployeeCode"].Value.ToString();
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtPhone.Text = row.Cells["Phone"].Value.ToString();
                    cmbDepartment.SelectedValue = row.Cells["DepartmentId"].Value;
                    txtSecretCode.Text = row.Cells["SecretCode"].Value.ToString();
                    txtSalary.Text = row.Cells["Salary"].Value.ToString();
                }
                else if (e.ColumnIndex == dgvEmployeeDetails.Columns["DeleteButton"].Index)
                {
                    if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection conn = DatabaseHelper.GetConnection())
                            {
                                conn.Open();
                                string deleteRequestsQuery = "DELETE FROM EmployeeRequests WHERE EmployeeCode = (SELECT EmployeeCode FROM Employees WHERE EmployeeId = @EmployeeId AND adminKey = @adminKey)";
                                using (SqlCommand cmdDeleteRequests = new SqlCommand(deleteRequestsQuery, conn))
                                {
                                    cmdDeleteRequests.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                                    cmdDeleteRequests.Parameters.AddWithValue("@adminKey", currentAdminKey);
                                    cmdDeleteRequests.ExecuteNonQuery();
                                }

                                string deleteEmployeeQuery = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId AND adminKey = @adminKey";
                                using (SqlCommand cmdDeleteEmployee = new SqlCommand(deleteEmployeeQuery, conn))
                                {
                                    cmdDeleteEmployee.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                                    cmdDeleteEmployee.Parameters.AddWithValue("@adminKey", currentAdminKey);
                                    cmdDeleteEmployee.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Employee deleted successfully!");
                            LoadEmployeeDetails();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting employee: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void dgvRequestManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRequestManagement.Rows[e.RowIndex];
                int requestId = Convert.ToInt32(row.Cells["RequestId"].Value);
                if (e.ColumnIndex == dgvRequestManagement.Columns["Accept"].Index)
                {
                    UpdateRequestStatus(requestId, "Accepted");
                    MessageBox.Show("Request Accepted!");
                }
                else if (e.ColumnIndex == dgvRequestManagement.Columns["Decline"].Index)
                {
                    UpdateRequestStatus(requestId, "Declined");
                    MessageBox.Show("Request Declined!");
                }
                LoadRequestManagement();
            }
        }

        private void UpdateRequestStatus(int requestId, string status)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE EmployeeRequests SET Status = @Status WHERE RequestId = @RequestId AND adminKey = @adminKey";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RequestId", requestId);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating request status: {ex.Message}");
            }
        }

        private void btnRefreshRequests_Click(object sender, EventArgs e)
        {
            LoadRequestManagement();
        }

        private void txtSearchSecretCode_TextChanged(object sender, EventArgs e)
        {
            LoadEmployeeReport();
        }

        private void LoadEmployeeReport()
        {
            try
            {
                string secretCode = txtSearchSecretCode.Text.Trim();
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT EmployeeId, EmployeeCode, Name, Email, Phone, DepartmentId, SecretCode, Salary FROM Employees WHERE SecretCode LIKE @SecretCode AND adminKey = @adminKey";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@SecretCode", $"%{secretCode}%");
                        da.SelectCommand.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvEmployeeReport.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee report: {ex.Message}");
            }
        }

        private void LoadAttendanceSummary()
        {
            if (cmbEmployeeCode.SelectedValue == null) return;

            try
            {
                string employeeCode = cmbEmployeeCode.SelectedValue.ToString();
                DateTime now = DateTime.Now;
                DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Attendance WHERE EmployeeCode = @EmployeeCode AND AttendanceDate BETWEEN @StartDate AND @EndDate AND IsWorkingDay = 1 AND adminKey = @adminKey";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                        cmd.Parameters.AddWithValue("@StartDate", startOfMonth);
                        cmd.Parameters.AddWithValue("@EndDate", endOfMonth);
                        cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        int attendanceDays = (int)cmd.ExecuteScalar();

                        query = "SELECT COUNT(*) FROM WorkingDates WHERE WorkDate BETWEEN @StartDate AND @EndDate AND IsWorkingDay = 1 AND adminKey = @adminKey";
                        using (SqlCommand cmdWorking = new SqlCommand(query, conn))
                        {
                            cmdWorking.Parameters.AddWithValue("@StartDate", startOfMonth);
                            cmdWorking.Parameters.AddWithValue("@EndDate", endOfMonth);
                            cmdWorking.Parameters.AddWithValue("@adminKey", currentAdminKey);
                            int totalWorkingDays = (int)cmdWorking.ExecuteScalar();
                            int leaveDays = totalWorkingDays - attendanceDays;
                            decimal deduction = leaveDays * 200;
                            decimal salary = 0;
                            query = "SELECT Salary FROM Employees WHERE EmployeeCode = @EmployeeCode AND adminKey = @adminKey";
                            using (SqlCommand cmdSalary = new SqlCommand(query, conn))
                            {
                                cmdSalary.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                                cmdSalary.Parameters.AddWithValue("@adminKey", currentAdminKey);
                                object salaryObj = cmdSalary.ExecuteScalar();
                                if (salaryObj != null && salaryObj != DBNull.Value)
                                {
                                    salary = Convert.ToDecimal(salaryObj);
                                }
                            }
                            decimal totalSalary = salary - deduction;

                            lblAttendanceDays.Text = $"Attendance Days: {attendanceDays}";
                            lblLeaveDays.Text = $"Leave Days: {leaveDays}";
                            lblDeduction.Text = $"Deduction: {deduction:C}";
                            lblTotalSalary.Text = $"Total Salary: {totalSalary:C}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attendance summary: {ex.Message}");
            }
        }

        private void cmbEmployeeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceSummary();
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeCode.SelectedValue == null) return;

            try
            {
                string employeeCode = cmbEmployeeCode.SelectedValue.ToString();
                DateTime now = DateTime.Now;
                DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Salary FROM Employees WHERE EmployeeCode = @EmployeeCode AND adminKey = @adminKey";
                    decimal currentSalary = 0;
                    using (SqlCommand cmdSalary = new SqlCommand(query, conn))
                    {
                        cmdSalary.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                        cmdSalary.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        object salaryObj = cmdSalary.ExecuteScalar();
                        if (salaryObj != null && salaryObj != DBNull.Value)
                        {
                            currentSalary = Convert.ToDecimal(salaryObj);
                        }
                    }

                    query = "SELECT COUNT(*) FROM Attendance WHERE EmployeeCode = @EmployeeCode AND AttendanceDate BETWEEN @StartDate AND @EndDate AND IsWorkingDay = 1 AND adminKey = @adminKey";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                        cmd.Parameters.AddWithValue("@StartDate", startOfMonth);
                        cmd.Parameters.AddWithValue("@EndDate", endOfMonth);
                        cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        int attendanceDays = (int)cmd.ExecuteScalar();

                        query = "SELECT COUNT(*) FROM WorkingDates WHERE WorkDate BETWEEN @StartDate AND @EndDate AND IsWorkingDay = 1 AND adminKey = @adminKey";
                        using (SqlCommand cmdWorking = new SqlCommand(query, conn))
                        {
                            cmdWorking.Parameters.AddWithValue("@StartDate", startOfMonth);
                            cmdWorking.Parameters.AddWithValue("@EndDate", endOfMonth);
                            cmdWorking.Parameters.AddWithValue("@adminKey", currentAdminKey);
                            int totalWorkingDays = (int)cmdWorking.ExecuteScalar();
                            int leaveDays = totalWorkingDays - attendanceDays;
                            decimal deduction = leaveDays * 200;
                            decimal totalSalary = currentSalary - deduction;

                            query = "UPDATE Employees SET Salary = @Salary WHERE EmployeeCode = @EmployeeCode AND adminKey = @adminKey";
                            using (SqlCommand cmdUpdate = new SqlCommand(query, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                                cmdUpdate.Parameters.AddWithValue("@Salary", totalSalary);
                                cmdUpdate.Parameters.AddWithValue("@adminKey", currentAdminKey);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Salary updated successfully!");
                LoadAttendanceSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating salary: {ex.Message}");
            }
        }

        private void btnAddAsWorkingDay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionStart;
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM WorkingDates WHERE WorkDate = @WorkDate AND adminKey = @adminKey";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@WorkDate", selectedDate.Date);
                        cmdCheck.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count == 0)
                        {
                            string insertQuery = "INSERT INTO WorkingDates (WorkDate, IsWorkingDay, adminKey) VALUES (@WorkDate, 1, @adminKey)";
                            using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@WorkDate", selectedDate.Date);
                                cmdInsert.Parameters.AddWithValue("@adminKey", currentAdminKey);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string updateQuery = "UPDATE WorkingDates SET IsWorkingDay = 1 WHERE WorkDate = @WorkDate AND adminKey = @adminKey";
                            using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@WorkDate", selectedDate.Date);
                                cmdUpdate.Parameters.AddWithValue("@adminKey", currentAdminKey);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show($"{selectedDate:yyyy-MM-dd} has been added as a working day!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding working day: {ex.Message}");
            }
        }

        private void btnAddAsOffDay_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionStart;
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM WorkingDates WHERE WorkDate = @WorkDate AND adminKey = @adminKey";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@WorkDate", selectedDate.Date);
                        cmdCheck.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count == 0)
                        {
                            string insertQuery = "INSERT INTO WorkingDates (WorkDate, IsWorkingDay, adminKey) VALUES (@WorkDate, 0, @adminKey)";
                            using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@WorkDate", selectedDate.Date);
                                cmdInsert.Parameters.AddWithValue("@adminKey", currentAdminKey);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string updateQuery = "UPDATE WorkingDates SET IsWorkingDay = 0 WHERE WorkDate = @WorkDate AND adminKey = @adminKey";
                            using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@WorkDate", selectedDate.Date);
                                cmdUpdate.Parameters.AddWithValue("@adminKey", currentAdminKey);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show($"{selectedDate:yyyy-MM-dd} has been added as an off day!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding off day: {ex.Message}");
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void btnDownloadPDF_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeReport.Rows.Count == 0)
            {
                MessageBox.Show("No employee data to generate PDF!");
                return;
            }

            if (dgvEmployeeReport.Rows.Count > 1)
            {
                MessageBox.Show("Please search for a single employee to generate PDF!");
                return;
            }

            DataGridViewRow row = dgvEmployeeReport.Rows[0];
            string employeeCode = row.Cells["EmployeeCode"].Value.ToString();
            string name = row.Cells["Name"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();
            string phone = row.Cells["Phone"].Value.ToString();
            string departmentId = row.Cells["DepartmentId"].Value.ToString();
            string secretCode = row.Cells["SecretCode"].Value.ToString();
            string salary = row.Cells["Salary"].Value.ToString();

            string latexContent = @"
\documentclass[a4paper,12pt]{article}
\usepackage[utf8]{inputenc}
\usepackage{geometry}
\geometry{a4paper, margin=1in}
\usepackage{amsmath}
\usepackage{amsfonts}
\usepackage{fancyhdr}
\pagestyle{fancy}
\fancyhf{}
\rhead{Sonargaon Textile LTD. Employee Report - Generated on " + DateTime.Now.ToString("MMMM dd, yyyy HH:mm:ss") + @" +06}
\cfoot{\thepage}
\begin{document}

\begin{center}
    \textbf{\large Employee Report}
\end{center}

\begin{itemize}
    \item \textbf{Employee Position:} " + employeeCode + @"
    \item \textbf{Name:} " + name + @"
    \item \textbf{Email:} " + email + @"
    \item \textbf{Phone:} " + phone + @"
    \item \textbf{Department ID:} " + departmentId + @"
    \item \textbf{Secret Code:} " + secretCode + @"
    \item \textbf{Salary:} " + salary + @"
\end{itemize}

\end{document}
";

            string tempLatexFile = Path.Combine(Path.GetTempPath(), "employee_report.tex");
            File.WriteAllText(tempLatexFile, latexContent);

            string pdfFile = Path.Combine(Path.GetTempPath(), "employee_report.pdf");
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "latexmk";
            process.StartInfo.Arguments = $"-pdf -output-directory={Path.GetTempPath()} {tempLatexFile}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            try
            {
                process.Start();
                process.WaitForExit(30000);

                if (process.ExitCode == 0 && File.Exists(pdfFile))
                {
                    System.Diagnostics.Process.Start(pdfFile);
                    MessageBox.Show("PDF generated and opened successfully!");
                }
                else
                {
                    string error = process.StandardError.ReadToEnd();
                    MessageBox.Show($"Failed to generate PDF! Error: {error}");
                }
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show($"Failed to generate PDF! Please ensure LaTeX (e.g., TeX Live or MiKTeX) with latexmk is installed and added to your system PATH. Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                if (File.Exists(tempLatexFile)) File.Delete(tempLatexFile);
                if (File.Exists(pdfFile) && process.ExitCode != 0) File.Delete(pdfFile);
            }
        }

        private void btnNoticePublish_Click(object sender, EventArgs e)
        {
            NoticePublishForm noticeForm = new NoticePublishForm(currentAdminKey);
            noticeForm.ShowDialog();
        }

        private void addNoticeButton_Click(object sender, EventArgs e)
        {
            NoticePublishForm noticeForm = new NoticePublishForm(currentAdminKey);
            noticeForm.ShowDialog();
        }

        // Separate form class (NoticePublishForm.cs)
        public partial class NoticePublishForm : Form
        {
            private ComboBox cmbDepartment;
            private TextBox txtNotice;
            private Button btnSubmit;
            private string currentAdminKey; // Added to store the adminKey

            public NoticePublishForm(string currentAdminKey)
            {
                InitializeComponent();
                this.currentAdminKey = currentAdminKey; // Store the adminKey
            }

            private void InitializeComponent()
            {
                this.cmbDepartment = new System.Windows.Forms.ComboBox();
                this.txtNotice = new System.Windows.Forms.TextBox();
                this.btnSubmit = new System.Windows.Forms.Button();
                this.SuspendLayout();

                // cmbDepartment
                this.cmbDepartment.FormattingEnabled = true;
                this.cmbDepartment.Location = new System.Drawing.Point(20, 20);
                this.cmbDepartment.Name = "cmbDepartment";
                this.cmbDepartment.Size = new System.Drawing.Size(260, 24);
                this.cmbDepartment.TabIndex = 0;
                this.cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;

                // txtNotice
                this.txtNotice.Location = new System.Drawing.Point(20, 60);
                this.txtNotice.Multiline = true;
                this.txtNotice.Name = "txtNotice";
                this.txtNotice.Size = new System.Drawing.Size(260, 100);
                this.txtNotice.TabIndex = 1;

                // btnSubmit
                this.btnSubmit.Location = new System.Drawing.Point(100, 170);
                this.btnSubmit.Name = "btnSubmit";
                this.btnSubmit.Size = new System.Drawing.Size(100, 30);
                this.btnSubmit.TabIndex = 2;
                this.btnSubmit.Text = "Submit";
                this.btnSubmit.UseVisualStyleBackColor = true;
                this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

                // Form
                this.ClientSize = new System.Drawing.Size(300, 220);
                this.Controls.Add(this.btnSubmit);
                this.Controls.Add(this.txtNotice);
                this.Controls.Add(this.cmbDepartment);
                this.Name = "NoticePublishForm";
                this.Text = "Publish Notice";
                this.Load += new System.EventHandler(this.NoticePublishForm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            private void NoticePublishForm_Load(object sender, EventArgs e)
            {
                LoadDepartments();
            }

            private void LoadDepartments()
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT DepartmentId, DepartmentName FROM Departments WHERE adminKey = @adminKey";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbDepartment.DataSource = dt;
                            cmbDepartment.DisplayMember = "DepartmentName";
                            cmbDepartment.ValueMember = "DepartmentId";
                        }
                    }
                }
            }

            private void btnSubmit_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtNotice.Text) || cmbDepartment.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter a notice and select a department.");
                    return;
                }

                try
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "INSERT INTO Notices (DepartmentId, NoticeText, PublishDate, adminKey) VALUES (@DepartmentId, @NoticeText, @PublishDate, @adminKey)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@DepartmentId", cmbDepartment.SelectedValue);
                            cmd.Parameters.AddWithValue("@NoticeText", txtNotice.Text.Trim());
                            cmd.Parameters.AddWithValue("@PublishDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@adminKey", currentAdminKey);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Notice published successfully.");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error publishing notice: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoticePublishForm noticeForm = new NoticePublishForm(currentAdminKey);
            noticeForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginSelection loginForm = new LoginSelection();
            loginForm.ShowDialog();
        }
    }
}