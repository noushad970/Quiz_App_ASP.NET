namespace BiogenInventorySystem
{
    partial class LoginForm
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelHeader
            this.labelHeader.Text = "Biogen Pharma Login";
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(20, 20);
            this.labelHeader.Size = new System.Drawing.Size(340, 30);
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.TabIndex = 0;

            // labelUsername
            this.labelUsername.Text = "Username:";
            this.labelUsername.Location = new System.Drawing.Point(50, 70);
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 10);
            this.labelUsername.Size = new System.Drawing.Size(80, 25);
            this.labelUsername.TabIndex = 1;

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(150, 70);
            this.txtUsername.Size = new System.Drawing.Size(200, 25);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtUsername.TabIndex = 2;

            // labelPassword
            this.labelPassword.Text = "Password:";
            this.labelPassword.Location = new System.Drawing.Point(50, 110);
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10);
            this.labelPassword.Size = new System.Drawing.Size(80, 25);
            this.labelPassword.TabIndex = 3;

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(150, 110);
            this.txtPassword.Size = new System.Drawing.Size(200, 25);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TabIndex = 4;

            // btnLogin
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(150, 160);
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.FlatAppearance.BorderSize = 0;

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biogen Pharmaceutical - Login";
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}