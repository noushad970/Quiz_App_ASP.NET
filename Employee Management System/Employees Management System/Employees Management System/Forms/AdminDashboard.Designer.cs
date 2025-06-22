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

            this.panelMain = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnWorkingDates = new System.Windows.Forms.Button();
            this.btnAttendanceSummary = new System.Windows.Forms.Button();
            this.btnEmployeeReport = new System.Windows.Forms.Button();
            this.btnRequestManagement = new System.Windows.Forms.Button();
            this.btnDepartmentManagement = new System.Windows.Forms.Button();
            this.btnEmployeeSection = new System.Windows.Forms.Button();
            this.btnEmployeeDetails = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelWorkingDates = new System.Windows.Forms.Panel();
            this.panelAttendanceSummary = new System.Windows.Forms.Panel();
            this.panelEmployeeReport = new System.Windows.Forms.Panel();
            this.panelRequestManagement = new System.Windows.Forms.Panel();
            this.panelDepartmentManagement = new System.Windows.Forms.Panel();
            this.panelEmployeeSection = new System.Windows.Forms.Panel();
            this.panelEmployeeDetails = new System.Windows.Forms.Panel();
            this.lblEmployeeDetailsTitle = new System.Windows.Forms.Label();
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.lblEmployeeSectionTitle = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSecretCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartmentManagementTitle = new System.Windows.Forms.Label();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDepartmentManagement = new System.Windows.Forms.DataGridView();
            this.lblRequestManagementTitle = new System.Windows.Forms.Label();
            this.btnRefreshRequests = new System.Windows.Forms.Button();
            this.dgvRequestManagement = new System.Windows.Forms.DataGridView();
            this.lblEmployeeReportTitle = new System.Windows.Forms.Label();
            this.btnDownloadPDF = new System.Windows.Forms.Button();
            this.txtSearchSecretCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvEmployeeReport = new System.Windows.Forms.DataGridView();
            this.lblAttendanceSummaryTitle = new System.Windows.Forms.Label();
            this.btnUpdateSalary = new System.Windows.Forms.Button();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDeduction = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLeaveDays = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAttendanceDays = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEmployeeCode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblWorkingDatesTitle = new System.Windows.Forms.Label();
            this.btnAddAsOffDay = new System.Windows.Forms.Button();
            this.btnAddAsWorkingDay = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panelMain.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelNavigation);
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1600, 985);
            this.panelMain.TabIndex = 0;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelNavigation.Controls.Add(this.btnWorkingDates);
            this.panelNavigation.Controls.Add(this.btnAttendanceSummary);
            this.panelNavigation.Controls.Add(this.btnEmployeeReport);
            this.panelNavigation.Controls.Add(this.btnRequestManagement);
            this.panelNavigation.Controls.Add(this.btnDepartmentManagement);
            this.panelNavigation.Controls.Add(this.btnEmployeeSection);
            this.panelNavigation.Controls.Add(this.btnEmployeeDetails);
            this.panelNavigation.Controls.Add(this.lblWelcome);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(333, 985);
            this.panelNavigation.TabIndex = 0;
            // 
            // btnWorkingDates
            // 
            this.btnWorkingDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnWorkingDates.FlatAppearance.BorderSize = 0;
            this.btnWorkingDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkingDates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnWorkingDates.ForeColor = System.Drawing.Color.White;
            this.btnWorkingDates.Location = new System.Drawing.Point(0, 492);
            this.btnWorkingDates.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkingDates.Name = "btnWorkingDates";
            this.btnWorkingDates.Size = new System.Drawing.Size(333, 62);
            this.btnWorkingDates.TabIndex = 7;
            this.btnWorkingDates.Text = "Working Dates";
            this.btnWorkingDates.UseVisualStyleBackColor = false;
            this.btnWorkingDates.Click += new System.EventHandler(this.btnWorkingDates_Click);
            // 
            // btnAttendanceSummary
            // 
            this.btnAttendanceSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnAttendanceSummary.FlatAppearance.BorderSize = 0;
            this.btnAttendanceSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAttendanceSummary.ForeColor = System.Drawing.Color.White;
            this.btnAttendanceSummary.Location = new System.Drawing.Point(0, 431);
            this.btnAttendanceSummary.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttendanceSummary.Name = "btnAttendanceSummary";
            this.btnAttendanceSummary.Size = new System.Drawing.Size(333, 62);
            this.btnAttendanceSummary.TabIndex = 6;
            this.btnAttendanceSummary.Text = "Attendance Summary";
            this.btnAttendanceSummary.UseVisualStyleBackColor = false;
            this.btnAttendanceSummary.Click += new System.EventHandler(this.btnAttendanceSummary_Click);
            // 
            // btnEmployeeReport
            // 
            this.btnEmployeeReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnEmployeeReport.FlatAppearance.BorderSize = 0;
            this.btnEmployeeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeReport.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeReport.Location = new System.Drawing.Point(0, 369);
            this.btnEmployeeReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeReport.Name = "btnEmployeeReport";
            this.btnEmployeeReport.Size = new System.Drawing.Size(333, 62);
            this.btnEmployeeReport.TabIndex = 5;
            this.btnEmployeeReport.Text = "Employee Report";
            this.btnEmployeeReport.UseVisualStyleBackColor = false;
            this.btnEmployeeReport.Click += new System.EventHandler(this.btnEmployeeReport_Click);
            // 
            // btnRequestManagement
            // 
            this.btnRequestManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnRequestManagement.FlatAppearance.BorderSize = 0;
            this.btnRequestManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRequestManagement.ForeColor = System.Drawing.Color.White;
            this.btnRequestManagement.Location = new System.Drawing.Point(0, 308);
            this.btnRequestManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequestManagement.Name = "btnRequestManagement";
            this.btnRequestManagement.Size = new System.Drawing.Size(333, 62);
            this.btnRequestManagement.TabIndex = 4;
            this.btnRequestManagement.Text = "Request Management";
            this.btnRequestManagement.UseVisualStyleBackColor = false;
            this.btnRequestManagement.Click += new System.EventHandler(this.btnRequestManagement_Click);
            // 
            // btnDepartmentManagement
            // 
            this.btnDepartmentManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnDepartmentManagement.FlatAppearance.BorderSize = 0;
            this.btnDepartmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDepartmentManagement.ForeColor = System.Drawing.Color.White;
            this.btnDepartmentManagement.Location = new System.Drawing.Point(0, 246);
            this.btnDepartmentManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepartmentManagement.Name = "btnDepartmentManagement";
            this.btnDepartmentManagement.Size = new System.Drawing.Size(333, 62);
            this.btnDepartmentManagement.TabIndex = 3;
            this.btnDepartmentManagement.Text = "Department Management";
            this.btnDepartmentManagement.UseVisualStyleBackColor = false;
            this.btnDepartmentManagement.Click += new System.EventHandler(this.btnDepartmentManagement_Click);
            // 
            // btnEmployeeSection
            // 
            this.btnEmployeeSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnEmployeeSection.FlatAppearance.BorderSize = 0;
            this.btnEmployeeSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeSection.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeSection.Location = new System.Drawing.Point(0, 185);
            this.btnEmployeeSection.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeSection.Name = "btnEmployeeSection";
            this.btnEmployeeSection.Size = new System.Drawing.Size(333, 62);
            this.btnEmployeeSection.TabIndex = 2;
            this.btnEmployeeSection.Text = "Employee Section";
            this.btnEmployeeSection.UseVisualStyleBackColor = false;
            this.btnEmployeeSection.Click += new System.EventHandler(this.btnEmployeeSection_Click);
            // 
            // btnEmployeeDetails
            // 
            this.btnEmployeeDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.btnEmployeeDetails.FlatAppearance.BorderSize = 0;
            this.btnEmployeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeDetails.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeDetails.Location = new System.Drawing.Point(0, 123);
            this.btnEmployeeDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeDetails.Name = "btnEmployeeDetails";
            this.btnEmployeeDetails.Size = new System.Drawing.Size(333, 62);
            this.btnEmployeeDetails.TabIndex = 1;
            this.btnEmployeeDetails.Text = "Employee Details";
            this.btnEmployeeDetails.UseVisualStyleBackColor = false;
            this.btnEmployeeDetails.Click += new System.EventHandler(this.btnEmployeeDetails_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(13, 12);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(179, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin!";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Controls.Add(this.panelWorkingDates);
            this.panelContent.Controls.Add(this.panelAttendanceSummary);
            this.panelContent.Controls.Add(this.panelEmployeeReport);
            this.panelContent.Controls.Add(this.panelRequestManagement);
            this.panelContent.Controls.Add(this.panelDepartmentManagement);
            this.panelContent.Controls.Add(this.panelEmployeeSection);
            this.panelContent.Controls.Add(this.panelEmployeeDetails);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1600, 985);
            this.panelContent.TabIndex = 1;
            // 
            // panelWorkingDates
            // 
            this.panelWorkingDates.Location = new System.Drawing.Point(0, 0);
            this.panelWorkingDates.Name = "panelWorkingDates";
            this.panelWorkingDates.Size = new System.Drawing.Size(200, 100);
            this.panelWorkingDates.TabIndex = 0;
            // 
            // panelAttendanceSummary
            // 
            this.panelAttendanceSummary.Location = new System.Drawing.Point(0, 0);
            this.panelAttendanceSummary.Name = "panelAttendanceSummary";
            this.panelAttendanceSummary.Size = new System.Drawing.Size(200, 100);
            this.panelAttendanceSummary.TabIndex = 1;
            // 
            // panelEmployeeReport
            // 
            this.panelEmployeeReport.Location = new System.Drawing.Point(0, 0);
            this.panelEmployeeReport.Name = "panelEmployeeReport";
            this.panelEmployeeReport.Size = new System.Drawing.Size(200, 100);
            this.panelEmployeeReport.TabIndex = 2;
            // 
            // panelRequestManagement
            // 
            this.panelRequestManagement.Location = new System.Drawing.Point(0, 0);
            this.panelRequestManagement.Name = "panelRequestManagement";
            this.panelRequestManagement.Size = new System.Drawing.Size(200, 100);
            this.panelRequestManagement.TabIndex = 3;
            // 
            // panelDepartmentManagement
            // 
            this.panelDepartmentManagement.Location = new System.Drawing.Point(0, 0);
            this.panelDepartmentManagement.Name = "panelDepartmentManagement";
            this.panelDepartmentManagement.Size = new System.Drawing.Size(200, 100);
            this.panelDepartmentManagement.TabIndex = 4;
            // 
            // panelEmployeeSection
            // 
            this.panelEmployeeSection.Location = new System.Drawing.Point(0, 0);
            this.panelEmployeeSection.Name = "panelEmployeeSection";
            this.panelEmployeeSection.Size = new System.Drawing.Size(200, 100);
            this.panelEmployeeSection.TabIndex = 5;

            // 
            // panelWorkingDates
            // 
            this.panelWorkingDates.AutoScroll = true;
            this.panelWorkingDates.BackColor = System.Drawing.Color.White;
            this.panelWorkingDates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.panelWorkingDates.Controls.Add(this.lblWorkingDatesTitle);
            //this.panelWorkingDates.Controls.Add(this.btnAddAsOffDay);
            //this.panelWorkingDates.Controls.Add(this.btnAddAsWorkingDay);
            //this.panelWorkingDates.Controls.Add(this.monthCalendar);
            this.panelWorkingDates.Location = new System.Drawing.Point(341, 12);
            this.panelWorkingDates.Margin = new System.Windows.Forms.Padding(4);
            this.panelWorkingDates.Name = "panelWorkingDates";
            this.panelWorkingDates.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelWorkingDates.Size = new System.Drawing.Size(911, 960);
            this.panelWorkingDates.TabIndex = 6;
            this.panelWorkingDates.Visible = false;

            // 
            // panelAttendanceSummary
            // 
            this.panelAttendanceSummary.AutoScroll = true;
            this.panelAttendanceSummary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAttendanceSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttendanceSummary.Controls.Add(this.lblAttendanceSummaryTitle);
            this.panelAttendanceSummary.Controls.Add(this.btnUpdateSalary);
            this.panelAttendanceSummary.Controls.Add(this.lblTotalSalary);
            this.panelAttendanceSummary.Controls.Add(this.label14);
            this.panelAttendanceSummary.Controls.Add(this.lblDeduction);
            this.panelAttendanceSummary.Controls.Add(this.label13);
            this.panelAttendanceSummary.Controls.Add(this.lblLeaveDays);
            this.panelAttendanceSummary.Controls.Add(this.label12);
            this.panelAttendanceSummary.Controls.Add(this.lblAttendanceDays);
            this.panelAttendanceSummary.Controls.Add(this.label11);
            this.panelAttendanceSummary.Controls.Add(this.cmbEmployeeCode);
            this.panelAttendanceSummary.Controls.Add(this.label10);
            this.panelAttendanceSummary.Location = new System.Drawing.Point(341, 12);
            this.panelAttendanceSummary.Margin = new System.Windows.Forms.Padding(4);
            this.panelAttendanceSummary.Name = "panelAttendanceSummary";
            this.panelAttendanceSummary.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelAttendanceSummary.Size = new System.Drawing.Size(911, 960);
            this.panelAttendanceSummary.TabIndex = 5;
            this.panelAttendanceSummary.Visible = false;

            // 
            // panelEmployeeReport
            // 
            this.panelEmployeeReport.AutoScroll = true;
            this.panelEmployeeReport.BackColor = System.Drawing.Color.White;
            this.panelEmployeeReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmployeeReport.Controls.Add(this.lblEmployeeReportTitle);
            this.panelEmployeeReport.Controls.Add(this.btnDownloadPDF);
            this.panelEmployeeReport.Controls.Add(this.txtSearchSecretCode);
            this.panelEmployeeReport.Controls.Add(this.label9);
            this.panelEmployeeReport.Controls.Add(this.dgvEmployeeReport);
            this.panelEmployeeReport.Location = new System.Drawing.Point(341, 12);
            this.panelEmployeeReport.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmployeeReport.Name = "panelEmployeeReport";
            this.panelEmployeeReport.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelEmployeeReport.Size = new System.Drawing.Size(911, 960);
            this.panelEmployeeReport.TabIndex = 4;
            this.panelEmployeeReport.Visible = false;

            // 
            // panelRequestManagement
            // 
            this.panelRequestManagement.AutoScroll = true;
            this.panelRequestManagement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRequestManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRequestManagement.Controls.Add(this.lblRequestManagementTitle);
            this.panelRequestManagement.Controls.Add(this.btnRefreshRequests);
            this.panelRequestManagement.Controls.Add(this.dgvRequestManagement);
            this.panelRequestManagement.Location = new System.Drawing.Point(341, 12);
            this.panelRequestManagement.Margin = new System.Windows.Forms.Padding(4);
            this.panelRequestManagement.Name = "panelRequestManagement";
            this.panelRequestManagement.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelRequestManagement.Size = new System.Drawing.Size(911, 960);
            this.panelRequestManagement.TabIndex = 3;
            this.panelRequestManagement.Visible = false;

            // 
            // panelDepartmentManagement
            // 
            this.panelDepartmentManagement.AutoScroll = true;
            this.panelDepartmentManagement.BackColor = System.Drawing.Color.White;
            this.panelDepartmentManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDepartmentManagement.Controls.Add(this.lblDepartmentManagementTitle);
            this.panelDepartmentManagement.Controls.Add(this.btnDeleteDepartment);
            this.panelDepartmentManagement.Controls.Add(this.btnUpdateDepartment);
            this.panelDepartmentManagement.Controls.Add(this.btnAddDepartment);
            this.panelDepartmentManagement.Controls.Add(this.txtDepartmentName);
            this.panelDepartmentManagement.Controls.Add(this.label2);
            this.panelDepartmentManagement.Controls.Add(this.dgvDepartmentManagement);
            this.panelDepartmentManagement.Location = new System.Drawing.Point(341, 12);
            this.panelDepartmentManagement.Margin = new System.Windows.Forms.Padding(4);
            this.panelDepartmentManagement.Name = "panelDepartmentManagement";
            this.panelDepartmentManagement.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelDepartmentManagement.Size = new System.Drawing.Size(911, 960);
            this.panelDepartmentManagement.TabIndex = 2;
            this.panelDepartmentManagement.Visible = false;

            // 
            // panelEmployeeSection
            // 
            this.panelEmployeeSection.AutoScroll = true;
            this.panelEmployeeSection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEmployeeSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmployeeSection.Controls.Add(this.lblEmployeeSectionTitle);
            this.panelEmployeeSection.Controls.Add(this.btnDeleteEmployee);
            this.panelEmployeeSection.Controls.Add(this.btnUpdateEmployee);
            this.panelEmployeeSection.Controls.Add(this.btnAddEmployee);
            this.panelEmployeeSection.Controls.Add(this.txtSalary);
            this.panelEmployeeSection.Controls.Add(this.label8);
            this.panelEmployeeSection.Controls.Add(this.txtSecretCode);
            this.panelEmployeeSection.Controls.Add(this.label7);
            this.panelEmployeeSection.Controls.Add(this.cmbDepartment);
            this.panelEmployeeSection.Controls.Add(this.label6);
            this.panelEmployeeSection.Controls.Add(this.txtPhone);
            this.panelEmployeeSection.Controls.Add(this.label5);
            this.panelEmployeeSection.Controls.Add(this.txtEmail);
            this.panelEmployeeSection.Controls.Add(this.label4);
            this.panelEmployeeSection.Controls.Add(this.txtName);
            this.panelEmployeeSection.Controls.Add(this.label3);
            this.panelEmployeeSection.Controls.Add(this.txtEmployeeCode);
            this.panelEmployeeSection.Controls.Add(this.label1);
            this.panelEmployeeSection.Location = new System.Drawing.Point(341, 12);
            this.panelEmployeeSection.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmployeeSection.Name = "panelEmployeeSection";
            this.panelEmployeeSection.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelEmployeeSection.Size = new System.Drawing.Size(911, 960);
            this.panelEmployeeSection.TabIndex = 1;
            this.panelEmployeeSection.Visible = false;

            // 
            // panelEmployeeDetails
            // 
            this.panelEmployeeDetails.AutoScroll = true;
            this.panelEmployeeDetails.BackColor = System.Drawing.Color.White;
            this.panelEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmployeeDetails.Controls.Add(this.lblEmployeeDetailsTitle);
            this.panelEmployeeDetails.Controls.Add(this.dgvEmployeeDetails);
            this.panelEmployeeDetails.Location = new System.Drawing.Point(341, 12);
            this.panelEmployeeDetails.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmployeeDetails.Name = "panelEmployeeDetails";
            this.panelEmployeeDetails.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelEmployeeDetails.Size = new System.Drawing.Size(911, 960);
            this.panelEmployeeDetails.TabIndex = 0;



            // 
            // lblEmployeeDetailsTitle
            // 
            this.lblEmployeeDetailsTitle.AutoSize = true;
            this.lblEmployeeDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblEmployeeDetailsTitle.Location = new System.Drawing.Point(13, 12);
            this.lblEmployeeDetailsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeDetailsTitle.Name = "lblEmployeeDetailsTitle";
            this.lblEmployeeDetailsTitle.Size = new System.Drawing.Size(176, 28);
            this.lblEmployeeDetailsTitle.TabIndex = 1;
            this.lblEmployeeDetailsTitle.Text = "Employee Details";
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.AllowUserToAddRows = false;
            this.dgvEmployeeDetails.AllowUserToDeleteRows = false;
            this.dgvEmployeeDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(13, 49);
            this.dgvEmployeeDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.ReadOnly = true;
            this.dgvEmployeeDetails.RowHeadersWidth = 51;
            this.dgvEmployeeDetails.RowTemplate.Height = 25;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(885, 898);
            this.dgvEmployeeDetails.TabIndex = 0;
            this.dgvEmployeeDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeDetails_CellClick);
            this.dgvEmployeeDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeDetails_CellContentClick);
            this.dgvEmployeeDetails.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeDetails_CellMouseEnter);
            this.dgvEmployeeDetails.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeDetails_CellMouseLeave);
            // 
            // lblEmployeeSectionTitle
            // 
            this.lblEmployeeSectionTitle.AutoSize = true;
            this.lblEmployeeSectionTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblEmployeeSectionTitle.Location = new System.Drawing.Point(13, 12);
            this.lblEmployeeSectionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeSectionTitle.Name = "lblEmployeeSectionTitle";
            this.lblEmployeeSectionTitle.Size = new System.Drawing.Size(180, 28);
            this.lblEmployeeSectionTitle.TabIndex = 17;
            this.lblEmployeeSectionTitle.Text = "Employee Section";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(360, 332);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(160, 37);
            this.btnDeleteEmployee.TabIndex = 16;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnUpdateEmployee.FlatAppearance.BorderSize = 0;
            this.btnUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(187, 332);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(160, 37);
            this.btnUpdateEmployee.TabIndex = 15;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(13, 332);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(160, 37);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSalary.Location = new System.Drawing.Point(173, 283);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(345, 30);
            this.txtSalary.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(13, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Salary:";
            // 
            // txtSecretCode
            // 
            this.txtSecretCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSecretCode.Location = new System.Drawing.Point(173, 246);
            this.txtSecretCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecretCode.Name = "txtSecretCode";
            this.txtSecretCode.Size = new System.Drawing.Size(345, 30);
            this.txtSecretCode.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(13, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Secret Code:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(173, 209);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(345, 31);
            this.cmbDepartment.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Department:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(173, 172);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(345, 30);
            this.txtPhone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(173, 135);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(173, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 30);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmployeeCode.Location = new System.Drawing.Point(173, 62);
            this.txtEmployeeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(345, 30);
            this.txtEmployeeCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Code:";
            // 
            // lblDepartmentManagementTitle
            // 
            this.lblDepartmentManagementTitle.AutoSize = true;
            this.lblDepartmentManagementTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentManagementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblDepartmentManagementTitle.Location = new System.Drawing.Point(13, 12);
            this.lblDepartmentManagementTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentManagementTitle.Name = "lblDepartmentManagementTitle";
            this.lblDepartmentManagementTitle.Size = new System.Drawing.Size(258, 28);
            this.lblDepartmentManagementTitle.TabIndex = 6;
            this.lblDepartmentManagementTitle.Text = "Department Management";
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnDeleteDepartment.FlatAppearance.BorderSize = 0;
            this.btnDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.Location = new System.Drawing.Point(360, 86);
            this.btnDeleteDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(160, 37);
            this.btnDeleteDepartment.TabIndex = 5;
            this.btnDeleteDepartment.Text = "Delete Department";
            this.btnDeleteDepartment.UseVisualStyleBackColor = false;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnUpdateDepartment.FlatAppearance.BorderSize = 0;
            this.btnUpdateDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDepartment.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDepartment.Location = new System.Drawing.Point(187, 86);
            this.btnUpdateDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(160, 37);
            this.btnUpdateDepartment.TabIndex = 4;
            this.btnUpdateDepartment.Text = "Update Department";
            this.btnUpdateDepartment.UseVisualStyleBackColor = false;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnAddDepartment.FlatAppearance.BorderSize = 0;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(13, 86);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(160, 37);
            this.btnAddDepartment.TabIndex = 3;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDepartmentName.Location = new System.Drawing.Point(173, 49);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(345, 30);
            this.txtDepartmentName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Name:";
            // 
            // dgvDepartmentManagement
            // 
            this.dgvDepartmentManagement.AllowUserToAddRows = false;
            this.dgvDepartmentManagement.AllowUserToDeleteRows = false;
            this.dgvDepartmentManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartmentManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartmentManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentManagement.Location = new System.Drawing.Point(13, 135);
            this.dgvDepartmentManagement.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepartmentManagement.Name = "dgvDepartmentManagement";
            this.dgvDepartmentManagement.ReadOnly = true;
            this.dgvDepartmentManagement.RowHeadersWidth = 51;
            this.dgvDepartmentManagement.RowTemplate.Height = 25;
            this.dgvDepartmentManagement.Size = new System.Drawing.Size(885, 800);
            this.dgvDepartmentManagement.TabIndex = 0;
            this.dgvDepartmentManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartmentManagement_CellClick);
            // 
            // lblRequestManagementTitle
            // 
            this.lblRequestManagementTitle.AutoSize = true;
            this.lblRequestManagementTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequestManagementTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblRequestManagementTitle.Location = new System.Drawing.Point(13, 12);
            this.lblRequestManagementTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestManagementTitle.Name = "lblRequestManagementTitle";
            this.lblRequestManagementTitle.Size = new System.Drawing.Size(219, 28);
            this.lblRequestManagementTitle.TabIndex = 2;
            this.lblRequestManagementTitle.Text = "Request Management";
            // 
            // btnRefreshRequests
            // 
            this.btnRefreshRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnRefreshRequests.FlatAppearance.BorderSize = 0;
            this.btnRefreshRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRequests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefreshRequests.ForeColor = System.Drawing.Color.White;
            this.btnRefreshRequests.Location = new System.Drawing.Point(27, 49);
            this.btnRefreshRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshRequests.Name = "btnRefreshRequests";
            this.btnRefreshRequests.Size = new System.Drawing.Size(160, 37);
            this.btnRefreshRequests.TabIndex = 1;
            this.btnRefreshRequests.Text = "Refresh Requests";
            this.btnRefreshRequests.UseVisualStyleBackColor = false;
            this.btnRefreshRequests.Click += new System.EventHandler(this.btnRefreshRequests_Click);
            // 
            // dgvRequestManagement
            // 
            this.dgvRequestManagement.AllowUserToAddRows = false;
            this.dgvRequestManagement.AllowUserToDeleteRows = false;
            this.dgvRequestManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequestManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequestManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestManagement.Location = new System.Drawing.Point(27, 98);
            this.dgvRequestManagement.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRequestManagement.Name = "dgvRequestManagement";
            this.dgvRequestManagement.ReadOnly = true;
            this.dgvRequestManagement.RowHeadersWidth = 51;
            this.dgvRequestManagement.RowTemplate.Height = 25;
            this.dgvRequestManagement.Size = new System.Drawing.Size(859, 837);
            this.dgvRequestManagement.TabIndex = 0;
            this.dgvRequestManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequestManagement_CellContentClick);
            // 
            // lblEmployeeReportTitle
            // 
            this.lblEmployeeReportTitle.AutoSize = true;
            this.lblEmployeeReportTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblEmployeeReportTitle.Location = new System.Drawing.Point(13, 12);
            this.lblEmployeeReportTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeReportTitle.Name = "lblEmployeeReportTitle";
            this.lblEmployeeReportTitle.Size = new System.Drawing.Size(175, 28);
            this.lblEmployeeReportTitle.TabIndex = 4;
            this.lblEmployeeReportTitle.Text = "Employee Report";
            // 
            // btnDownloadPDF
            // 
            this.btnDownloadPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnDownloadPDF.FlatAppearance.BorderSize = 0;
            this.btnDownloadPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadPDF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDownloadPDF.ForeColor = System.Drawing.Color.White;
            this.btnDownloadPDF.Location = new System.Drawing.Point(27, 98);
            this.btnDownloadPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownloadPDF.Name = "btnDownloadPDF";
            this.btnDownloadPDF.Size = new System.Drawing.Size(160, 37);
            this.btnDownloadPDF.TabIndex = 3;
            this.btnDownloadPDF.Text = "Download PDF";
            this.btnDownloadPDF.UseVisualStyleBackColor = false;
            this.btnDownloadPDF.Click += new System.EventHandler(this.btnDownloadPDF_Click);
            // 
            // txtSearchSecretCode
            // 
            this.txtSearchSecretCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchSecretCode.Location = new System.Drawing.Point(27, 62);
            this.txtSearchSecretCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchSecretCode.Name = "txtSearchSecretCode";
            this.txtSearchSecretCode.Size = new System.Drawing.Size(265, 30);
            this.txtSearchSecretCode.TabIndex = 2;
            this.txtSearchSecretCode.TextChanged += new System.EventHandler(this.txtSearchSecretCode_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(27, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Secret Code:";
            // 
            // dgvEmployeeReport
            // 
            this.dgvEmployeeReport.AllowUserToAddRows = false;
            this.dgvEmployeeReport.AllowUserToDeleteRows = false;
            this.dgvEmployeeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeReport.Location = new System.Drawing.Point(27, 148);
            this.dgvEmployeeReport.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployeeReport.Name = "dgvEmployeeReport";
            this.dgvEmployeeReport.ReadOnly = true;
            this.dgvEmployeeReport.RowHeadersWidth = 51;
            this.dgvEmployeeReport.RowTemplate.Height = 25;
            this.dgvEmployeeReport.Size = new System.Drawing.Size(859, 788);
            this.dgvEmployeeReport.TabIndex = 0;
            // 
            // lblAttendanceSummaryTitle
            // 
            this.lblAttendanceSummaryTitle.AutoSize = true;
            this.lblAttendanceSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblAttendanceSummaryTitle.Location = new System.Drawing.Point(13, 12);
            this.lblAttendanceSummaryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendanceSummaryTitle.Name = "lblAttendanceSummaryTitle";
            this.lblAttendanceSummaryTitle.Size = new System.Drawing.Size(217, 28);
            this.lblAttendanceSummaryTitle.TabIndex = 11;
            this.lblAttendanceSummaryTitle.Text = "Attendance Summary";
            // 
            // btnUpdateSalary
            // 
            this.btnUpdateSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnUpdateSalary.FlatAppearance.BorderSize = 0;
            this.btnUpdateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateSalary.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSalary.Location = new System.Drawing.Point(27, 234);
            this.btnUpdateSalary.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateSalary.Name = "btnUpdateSalary";
            this.btnUpdateSalary.Size = new System.Drawing.Size(160, 37);
            this.btnUpdateSalary.TabIndex = 10;
            this.btnUpdateSalary.Text = "Update Salary";
            this.btnUpdateSalary.UseVisualStyleBackColor = false;
            this.btnUpdateSalary.Click += new System.EventHandler(this.btnUpdateSalary_Click);
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalSalary.Location = new System.Drawing.Point(27, 209);
            this.lblTotalSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(114, 23);
            this.lblTotalSalary.TabIndex = 9;
            this.lblTotalSalary.Text = "Total Salary: 0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(27, 185);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Total Salary:";
            // 
            // lblDeduction
            // 
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeduction.Location = new System.Drawing.Point(27, 160);
            this.lblDeduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeduction.Name = "lblDeduction";
            this.lblDeduction.Size = new System.Drawing.Size(107, 23);
            this.lblDeduction.TabIndex = 7;
            this.lblDeduction.Text = "Deduction: 0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(27, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "Deduction:";
            // 
            // lblLeaveDays
            // 
            this.lblLeaveDays.AutoSize = true;
            this.lblLeaveDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLeaveDays.Location = new System.Drawing.Point(27, 111);
            this.lblLeaveDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeaveDays.Name = "lblLeaveDays";
            this.lblLeaveDays.Size = new System.Drawing.Size(112, 23);
            this.lblLeaveDays.TabIndex = 5;
            this.lblLeaveDays.Text = "Leave Days: 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(27, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Leave Days:";
            // 
            // lblAttendanceDays
            // 
            this.lblAttendanceDays.AutoSize = true;
            this.lblAttendanceDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAttendanceDays.Location = new System.Drawing.Point(27, 62);
            this.lblAttendanceDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendanceDays.Name = "lblAttendanceDays";
            this.lblAttendanceDays.Size = new System.Drawing.Size(157, 23);
            this.lblAttendanceDays.TabIndex = 3;
            this.lblAttendanceDays.Text = "Attendance Days: 0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(27, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Attendance Days:";
            // 
            // cmbEmployeeCode
            // 
            this.cmbEmployeeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmployeeCode.FormattingEnabled = true;
            this.cmbEmployeeCode.Location = new System.Drawing.Point(27, 160);
            this.cmbEmployeeCode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmployeeCode.Name = "cmbEmployeeCode";
            this.cmbEmployeeCode.Size = new System.Drawing.Size(265, 31);
            this.cmbEmployeeCode.TabIndex = 1;
            this.cmbEmployeeCode.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeCode_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(27, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Employee Code:";
            // 
            // lblWorkingDatesTitle
            // 
            this.lblWorkingDatesTitle.AutoSize = true;
            this.lblWorkingDatesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWorkingDatesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblWorkingDatesTitle.Location = new System.Drawing.Point(341, 12);
            this.lblWorkingDatesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkingDatesTitle.Name = "lblWorkingDatesTitle";
            this.lblWorkingDatesTitle.Size = new System.Drawing.Size(911, 960);
            this.lblWorkingDatesTitle.TabIndex = 3;
            this.lblWorkingDatesTitle.Text = "Working Dates";
            // 
            // btnAddAsOffDay
            // 
            this.btnAddAsOffDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnAddAsOffDay.FlatAppearance.BorderSize = 0;
            this.btnAddAsOffDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAsOffDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddAsOffDay.ForeColor = System.Drawing.Color.White;
            this.btnAddAsOffDay.Location = new System.Drawing.Point(200, 271);
            this.btnAddAsOffDay.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAsOffDay.Name = "btnAddAsOffDay";
            this.btnAddAsOffDay.Size = new System.Drawing.Size(160, 37);
            this.btnAddAsOffDay.TabIndex = 2;
            this.btnAddAsOffDay.Text = "Add as Off Day";
            this.btnAddAsOffDay.UseVisualStyleBackColor = false;
            this.btnAddAsOffDay.Click += new System.EventHandler(this.btnAddAsOffDay_Click);
            // 
            // btnAddAsWorkingDay
            // 
            this.btnAddAsWorkingDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnAddAsWorkingDay.FlatAppearance.BorderSize = 0;
            this.btnAddAsWorkingDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAsWorkingDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddAsWorkingDay.ForeColor = System.Drawing.Color.White;
            this.btnAddAsWorkingDay.Location = new System.Drawing.Point(27, 271);
            this.btnAddAsWorkingDay.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAsWorkingDay.Name = "btnAddAsWorkingDay";
            this.btnAddAsWorkingDay.Size = new System.Drawing.Size(160, 37);
            this.btnAddAsWorkingDay.TabIndex = 1;
            this.btnAddAsWorkingDay.Text = "Add as Working Day";
            this.btnAddAsWorkingDay.UseVisualStyleBackColor = false;
            this.btnAddAsWorkingDay.Click += new System.EventHandler(this.btnAddAsWorkingDay_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(27, 49);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 985);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelMain.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelEmployeeDetails.ResumeLayout(false);
            this.panelEmployeeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnWorkingDates;
        private System.Windows.Forms.Button btnAttendanceSummary;
        private System.Windows.Forms.Button btnEmployeeReport;
        private System.Windows.Forms.Button btnRequestManagement;
        private System.Windows.Forms.Button btnDepartmentManagement;
        private System.Windows.Forms.Button btnEmployeeSection;
        private System.Windows.Forms.Button btnEmployeeDetails;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelWorkingDates;
        private System.Windows.Forms.Label lblWorkingDatesTitle;
        private System.Windows.Forms.Button btnAddAsOffDay;
        private System.Windows.Forms.Button btnAddAsWorkingDay;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Panel panelAttendanceSummary;
        private System.Windows.Forms.Label lblAttendanceSummaryTitle;
        private System.Windows.Forms.Button btnUpdateSalary;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDeduction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblLeaveDays;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAttendanceDays;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEmployeeCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelEmployeeReport;
        private System.Windows.Forms.Label lblEmployeeReportTitle;
        private System.Windows.Forms.Button btnDownloadPDF;
        private System.Windows.Forms.TextBox txtSearchSecretCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvEmployeeReport;
        private System.Windows.Forms.Panel panelRequestManagement;
        private System.Windows.Forms.Label lblRequestManagementTitle;
        private System.Windows.Forms.Button btnRefreshRequests;
        private System.Windows.Forms.DataGridView dgvRequestManagement;
        private System.Windows.Forms.Panel panelDepartmentManagement;
        private System.Windows.Forms.Label lblDepartmentManagementTitle;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDepartmentManagement;
        private System.Windows.Forms.Panel panelEmployeeSection;
        private System.Windows.Forms.Label lblEmployeeSectionTitle;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSecretCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEmployeeDetails;
        private System.Windows.Forms.Label lblEmployeeDetailsTitle;
        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
    }
}