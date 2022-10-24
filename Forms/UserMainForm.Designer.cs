
namespace CourseworkDenisZhukov.Forms {
    partial class UserMainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            this.storageProductBtn = new System.Windows.Forms.Button();
            this.storageFileBtn = new System.Windows.Forms.Button();
            this.loggerFileBtn = new System.Windows.Forms.Button();
            this.showHistoryMovementProductsBtn = new System.Windows.Forms.Button();
            this.addMovementBtn = new System.Windows.Forms.Button();
            this.loginAccount = new System.Windows.Forms.Label();
            this.accessAccount = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.SignOutImgPanel = new System.Windows.Forms.Panel();
            this.signOutImg = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.SignOutImgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signOutImg)).BeginInit();
            this.SuspendLayout();
            // 
            // storageProductBtn
            // 
            this.storageProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.storageProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storageProductBtn.ForeColor = System.Drawing.Color.White;
            this.storageProductBtn.Location = new System.Drawing.Point(20, 60);
            this.storageProductBtn.Name = "storageProductBtn";
            this.storageProductBtn.Size = new System.Drawing.Size(134, 39);
            this.storageProductBtn.TabIndex = 0;
            this.storageProductBtn.Text = "Товар на складе";
            this.storageProductBtn.UseVisualStyleBackColor = false;
            // 
            // storageFileBtn
            // 
            this.storageFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.storageFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storageFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.storageFileBtn.ForeColor = System.Drawing.Color.White;
            this.storageFileBtn.Location = new System.Drawing.Point(20, 139);
            this.storageFileBtn.Name = "storageFileBtn";
            this.storageFileBtn.Size = new System.Drawing.Size(134, 30);
            this.storageFileBtn.TabIndex = 3;
            this.storageFileBtn.Text = "Файл склада";
            this.storageFileBtn.UseVisualStyleBackColor = false;
            // 
            // loggerFileBtn
            // 
            this.loggerFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.loggerFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggerFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.loggerFileBtn.ForeColor = System.Drawing.Color.White;
            this.loggerFileBtn.Location = new System.Drawing.Point(160, 139);
            this.loggerFileBtn.Name = "loggerFileBtn";
            this.loggerFileBtn.Size = new System.Drawing.Size(134, 30);
            this.loggerFileBtn.TabIndex = 4;
            this.loggerFileBtn.Text = "Логгер";
            this.loggerFileBtn.UseVisualStyleBackColor = false;
            // 
            // showHistoryMovementProductsBtn
            // 
            this.showHistoryMovementProductsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showHistoryMovementProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showHistoryMovementProductsBtn.ForeColor = System.Drawing.Color.White;
            this.showHistoryMovementProductsBtn.Location = new System.Drawing.Point(300, 60);
            this.showHistoryMovementProductsBtn.Name = "showHistoryMovementProductsBtn";
            this.showHistoryMovementProductsBtn.Size = new System.Drawing.Size(134, 39);
            this.showHistoryMovementProductsBtn.TabIndex = 2;
            this.showHistoryMovementProductsBtn.Text = "История движения товара";
            this.showHistoryMovementProductsBtn.UseVisualStyleBackColor = false;
            // 
            // addMovementBtn
            // 
            this.addMovementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addMovementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovementBtn.ForeColor = System.Drawing.Color.White;
            this.addMovementBtn.Location = new System.Drawing.Point(160, 60);
            this.addMovementBtn.Name = "addMovementBtn";
            this.addMovementBtn.Size = new System.Drawing.Size(134, 39);
            this.addMovementBtn.TabIndex = 1;
            this.addMovementBtn.Text = "Импорт/Экспорт товара";
            this.addMovementBtn.UseVisualStyleBackColor = false;
            // 
            // loginAccount
            // 
            this.loginAccount.AutoSize = true;
            this.loginAccount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.loginAccount.ForeColor = System.Drawing.Color.White;
            this.loginAccount.Location = new System.Drawing.Point(12, 6);
            this.loginAccount.Name = "loginAccount";
            this.loginAccount.Size = new System.Drawing.Size(53, 14);
            this.loginAccount.TabIndex = 2;
            this.loginAccount.Text = "Логин: ";
            // 
            // accessAccount
            // 
            this.accessAccount.AutoSize = true;
            this.accessAccount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.accessAccount.ForeColor = System.Drawing.Color.White;
            this.accessAccount.Location = new System.Drawing.Point(4, 24);
            this.accessAccount.Name = "accessAccount";
            this.accessAccount.Size = new System.Drawing.Size(61, 14);
            this.accessAccount.TabIndex = 1;
            this.accessAccount.Text = "Доступ: ";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.topPanel.Controls.Add(this.accessAccount);
            this.topPanel.Controls.Add(this.loginAccount);
            this.topPanel.Controls.Add(this.SignOutImgPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(444, 44);
            this.topPanel.TabIndex = 5;
            // 
            // SignOutImgPanel
            // 
            this.SignOutImgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.SignOutImgPanel.Controls.Add(this.signOutImg);
            this.SignOutImgPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOutImgPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SignOutImgPanel.Location = new System.Drawing.Point(394, 0);
            this.SignOutImgPanel.Name = "SignOutImgPanel";
            this.SignOutImgPanel.Size = new System.Drawing.Size(50, 44);
            this.SignOutImgPanel.TabIndex = 0;
            this.SignOutImgPanel.Click += new System.EventHandler(this.SignOut_Click);
            this.SignOutImgPanel.MouseEnter += new System.EventHandler(this.SignOutMouseEnter);
            this.SignOutImgPanel.MouseLeave += new System.EventHandler(this.SignOutMouseLeave);
            // 
            // signOutImg
            // 
            this.signOutImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.signOutImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutImg.Image = global::CourseworkDenisZhukov.Properties.Resources.signout;
            this.signOutImg.Location = new System.Drawing.Point(10, 7);
            this.signOutImg.Name = "signOutImg";
            this.signOutImg.Size = new System.Drawing.Size(30, 30);
            this.signOutImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signOutImg.TabIndex = 4;
            this.signOutImg.TabStop = false;
            this.signOutImg.Click += new System.EventHandler(this.SignOut_Click);
            this.signOutImg.MouseEnter += new System.EventHandler(this.SignOutMouseEnter);
            this.signOutImg.MouseLeave += new System.EventHandler(this.SignOutMouseLeave);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(444, 181);
            this.Controls.Add(this.addMovementBtn);
            this.Controls.Add(this.loggerFileBtn);
            this.Controls.Add(this.storageFileBtn);
            this.Controls.Add(this.showHistoryMovementProductsBtn);
            this.Controls.Add(this.storageProductBtn);
            this.Controls.Add(this.topPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMainForm";
            this.Text = "ИС «Склад»";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.SignOutImgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signOutImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button storageProductBtn;
        private System.Windows.Forms.Button storageFileBtn;
        private System.Windows.Forms.Button loggerFileBtn;
        private System.Windows.Forms.Button showHistoryMovementProductsBtn;
        private System.Windows.Forms.Button addMovementBtn;
        private System.Windows.Forms.Label loginAccount;
        private System.Windows.Forms.Label accessAccount;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox signOutImg;
        private System.Windows.Forms.Panel SignOutImgPanel;
    }
}

