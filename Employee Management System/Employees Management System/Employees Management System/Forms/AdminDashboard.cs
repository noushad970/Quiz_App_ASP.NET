using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class AdminDashboard : Form
    {
        private int selectedEmployeeId = -1;
        private int selectedDepartmentId = -1;
        private int slidePosition = 0;

        public AdminDashboard()
        {
            InitializeComponent();
            this.Opacity = 0; // Start with 0 opacity for fade-in effect
            dgvEmployeeDetails.EnableHeadersVisualStyles = false;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            fadeTimer.Start(); // Start the fade-in animation
            LoadEmployeeDetails();
            LoadDepartmentManagement();
            LoadRequestManagement();
            LoadDepartments();
            panelEmployeeDetails.Visible = true; // Default to Employee Details
            slideTimer.Start(); // Start slide animation
            ApplyDataGridViewStyling();
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
            else
            {
                fadeTimer.Stop(); // Stop timer when fully visible
            }
        }

        private void slideTimer_Tick(object sender, EventArgs e)
        {
            if (slidePosition < 0)
            {
                slidePosition += 10;
                panelEmployeeDetails.Location = new System.Drawing.Point(slidePosition, 0);
                if (slidePosition >= 0) slideTimer.Stop();
            }
            else if (slidePosition > 0)
            {
                slidePosition -= 10;
                panelEmployeeDetails.Location = new System.Drawing.Point(slidePosition, 0);
                if (slidePosition <= 0) slideTimer.Stop();
            }
        }

        private void LoadEmployeeDetails()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT EmployeeId, EmployeeCode, Name, Email, Phone, DepartmentId, SecretCode, Salary FROM Employees";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Clear existing rows and columns
                    dgvEmployeeDetails.DataSource = null;
                    dgvEmployeeDetails.Columns.Clear();

                    // Add columns manually to avoid duplication
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

                    // Populate DataGridView
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
            slidePosition = -560; // Slide in from left
            slideTimer.Start();
            ApplyDataGridViewStyling();
        }

        private void LoadDepartmentManagement()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT DepartmentId, DepartmentName FROM Departments";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDepartmentManagement.DataSource = dt;
                }
            }
        }

        private void LoadRequestManagement()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT RequestId, EmployeeCode, RequestType, Reason, RequestDate, Status FROM EmployeeRequests";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRequestManagement.DataSource = dt;
                }
            }
        }

        private void LoadDepartments()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT DepartmentId, DepartmentName FROM Departments";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbDepartment.DataSource = dt;
                    cmbDepartment.DisplayMember = "DepartmentName";
                    cmbDepartment.ValueMember = "DepartmentId";
                }
            }
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = true;
            panelDepartmentManagement.Visible = false;
            panelRequestManagement.Visible = false;
            panelEmployeeSection.Visible = false;
            LoadEmployeeDetails();
        }

        private void btnEmployeeSection_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = false;
            panelDepartmentManagement.Visible = false;
            panelRequestManagement.Visible = false;
            panelEmployeeSection.Visible = true;
            ClearEmployeeFields();
            selectedEmployeeId = -1;
        }

        private void btnDepartmentManagement_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Visible = false;
            panelDepartmentManagement.Visible = true;
            panelRequestManagement.Visible = false;
            panelEmployeeSection.Visible = false;
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
            LoadRequestManagement();
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

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Employees WHERE SecretCode = @SecretCode AND EmployeeId != @EmployeeId";
                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@SecretCode", secretCode);
                    cmdCheck.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId == -1 ? 0 : selectedEmployeeId);
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("The secret code is already in use by another employee!");
                        return;
                    }
                }

                string query = "INSERT INTO Employees (EmployeeCode, Name, Email, Phone, DepartmentId, SecretCode, Salary) VALUES (@EmployeeCode, @Name, @Email, @Phone, @DepartmentId, @SecretCode, @Salary)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                    cmd.Parameters.AddWithValue("@SecretCode", secretCode);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee added successfully!");
                    LoadEmployeeDetails();
                    ClearEmployeeFields();
                }
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

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Employees WHERE SecretCode = @SecretCode AND EmployeeId != @EmployeeId";
                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@SecretCode", secretCode);
                    cmdCheck.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("The secret code is already in use by another employee!");
                        return;
                    }
                }

                string query = "UPDATE Employees SET EmployeeCode = @EmployeeCode, Name = @Name, Email = @Email, Phone = @Phone, DepartmentId = @DepartmentId, SecretCode = @SecretCode, Salary = @Salary WHERE EmployeeId = @EmployeeId";
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
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee updated successfully!");
                    LoadEmployeeDetails();
                    ClearEmployeeFields();
                    selectedEmployeeId = -1;
                }
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
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee deleted successfully!");
                        LoadEmployeeDetails();
                        ClearEmployeeFields();
                        selectedEmployeeId = -1;
                    }
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

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Departments (DepartmentName) VALUES (@DepartmentName)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DepartmentName", departmentName);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department added successfully!");
                    LoadDepartmentManagement();
                    LoadDepartments();
                    txtDepartmentName.Text = "";
                }
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

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Departments SET DepartmentName = @DepartmentName WHERE DepartmentId = @DepartmentId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DepartmentName", departmentName);
                    cmd.Parameters.AddWithValue("@DepartmentId", selectedDepartmentId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department updated successfully!");
                    LoadDepartmentManagement();
                    LoadDepartments();
                    txtDepartmentName.Text = "";
                    selectedDepartmentId = -1;
                }
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
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Departments WHERE DepartmentId = @DepartmentId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DepartmentId", selectedDepartmentId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Department deleted successfully!");
                        LoadDepartmentManagement();
                        LoadDepartments();
                        txtDepartmentName.Text = "";
                        selectedDepartmentId = -1;
                    }
                }
            }
        }

        private void ApplyDataGridViewStyling()
        {
            for (int i = 0; i < dgvEmployeeDetails.Rows.Count; i++)
            {
                if (i % 2 == 0)
                    dgvEmployeeDetails.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // AliceBlue
                else
                    dgvEmployeeDetails.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }

            dgvEmployeeDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 52, 54);
            dgvEmployeeDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmployeeDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvEmployeeDetails.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dgvEmployeeDetails.DefaultCellStyle.SelectionForeColor = Color.White;
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
                    dgvEmployeeDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // AliceBlue
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
                        using (SqlConnection conn = DatabaseHelper.GetConnection())
                        {
                            conn.Open();
                            string query = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Employee deleted successfully!");
                                LoadEmployeeDetails();
                            }
                        }
                    }
                }
            }
        }
    }
}