
namespace CourseworkDenisZhukov.Forms {
    partial class AddMovementForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovementForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.productNames = new System.Windows.Forms.ComboBox();
            this.productNamePanel = new System.Windows.Forms.Panel();
            this.countProduct = new System.Windows.Forms.TextBox();
            this.countProductPanel = new System.Windows.Forms.Panel();
            this.ImpExpPanel = new System.Windows.Forms.Panel();
            this.ImpExp = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.datePanel = new System.Windows.Forms.Panel();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.ImpExpLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fixProductBtn = new System.Windows.Forms.Button();
            this.deadStock = new System.Windows.Forms.TextBox();
            this.priceAllPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.productNamePanel.SuspendLayout();
            this.ImpExpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(502, 247);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 30);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // productNames
            // 
            this.productNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productNames.Font = new System.Drawing.Font("Tahoma", 12F);
            this.productNames.FormattingEnabled = true;
            this.productNames.Location = new System.Drawing.Point(6, 4);
            this.productNames.Name = "productNames";
            this.productNames.Size = new System.Drawing.Size(279, 27);
            this.productNames.TabIndex = 7;
            this.productNames.SelectedIndexChanged += new System.EventHandler(this.ProductsList_SelectedIndexChanged);
            // 
            // productNamePanel
            // 
            this.productNamePanel.BackColor = System.Drawing.Color.White;
            this.productNamePanel.Controls.Add(this.productNames);
            this.productNamePanel.Location = new System.Drawing.Point(6, 32);
            this.productNamePanel.Name = "productNamePanel";
            this.productNamePanel.Size = new System.Drawing.Size(288, 35);
            this.productNamePanel.TabIndex = 8;
            // 
            // countProduct
            // 
            this.countProduct.BackColor = System.Drawing.Color.White;
            this.countProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countProduct.Location = new System.Drawing.Point(302, 114);
            this.countProduct.MaxLength = 50;
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(275, 20);
            this.countProduct.TabIndex = 9;
            this.countProduct.WordWrap = false;
            this.countProduct.TextChanged += new System.EventHandler(this.CountProduct_TextChanged);
            // 
            // countProductPanel
            // 
            this.countProductPanel.BackColor = System.Drawing.Color.White;
            this.countProductPanel.Location = new System.Drawing.Point(299, 107);
            this.countProductPanel.Name = "countProductPanel";
            this.countProductPanel.Size = new System.Drawing.Size(281, 35);
            this.countProductPanel.TabIndex = 10;
            // 
            // ImpExpPanel
            // 
            this.ImpExpPanel.BackColor = System.Drawing.Color.White;
            this.ImpExpPanel.Controls.Add(this.ImpExp);
            this.ImpExpPanel.Location = new System.Drawing.Point(300, 32);
            this.ImpExpPanel.Name = "ImpExpPanel";
            this.ImpExpPanel.Size = new System.Drawing.Size(280, 35);
            this.ImpExpPanel.TabIndex = 9;
            // 
            // ImpExp
            // 
            this.ImpExp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ImpExp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ImpExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImpExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImpExp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ImpExp.FormattingEnabled = true;
            this.ImpExp.Items.AddRange(new object[] {
            "Приход",
            "Расход"});
            this.ImpExp.Location = new System.Drawing.Point(2, 5);
            this.ImpExp.Name = "ImpExp";
            this.ImpExp.Size = new System.Drawing.Size(275, 27);
            this.ImpExp.TabIndex = 7;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.date.CustomFormat = "dd.MM.yyyy";
            this.date.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(9, 114);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(283, 21);
            this.date.TabIndex = 11;
            // 
            // datePanel
            // 
            this.datePanel.BackColor = System.Drawing.Color.White;
            this.datePanel.Location = new System.Drawing.Point(6, 107);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(289, 35);
            this.datePanel.TabIndex = 10;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.productNameLabel.ForeColor = System.Drawing.Color.White;
            this.productNameLabel.Location = new System.Drawing.Point(9, 13);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(48, 16);
            this.productNameLabel.TabIndex = 12;
            this.productNameLabel.Text = "Товар:";
            // 
            // ImpExpLabel
            // 
            this.ImpExpLabel.AutoSize = true;
            this.ImpExpLabel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ImpExpLabel.ForeColor = System.Drawing.Color.White;
            this.ImpExpLabel.Location = new System.Drawing.Point(303, 13);
            this.ImpExpLabel.Name = "ImpExpLabel";
            this.ImpExpLabel.Size = new System.Drawing.Size(99, 16);
            this.ImpExpLabel.TabIndex = 13;
            this.ImpExpLabel.Text = "Приход/Расход:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(299, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Количество товара:";
            // 
            // fixProductBtn
            // 
            this.fixProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fixProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixProductBtn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.fixProductBtn.ForeColor = System.Drawing.Color.White;
            this.fixProductBtn.Location = new System.Drawing.Point(212, 244);
            this.fixProductBtn.Name = "fixProductBtn";
            this.fixProductBtn.Size = new System.Drawing.Size(175, 35);
            this.fixProductBtn.TabIndex = 16;
            this.fixProductBtn.Text = "Записать товар";
            this.fixProductBtn.UseVisualStyleBackColor = false;
            this.fixProductBtn.Click += new System.EventHandler(this.FixProduct_Click);
            // 
            // deadStock
            // 
            this.deadStock.BackColor = System.Drawing.Color.Gray;
            this.deadStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deadStock.Cursor = System.Windows.Forms.Cursors.No;
            this.deadStock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.deadStock.Location = new System.Drawing.Point(302, 185);
            this.deadStock.MaxLength = 100;
            this.deadStock.Name = "deadStock";
            this.deadStock.ReadOnly = true;
            this.deadStock.Size = new System.Drawing.Size(275, 20);
            this.deadStock.TabIndex = 17;
            this.deadStock.Text = "-";
            this.deadStock.WordWrap = false;
            // 
            // priceAllPanel
            // 
            this.priceAllPanel.BackColor = System.Drawing.Color.Gray;
            this.priceAllPanel.Location = new System.Drawing.Point(299, 178);
            this.priceAllPanel.Name = "priceAllPanel";
            this.priceAllPanel.Size = new System.Drawing.Size(281, 35);
            this.priceAllPanel.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(299, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Количество товара на складе:";
            // 
            // AddMovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.deadStock);
            this.Controls.Add(this.fixProductBtn);
            this.Controls.Add(this.priceAllPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImpExpLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ImpExpPanel);
            this.Controls.Add(this.countProduct);
            this.Controls.Add(this.datePanel);
            this.Controls.Add(this.countProductPanel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.productNamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMovementForm";
            this.Text = "ИС «Склад» - Добавить движение товара";
            this.productNamePanel.ResumeLayout(false);
            this.ImpExpPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox productNames;
        private System.Windows.Forms.Panel productNamePanel;
        private System.Windows.Forms.TextBox countProduct;
        private System.Windows.Forms.Panel countProductPanel;
        private System.Windows.Forms.Panel ImpExpPanel;
        private System.Windows.Forms.ComboBox ImpExp;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label ImpExpLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fixProductBtn;
        private System.Windows.Forms.TextBox deadStock;
        private System.Windows.Forms.Panel priceAllPanel;
        private System.Windows.Forms.Label label4;
    }
}