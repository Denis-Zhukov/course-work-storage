namespace CourseworkDenisZhukov.Forms {
    partial class SignInForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.login = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.signInBtn = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordVisible = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.passwordIcon = new System.Windows.Forms.PictureBox();
            this.loginIcon = new System.Windows.Forms.PictureBox();
            this.signInGuestLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(3, 8);
            this.login.MaxLength = 32;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(287, 20);
            this.login.TabIndex = 0;
            this.login.WordWrap = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginLabel.Location = new System.Drawing.Point(26, 98);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(65, 19);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин:";
            this.LoginLabel.Click += new System.EventHandler(this.ToLogin);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.login);
            this.loginPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPanel.Location = new System.Drawing.Point(94, 90);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(290, 35);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Click += new System.EventHandler(this.ToLogin);
            this.loginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToLogin);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(175, 190);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(100, 35);
            this.signInBtn.TabIndex = 2;
            this.signInBtn.Text = "Войти";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PasswordLabel.Location = new System.Drawing.Point(15, 145);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 19);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль:";
            this.PasswordLabel.Click += new System.EventHandler(this.ToPassword);
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.Controls.Add(this.passwordVisible);
            this.passwordPanel.Controls.Add(this.password);
            this.passwordPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordPanel.Location = new System.Drawing.Point(94, 139);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(290, 35);
            this.passwordPanel.TabIndex = 1;
            this.passwordPanel.Click += new System.EventHandler(this.ToPassword);
            this.passwordPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToPassword);
            // 
            // passwordVisible
            // 
            this.passwordVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passwordVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordVisible.Image = global::CourseworkDenisZhukov.Properties.Resources.hidden;
            this.passwordVisible.InitialImage = null;
            this.passwordVisible.Location = new System.Drawing.Point(261, 5);
            this.passwordVisible.Name = "passwordVisible";
            this.passwordVisible.Size = new System.Drawing.Size(25, 25);
            this.passwordVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordVisible.TabIndex = 4;
            this.passwordVisible.TabStop = false;
            this.passwordVisible.Tag = "hidden";
            this.passwordVisible.Click += new System.EventHandler(this.PasswordVisible_Toggle);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(3, 7);
            this.password.MaxLength = 32;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(284, 20);
            this.password.TabIndex = 0;
            this.password.WordWrap = false;
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(190, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(70, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.signUpLabel.ForeColor = System.Drawing.Color.White;
            this.signUpLabel.Location = new System.Drawing.Point(312, 224);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(120, 13);
            this.signUpLabel.TabIndex = 3;
            this.signUpLabel.Text = "зарегистрироваться »";
            this.signUpLabel.Click += new System.EventHandler(this.SignUp_Click);
            this.signUpLabel.MouseEnter += new System.EventHandler(this.LinkedText_MouseEnter);
            this.signUpLabel.MouseLeave += new System.EventHandler(this.LinkedText_MouseLeave);
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passwordIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordIcon.Image = ((System.Drawing.Image)(resources.GetObject("passwordIcon.Image")));
            this.passwordIcon.InitialImage = null;
            this.passwordIcon.Location = new System.Drawing.Point(390, 139);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.Size = new System.Drawing.Size(35, 35);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordIcon.TabIndex = 4;
            this.passwordIcon.TabStop = false;
            this.passwordIcon.Tag = "";
            this.passwordIcon.Click += new System.EventHandler(this.ToPassword);
            // 
            // loginIcon
            // 
            this.loginIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginIcon.Image = ((System.Drawing.Image)(resources.GetObject("loginIcon.Image")));
            this.loginIcon.InitialImage = null;
            this.loginIcon.Location = new System.Drawing.Point(390, 90);
            this.loginIcon.Name = "loginIcon";
            this.loginIcon.Size = new System.Drawing.Size(35, 35);
            this.loginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginIcon.TabIndex = 4;
            this.loginIcon.TabStop = false;
            this.loginIcon.Tag = "";
            this.loginIcon.Click += new System.EventHandler(this.ToLogin);
            // 
            // signInGuestLabel
            // 
            this.signInGuestLabel.AutoSize = true;
            this.signInGuestLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInGuestLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInGuestLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.signInGuestLabel.ForeColor = System.Drawing.Color.White;
            this.signInGuestLabel.Location = new System.Drawing.Point(1, 224);
            this.signInGuestLabel.Name = "signInGuestLabel";
            this.signInGuestLabel.Size = new System.Drawing.Size(98, 13);
            this.signInGuestLabel.TabIndex = 4;
            this.signInGuestLabel.Text = "« войти как гость";
            this.signInGuestLabel.Click += new System.EventHandler(this.SignInGuest_Click);
            this.signInGuestLabel.MouseEnter += new System.EventHandler(this.LinkedText_MouseEnter);
            this.signInGuestLabel.MouseLeave += new System.EventHandler(this.LinkedText_MouseLeave);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.Controls.Add(this.signInGuestLabel);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.passwordIcon);
            this.Controls.Add(this.loginIcon);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.Text = "ИС «Склад» - Авторизация";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.PictureBox passwordIcon;
        private System.Windows.Forms.PictureBox loginIcon;
        private System.Windows.Forms.Label signInGuestLabel;
        private System.Windows.Forms.PictureBox passwordVisible;
    }
}