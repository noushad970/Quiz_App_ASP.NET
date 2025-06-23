using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees_Management_System.Forms
{
    public partial class NoticePublishForm : Form
    {
        public NoticePublishForm()
        {
            InitializeComponent();
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
                string query = "SELECT DepartmentId, DepartmentName FROM Departments";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
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
                    string query = "INSERT INTO Notices (DepartmentId, NoticeText, PublishDate) VALUES (@DepartmentId, @NoticeText, @PublishDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DepartmentId", cmbDepartment.SelectedValue);
                        cmd.Parameters.AddWithValue("@NoticeText", txtNotice.Text.Trim());
                        cmd.Parameters.AddWithValue("@PublishDate", DateTime.Now);
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
}