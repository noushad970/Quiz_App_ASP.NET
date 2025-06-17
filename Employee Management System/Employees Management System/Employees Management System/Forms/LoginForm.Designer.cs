namespace Employees_Management_System.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer fadeTimer;

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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // Form Settings
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Opacity = 0D;

            // Title Label
            this.lblTitle.Text = "Login";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(160, 20);

            // Username Label
            this.lblUsername.Text = "Username:";
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(50, 80);
            this.lblUsername.AutoSize = true;

            // Username TextBox
            this.txtUsername.Location = new System.Drawing.Point(140, 75);
            this.txtUsername.Size = new System.Drawing.Size(200, 25);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Password Label
            this.lblPassword.Text = "Password:";
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(50, 130);
            this.lblPassword.AutoSize = true;

            // Password TextBox
            this.txtPassword.Location = new System.Drawing.Point(140, 125);
            this.txtPassword.Size = new System.Drawing.Size(200, 25);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.PasswordChar = '*';

            // Login Button
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(140, 180);
            this.btnLogin.Size = new System.Drawing.Size(200, 35);
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);

            // Fade Timer
            this.fadeTimer.Interval = 50;
            this.fadeTimer.Tick += new System.EventHandler(this.FadeTimer_Tick);
            this.fadeTimer.Start();

            // Add Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
