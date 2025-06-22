namespace Employees_Management_System.Forms
{
    partial class LoginSelection
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
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(361, 192);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(133, 49);
            this.btnAdminLogin.TabIndex = 0;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnEmployeeLogin
            // 
            this.btnEmployeeLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEmployeeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeLogin.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeLogin.Location = new System.Drawing.Point(361, 266);
            this.btnEmployeeLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmployeeLogin.Name = "btnEmployeeLogin";
            this.btnEmployeeLogin.Size = new System.Drawing.Size(133, 49);
            this.btnEmployeeLogin.TabIndex = 1;
            this.btnEmployeeLogin.Text = "Employee Login";
            this.btnEmployeeLogin.UseVisualStyleBackColor = false;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(361, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Login:";
            // 
            // LoginSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmployeeLogin);
            this.Controls.Add(this.btnAdminLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LoginSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Selection";
            this.Load += new System.EventHandler(this.LoginSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnEmployeeLogin;
        private System.Windows.Forms.Label label1;
    }
}