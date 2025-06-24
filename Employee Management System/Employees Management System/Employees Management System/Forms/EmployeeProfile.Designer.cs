namespace Employees_Management_System.Forms
{
    partial class EmployeeProfile
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnThisMonthSchedule = new System.Windows.Forms.Button();
            this.btnLeaveRequest = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.tableLayoutPanelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dgvLeaveRequests = new System.Windows.Forms.DataGridView();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.tableLayoutPanelSummary = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalDutyDays = new System.Windows.Forms.Label();
            this.lblUnexcusedAbsences = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.panelNotices = new System.Windows.Forms.Panel();
            this.tableLayoutPanelNotices = new System.Windows.Forms.TableLayoutPanel();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tableLayoutPanelDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.tableLayoutPanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequests)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.tableLayoutPanelSummary.SuspendLayout();
            this.panelNotices.SuspendLayout();
            this.tableLayoutPanelNotices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelProfile, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelButtons, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panelGrid, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.panelSummary, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.panelNotices, 0, 5);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 6;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1100, 970);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(4, 4);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1092, 52);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 10);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(236, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Employee Profile";
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelProfile.Controls.Add(this.pictureBoxProfile);
            this.panelProfile.Controls.Add(this.tableLayoutPanelDetails);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfile.Location = new System.Drawing.Point(4, 64);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(4);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Padding = new System.Windows.Forms.Padding(10);
            this.panelProfile.Size = new System.Drawing.Size(1092, 242);
            this.panelProfile.TabIndex = 1;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tableLayoutPanelDetails
            // 
            this.tableLayoutPanelDetails.ColumnCount = 2;
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 827F));
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDetails.Controls.Add(this.lblEmployeeCode, 0, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanelDetails.Controls.Add(this.lblEmail, 0, 2);
            this.tableLayoutPanelDetails.Controls.Add(this.lblPhone, 0, 3);
            this.tableLayoutPanelDetails.Controls.Add(this.lblDepartment, 0, 4);
            this.tableLayoutPanelDetails.Controls.Add(this.lblSalary, 0, 5);
            this.tableLayoutPanelDetails.Location = new System.Drawing.Point(230, 20);
            this.tableLayoutPanelDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            this.tableLayoutPanelDetails.RowCount = 6;
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDetails.Size = new System.Drawing.Size(850, 200);
            this.tableLayoutPanelDetails.TabIndex = 1;
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmployeeCode.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeCode.Location = new System.Drawing.Point(4, 0);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(74, 23);
            this.lblEmployeeCode.TabIndex = 1;
            this.lblEmployeeCode.Text = "Position:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(4, 33);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(393, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "asasa";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(4, 66);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(4, 99);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 23);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(4, 132);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(106, 23);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(4, 165);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(59, 23);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Salary:";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelButtons.Controls.Add(this.tableLayoutPanelButtons);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(4, 314);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(10);
            this.panelButtons.Size = new System.Drawing.Size(400, 132);
            this.panelButtons.TabIndex = 2;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 3;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnAttendance, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnThisMonthSchedule, 2, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnLeaveRequest, 0, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(1072, 112);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(361, 4);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(200, 50);
            this.btnAttendance.TabIndex = 8;
            this.btnAttendance.Text = "Give Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnThisMonthSchedule
            // 
            this.btnThisMonthSchedule.BackColor = System.Drawing.Color.Gold;
            this.btnThisMonthSchedule.FlatAppearance.BorderSize = 0;
            this.btnThisMonthSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonthSchedule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThisMonthSchedule.ForeColor = System.Drawing.Color.Black;
            this.btnThisMonthSchedule.Location = new System.Drawing.Point(718, 4);
            this.btnThisMonthSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnThisMonthSchedule.Name = "btnThisMonthSchedule";
            this.btnThisMonthSchedule.Size = new System.Drawing.Size(200, 50);
            this.btnThisMonthSchedule.TabIndex = 10;
            this.btnThisMonthSchedule.Text = "This Month Schedule";
            this.btnThisMonthSchedule.UseVisualStyleBackColor = false;
            this.btnThisMonthSchedule.Click += new System.EventHandler(this.btnThisMonthSchedule_Click);
            // 
            // btnLeaveRequest
            // 
            this.btnLeaveRequest.BackColor = System.Drawing.Color.Crimson;
            this.btnLeaveRequest.FlatAppearance.BorderSize = 0;
            this.btnLeaveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLeaveRequest.ForeColor = System.Drawing.Color.White;
            this.btnLeaveRequest.Location = new System.Drawing.Point(4, 4);
            this.btnLeaveRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeaveRequest.Name = "btnLeaveRequest";
            this.btnLeaveRequest.Size = new System.Drawing.Size(200, 50);
            this.btnLeaveRequest.TabIndex = 7;
            this.btnLeaveRequest.Text = "Apply Leave Request";
            this.btnLeaveRequest.UseVisualStyleBackColor = false;
            this.btnLeaveRequest.Click += new System.EventHandler(this.btnLeaveRequest_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.AutoScroll = true;
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelGrid.Controls.Add(this.tableLayoutPanelGrid);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(4, 454);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(10);
            this.panelGrid.Size = new System.Drawing.Size(1092, 292);
            this.panelGrid.TabIndex = 3;
            // 
            // tableLayoutPanelGrid
            // 
            this.tableLayoutPanelGrid.ColumnCount = 1;
            this.tableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGrid.Controls.Add(this.dgvLeaveRequests, 0, 0);
            this.tableLayoutPanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGrid.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelGrid.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelGrid.Name = "tableLayoutPanelGrid";
            this.tableLayoutPanelGrid.RowCount = 1;
            this.tableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGrid.Size = new System.Drawing.Size(1072, 272);
            this.tableLayoutPanelGrid.TabIndex = 0;
            // 
            // dgvLeaveRequests
            // 
            this.dgvLeaveRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaveRequests.Location = new System.Drawing.Point(4, 4);
            this.dgvLeaveRequests.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLeaveRequests.Name = "dgvLeaveRequests";
            this.dgvLeaveRequests.RowHeadersWidth = 51;
            this.dgvLeaveRequests.Size = new System.Drawing.Size(1064, 264);
            this.dgvLeaveRequests.TabIndex = 9;
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.panelSummary.Controls.Add(this.tableLayoutPanelSummary);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSummary.Location = new System.Drawing.Point(4, 754);
            this.panelSummary.Margin = new System.Windows.Forms.Padding(4);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(10);
            this.panelSummary.Size = new System.Drawing.Size(1092, 62);
            this.panelSummary.TabIndex = 4;
            // 
            // tableLayoutPanelSummary
            // 
            this.tableLayoutPanelSummary.ColumnCount = 3;
            this.tableLayoutPanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSummary.Controls.Add(this.lblTotalDutyDays, 0, 0);
            this.tableLayoutPanelSummary.Controls.Add(this.lblUnexcusedAbsences, 1, 0);
            this.tableLayoutPanelSummary.Controls.Add(this.lblFine, 2, 0);
            this.tableLayoutPanelSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSummary.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelSummary.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelSummary.Name = "tableLayoutPanelSummary";
            this.tableLayoutPanelSummary.RowCount = 1;
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSummary.Size = new System.Drawing.Size(1072, 42);
            this.tableLayoutPanelSummary.TabIndex = 0;
            // 
            // lblTotalDutyDays
            // 
            this.lblTotalDutyDays.AutoSize = true;
            this.lblTotalDutyDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalDutyDays.ForeColor = System.Drawing.Color.White;
            this.lblTotalDutyDays.Location = new System.Drawing.Point(4, 0);
            this.lblTotalDutyDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDutyDays.Name = "lblTotalDutyDays";
            this.lblTotalDutyDays.Size = new System.Drawing.Size(146, 23);
            this.lblTotalDutyDays.TabIndex = 11;
            this.lblTotalDutyDays.Text = "Total Duty Days: 0";
            // 
            // lblUnexcusedAbsences
            // 
            this.lblUnexcusedAbsences.AutoSize = true;
            this.lblUnexcusedAbsences.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnexcusedAbsences.ForeColor = System.Drawing.Color.White;
            this.lblUnexcusedAbsences.Location = new System.Drawing.Point(361, 0);
            this.lblUnexcusedAbsences.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnexcusedAbsences.Name = "lblUnexcusedAbsences";
            this.lblUnexcusedAbsences.Size = new System.Drawing.Size(187, 23);
            this.lblUnexcusedAbsences.TabIndex = 12;
            this.lblUnexcusedAbsences.Text = "Unexcused Absences: 0";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFine.ForeColor = System.Drawing.Color.White;
            this.lblFine.Location = new System.Drawing.Point(718, 0);
            this.lblFine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(97, 23);
            this.lblFine.TabIndex = 13;
            this.lblFine.Text = "Fine: 0 Taka";
            // 
            // panelNotices
            // 
            this.panelNotices.AutoScroll = true;
            this.panelNotices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panelNotices.Controls.Add(this.tableLayoutPanelNotices);
            this.panelNotices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotices.Location = new System.Drawing.Point(4, 824);
            this.panelNotices.Margin = new System.Windows.Forms.Padding(4);
            this.panelNotices.Name = "panelNotices";
            this.panelNotices.Padding = new System.Windows.Forms.Padding(10);
            this.panelNotices.Size = new System.Drawing.Size(1092, 142);
            this.panelNotices.TabIndex = 5;
            // 
            // tableLayoutPanelNotices
            // 
            this.tableLayoutPanelNotices.ColumnCount = 1;
            this.tableLayoutPanelNotices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNotices.Controls.Add(this.dgvNotices, 0, 0);
            this.tableLayoutPanelNotices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNotices.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelNotices.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelNotices.Name = "tableLayoutPanelNotices";
            this.tableLayoutPanelNotices.RowCount = 1;
            this.tableLayoutPanelNotices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNotices.Size = new System.Drawing.Size(1072, 122);
            this.tableLayoutPanelNotices.TabIndex = 0;
            // 
            // dgvNotices
            // 
            this.dgvNotices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.dgvNotices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNotices.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle { BackColor = System.Drawing.Color.SteelBlue, ForeColor = System.Drawing.Color.White, Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold) };
            this.dgvNotices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotices.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle { BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(90))))), ForeColor = System.Drawing.Color.White, SelectionBackColor = System.Drawing.Color.DodgerBlue, SelectionForeColor = System.Drawing.Color.White };
            this.dgvNotices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotices.Location = new System.Drawing.Point(4, 4);
            this.dgvNotices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.RowHeadersWidth = 51;
            this.dgvNotices.RowTemplate.Height = 28;
            this.dgvNotices.Size = new System.Drawing.Size(1064, 114);
            this.dgvNotices.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            this.openFileDialog1.Title = "Select Employee Image";
            // 
            // EmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1100, 970);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Profile";
            this.Load += new System.EventHandler(this.EmployeeProfile_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tableLayoutPanelDetails.ResumeLayout(false);
            this.tableLayoutPanelDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.tableLayoutPanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequests)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.tableLayoutPanelSummary.ResumeLayout(false);
            this.tableLayoutPanelSummary.PerformLayout();
            this.panelNotices.ResumeLayout(false);
            this.tableLayoutPanelNotices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button btnLeaveRequest;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnThisMonthSchedule;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGrid;
        private System.Windows.Forms.DataGridView dgvLeaveRequests;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSummary;
        private System.Windows.Forms.Label lblTotalDutyDays;
        private System.Windows.Forms.Label lblUnexcusedAbsences;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelNotices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNotices;
        private System.Windows.Forms.DataGridView dgvNotices;
    }
}