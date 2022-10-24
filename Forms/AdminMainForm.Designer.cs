
namespace CourseworkDenisZhukov.Forms {
    partial class AdminMainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.storageProductBtn = new System.Windows.Forms.Button();
            this.fixStorageProductBtn = new System.Windows.Forms.Button();
            this.removeFromStorageBtn = new System.Windows.Forms.Button();
            this.storageFileBtn = new System.Windows.Forms.Button();
            this.importExportFileBtn = new System.Windows.Forms.Button();
            this.loggerFileBtn = new System.Windows.Forms.Button();
            this.showHistoryMovementProductsBtn = new System.Windows.Forms.Button();
            this.addMovementBtn = new System.Windows.Forms.Button();
            this.loginAccountLabel = new System.Windows.Forms.Label();
            this.accessAccountLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.signOutImgPanel = new System.Windows.Forms.Panel();
            this.signOutImg = new System.Windows.Forms.PictureBox();
            this.findProductBtn = new System.Windows.Forms.Button();
            this.reportOfStorageBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.signOutImgPanel.SuspendLayout();
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
            // fixStorageProductBtn
            // 
            this.fixStorageProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fixStorageProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixStorageProductBtn.ForeColor = System.Drawing.Color.White;
            this.fixStorageProductBtn.Location = new System.Drawing.Point(20, 110);
            this.fixStorageProductBtn.Name = "fixStorageProductBtn";
            this.fixStorageProductBtn.Size = new System.Drawing.Size(134, 39);
            this.fixStorageProductBtn.TabIndex = 3;
            this.fixStorageProductBtn.Text = "Зафиксировать товар на складе";
            this.fixStorageProductBtn.UseVisualStyleBackColor = false;
            // 
            // removeFromStorageBtn
            // 
            this.removeFromStorageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.removeFromStorageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFromStorageBtn.ForeColor = System.Drawing.Color.White;
            this.removeFromStorageBtn.Location = new System.Drawing.Point(20, 160);
            this.removeFromStorageBtn.Name = "removeFromStorageBtn";
            this.removeFromStorageBtn.Size = new System.Drawing.Size(134, 39);
            this.removeFromStorageBtn.TabIndex = 6;
            this.removeFromStorageBtn.Text = "Удалить товар со склада";
            this.removeFromStorageBtn.UseVisualStyleBackColor = false;
            // 
            // storageFileBtn
            // 
            this.storageFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.storageFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storageFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.storageFileBtn.ForeColor = System.Drawing.Color.White;
            this.storageFileBtn.Location = new System.Drawing.Point(20, 239);
            this.storageFileBtn.Name = "storageFileBtn";
            this.storageFileBtn.Size = new System.Drawing.Size(146, 30);
            this.storageFileBtn.TabIndex = 7;
            this.storageFileBtn.Text = "Файл склада";
            this.storageFileBtn.UseVisualStyleBackColor = false;
            // 
            // importExportFileBtn
            // 
            this.importExportFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.importExportFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importExportFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.importExportFileBtn.ForeColor = System.Drawing.Color.White;
            this.importExportFileBtn.Location = new System.Drawing.Point(172, 239);
            this.importExportFileBtn.Name = "importExportFileBtn";
            this.importExportFileBtn.Size = new System.Drawing.Size(148, 30);
            this.importExportFileBtn.TabIndex = 8;
            this.importExportFileBtn.Text = "Файл движение товара";
            this.importExportFileBtn.UseVisualStyleBackColor = false;
            // 
            // loggerFileBtn
            // 
            this.loggerFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.loggerFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loggerFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.loggerFileBtn.ForeColor = System.Drawing.Color.White;
            this.loggerFileBtn.Location = new System.Drawing.Point(326, 239);
            this.loggerFileBtn.Name = "loggerFileBtn";
            this.loggerFileBtn.Size = new System.Drawing.Size(153, 30);
            this.loggerFileBtn.TabIndex = 9;
            this.loggerFileBtn.Text = "Логгер";
            this.loggerFileBtn.UseVisualStyleBackColor = false;
            // 
            // showHistoryMovementProductsBtn
            // 
            this.showHistoryMovementProductsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showHistoryMovementProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showHistoryMovementProductsBtn.ForeColor = System.Drawing.Color.White;
            this.showHistoryMovementProductsBtn.Location = new System.Drawing.Point(180, 60);
            this.showHistoryMovementProductsBtn.Name = "showHistoryMovementProductsBtn";
            this.showHistoryMovementProductsBtn.Size = new System.Drawing.Size(134, 39);
            this.showHistoryMovementProductsBtn.TabIndex = 1;
            this.showHistoryMovementProductsBtn.Text = "История движения товара";
            this.showHistoryMovementProductsBtn.UseVisualStyleBackColor = false;
            // 
            // addMovementBtn
            // 
            this.addMovementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addMovementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovementBtn.ForeColor = System.Drawing.Color.White;
            this.addMovementBtn.Location = new System.Drawing.Point(180, 110);
            this.addMovementBtn.Name = "addMovementBtn";
            this.addMovementBtn.Size = new System.Drawing.Size(134, 39);
            this.addMovementBtn.TabIndex = 4;
            this.addMovementBtn.Text = "Импорт/Экспорт товара";
            this.addMovementBtn.UseVisualStyleBackColor = false;
            // 
            // loginAccountLabel
            // 
            this.loginAccountLabel.AutoSize = true;
            this.loginAccountLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.loginAccountLabel.ForeColor = System.Drawing.Color.White;
            this.loginAccountLabel.Location = new System.Drawing.Point(12, 6);
            this.loginAccountLabel.Name = "loginAccountLabel";
            this.loginAccountLabel.Size = new System.Drawing.Size(53, 14);
            this.loginAccountLabel.TabIndex = 1;
            this.loginAccountLabel.Text = "Логин: ";
            // 
            // accessAccountLabel
            // 
            this.accessAccountLabel.AutoSize = true;
            this.accessAccountLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.accessAccountLabel.ForeColor = System.Drawing.Color.White;
            this.accessAccountLabel.Location = new System.Drawing.Point(4, 24);
            this.accessAccountLabel.Name = "accessAccountLabel";
            this.accessAccountLabel.Size = new System.Drawing.Size(61, 14);
            this.accessAccountLabel.TabIndex = 2;
            this.accessAccountLabel.Text = "Доступ: ";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.topPanel.Controls.Add(this.accessAccountLabel);
            this.topPanel.Controls.Add(this.loginAccountLabel);
            this.topPanel.Controls.Add(this.signOutImgPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(489, 44);
            this.topPanel.TabIndex = 4;
            // 
            // signOutImgPanel
            // 
            this.signOutImgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.signOutImgPanel.Controls.Add(this.signOutImg);
            this.signOutImgPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutImgPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.signOutImgPanel.Location = new System.Drawing.Point(439, 0);
            this.signOutImgPanel.Name = "signOutImgPanel";
            this.signOutImgPanel.Size = new System.Drawing.Size(50, 44);
            this.signOutImgPanel.TabIndex = 0;
            this.signOutImgPanel.Click += new System.EventHandler(this.SignOut_Click);
            this.signOutImgPanel.MouseEnter += new System.EventHandler(this.SignOutMouseEnter);
            this.signOutImgPanel.MouseLeave += new System.EventHandler(this.SignOutMouseLeave);
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
            // findProductBtn
            // 
            this.findProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.findProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findProductBtn.ForeColor = System.Drawing.Color.White;
            this.findProductBtn.Location = new System.Drawing.Point(340, 60);
            this.findProductBtn.Name = "findProductBtn";
            this.findProductBtn.Size = new System.Drawing.Size(134, 39);
            this.findProductBtn.TabIndex = 2;
            this.findProductBtn.Text = "Поиск товара";
            this.findProductBtn.UseVisualStyleBackColor = false;
            this.findProductBtn.Click += new System.EventHandler(this.FindProduct_Click);
            // 
            // reportOfStorageBtn
            // 
            this.reportOfStorageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reportOfStorageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportOfStorageBtn.ForeColor = System.Drawing.Color.White;
            this.reportOfStorageBtn.Location = new System.Drawing.Point(340, 110);
            this.reportOfStorageBtn.Name = "reportOfStorageBtn";
            this.reportOfStorageBtn.Size = new System.Drawing.Size(134, 39);
            this.reportOfStorageBtn.TabIndex = 5;
            this.reportOfStorageBtn.Text = "Отчет об остатках";
            this.reportOfStorageBtn.UseVisualStyleBackColor = false;
            this.reportOfStorageBtn.Click += new System.EventHandler(this.ReportOfStorageButton_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(489, 281);
            this.Controls.Add(this.addMovementBtn);
            this.Controls.Add(this.loggerFileBtn);
            this.Controls.Add(this.importExportFileBtn);
            this.Controls.Add(this.storageFileBtn);
            this.Controls.Add(this.removeFromStorageBtn);
            this.Controls.Add(this.fixStorageProductBtn);
            this.Controls.Add(this.reportOfStorageBtn);
            this.Controls.Add(this.findProductBtn);
            this.Controls.Add(this.showHistoryMovementProductsBtn);
            this.Controls.Add(this.storageProductBtn);
            this.Controls.Add(this.topPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMainForm";
            this.Text = "ИС «Склад»";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.signOutImgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signOutImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button storageProductBtn;
        private System.Windows.Forms.Button fixStorageProductBtn;
        private System.Windows.Forms.Button removeFromStorageBtn;
        private System.Windows.Forms.Button storageFileBtn;
        private System.Windows.Forms.Button importExportFileBtn;
        private System.Windows.Forms.Button loggerFileBtn;
        private System.Windows.Forms.Button showHistoryMovementProductsBtn;
        private System.Windows.Forms.Button addMovementBtn;
        private System.Windows.Forms.Label loginAccountLabel;
        private System.Windows.Forms.Label accessAccountLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox signOutImg;
        private System.Windows.Forms.Panel signOutImgPanel;
        private System.Windows.Forms.Button findProductBtn;
        private System.Windows.Forms.Button reportOfStorageBtn;
    }
}

