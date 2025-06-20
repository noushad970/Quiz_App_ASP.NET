namespace Employees_Management_System.Forms
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnEmployeeDetails = new System.Windows.Forms.Button();
            this.btnEmployeeSection = new System.Windows.Forms.Button();
            this.btnDepartmentManagement = new System.Windows.Forms.Button();
            this.btnRequestManagement = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnWorkingDates = new System.Windows.Forms.Button();
            this.btnAttendanceSummary = new System.Windows.Forms.Button();
            this.btnEmployeeReport = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelEmployeeSection = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSecretCode = new System.Windows.Forms.TextBox();
            this.lblSecretCode = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.panelEmployeeDetails = new System.Windows.Forms.Panel();
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.panelDepartmentManagement = new System.Windows.Forms.Panel();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.dgvDepartmentManagement = new System.Windows.Forms.DataGridView();
            this.panelRequestManagement = new System.Windows.Forms.Panel();
            this.btnRefreshRequests = new System.Windows.Forms.Button();
            this.dgvRequestManagement = new System.Windows.Forms.DataGridView();
            this.panelEmployeeReport = new System.Windows.Forms.Panel();
            this.btnDownloadPDF = new System.Windows.Forms.Button();
            this.txtSearchSecretCode = new System.Windows.Forms.TextBox();
            this.lblSearchSecretCode = new System.Windows.Forms.Label();
            this.dgvEmployeeReport = new System.Windows.Forms.DataGridView();
            this.panelAttendanceSummary = new System.Windows.Forms.Panel();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.lblDeduction = new System.Windows.Forms.Label();
            this.lblLeaveDays = new System.Windows.Forms.Label();
            this.lblAttendanceDays = new System.Windows.Forms.Label();
            this.btnUpdateSalary = new System.Windows.Forms.Button();
            this.cmbEmployeeCode = new System.Windows.Forms.ComboBox();
            this.lblEmployeeCodeSummary = new System.Windows.Forms.Label();
            this.panelWorkingDates = new System.Windows.Forms.Panel();
            this.btnSaveWorkingDates = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelEmployeeSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.panelDepartmentManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentManagement)).BeginInit();
            this.panelRequestManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestManagement)).BeginInit();
            this.panelEmployeeReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeReport)).BeginInit();
            this.panelAttendanceSummary.SuspendLayout();
            this.panelWorkingDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(150, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, noushad97!";
            // 
            // btnEmployeeDetails
            // 
            this.btnEmployeeDetails.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmployeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeDetails.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeDetails.Location = new System.Drawing.Point(20, 60);
            this.btnEmployeeDetails.Name = "btnEmployeeDetails";
            this.btnEmployeeDetails.Size = new System.Drawing.Size(200, 40);
            this.btnEmployeeDetails.TabIndex = 1;
            this.btnEmployeeDetails.Text = "Employee Details";
            this.btnEmployeeDetails.UseVisualStyleBackColor = false;
            this.btnEmployeeDetails.Click += new System.EventHandler(this.btnEmployeeDetails_Click);
            // 
            // btnEmployeeSection
            // 
            this.btnEmployeeSection.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmployeeSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeSection.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeSection.Location = new System.Drawing.Point(20, 110);
            this.btnEmployeeSection.Name = "btnEmployeeSection";
            this.btnEmployeeSection.Size = new System.Drawing.Size(200, 40);
            this.btnEmployeeSection.TabIndex = 2;
            this.btnEmployeeSection.Text = "Employee Section";
            this.btnEmployeeSection.UseVisualStyleBackColor = false;
            this.btnEmployeeSection.Click += new System.EventHandler(this.btnEmployeeSection_Click);
            // 
            // btnDepartmentManagement
            // 
            this.btnDepartmentManagement.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDepartmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDepartmentManagement.ForeColor = System.Drawing.Color.White;
            this.btnDepartmentManagement.Location = new System.Drawing.Point(20, 160);
            this.btnDepartmentManagement.Name = "btnDepartmentManagement";
            this.btnDepartmentManagement.Size = new System.Drawing.Size(200, 40);
            this.btnDepartmentManagement.TabIndex = 3;
            this.btnDepartmentManagement.Text = "Department Management";
            this.btnDepartmentManagement.UseVisualStyleBackColor = false;
            this.btnDepartmentManagement.Click += new System.EventHandler(this.btnDepartmentManagement_Click);
            // 
            // btnRequestManagement
            // 
            this.btnRequestManagement.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRequestManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRequestManagement.ForeColor = System.Drawing.Color.White;
            this.btnRequestManagement.Location = new System.Drawing.Point(20, 210);
            this.btnRequestManagement.Name = "btnRequestManagement";
            this.btnRequestManagement.Size = new System.Drawing.Size(200, 40);
            this.btnRequestManagement.TabIndex = 4;
            this.btnRequestManagement.Text = "Request Management";
            this.btnRequestManagement.UseVisualStyleBackColor = false;
            this.btnRequestManagement.Click += new System.EventHandler(this.btnRequestManagement_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.panelMenu.Controls.Add(this.btnWorkingDates);
            this.panelMenu.Controls.Add(this.btnAttendanceSummary);
            this.panelMenu.Controls.Add(this.btnEmployeeReport);
            this.panelMenu.Controls.Add(this.btnRequestManagement);
            this.panelMenu.Controls.Add(this.btnDepartmentManagement);
            this.panelMenu.Controls.Add(this.btnEmployeeSection);
            this.panelMenu.Controls.Add(this.btnEmployeeDetails);
            this.panelMenu.Controls.Add(this.lblWelcome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 450);
            this.panelMenu.TabIndex = 4;
            // 
            // btnWorkingDates
            // 
            this.btnWorkingDates.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWorkingDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkingDates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnWorkingDates.ForeColor = System.Drawing.Color.White;
            this.btnWorkingDates.Location = new System.Drawing.Point(20, 360);
            this.btnWorkingDates.Name = "btnWorkingDates";
            this.btnWorkingDates.Size = new System.Drawing.Size(200, 40);
            this.btnWorkingDates.TabIndex = 7;
            this.btnWorkingDates.Text = "Working Dates";
            this.btnWorkingDates.UseVisualStyleBackColor = false;
            this.btnWorkingDates.Click += new System.EventHandler(this.btnWorkingDates_Click);
            // 
            // btnAttendanceSummary
            // 
            this.btnAttendanceSummary.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAttendanceSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAttendanceSummary.ForeColor = System.Drawing.Color.White;
            this.btnAttendanceSummary.Location = new System.Drawing.Point(20, 310);
            this.btnAttendanceSummary.Name = "btnAttendanceSummary";
            this.btnAttendanceSummary.Size = new System.Drawing.Size(200, 40);
            this.btnAttendanceSummary.TabIndex = 6;
            this.btnAttendanceSummary.Text = "Attendance Summary";
            this.btnAttendanceSummary.UseVisualStyleBackColor = false;
            this.btnAttendanceSummary.Click += new System.EventHandler(this.btnAttendanceSummary_Click);
            // 
            // btnEmployeeReport
            // 
            this.btnEmployeeReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmployeeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeReport.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeReport.Location = new System.Drawing.Point(20, 260);
            this.btnEmployeeReport.Name = "btnEmployeeReport";
            this.btnEmployeeReport.Size = new System.Drawing.Size(200, 40);
            this.btnEmployeeReport.TabIndex = 5;
            this.btnEmployeeReport.Text = "Employee Report";
            this.btnEmployeeReport.UseVisualStyleBackColor = false;
            this.btnEmployeeReport.Click += new System.EventHandler(this.btnEmployeeReport_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.panelEmployeeSection);
            this.panelMain.Controls.Add(this.panelRequestManagement);
            this.panelMain.Controls.Add(this.panelDepartmentManagement);
            this.panelMain.Controls.Add(this.panelEmployeeDetails);
            this.panelMain.Controls.Add(this.panelWorkingDates);
            this.panelMain.Controls.Add(this.panelAttendanceSummary);
            this.panelMain.Controls.Add(this.panelEmployeeReport);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(240, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(560, 450);
            this.panelMain.TabIndex = 5;
            // 
            // panelEmployeeSection
            // 
            this.panelEmployeeSection.Controls.Add(this.btnDeleteEmployee);
            this.panelEmployeeSection.Controls.Add(this.btnUpdateEmployee);
            this.panelEmployeeSection.Controls.Add(this.btnAddEmployee);
            this.panelEmployeeSection.Controls.Add(this.txtSalary);
            this.panelEmployeeSection.Controls.Add(this.lblSalary);
            this.panelEmployeeSection.Controls.Add(this.txtSecretCode);
            this.panelEmployeeSection.Controls.Add(this.lblSecretCode);
            this.panelEmployeeSection.Controls.Add(this.cmbDepartment);
            this.panelEmployeeSection.Controls.Add(this.lblDepartment);
            this.panelEmployeeSection.Controls.Add(this.txtPhone);
            this.panelEmployeeSection.Controls.Add(this.lblPhone);
            this.panelEmployeeSection.Controls.Add(this.txtEmail);
            this.panelEmployeeSection.Controls.Add(this.lblEmail);
            this.panelEmployeeSection.Controls.Add(this.txtName);
            this.panelEmployeeSection.Controls.Add(this.lblName);
            this.panelEmployeeSection.Controls.Add(this.txtEmployeeCode);
            this.panelEmployeeSection.Controls.Add(this.lblEmployeeCode);
            this.panelEmployeeSection.Location = new System.Drawing.Point(0, 0);
            this.panelEmployeeSection.Name = "panelEmployeeSection";
            this.panelEmployeeSection.Size = new System.Drawing.Size(560, 450);
            this.panelEmployeeSection.TabIndex = 3;
            this.panelEmployeeSection.Visible = false;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(400, 400);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteEmployee.TabIndex = 12;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(280, 400);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateEmployee.TabIndex = 11;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(160, 400);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnAddEmployee.TabIndex = 10;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(150, 300);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 22);
            this.txtSalary.TabIndex = 9;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalary.ForeColor = System.Drawing.Color.Black;
            this.lblSalary.Location = new System.Drawing.Point(50, 300);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(47, 17);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "Salary:";
            // 
            // txtSecretCode
            // 
            this.txtSecretCode.Location = new System.Drawing.Point(150, 350);
            this.txtSecretCode.Name = "txtSecretCode";
            this.txtSecretCode.Size = new System.Drawing.Size(200, 22);
            this.txtSecretCode.TabIndex = 7;
            // 
            // lblSecretCode
            // 
            this.lblSecretCode.AutoSize = true;
            this.lblSecretCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecretCode.ForeColor = System.Drawing.Color.Black;
            this.lblSecretCode.Location = new System.Drawing.Point(50, 350);
            this.lblSecretCode.Name = "lblSecretCode";
            this.lblSecretCode.Size = new System.Drawing.Size(83, 17);
            this.lblSecretCode.TabIndex = 6;
            this.lblSecretCode.Text = "Secret Code:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(150, 250);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(200, 24);
            this.cmbDepartment.TabIndex = 5;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.ForeColor = System.Drawing.Color.Black;
            this.lblDepartment.Location = new System.Drawing.Point(50, 250);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(85, 17);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(150, 200);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(50, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 17);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(50, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(50, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(150, 50);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(200, 22);
            this.txtEmployeeCode.TabIndex = 0;
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeCode.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeCode.Location = new System.Drawing.Point(50, 50);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(100, 17);
            this.lblEmployeeCode.TabIndex = 0;
            this.lblEmployeeCode.Text = "Employee Code:";
            // 
            // panelEmployeeDetails
            // 
            this.panelEmployeeDetails.BackColor = System.Drawing.Color.White;
            this.panelEmployeeDetails.Controls.Add(this.dgvEmployeeDetails);
            this.panelEmployeeDetails.Location = new System.Drawing.Point(0, 0);
            this.panelEmployeeDetails.Name = "panelEmployeeDetails";
            this.panelEmployeeDetails.Size = new System.Drawing.Size(560, 450);
            this.panelEmployeeDetails.TabIndex = 0;
            this.panelEmployeeDetails.Visible = false;
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.AllowUserToAddRows = false;
            this.dgvEmployeeDetails.AllowUserToDeleteRows = false;
            this.dgvEmployeeDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployeeDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvEmployeeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Employee ID", Name = "EmployeeId", Visible = false },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Employee Code", Name = "EmployeeCode" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Name", Name = "Name" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Email", Name = "Email" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Phone", Name = "Phone" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Department ID", Name = "DepartmentId", Visible = false },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Secret Code", Name = "SecretCode" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { HeaderText = "Salary", Name = "Salary" },
            new System.Windows.Forms.DataGridViewButtonColumn() { HeaderText = "Update", Name = "UpdateButton", Text = "Update", UseColumnTextForButtonValue = true },
            new System.Windows.Forms.DataGridViewButtonColumn() { HeaderText = "Delete", Name = "DeleteButton", Text = "Delete", UseColumnTextForButtonValue = true }});
            this.dgvEmployeeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeDetails.EnableHeadersVisualStyles = false;
            this.dgvEmployeeDetails.GridColor = System.Drawing.Color.LightGray;
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.ReadOnly = true;
            this.dgvEmployeeDetails.RowHeadersVisible = false;
            this.dgvEmployeeDetails.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployeeDetails.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(560, 450);
            this.dgvEmployeeDetails.TabIndex = 0;
            this.dgvEmployeeDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeDetails_CellClick);
            this.dgvEmployeeDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeDetails_CellMouseEnter);
            this.dgvEmployeeDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeDetails_CellMouseLeave);
            this.dgvEmployeeDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeDetails_CellContentClick);
            // 
            // panelDepartmentManagement
            // 
            this.panelDepartmentManagement.Controls.Add(this.btnDeleteDepartment);
            this.panelDepartmentManagement.Controls.Add(this.btnUpdateDepartment);
            this.panelDepartmentManagement.Controls.Add(this.btnAddDepartment);
            this.panelDepartmentManagement.Controls.Add(this.txtDepartmentName);
            this.panelDepartmentManagement.Controls.Add(this.lblDepartmentName);
            this.panelDepartmentManagement.Controls.Add(this.dgvDepartmentManagement);
            this.panelDepartmentManagement.Location = new System.Drawing.Point(0, 0);
            this.panelDepartmentManagement.Name = "panelDepartmentManagement";
            this.panelDepartmentManagement.Size = new System.Drawing.Size(560, 450);
            this.panelDepartmentManagement.TabIndex = 1;
            this.panelDepartmentManagement.Visible = false;
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.Location = new System.Drawing.Point(400, 350);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteDepartment.TabIndex = 5;
            this.btnDeleteDepartment.Text = "Delete";
            this.btnDeleteDepartment.UseVisualStyleBackColor = false;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDepartment.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDepartment.Location = new System.Drawing.Point(280, 350);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateDepartment.TabIndex = 4;
            this.btnUpdateDepartment.Text = "Update";
            this.btnUpdateDepartment.UseVisualStyleBackColor = false;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(160, 350);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(100, 30);
            this.btnAddDepartment.TabIndex = 3;
            this.btnAddDepartment.Text = "Add";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(150, 300);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(200, 22);
            this.txtDepartmentName.TabIndex = 2;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentName.ForeColor = System.Drawing.Color.Black;
            this.lblDepartmentName.Location = new System.Drawing.Point(50, 300);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(115, 17);
            this.lblDepartmentName.TabIndex = 1;
            this.lblDepartmentName.Text = "Department Name:";
            // 
            // dgvDepartmentManagement
            // 
            this.dgvDepartmentManagement.AllowUserToAddRows = false;
            this.dgvDepartmentManagement.AllowUserToDeleteRows = false;
            this.dgvDepartmentManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartmentManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDepartmentManagement.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartmentManagement.Name = "dgvDepartmentManagement";
            this.dgvDepartmentManagement.ReadOnly = true;
            this.dgvDepartmentManagement.RowHeadersVisible = false;
            this.dgvDepartmentManagement.Size = new System.Drawing.Size(560, 250);
            this.dgvDepartmentManagement.TabIndex = 0;
            this.dgvDepartmentManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartmentManagement_CellClick);
            // 
            // panelRequestManagement
            // 
            this.panelRequestManagement.Controls.Add(this.btnRefreshRequests);
            this.panelRequestManagement.Controls.Add(this.dgvRequestManagement);
            this.panelRequestManagement.Location = new System.Drawing.Point(0, 0);
            this.panelRequestManagement.Name = "panelRequestManagement";
            this.panelRequestManagement.Size = new System.Drawing.Size(560, 450);
            this.panelRequestManagement.TabIndex = 2;
            this.panelRequestManagement.Visible = false;
            // 
            // btnRefreshRequests
            // 
            this.btnRefreshRequests.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRequests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefreshRequests.ForeColor = System.Drawing.Color.White;
            this.btnRefreshRequests.Location = new System.Drawing.Point(450, 10);
            this.btnRefreshRequests.Name = "btnRefreshRequests";
            this.btnRefreshRequests.Size = new System.Drawing.Size(100, 30);
            this.btnRefreshRequests.TabIndex = 1;
            this.btnRefreshRequests.Text = "Refresh";
            this.btnRefreshRequests.UseVisualStyleBackColor = false;
            this.btnRefreshRequests.Click += new System.EventHandler(this.btnRefreshRequests_Click);
            // 
            // dgvRequestManagement
            // 
            this.dgvRequestManagement.AllowUserToAddRows = false;
            this.dgvRequestManagement.AllowUserToDeleteRows = false;
            this.dgvRequestManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequestManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequestManagement.Location = new System.Drawing.Point(0, 0);
            this.dgvRequestManagement.Name = "dgvRequestManagement";
            this.dgvRequestManagement.ReadOnly = true;
            this.dgvRequestManagement.RowHeadersVisible = false;
            this.dgvRequestManagement.Size = new System.Drawing.Size(560, 450);
            this.dgvRequestManagement.TabIndex = 0;
            this.dgvRequestManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestManagement_CellContentClick);
            // 
            // panelEmployeeReport
            // 
            this.panelEmployeeReport.Controls.Add(this.btnDownloadPDF);
            this.panelEmployeeReport.Controls.Add(this.txtSearchSecretCode);
            this.panelEmployeeReport.Controls.Add(this.lblSearchSecretCode);
            this.panelEmployeeReport.Controls.Add(this.dgvEmployeeReport);
            this.panelEmployeeReport.Location = new System.Drawing.Point(0, 0);
            this.panelEmployeeReport.Name = "panelEmployeeReport";
            this.panelEmployeeReport.Size = new System.Drawing.Size(560, 450);
            this.panelEmployeeReport.TabIndex = 6;
            this.panelEmployeeReport.Visible = false;
            // 
            // btnDownloadPDF
            // 
            this.btnDownloadPDF.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadPDF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDownloadPDF.ForeColor = System.Drawing.Color.White;
            this.btnDownloadPDF.Location = new System.Drawing.Point(400, 50);
            this.btnDownloadPDF.Name = "btnDownloadPDF";
            this.btnDownloadPDF.Size = new System.Drawing.Size(100, 30);
            this.btnDownloadPDF.TabIndex = 3;
            this.btnDownloadPDF.Text = "Download PDF";
            this.btnDownloadPDF.UseVisualStyleBackColor = false;
            this.btnDownloadPDF.Click += new System.EventHandler(this.btnDownloadPDF_Click);
            // 
            // txtSearchSecretCode
            // 
            this.txtSearchSecretCode.Location = new System.Drawing.Point(150, 50);
            this.txtSearchSecretCode.Name = "txtSearchSecretCode";
            this.txtSearchSecretCode.Size = new System.Drawing.Size(200, 22);
            this.txtSearchSecretCode.TabIndex = 2;
            this.txtSearchSecretCode.TextChanged += new System.EventHandler(this.txtSearchSecretCode_TextChanged);
            // 
            // lblSearchSecretCode
            // 
            this.lblSearchSecretCode.AutoSize = true;
            this.lblSearchSecretCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchSecretCode.ForeColor = System.Drawing.Color.Black;
            this.lblSearchSecretCode.Location = new System.Drawing.Point(50, 50);
            this.lblSearchSecretCode.Name = "lblSearchSecretCode";
            this.lblSearchSecretCode.Size = new System.Drawing.Size(83, 17);
            this.lblSearchSecretCode.TabIndex = 1;
            this.lblSearchSecretCode.Text = "Secret Code:";
            // 
            // dgvEmployeeReport
            // 
            this.dgvEmployeeReport.AllowUserToAddRows = false;
            this.dgvEmployeeReport.AllowUserToDeleteRows = false;
            this.dgvEmployeeReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployeeReport.Location = new System.Drawing.Point(0, 100);
            this.dgvEmployeeReport.Name = "dgvEmployeeReport";
            this.dgvEmployeeReport.ReadOnly = true;
            this.dgvEmployeeReport.RowHeadersVisible = false;
            this.dgvEmployeeReport.Size = new System.Drawing.Size(560, 350);
            this.dgvEmployeeReport.TabIndex = 0;
            // 
            // panelAttendanceSummary
            // 
            this.panelAttendanceSummary.Controls.Add(this.lblTotalSalary);
            this.panelAttendanceSummary.Controls.Add(this.lblDeduction);
            this.panelAttendanceSummary.Controls.Add(this.lblLeaveDays);
            this.panelAttendanceSummary.Controls.Add(this.lblAttendanceDays);
            this.panelAttendanceSummary.Controls.Add(this.btnUpdateSalary);
            this.panelAttendanceSummary.Controls.Add(this.cmbEmployeeCode);
            this.panelAttendanceSummary.Controls.Add(this.lblEmployeeCodeSummary);
            this.panelAttendanceSummary.Location = new System.Drawing.Point(0, 0);
            this.panelAttendanceSummary.Name = "panelAttendanceSummary";
            this.panelAttendanceSummary.Size = new System.Drawing.Size(560, 450);
            this.panelAttendanceSummary.TabIndex = 7;
            this.panelAttendanceSummary.Visible = false;
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalSalary.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSalary.Location = new System.Drawing.Point(50, 200);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(80, 17);
            this.lblTotalSalary.TabIndex = 6;
            this.lblTotalSalary.Text = "Total Salary: ";
            // 
            // lblDeduction
            // 
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeduction.ForeColor = System.Drawing.Color.Black;
            this.lblDeduction.Location = new System.Drawing.Point(50, 180);
            this.lblDeduction.Name = "lblDeduction";
            this.lblDeduction.Size = new System.Drawing.Size(70, 17);
            this.lblDeduction.TabIndex = 5;
            this.lblDeduction.Text = "Deduction: ";
            // 
            // lblLeaveDays
            // 
            this.lblLeaveDays.AutoSize = true;
            this.lblLeaveDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLeaveDays.ForeColor = System.Drawing.Color.Black;
            this.lblLeaveDays.Location = new System.Drawing.Point(50, 160);
            this.lblLeaveDays.Name = "lblLeaveDays";
            this.lblLeaveDays.Size = new System.Drawing.Size(70, 17);
            this.lblLeaveDays.TabIndex = 4;
            this.lblLeaveDays.Text = "Leave Days: ";
            // 
            // lblAttendanceDays
            // 
            this.lblAttendanceDays.AutoSize = true;
            this.lblAttendanceDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceDays.ForeColor = System.Drawing.Color.Black;
            this.lblAttendanceDays.Location = new System.Drawing.Point(50, 140);
            this.lblAttendanceDays.Name = "lblAttendanceDays";
            this.lblAttendanceDays.Size = new System.Drawing.Size(100, 17);
            this.lblAttendanceDays.TabIndex = 3;
            this.lblAttendanceDays.Text = "Attendance Days: ";
            // 
            // btnUpdateSalary
            // 
            this.btnUpdateSalary.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateSalary.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSalary.Location = new System.Drawing.Point(400, 100);
            this.btnUpdateSalary.Name = "btnUpdateSalary";
            this.btnUpdateSalary.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateSalary.TabIndex = 2;
            this.btnUpdateSalary.Text = "Update Salary";
            this.btnUpdateSalary.UseVisualStyleBackColor = false;
            this.btnUpdateSalary.Click += new System.EventHandler(this.btnUpdateSalary_Click);
            // 
            // cmbEmployeeCode
            // 
            this.cmbEmployeeCode.FormattingEnabled = true;
            this.cmbEmployeeCode.Location = new System.Drawing.Point(150, 100);
            this.cmbEmployeeCode.Name = "cmbEmployeeCode";
            this.cmbEmployeeCode.Size = new System.Drawing.Size(200, 24);
            this.cmbEmployeeCode.TabIndex = 1;
            this.cmbEmployeeCode.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeCode_SelectedIndexChanged);
            // 
            // lblEmployeeCodeSummary
            // 
            this.lblEmployeeCodeSummary.AutoSize = true;
            this.lblEmployeeCodeSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeCodeSummary.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeCodeSummary.Location = new System.Drawing.Point(50, 100);
            this.lblEmployeeCodeSummary.Name = "lblEmployeeCodeSummary";
            this.lblEmployeeCodeSummary.Size = new System.Drawing.Size(100, 17);
            this.lblEmployeeCodeSummary.TabIndex = 0;
            this.lblEmployeeCodeSummary.Text = "Employee Code:";
            // 
            // panelWorkingDates
            // 
            this.panelWorkingDates.Controls.Add(this.btnSaveWorkingDates);
            this.panelWorkingDates.Controls.Add(this.monthCalendar);
            this.panelWorkingDates.Location = new System.Drawing.Point(0, 0);
            this.panelWorkingDates.Name = "panelWorkingDates";
            this.panelWorkingDates.Size = new System.Drawing.Size(560, 450);
            this.panelWorkingDates.TabIndex = 8;
            this.panelWorkingDates.Visible = false;
            // 
            // btnSaveWorkingDates
            // 
            this.btnSaveWorkingDates.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveWorkingDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWorkingDates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveWorkingDates.ForeColor = System.Drawing.Color.White;
            this.btnSaveWorkingDates.Location = new System.Drawing.Point(400, 10);
            this.btnSaveWorkingDates.Name = "btnSaveWorkingDates";
            this.btnSaveWorkingDates.Size = new System.Drawing.Size(100, 30);
            this.btnSaveWorkingDates.TabIndex = 1;
            this.btnSaveWorkingDates.Text = "Save";
            this.btnSaveWorkingDates.UseVisualStyleBackColor = false;
            this.btnSaveWorkingDates.Click += new System.EventHandler(this.btnSaveWorkingDates_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(50, 50);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // fadeTimer
            // 
            this.fadeTimer.Interval = 50;
            this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 20;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelEmployeeSection.ResumeLayout(false);
            this.panelEmployeeSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.panelDepartmentManagement.ResumeLayout(false);
            this.panelDepartmentManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentManagement)).EndInit();
            this.panelRequestManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestManagement)).EndInit();
            this.panelEmployeeReport.ResumeLayout(false);
            this.panelEmployeeReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeReport)).EndInit();
            this.panelAttendanceSummary.ResumeLayout(false);
            this.panelAttendanceSummary.PerformLayout();
            this.panelWorkingDates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnEmployeeDetails;
        private System.Windows.Forms.Button btnEmployeeSection;
        private System.Windows.Forms.Button btnDepartmentManagement;
        private System.Windows.Forms.Button btnRequestManagement;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelEmployeeDetails;
        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private System.Windows.Forms.Panel panelDepartmentManagement;
        private System.Windows.Forms.DataGridView dgvDepartmentManagement;
        private System.Windows.Forms.Panel panelRequestManagement;
        private System.Windows.Forms.DataGridView dgvRequestManagement;
        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Panel panelEmployeeSection;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSecretCode;
        private System.Windows.Forms.Label lblSecretCode;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.Button btnWorkingDates;
        private System.Windows.Forms.Button btnAttendanceSummary;
        private System.Windows.Forms.Button btnEmployeeReport;
        private System.Windows.Forms.Panel panelEmployeeReport;
        private System.Windows.Forms.Button btnDownloadPDF;
        private System.Windows.Forms.TextBox txtSearchSecretCode;
        private System.Windows.Forms.Label lblSearchSecretCode;
        private System.Windows.Forms.DataGridView dgvEmployeeReport;
        private System.Windows.Forms.Panel panelAttendanceSummary;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.Label lblDeduction;
        private System.Windows.Forms.Label lblLeaveDays;
        private System.Windows.Forms.Label lblAttendanceDays;
        private System.Windows.Forms.Button btnUpdateSalary;
        private System.Windows.Forms.ComboBox cmbEmployeeCode;
        private System.Windows.Forms.Label lblEmployeeCodeSummary;
        private System.Windows.Forms.Panel panelWorkingDates;
        private System.Windows.Forms.Button btnSaveWorkingDates;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnRefreshRequests;
    }
}