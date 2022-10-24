
namespace CourseworkDenisZhukov.Forms {
    partial class RemoveProductForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveProductForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNames = new System.Windows.Forms.ComboBox();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.productNamesPanel = new System.Windows.Forms.Panel();
            this.loadText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(497, 319);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 30);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeight = 35;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Unit,
            this.Count,
            this.PricePerUnit,
            this.PriceAll});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.EnableHeadersVisualStyles = false;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(584, 308);
            this.table.TabIndex = 5;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DividerWidth = 1;
            this.ProductName.HeaderText = " Название товара";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Unit.DividerWidth = 1;
            this.Unit.HeaderText = "Единица измерения";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Unit.Width = 75;
            // 
            // Count
            // 
            this.Count.DividerWidth = 1;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.DividerWidth = 1;
            this.PricePerUnit.HeaderText = "Цена за единицу";
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            this.PricePerUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PriceAll
            // 
            this.PriceAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PriceAll.HeaderText = "Цена за весь товар";
            this.PriceAll.Name = "PriceAll";
            this.PriceAll.ReadOnly = true;
            this.PriceAll.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PriceAll.Width = 125;
            // 
            // productNames
            // 
            this.productNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productNames.BackColor = System.Drawing.Color.White;
            this.productNames.DropDownHeight = 66;
            this.productNames.DropDownWidth = 316;
            this.productNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNames.ForeColor = System.Drawing.Color.Black;
            this.productNames.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.productNames.IntegralHeight = false;
            this.productNames.Location = new System.Drawing.Point(12, 322);
            this.productNames.MaxLength = 100;
            this.productNames.Name = "productNames";
            this.productNames.Size = new System.Drawing.Size(398, 24);
            this.productNames.TabIndex = 6;
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.deleteProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductBtn.ForeColor = System.Drawing.Color.White;
            this.deleteProductBtn.Location = new System.Drawing.Point(416, 319);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(75, 30);
            this.deleteProductBtn.TabIndex = 4;
            this.deleteProductBtn.Text = "Удалить";
            this.deleteProductBtn.UseVisualStyleBackColor = false;
            this.deleteProductBtn.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // productNamesPanel
            // 
            this.productNamesPanel.BackColor = System.Drawing.Color.White;
            this.productNamesPanel.Location = new System.Drawing.Point(12, 319);
            this.productNamesPanel.Name = "productNamesPanel";
            this.productNamesPanel.Size = new System.Drawing.Size(398, 30);
            this.productNamesPanel.TabIndex = 7;
            // 
            // loadText
            // 
            this.loadText.AutoSize = true;
            this.loadText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.loadText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.loadText.ForeColor = System.Drawing.Color.White;
            this.loadText.Location = new System.Drawing.Point(234, 160);
            this.loadText.Name = "loadText";
            this.loadText.Size = new System.Drawing.Size(131, 25);
            this.loadText.TabIndex = 8;
            this.loadText.Text = "Загрузка...";
            // 
            // RemoveProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.loadText);
            this.Controls.Add(this.productNames);
            this.Controls.Add(this.table);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.productNamesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveProductForm";
            this.Text = "ИС «Склад» - Удаление товара";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceAll;
        private System.Windows.Forms.ComboBox productNames;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Panel productNamesPanel;
        private System.Windows.Forms.Label loadText;
    }
}