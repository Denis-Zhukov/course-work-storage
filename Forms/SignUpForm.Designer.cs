namespace CourseworkDenisZhukov.Forms {
    partial class SignUpForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.TextBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordVisible = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordConfirmPanel = new System.Windows.Forms.Panel();
            this.PasswordConfirmVisible = new System.Windows.Forms.PictureBox();
            this.passwordConfirm = new System.Windows.Forms.TextBox();
            this.PasswordConfirmLabel = new System.Windows.Forms.Label();
            this.adminKey = new System.Windows.Forms.TextBox();
            this.adminKeyLabel = new System.Windows.Forms.Label();
            this.optionalLabel = new System.Windows.Forms.Label();
            this.adminKeyVisible = new System.Windows.Forms.PictureBox();
            this.passwordConfirmSuccess = new System.Windows.Forms.PictureBox();
            this.passwordSuccess = new System.Windows.Forms.PictureBox();
            this.loginSuccess = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisible)).BeginInit();
            this.passwordConfirmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordConfirmVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminKeyVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordConfirmSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.Location = new System.Drawing.Point(137, 263);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(175, 35);
            this.SignUpBtn.TabIndex = 4;
            this.SignUpBtn.Text = "Зарегистрироваться";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(351, 268);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 30);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.login);
            this.loginPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPanel.Location = new System.Drawing.Point(95, 97);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(290, 35);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Click += new System.EventHandler(this.ToLogin);
            this.loginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToLogin);
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
            this.login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.Controls.Add(this.passwordVisible);
            this.passwordPanel.Controls.Add(this.password);
            this.passwordPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordPanel.Location = new System.Drawing.Point(95, 142);
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
            this.passwordVisible.Location = new System.Drawing.Point(262, 4);
            this.passwordVisible.Name = "passwordVisible";
            this.passwordVisible.Size = new System.Drawing.Size(25, 25);
            this.passwordVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordVisible.TabIndex = 11;
            this.passwordVisible.TabStop = false;
            this.passwordVisible.Tag = "hidden";
            this.passwordVisible.Click += new System.EventHandler(this.ToggleVisible);
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
            this.password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginLabel.Location = new System.Drawing.Point(29, 105);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(65, 19);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Логин:";
            this.loginLabel.Click += new System.EventHandler(this.ToLogin);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(19, 150);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 19);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.Click += new System.EventHandler(this.ToPassword);
            // 
            // passwordConfirmPanel
            // 
            this.passwordConfirmPanel.BackColor = System.Drawing.Color.White;
            this.passwordConfirmPanel.Controls.Add(this.PasswordConfirmVisible);
            this.passwordConfirmPanel.Controls.Add(this.passwordConfirm);
            this.passwordConfirmPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordConfirmPanel.Location = new System.Drawing.Point(95, 187);
            this.passwordConfirmPanel.Name = "passwordConfirmPanel";
            this.passwordConfirmPanel.Size = new System.Drawing.Size(290, 35);
            this.passwordConfirmPanel.TabIndex = 2;
            this.passwordConfirmPanel.Click += new System.EventHandler(this.ToPasswordConfirm);
            this.passwordConfirmPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToPasswordConfirm);
            // 
            // PasswordConfirmVisible
            // 
            this.PasswordConfirmVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasswordConfirmVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordConfirmVisible.Image = global::CourseworkDenisZhukov.Properties.Resources.hidden;
            this.PasswordConfirmVisible.InitialImage = null;
            this.PasswordConfirmVisible.Location = new System.Drawing.Point(262, 5);
            this.PasswordConfirmVisible.Name = "PasswordConfirmVisible";
            this.PasswordConfirmVisible.Size = new System.Drawing.Size(25, 25);
            this.PasswordConfirmVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordConfirmVisible.TabIndex = 11;
            this.PasswordConfirmVisible.TabStop = false;
            this.PasswordConfirmVisible.Tag = "hidden";
            this.PasswordConfirmVisible.Click += new System.EventHandler(this.ToggleVisible);
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.BackColor = System.Drawing.Color.White;
            this.passwordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordConfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordConfirm.Location = new System.Drawing.Point(3, 7);
            this.passwordConfirm.MaxLength = 32;
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.PasswordChar = '*';
            this.passwordConfirm.Size = new System.Drawing.Size(284, 20);
            this.passwordConfirm.TabIndex = 0;
            this.passwordConfirm.WordWrap = false;
            this.passwordConfirm.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // PasswordConfirmLabel
            // 
            this.PasswordConfirmLabel.AutoSize = true;
            this.PasswordConfirmLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordConfirmLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PasswordConfirmLabel.Location = new System.Drawing.Point(19, 195);
            this.PasswordConfirmLabel.Name = "PasswordConfirmLabel";
            this.PasswordConfirmLabel.Size = new System.Drawing.Size(76, 19);
            this.PasswordConfirmLabel.TabIndex = 8;
            this.PasswordConfirmLabel.Text = "Пароль:";
            this.PasswordConfirmLabel.Click += new System.EventHandler(this.ToPasswordConfirm);
            // 
            // adminKey
            // 
            this.adminKey.BackColor = System.Drawing.Color.White;
            this.adminKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminKey.Font = new System.Drawing.Font("Tahoma", 10F);
            this.adminKey.Location = new System.Drawing.Point(94, 232);
            this.adminKey.MaxLength = 32;
            this.adminKey.Name = "adminKey";
            this.adminKey.PasswordChar = '*';
            this.adminKey.Size = new System.Drawing.Size(209, 17);
            this.adminKey.TabIndex = 3;
            this.adminKey.WordWrap = false;
            // 
            // adminKeyLabel
            // 
            this.adminKeyLabel.AutoSize = true;
            this.adminKeyLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.adminKeyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminKeyLabel.Location = new System.Drawing.Point(39, 232);
            this.adminKeyLabel.Name = "adminKeyLabel";
            this.adminKeyLabel.Size = new System.Drawing.Size(56, 17);
            this.adminKeyLabel.TabIndex = 7;
            this.adminKeyLabel.Text = "S-код:";
            this.adminKeyLabel.Click += new System.EventHandler(this.ToSecretKey);
            // 
            // optionalLabel
            // 
            this.optionalLabel.AutoSize = true;
            this.optionalLabel.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.optionalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.optionalLabel.Location = new System.Drawing.Point(309, 235);
            this.optionalLabel.Name = "optionalLabel";
            this.optionalLabel.Size = new System.Drawing.Size(76, 10);
            this.optionalLabel.TabIndex = 6;
            this.optionalLabel.Text = "(необязательно)";
            // 
            // adminKeyVisible
            // 
            this.adminKeyVisible.BackColor = System.Drawing.Color.White;
            this.adminKeyVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adminKeyVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminKeyVisible.Image = global::CourseworkDenisZhukov.Properties.Resources.hidden;
            this.adminKeyVisible.InitialImage = null;
            this.adminKeyVisible.Location = new System.Drawing.Point(278, 233);
            this.adminKeyVisible.Name = "adminKeyVisible";
            this.adminKeyVisible.Size = new System.Drawing.Size(25, 15);
            this.adminKeyVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminKeyVisible.TabIndex = 11;
            this.adminKeyVisible.TabStop = false;
            this.adminKeyVisible.Tag = "hidden";
            this.adminKeyVisible.Click += new System.EventHandler(this.ToggleVisible);
            // 
            // passwordConfirmSuccess
            // 
            this.passwordConfirmSuccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passwordConfirmSuccess.Image = global::CourseworkDenisZhukov.Properties.Resources.failure;
            this.passwordConfirmSuccess.InitialImage = null;
            this.passwordConfirmSuccess.Location = new System.Drawing.Point(391, 187);
            this.passwordConfirmSuccess.Name = "passwordConfirmSuccess";
            this.passwordConfirmSuccess.Size = new System.Drawing.Size(35, 35);
            this.passwordConfirmSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordConfirmSuccess.TabIndex = 11;
            this.passwordConfirmSuccess.TabStop = false;
            this.passwordConfirmSuccess.Tag = "0";
            // 
            // passwordSuccess
            // 
            this.passwordSuccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passwordSuccess.Image = global::CourseworkDenisZhukov.Properties.Resources.failure;
            this.passwordSuccess.InitialImage = null;
            this.passwordSuccess.Location = new System.Drawing.Point(391, 142);
            this.passwordSuccess.Name = "passwordSuccess";
            this.passwordSuccess.Size = new System.Drawing.Size(35, 35);
            this.passwordSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordSuccess.TabIndex = 11;
            this.passwordSuccess.TabStop = false;
            this.passwordSuccess.Tag = "0";
            // 
            // loginSuccess
            // 
            this.loginSuccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginSuccess.Image = global::CourseworkDenisZhukov.Properties.Resources.failure;
            this.loginSuccess.InitialImage = null;
            this.loginSuccess.Location = new System.Drawing.Point(391, 97);
            this.loginSuccess.Name = "loginSuccess";
            this.loginSuccess.Size = new System.Drawing.Size(35, 35);
            this.loginSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginSuccess.TabIndex = 11;
            this.loginSuccess.TabStop = false;
            this.loginSuccess.Tag = "0";
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(190, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(70, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            this.logo.Tag = "1";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.adminKeyVisible);
            this.Controls.Add(this.adminKey);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.passwordConfirmSuccess);
            this.Controls.Add(this.passwordSuccess);
            this.Controls.Add(this.loginSuccess);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.optionalLabel);
            this.Controls.Add(this.adminKeyLabel);
            this.Controls.Add(this.PasswordConfirmLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordConfirmPanel);
            this.Controls.Add(this.passwordPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Text = "ИС «Склад» - Регистрация";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordVisible)).EndInit();
            this.passwordConfirmPanel.ResumeLayout(false);
            this.passwordConfirmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordConfirmVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminKeyVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordConfirmSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel passwordConfirmPanel;
        private System.Windows.Forms.TextBox passwordConfirm;
        private System.Windows.Forms.Label PasswordConfirmLabel;
        private System.Windows.Forms.TextBox adminKey;
        private System.Windows.Forms.Label adminKeyLabel;
        private System.Windows.Forms.PictureBox loginSuccess;
        private System.Windows.Forms.PictureBox passwordSuccess;
        private System.Windows.Forms.PictureBox passwordConfirmSuccess;
        private System.Windows.Forms.Label optionalLabel;
        private System.Windows.Forms.PictureBox passwordVisible;
        private System.Windows.Forms.PictureBox PasswordConfirmVisible;
        private System.Windows.Forms.PictureBox adminKeyVisible;
    }
}