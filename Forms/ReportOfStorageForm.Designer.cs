namespace CourseworkDenisZhukov.Forms {
    partial class ReportOfStorageForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOfStorageForm));
            this.createReportButton = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // createReportButton
            // 
            this.createReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.createReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReportButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.createReportButton.ForeColor = System.Drawing.Color.White;
            this.createReportButton.Location = new System.Drawing.Point(110, 48);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(135, 40);
            this.createReportButton.TabIndex = 0;
            this.createReportButton.Text = "Создать отчет";
            this.createReportButton.UseVisualStyleBackColor = false;
            this.createReportButton.Click += new System.EventHandler(this.CreateReport_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(252, 94);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 30);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.date.Location = new System.Drawing.Point(12, 12);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(315, 21);
            this.date.TabIndex = 5;
            // 
            // ReportOfStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(339, 136);
            this.Controls.Add(this.date);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportOfStorageForm";
            this.Text = "ИС «Склад» - Отчет об остатках";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DateTimePicker date;
    }
}