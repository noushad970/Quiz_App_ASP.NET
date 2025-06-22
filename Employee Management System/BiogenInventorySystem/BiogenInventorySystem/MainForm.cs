//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace BiogenInventorySystem
{
    public partial class MainForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BiogenPharmaConnection"].ConnectionString;
        private string userRole;
        private string username;

        public MainForm(string role, string user)
        {
            InitializeComponent();
            userRole = role;
            username = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (contentPanel == null)
            {
                MessageBox.Show("contentPanel is not initialized. Please check the designer file.");
                return;
            }
            SetupUI();
        }

        private void SetupUI()
        {
            if (userRole == "Admin")
            {
                CreateAdminMenu(panelMenu);
                ShowReports();
            }
            else
            {
                CreateStaffMenu(panelMenu);
                ShowReports();
            }
        }

        private void CreateAdminMenu(Panel menuPanel)
        {
            int yOffset = 60;
            Button dashboardBtn = CreateMenuButton("Dashboard", yOffset, ShowDashboard);
            Button userMgmtBtn = CreateMenuButton("User Management", yOffset + 50, ShowUserManagement);
            Button stockBtn = CreateMenuButton("Stock Management", yOffset + 100, ShowStockManagement);
            Button reportsBtn = CreateMenuButton("Reports", yOffset + 150, ShowReports);
            Button soldMedicineBtn = CreateMenuButton("Sold Medicine", yOffset + 200, ShowSoldMedicine);

            menuPanel.Controls.AddRange(new Control[] { dashboardBtn, userMgmtBtn, stockBtn, reportsBtn, soldMedicineBtn });
        }

        private void CreateStaffMenu(Panel menuPanel)
        {
            int yOffset = 60;
            Button dashboardBtn = CreateMenuButton("Dashboard", yOffset, ShowDashboard);
            Button addMedicineBtn = CreateMenuButton("Add Medicine", yOffset + 50, ShowAddMedicine);
            Button stockUpdatesBtn = CreateMenuButton("Stock Updates", yOffset + 100, ShowStockUpdates);
            Button alertsBtn = CreateMenuButton("Stock Alerts", yOffset + 150, ShowStockAlerts);
            Button expiredBtn = CreateMenuButton("Expired Medicines", yOffset + 200, ShowExpiredMedicines);
            Button soldMedicineBtn = CreateMenuButton("Sold Medicine", yOffset + 250, ShowSoldMedicine);

            menuPanel.Controls.AddRange(new Control[] { dashboardBtn, addMedicineBtn, stockUpdatesBtn, alertsBtn, expiredBtn, soldMedicineBtn });
        }

        private Button CreateMenuButton(string text, int yOffset, Action onClick)
        {
            Button btn = new Button
            {
                Text = text,
                Location = new Point(10, yOffset),
                Size = new Size(200, 40),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(26, 32, 40),
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 60, 70);
            btn.Click += (s, e) =>
            {
                if (contentPanel != null) onClick();
                else MessageBox.Show("contentPanel is null. Cannot proceed.");
            };
            return btn;
        }

        private void ShowDashboard()
        {
            if (contentPanel == null) return;
            contentPanel.Controls.Clear();

            Label header = new Label
            {
                Text = userRole == "Admin" ? "Admin Dashboard" : "Staff Dashboard",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };

            Panel statsPanel = new Panel
            {
                Location = new Point(20, 60),
                Size = new Size(900, 100),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            int totalMedicines = 0;
            int lowStockCount = 0;
            int expiredCount = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmdTotal = new SqlCommand("SELECT COUNT(*) FROM Medicines", conn);
                totalMedicines = (int)cmdTotal.ExecuteScalar();

                SqlCommand cmdLowStock = new SqlCommand("SELECT COUNT(*) FROM Medicines WHERE Quantity < 10", conn);
                lowStockCount = (int)cmdLowStock.ExecuteScalar();

                SqlCommand cmdExpired = new SqlCommand("SELECT COUNT(*) FROM Medicines WHERE ExpiryDate < @CurrentDate", conn);
                cmdExpired.Parameters.AddWithValue("@CurrentDate", DateTime.Now);
                expiredCount = (int)cmdExpired.ExecuteScalar();
            }

            Label totalMedicinesLabel = CreateStatLabel("Total Medicines", totalMedicines.ToString(), 20);
            totalMedicinesLabel.Click += (s, e) => ShowMedicineDetails("SELECT * FROM Medicines");
            Label lowStockLabel = CreateStatLabel("Low Stock", lowStockCount.ToString(), 230);
            lowStockLabel.Click += (s, e) => ShowMedicineDetails("SELECT * FROM Medicines WHERE Quantity < 10");
            Label expiredMedicinesLabel = CreateStatLabel("Expired Medicines", expiredCount.ToString(), 440);
            expiredMedicinesLabel.Click += (s, e) => ShowMedicineDetails("SELECT * FROM Medicines WHERE ExpiryDate < @CurrentDate", DateTime.Now);

            statsPanel.Controls.AddRange(new Control[] { totalMedicinesLabel, lowStockLabel, expiredMedicinesLabel });

            Chart stockChart = new Chart
            {
                Location = new Point(20, 180),
                Size = new Size(900, 400),
                BackColor = Color.White
            };
            ChartArea chartArea = new ChartArea();
            stockChart.ChartAreas.Add(chartArea);
            Series series = new Series
            {
                ChartType = SeriesChartType.Bar,
                Name = "Stock Levels"
            };
            stockChart.Series.Add(series);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MedicineName, Quantity FROM Medicines", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    series.Points.AddXY(reader["MedicineName"].ToString(), Convert.ToInt32(reader["Quantity"]));
                }
            }

            contentPanel.Controls.Clear();
            contentPanel.Controls.AddRange(new Control[] { header, statsPanel, stockChart });
        }

        private Label CreateStatLabel(string title, string value, int xOffset)
        {
            Label lbl = new Label
            {
                Text = $"{title}\n{value}",
                Font = new Font("Segoe UI", 10),
                Size = new Size(200, 60),
                Location = new Point(xOffset, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };
            lbl.Click += (s, e) => lbl.ForeColor = Color.Blue;
            return lbl;
        }

        private void ShowMedicineDetails(string query, DateTime? currentDate = null)
        {
            if (contentPanel == null) return;
            contentPanel.Controls.Clear();

            Label header = new Label
            {
                Text = query.Contains("Quantity < 10") ? "Low Stock Medicines" :
                       query.Contains("ExpiryDate <") ? "Expired Medicines" : "All Medicines",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };

            DataGridView dgv = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(900, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (currentDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@CurrentDate", currentDate.Value);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }

            contentPanel.Controls.AddRange(new Control[] { header, dgv });
        }

        private void ShowUserManagement()
        {
            if (contentPanel == null) return;
            contentPanel.Controls.Clear();
            Label header = new Label
            {
                Text = "User Management",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };

            DataGridView dgv = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(900, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            Button addUserBtn = new Button
            {
                Text = "Add User",
                Location = new Point(20, 570),
                Size = new Size(100, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White
            };
            addUserBtn.FlatAppearance.BorderSize = 0;
            addUserBtn.Click += (s, e) => AddUser();

            contentPanel.Controls.AddRange(new Control[] { header, dgv, addUserBtn });
            LoadUsers(dgv);
        }

        private void LoadUsers(DataGridView dgv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Username, Role, Department FROM Users", conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void AddUser()
        {
            if (contentPanel == null) return;
            Form userForm = new Form
            {
                Text = "Add New User",
                Size = new Size(300, 400),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            Label lblUsername = new Label { Text = "Username:", Location = new Point(20, 20), Font = new Font("Segoe UI", 10) };
            TextBox txtUsername = new TextBox { Location = new Point(20, 40), Width = 240, Font = new Font("Segoe UI", 10) };
            Label lblPassword = new Label { Text = "Password:", Location = new Point(20, 80), Font = new Font("Segoe UI", 10) };
            TextBox txtPassword = new TextBox { Location = new Point(20, 100), Width = 240, UseSystemPasswordChar = true, Font = new Font("Segoe UI", 10) };
            Label lblRole = new Label { Text = "Role:", Location = new Point(20, 140), Font = new Font("Segoe UI", 10) };
            ComboBox cmbRole = new ComboBox { Location = new Point(20, 160), Width = 240, Font = new Font("Segoe UI", 10) };
            cmbRole.Items.AddRange(new string[] { "Admin", "Staff" });
            Label lblDepartment = new Label { Text = "Department:", Location = new Point(20, 200), Font = new Font("Segoe UI", 10) };
            TextBox txtDepartment = new TextBox { Location = new Point(20, 220), Width = 240, Font = new Font("Segoe UI", 10) };
            Button saveBtn = new Button
            {
                Text = "Save",
                Location = new Point(20, 260),
                Size = new Size(100, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10)
            };
            saveBtn.FlatAppearance.BorderSize = 0;

            saveBtn.Click += (s, e) =>
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, Role, Department) VALUES (@Username, @Password, @Role, @Department)", conn);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem?.ToString() ?? "Staff");
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.ExecuteNonQuery();
                }
                userForm.Close();
                LoadUsers((DataGridView)contentPanel.Controls[1]);
            };

            userForm.Controls.AddRange(new Control[] { lblUsername, txtUsername, lblPassword, txtPassword, lblRole, cmbRole, lblDepartment, txtDepartment, saveBtn });
            userForm.ShowDialog();
        }

        private void ShowStockManagement()
        {
            if (contentPanel == null) return;
            contentPanel.Controls.Clear();
            Label header = new Label
            {
                Text = "Stock Management",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };

            DataGridView dgv = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(900, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            contentPanel.Controls.AddRange(new Control[] { header, dgv });
            LoadMedicines(dgv);
        }

        private void LoadMedicines(DataGridView dgv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MedicineName, Quantity, ExpiryDate FROM Medicines", conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void ShowAddMedicine()
        {
            if (contentPanel == null) return;
            contentPanel.Controls.Clear();

            Form medicineForm = new Form
            {
                Text = "Add New Medicine",
                Size = new Size(300, 400),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            Label lblName = new Label { Text = "Medicine Name:", Location = new Point(20, 20), Font = new Font("Segoe UI", 10) };
            TextBox txtName = new TextBox { Location = new Point(20, 40), Width = 240, Font = new Font("Segoe UI", 10) };
            Label lblQuantity = new Label { Text = "Quantity:", Location = new Point(20, 80), Font = new Font("Segoe UI", 10) };
            NumericUpDown nudQuantity = new NumericUpDown { Location = new Point(20, 100), Width = 240, Font = new Font("Segoe UI", 10), Maximum = 10000 };
            Label lblExpiry = new Label { Text = "Expiry Date:", Location = new Point(20, 140), Font = new Font("Segoe UI", 10) };
            DateTimePicker dtpExpiry = new DateTimePicker { Location = new Point(20, 160), Width = 240, Font = new Font("Segoe UI", 10) };
            Button saveBtn = new Button
            {
                Text = "Save",
                Location = new Point(20, 200),
                Size = new Size(100, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10)
            };
            saveBtn.FlatAppearance.BorderSize = 0;

            saveBtn.Click += (s, e) =>
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Medicines (MedicineName, Quantity, ExpiryDate) VALUES (@Name, @Quantity, @ExpiryDate)", conn);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", nudQuantity.Value);
                    cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiry.Value);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmdUpdate = new SqlCommand("INSERT INTO StockUpdates (MedicineName, UpdateType, Quantity, UpdateDate, ExpiryDate, Department) VALUES (@Name, 'Added', @Quantity, @UpdateDate, @ExpiryDate, @Department)", conn);
                    cmdUpdate.Parameters.AddWithValue("@Name", txtName.Text);
                    cmdUpdate.Parameters.AddWithValue("@Quantity", nudQuantity.Value);
                    cmdUpdate.Parameters.AddWithValue("@UpdateDate", DateTime.Now);
                    cmdUpdate.Parameters.AddWithValue("@ExpiryDate", dtpExpiry.Value);
                    cmdUpdate.Parameters.AddWithValue("@Department", "Warehouse");
                    cmdUpdate.ExecuteNonQuery();
                }
                medicineForm.Close();
                ShowStockManagement();
            };

            medicineForm.Controls.AddRange(new Control[] { lblName, txtName, lblQuantity, nudQuantity, lblExpiry, dtpExpiry, saveBtn });
            medicineForm.ShowDialog();
        }

        private void ShowStockUpdates()
        {
            if (contentPanel == null) return;
            contentPanel.Controls.Clear();

            Label header = new Label
            {
                Text = "Stock Updates",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };

            DataGridView dgv = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(900, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT UpdateID, MedicineName, UpdateType, Quantity, UpdateDate, ExpiryDate, Department FROM StockUpdates ORDER BY UpdateDate DESC", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }

            contentPanel.Controls.AddRange(new Control[] { header, dgv });
        }

        private void ShowSoldMedicine()
        {
            if (contentPanel == null) return;
            contentPanel.Controls.Clear();

            Label header = new Label
            {
                Text = "Sold Medicine",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };

            Form sellForm = new Form
            {
                Text = "Sell Medicine",
                Size = new Size(300, 300),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            Label lblMedicine = new Label { Text = "Medicine Name:", Location = new Point(20, 20), Font = new Font("Segoe UI", 10) };
            ComboBox cmbMedicine = new ComboBox { Location = new Point(20, 40), Width = 240, Font = new Font("Segoe UI", 10) };
            Label lblQuantity = new Label { Text = "Quantity to Sell:", Location = new Point(20, 80), Font = new Font("Segoe UI", 10) };
            NumericUpDown nudQuantity = new NumericUpDown { Location = new Point(20, 100), Width = 240, Font = new Font("Segoe UI", 10), Minimum = 1, Maximum = 10000 };
            Button sellBtn = new Button
            {
                Text = "Sell",
                Location = new Point(20, 140),
                Size = new Size(100, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10)
            };
            sellBtn.FlatAppearance.BorderSize = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MedicineName, Quantity FROM Medicines", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbMedicine.Items.Add(new { Name = reader["MedicineName"].ToString(), Quantity = (int)reader["Quantity"] });
                }
            }
            cmbMedicine.DisplayMember = "Name";
            cmbMedicine.ValueMember = "Quantity";

            sellBtn.Click += (s, e) =>
            {
                if (cmbMedicine.SelectedItem == null)
                {
                    MessageBox.Show("Please select a medicine.");
                    return;
                }

                var selected = (dynamic)cmbMedicine.SelectedItem;
                string medicineName = selected.Name;
                int availableQuantity = selected.Quantity;
                int sellQuantity = (int)nudQuantity.Value;

                if (sellQuantity > availableQuantity)
                {
                    MessageBox.Show($"Cannot sell {sellQuantity}. Only {availableQuantity} available.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        SqlCommand cmdUpdate = new SqlCommand("UPDATE Medicines SET Quantity = Quantity - @SellQuantity WHERE MedicineName = @MedicineName", conn, transaction);
                        cmdUpdate.Parameters.AddWithValue("@SellQuantity", sellQuantity);
                        cmdUpdate.Parameters.AddWithValue("@MedicineName", medicineName);
                        cmdUpdate.ExecuteNonQuery();

                        SqlCommand cmdInsert = new SqlCommand("INSERT INTO StockUpdates (MedicineName, UpdateType, Quantity, UpdateDate, ExpiryDate, Department) VALUES (@MedicineName, 'Sold', @SellQuantity, @UpdateDate, (SELECT ExpiryDate FROM Medicines WHERE MedicineName = @MedicineName), @Department)", conn, transaction);
                        cmdInsert.Parameters.AddWithValue("@MedicineName", medicineName);
                        cmdInsert.Parameters.AddWithValue("@SellQuantity", sellQuantity);
                        cmdInsert.Parameters.AddWithValue("@UpdateDate", DateTime.Now);
                        cmdInsert.Parameters.AddWithValue("@Department", "Pharmacy");
                        cmdInsert.ExecuteNonQuery();

                        SqlCommand cmdCheck = new SqlCommand("SELECT Quantity FROM Medicines WHERE MedicineName = @MedicineName", conn, transaction);
                        cmdCheck.Parameters.AddWithValue("@MedicineName", medicineName);
                        int remainingQuantity = (int)cmdCheck.ExecuteScalar();
                        if (remainingQuantity == 0)
                        {
                            SqlCommand cmdSoldOut = new SqlCommand("INSERT INTO StockUpdates (MedicineName, UpdateType, Quantity, UpdateDate, ExpiryDate, Department) VALUES (@MedicineName, 'SoldOut', 0, @UpdateDate, (SELECT ExpiryDate FROM Medicines WHERE MedicineName = @MedicineName), @Department)", conn, transaction);
                            cmdSoldOut.Parameters.AddWithValue("@MedicineName", medicineName);
                            cmdSoldOut.Parameters.AddWithValue("@UpdateDate", DateTime.Now);
                            cmdSoldOut.Parameters.AddWithValue("@Department", "Pharmacy");
                            cmdSoldOut.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show($"{sellQuantity} units of {medicineName} sold successfully.");
                        sellForm.Close();
                        ShowStockManagement();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error selling medicine: " + ex.Message);
                    }
                }
            };

            sellForm.Controls.AddRange(new Control[] { lblMedicine, cmbMedicine, lblQuantity, nudQuantity, sellBtn });
            sellForm.ShowDialog();
        }

        private void ShowStockAlerts()
        {
            if (contentPanel == null) return;
            contentPanel.Controls.Clear();
            Label header = new Label
            {
                Text = "Stock Alerts",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };

            DataGridView dgv = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(900, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            contentPanel.Controls.AddRange(new Control[] { header, dgv });
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MedicineName, Quantity FROM Medicines WHERE Quantity < 10", conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void ShowExpiredMedicines()
        {
            if (contentPanel == null) return;
            contentPanel.Controls.Clear();
            Label header = new Label
            {
                Text = "Expired Medicines",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };

            DataGridView dgv = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(900, 500),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            contentPanel.Controls.AddRange(new Control[] { header, dgv });
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MedicineName, ExpiryDate FROM Medicines WHERE ExpiryDate < GETDATE()", conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
        }

        private void ShowReports()
        {
            if (contentPanel == null || userRole != "Admin") return;
            contentPanel.Controls.Clear();

            Label header = new Label
            {
                Text = "Reports and Analytics",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                Size = new Size(300, 30)
            };

            DataGridView dgv = new DataGridView
            {
                Location = new Point(20, 60),
                Size = new Size(900, 300),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MedicineName, Quantity, ExpiryDate FROM Medicines", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }

            Label lblFromDate = new Label { Text = "From Date:", Location = new Point(20, 370), Font = new Font("Segoe UI", 10) };
            DateTimePicker dtpFromDate = new DateTimePicker { Location = new Point(90, 370), Width = 150, Font = new Font("Segoe UI", 10) };
            Label lblToDate = new Label { Text = "To Date:", Location = new Point(250, 370), Font = new Font("Segoe UI", 10) };
            DateTimePicker dtpToDate = new DateTimePicker { Location = new Point(320, 370), Width = 150, Font = new Font("Segoe UI", 10) };
            Button btnGeneratePDF = new Button
            {
                Text = "Generate PDF",
                Location = new Point(480, 370),
                Size = new Size(100, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10)
            };
            btnGeneratePDF.FlatAppearance.BorderSize = 0;

            Chart vennChart = new Chart
            {
                Location = new Point(20, 410),
                Size = new Size(900, 300),
                BackColor = Color.White
            };
            ChartArea chartArea = new ChartArea();
            vennChart.ChartAreas.Add(chartArea);
            Series series = new Series
            {
                ChartType = SeriesChartType.Range,
                Name = "VennDiagram"
            };
            vennChart.Series.Add(series);

            // Approximate Venn Diagram (using Range chart as a proxy since true Venn is not natively supported)
            int totalMedicines = 0, lowStock = 0, expired = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmdTotal = new SqlCommand("SELECT COUNT(*) FROM Medicines", conn);
                totalMedicines = (int)cmdTotal.ExecuteScalar();
                SqlCommand cmdLowStock = new SqlCommand("SELECT COUNT(*) FROM Medicines WHERE Quantity < 10", conn);
                lowStock = (int)cmdLowStock.ExecuteScalar();
                SqlCommand cmdExpired = new SqlCommand("SELECT COUNT(*) FROM Medicines WHERE ExpiryDate < @CurrentDate", conn);
                cmdExpired.Parameters.AddWithValue("@CurrentDate", DateTime.Now);
                expired = (int)cmdExpired.ExecuteScalar();
            }
            series.Points.AddXY("Low Stock", lowStock, lowStock + (totalMedicines - lowStock - expired));
            series.Points.AddXY("Expired", expired, expired + (totalMedicines - lowStock - expired));
            series.Points.AddXY("In Stock", totalMedicines - lowStock - expired, totalMedicines);

           

            contentPanel.Controls.AddRange(new Control[] { header, dgv, lblFromDate, dtpFromDate, lblToDate, dtpToDate, btnGeneratePDF, vennChart });
        }

        
    }
}