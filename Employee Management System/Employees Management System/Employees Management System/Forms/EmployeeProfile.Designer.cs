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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelProfile = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnLeaveRequest = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnThisMonthSchedule = new System.Windows.Forms.Button();
            this.tableLayoutPanelGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dgvLeaveRequests = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelSummary = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalDutyDays = new System.Windows.Forms.Label();
            this.lblUnexcusedAbsences = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelProfile.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.tableLayoutPanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequests)).BeginInit();
            this.tableLayoutPanelSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelProfile, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelGrid, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelSummary, 0, 4);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(533, 800);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelProfile
            // 
            this.tableLayoutPanelProfile.ColumnCount = 1;
            this.tableLayoutPanelProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProfile.Controls.Add(this.lblEmployeeCode, 0, 0);
            this.tableLayoutPanelProfile.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanelProfile.Controls.Add(this.lblEmail, 0, 2);
            this.tableLayoutPanelProfile.Controls.Add(this.lblPhone, 0, 3);
            this.tableLayoutPanelProfile.Controls.Add(this.lblDepartment, 0, 4);
            this.tableLayoutPanelProfile.Controls.Add(this.lblSalary, 0, 5);
            this.tableLayoutPanelProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProfile.Location = new System.Drawing.Point(4, 66);
            this.tableLayoutPanelProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelProfile.Name = "tableLayoutPanelProfile";
            this.tableLayoutPanelProfile.RowCount = 6;
            this.tableLayoutPanelProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProfile.Size = new System.Drawing.Size(525, 214);
            this.tableLayoutPanelProfile.TabIndex = 1;
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmployeeCode.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeCode.Location = new System.Drawing.Point(4, 0);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(117, 20);
            this.lblEmployeeCode.TabIndex = 1;
            this.lblEmployeeCode.Text = "Employee Code:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(4, 35);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(4, 70);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(4, 105);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(4, 140);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(92, 20);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(4, 175);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(52, 20);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Salary:";
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Controls.Add(this.btnLeaveRequest, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnAttendance, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btnThisMonthSchedule, 0, 2);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(4, 288);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 3;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(525, 140);
            this.tableLayoutPanelButtons.TabIndex = 2;
            // 
            // btnLeaveRequest
            // 
            this.btnLeaveRequest.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLeaveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaveRequest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLeaveRequest.ForeColor = System.Drawing.Color.White;
            this.btnLeaveRequest.Location = new System.Drawing.Point(4, 4);
            this.btnLeaveRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeaveRequest.Name = "btnLeaveRequest";
            this.btnLeaveRequest.Size = new System.Drawing.Size(133, 38);
            this.btnLeaveRequest.TabIndex = 7;
            this.btnLeaveRequest.Text = "Apply Leave";
            this.btnLeaveRequest.UseVisualStyleBackColor = false;
            this.btnLeaveRequest.Click += new System.EventHandler(this.btnLeaveRequest_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(4, 50);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(133, 38);
            this.btnAttendance.TabIndex = 8;
            this.btnAttendance.Text = "Give Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnThisMonthSchedule
            // 
            this.btnThisMonthSchedule.BackColor = System.Drawing.Color.MediumPurple;
            this.btnThisMonthSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonthSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThisMonthSchedule.ForeColor = System.Drawing.Color.White;
            this.btnThisMonthSchedule.Location = new System.Drawing.Point(4, 96);
            this.btnThisMonthSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThisMonthSchedule.Name = "btnThisMonthSchedule";
            this.btnThisMonthSchedule.Size = new System.Drawing.Size(133, 39);
            this.btnThisMonthSchedule.TabIndex = 10;
            this.btnThisMonthSchedule.Text = "This Month Schedule";
            this.btnThisMonthSchedule.UseVisualStyleBackColor = false;
            this.btnThisMonthSchedule.Click += new System.EventHandler(this.btnThisMonthSchedule_Click);
            // 
            // tableLayoutPanelGrid
            // 
            this.tableLayoutPanelGrid.ColumnCount = 1;
            this.tableLayoutPanelGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGrid.Controls.Add(this.dgvLeaveRequests, 0, 0);
            this.tableLayoutPanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGrid.Location = new System.Drawing.Point(4, 436);
            this.tableLayoutPanelGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelGrid.Name = "tableLayoutPanelGrid";
            this.tableLayoutPanelGrid.RowCount = 1;
            this.tableLayoutPanelGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGrid.Size = new System.Drawing.Size(525, 262);
            this.tableLayoutPanelGrid.TabIndex = 3;
            // 
            // dgvLeaveRequests
            // 
            this.dgvLeaveRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaveRequests.Location = new System.Drawing.Point(4, 4);
            this.dgvLeaveRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLeaveRequests.Name = "dgvLeaveRequests";
            this.dgvLeaveRequests.RowHeadersWidth = 51;
            this.dgvLeaveRequests.Size = new System.Drawing.Size(517, 254);
            this.dgvLeaveRequests.TabIndex = 9;
            // 
            // tableLayoutPanelSummary
            // 
            this.tableLayoutPanelSummary.ColumnCount = 1;
            this.tableLayoutPanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSummary.Controls.Add(this.lblTotalDutyDays, 0, 0);
            this.tableLayoutPanelSummary.Controls.Add(this.lblUnexcusedAbsences, 0, 1);
            this.tableLayoutPanelSummary.Controls.Add(this.lblFine, 0, 2);
            this.tableLayoutPanelSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSummary.Location = new System.Drawing.Point(4, 706);
            this.tableLayoutPanelSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelSummary.Name = "tableLayoutPanelSummary";
            this.tableLayoutPanelSummary.RowCount = 3;
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSummary.Size = new System.Drawing.Size(525, 90);
            this.tableLayoutPanelSummary.TabIndex = 4;
            // 
            // lblTotalDutyDays
            // 
            this.lblTotalDutyDays.AutoSize = true;
            this.lblTotalDutyDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalDutyDays.ForeColor = System.Drawing.Color.White;
            this.lblTotalDutyDays.Location = new System.Drawing.Point(4, 0);
            this.lblTotalDutyDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDutyDays.Name = "lblTotalDutyDays";
            this.lblTotalDutyDays.Size = new System.Drawing.Size(128, 20);
            this.lblTotalDutyDays.TabIndex = 11;
            this.lblTotalDutyDays.Text = "Total Duty Days: 0";
            // 
            // lblUnexcusedAbsences
            // 
            this.lblUnexcusedAbsences.AutoSize = true;
            this.lblUnexcusedAbsences.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUnexcusedAbsences.ForeColor = System.Drawing.Color.White;
            this.lblUnexcusedAbsences.Location = new System.Drawing.Point(4, 30);
            this.lblUnexcusedAbsences.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnexcusedAbsences.Name = "lblUnexcusedAbsences";
            this.lblUnexcusedAbsences.Size = new System.Drawing.Size(161, 20);
            this.lblUnexcusedAbsences.TabIndex = 12;
            this.lblUnexcusedAbsences.Text = "Unexcused Absences: 0";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFine.ForeColor = System.Drawing.Color.White;
            this.lblFine.Location = new System.Drawing.Point(4, 60);
            this.lblFine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(84, 20);
            this.lblFine.TabIndex = 13;
            this.lblFine.Text = "Fine: 0 Taka";
            // 
            // EmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(533, 800);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Profile";
            this.Load += new System.EventHandler(this.EmployeeProfile_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelProfile.ResumeLayout(false);
            this.tableLayoutPanelProfile.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequests)).EndInit();
            this.tableLayoutPanelSummary.ResumeLayout(false);
            this.tableLayoutPanelSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnLeaveRequest;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.DataGridView dgvLeaveRequests;
        private System.Windows.Forms.Button btnThisMonthSchedule;
        private System.Windows.Forms.Label lblTotalDutyDays;
        private System.Windows.Forms.Label lblUnexcusedAbsences;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSummary;
    }
}