namespace Tapp
{
    partial class Login
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
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdLogin = new System.Windows.Forms.Button();
            this.CmdMinimize = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(73, 136);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(410, 22);
            this.TxtEmail.TabIndex = 0;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(73, 176);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '•';
            this.TxtPassword.Size = new System.Drawing.Size(410, 22);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kaushan Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 93);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tapp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kaushan Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Windows";
            // 
            // CmdLogin
            // 
            this.CmdLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.CmdLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CmdLogin.FlatAppearance.BorderSize = 0;
            this.CmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLogin.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.CmdLogin.Location = new System.Drawing.Point(167, 247);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(244, 46);
            this.CmdLogin.TabIndex = 4;
            this.CmdLogin.Text = "Login";
            this.CmdLogin.UseVisualStyleBackColor = false;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // CmdMinimize
            // 
            this.CmdMinimize.BackColor = System.Drawing.Color.Gold;
            this.CmdMinimize.FlatAppearance.BorderSize = 0;
            this.CmdMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMinimize.Location = new System.Drawing.Point(517, 6);
            this.CmdMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.CmdMinimize.Name = "CmdMinimize";
            this.CmdMinimize.Size = new System.Drawing.Size(22, 36);
            this.CmdMinimize.TabIndex = 6;
            this.CmdMinimize.Text = "—";
            this.CmdMinimize.UseVisualStyleBackColor = false;
            this.CmdMinimize.Click += new System.EventHandler(this.CmdMinimize_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.Brown;
            this.CmdClose.FlatAppearance.BorderSize = 0;
            this.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClose.Location = new System.Drawing.Point(543, 6);
            this.CmdClose.Margin = new System.Windows.Forms.Padding(2);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(23, 36);
            this.CmdClose.TabIndex = 5;
            this.CmdClose.Text = "☓";
            this.CmdClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.BackColor = System.Drawing.Color.Gray;
            this.LblError.Font = new System.Drawing.Font("Kaushan Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Maroon;
            this.LblError.Location = new System.Drawing.Point(250, 296);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(86, 30);
            this.LblError.TabIndex = 8;
            this.LblError.Text = "Windows";
            this.LblError.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.CmdLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(577, 351);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.CmdMinimize);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdLogin;
        private System.Windows.Forms.Button CmdMinimize;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Label LblError;
    }
}