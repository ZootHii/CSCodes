namespace AdoNetDemo
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_UnitPrice = new System.Windows.Forms.TextBox();
            this.textBox_StockAmount = new System.Windows.Forms.TextBox();
            this.label_UnitPrice = new System.Windows.Forms.Label();
            this.label_StockAmount = new System.Windows.Forms.Label();
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.button_AddProduct = new System.Windows.Forms.Button();
            this.groupBox_Update = new System.Windows.Forms.GroupBox();
            this.button_UpdateProduct = new System.Windows.Forms.Button();
            this.textBox_NameUpdate = new System.Windows.Forms.TextBox();
            this.label_StockAmountUpdate = new System.Windows.Forms.Label();
            this.label_NameUpdate = new System.Windows.Forms.Label();
            this.label_UnitPriceUpdate = new System.Windows.Forms.Label();
            this.textBox_UnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.textBox_StockAmountUpdate = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_Product)).BeginInit();
            this.groupBox_Add.SuspendLayout();
            this.groupBox_Update.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Product.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Product.Location = new System.Drawing.Point(41, 12);
            this.dataGridView_Product.Name = "dataGridView_Product";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Product.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Product.Size = new System.Drawing.Size(722, 150);
            this.dataGridView_Product.TabIndex = 0;
            this.dataGridView_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Product_CellClick);
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label_Name.Location = new System.Drawing.Point(28, 29);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(56, 26);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(162, 29);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(149, 27);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_UnitPrice
            // 
            this.textBox_UnitPrice.Location = new System.Drawing.Point(162, 73);
            this.textBox_UnitPrice.Name = "textBox_UnitPrice";
            this.textBox_UnitPrice.Size = new System.Drawing.Size(149, 27);
            this.textBox_UnitPrice.TabIndex = 3;
            // 
            // textBox_StockAmount
            // 
            this.textBox_StockAmount.Location = new System.Drawing.Point(162, 124);
            this.textBox_StockAmount.Name = "textBox_StockAmount";
            this.textBox_StockAmount.Size = new System.Drawing.Size(149, 27);
            this.textBox_StockAmount.TabIndex = 4;
            // 
            // label_UnitPrice
            // 
            this.label_UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label_UnitPrice.Location = new System.Drawing.Point(28, 73);
            this.label_UnitPrice.Name = "label_UnitPrice";
            this.label_UnitPrice.Size = new System.Drawing.Size(89, 26);
            this.label_UnitPrice.TabIndex = 5;
            this.label_UnitPrice.Text = "Unit Price";
            // 
            // label_StockAmount
            // 
            this.label_StockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label_StockAmount.Location = new System.Drawing.Point(28, 124);
            this.label_StockAmount.Name = "label_StockAmount";
            this.label_StockAmount.Size = new System.Drawing.Size(125, 27);
            this.label_StockAmount.TabIndex = 6;
            this.label_StockAmount.Text = "Stock Amount";
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Add.Controls.Add(this.button_AddProduct);
            this.groupBox_Add.Controls.Add(this.textBox_Name);
            this.groupBox_Add.Controls.Add(this.label_StockAmount);
            this.groupBox_Add.Controls.Add(this.label_Name);
            this.groupBox_Add.Controls.Add(this.label_UnitPrice);
            this.groupBox_Add.Controls.Add(this.textBox_UnitPrice);
            this.groupBox_Add.Controls.Add(this.textBox_StockAmount);
            this.groupBox_Add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.groupBox_Add.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox_Add.Location = new System.Drawing.Point(41, 227);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Size = new System.Drawing.Size(346, 211);
            this.groupBox_Add.TabIndex = 7;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "Add a Product";
            // 
            // button_AddProduct
            // 
            this.button_AddProduct.Location = new System.Drawing.Point(28, 167);
            this.button_AddProduct.Name = "button_AddProduct";
            this.button_AddProduct.Size = new System.Drawing.Size(283, 34);
            this.button_AddProduct.TabIndex = 7;
            this.button_AddProduct.Text = "Add Product";
            this.button_AddProduct.UseVisualStyleBackColor = true;
            this.button_AddProduct.Click += new System.EventHandler(this.button_AddProduct_Click);
            // 
            // groupBox_Update
            // 
            this.groupBox_Update.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Update.Controls.Add(this.button_UpdateProduct);
            this.groupBox_Update.Controls.Add(this.textBox_NameUpdate);
            this.groupBox_Update.Controls.Add(this.label_StockAmountUpdate);
            this.groupBox_Update.Controls.Add(this.label_NameUpdate);
            this.groupBox_Update.Controls.Add(this.label_UnitPriceUpdate);
            this.groupBox_Update.Controls.Add(this.textBox_UnitPriceUpdate);
            this.groupBox_Update.Controls.Add(this.textBox_StockAmountUpdate);
            this.groupBox_Update.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.groupBox_Update.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox_Update.Location = new System.Drawing.Point(417, 227);
            this.groupBox_Update.Name = "groupBox_Update";
            this.groupBox_Update.Size = new System.Drawing.Size(346, 211);
            this.groupBox_Update.TabIndex = 8;
            this.groupBox_Update.TabStop = false;
            this.groupBox_Update.Text = "Update a Product";
            // 
            // button_UpdateProduct
            // 
            this.button_UpdateProduct.Location = new System.Drawing.Point(28, 167);
            this.button_UpdateProduct.Name = "button_UpdateProduct";
            this.button_UpdateProduct.Size = new System.Drawing.Size(283, 34);
            this.button_UpdateProduct.TabIndex = 7;
            this.button_UpdateProduct.Text = "Update Product";
            this.button_UpdateProduct.UseVisualStyleBackColor = true;
            this.button_UpdateProduct.Click += new System.EventHandler(this.button_UpdateProduct_Click);
            // 
            // textBox_NameUpdate
            // 
            this.textBox_NameUpdate.Location = new System.Drawing.Point(162, 29);
            this.textBox_NameUpdate.Name = "textBox_NameUpdate";
            this.textBox_NameUpdate.Size = new System.Drawing.Size(149, 27);
            this.textBox_NameUpdate.TabIndex = 2;
            // 
            // label_StockAmountUpdate
            // 
            this.label_StockAmountUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label_StockAmountUpdate.Location = new System.Drawing.Point(28, 124);
            this.label_StockAmountUpdate.Name = "label_StockAmountUpdate";
            this.label_StockAmountUpdate.Size = new System.Drawing.Size(125, 27);
            this.label_StockAmountUpdate.TabIndex = 6;
            this.label_StockAmountUpdate.Text = "Stock Amount";
            // 
            // label_NameUpdate
            // 
            this.label_NameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label_NameUpdate.Location = new System.Drawing.Point(28, 29);
            this.label_NameUpdate.Name = "label_NameUpdate";
            this.label_NameUpdate.Size = new System.Drawing.Size(56, 26);
            this.label_NameUpdate.TabIndex = 1;
            this.label_NameUpdate.Text = "Name";
            // 
            // label_UnitPriceUpdate
            // 
            this.label_UnitPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label_UnitPriceUpdate.Location = new System.Drawing.Point(28, 73);
            this.label_UnitPriceUpdate.Name = "label_UnitPriceUpdate";
            this.label_UnitPriceUpdate.Size = new System.Drawing.Size(89, 26);
            this.label_UnitPriceUpdate.TabIndex = 5;
            this.label_UnitPriceUpdate.Text = "Unit Price";
            // 
            // textBox_UnitPriceUpdate
            // 
            this.textBox_UnitPriceUpdate.Location = new System.Drawing.Point(162, 73);
            this.textBox_UnitPriceUpdate.Name = "textBox_UnitPriceUpdate";
            this.textBox_UnitPriceUpdate.Size = new System.Drawing.Size(149, 27);
            this.textBox_UnitPriceUpdate.TabIndex = 3;
            // 
            // textBox_StockAmountUpdate
            // 
            this.textBox_StockAmountUpdate.Location = new System.Drawing.Point(162, 124);
            this.textBox_StockAmountUpdate.Name = "textBox_StockAmountUpdate";
            this.textBox_StockAmountUpdate.Size = new System.Drawing.Size(149, 27);
            this.textBox_StockAmountUpdate.TabIndex = 4;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(41, 168);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(283, 34);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Delete Product";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.groupBox_Update);
            this.Controls.Add(this.groupBox_Add);
            this.Controls.Add(this.dataGridView_Product);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView_Product)).EndInit();
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            this.groupBox_Update.ResumeLayout(false);
            this.groupBox_Update.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button_Delete;

        private System.Windows.Forms.Button button_UpdateProduct;
        private System.Windows.Forms.GroupBox groupBox_Update;
        private System.Windows.Forms.Label label_StockAmountUpdate;
        private System.Windows.Forms.Label label_NameUpdate;
        private System.Windows.Forms.Label label_UnitPriceUpdate;
        private System.Windows.Forms.TextBox textBox_NameUpdate;
        private System.Windows.Forms.TextBox textBox_UnitPriceUpdate;
        private System.Windows.Forms.TextBox textBox_StockAmountUpdate;

        private System.Windows.Forms.Button button_AddProduct;

        private System.Windows.Forms.GroupBox groupBox_Add;

        private System.Windows.Forms.Label label_UnitPrice;
        private System.Windows.Forms.Label label_StockAmount;

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_UnitPrice;
        private System.Windows.Forms.TextBox textBox_StockAmount;

        private System.Windows.Forms.DataGridView dataGridView_Product;

        #endregion
    }
}