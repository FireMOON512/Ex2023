﻿namespace Ex2023
{
    partial class Del_data
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Del_data));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.trade2023DataSet1 = new Ex2023.Trade2023DataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Ex2023.Trade2023DataSet1TableAdapters.ProductTableAdapter();
            this.productArticleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDiscountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productProviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCurrentDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trade2023DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 100);
            this.panel2.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnBack.Location = new System.Drawing.Point(803, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 54);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.button1.Location = new System.Drawing.Point(30, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить выбранное";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(327, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 39);
            this.label10.TabIndex = 4;
            this.label10.Text = "ООО «Рыбалка»";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 81);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productArticleNumberDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productUnitDataGridViewTextBoxColumn,
            this.productCostDataGridViewTextBoxColumn,
            this.productDiscountAmountDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productProviderDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn,
            this.productCurrentDiscountDataGridViewTextBoxColumn,
            this.productQuantityInStockDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productPhotoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 276);
            this.dataGridView1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите что нужно удалить :";
            // 
            // trade2023DataSet1
            // 
            this.trade2023DataSet1.DataSetName = "Trade2023DataSet1";
            this.trade2023DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.trade2023DataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productArticleNumberDataGridViewTextBoxColumn
            // 
            this.productArticleNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.HeaderText = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productArticleNumberDataGridViewTextBoxColumn.Name = "productArticleNumberDataGridViewTextBoxColumn";
            this.productArticleNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productUnitDataGridViewTextBoxColumn
            // 
            this.productUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductUnit";
            this.productUnitDataGridViewTextBoxColumn.HeaderText = "ProductUnit";
            this.productUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productUnitDataGridViewTextBoxColumn.Name = "productUnitDataGridViewTextBoxColumn";
            this.productUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCostDataGridViewTextBoxColumn
            // 
            this.productCostDataGridViewTextBoxColumn.DataPropertyName = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.HeaderText = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCostDataGridViewTextBoxColumn.Name = "productCostDataGridViewTextBoxColumn";
            this.productCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDiscountAmountDataGridViewTextBoxColumn
            // 
            this.productDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.HeaderText = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDiscountAmountDataGridViewTextBoxColumn.Name = "productDiscountAmountDataGridViewTextBoxColumn";
            this.productDiscountAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productManufacturerDataGridViewTextBoxColumn
            // 
            this.productManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.HeaderText = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productManufacturerDataGridViewTextBoxColumn.Name = "productManufacturerDataGridViewTextBoxColumn";
            this.productManufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // productProviderDataGridViewTextBoxColumn
            // 
            this.productProviderDataGridViewTextBoxColumn.DataPropertyName = "ProductProvider";
            this.productProviderDataGridViewTextBoxColumn.HeaderText = "ProductProvider";
            this.productProviderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productProviderDataGridViewTextBoxColumn.Name = "productProviderDataGridViewTextBoxColumn";
            this.productProviderDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            this.productCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCurrentDiscountDataGridViewTextBoxColumn
            // 
            this.productCurrentDiscountDataGridViewTextBoxColumn.DataPropertyName = "ProductCurrentDiscount";
            this.productCurrentDiscountDataGridViewTextBoxColumn.HeaderText = "ProductCurrentDiscount";
            this.productCurrentDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCurrentDiscountDataGridViewTextBoxColumn.Name = "productCurrentDiscountDataGridViewTextBoxColumn";
            this.productCurrentDiscountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productQuantityInStockDataGridViewTextBoxColumn
            // 
            this.productQuantityInStockDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.HeaderText = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productQuantityInStockDataGridViewTextBoxColumn.Name = "productQuantityInStockDataGridViewTextBoxColumn";
            this.productQuantityInStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            this.productDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPhotoDataGridViewTextBoxColumn
            // 
            this.productPhotoDataGridViewTextBoxColumn.DataPropertyName = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.HeaderText = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPhotoDataGridViewTextBoxColumn.Name = "productPhotoDataGridViewTextBoxColumn";
            this.productPhotoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Del_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Del_data";
            this.Text = "Окно удаления данных";
            this.Load += new System.EventHandler(this.Del_data_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trade2023DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private Trade2023DataSet1 trade2023DataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Trade2023DataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productArticleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productProviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCurrentDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPhotoDataGridViewTextBoxColumn;
    }
}