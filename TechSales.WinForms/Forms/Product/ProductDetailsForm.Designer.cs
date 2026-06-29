namespace TechSales.WinForms.Forms.Product
{
    partial class ProductDetailsForm
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
            lblNameTitle = new Label();
            lblCategoryTitle = new Label();
            lblSupplierTitle = new Label();
            lblPriceTitle = new Label();
            lblStockTitle = new Label();
            lblStatusTitle = new Label();
            lblNameValue = new Label();
            lblCategoryValue = new Label();
            lblSupplierValue = new Label();
            lblPriceValue = new Label();
            lblStockValue = new Label();
            lblStatusValue = new Label();
            btnDelete = new Button();
            numAddStock = new NumericUpDown();
            lblAddStockTitle = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numAddStock).BeginInit();
            SuspendLayout();
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.BackColor = Color.Transparent;
            lblNameTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblNameTitle.Location = new Point(14, 13);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(71, 28);
            lblNameTitle.TabIndex = 0;
            lblNameTitle.Text = "Name:";
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.BackColor = Color.Transparent;
            lblCategoryTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblCategoryTitle.Location = new Point(14, 53);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(99, 28);
            lblCategoryTitle.TabIndex = 1;
            lblCategoryTitle.Text = "Category:";
            // 
            // lblSupplierTitle
            // 
            lblSupplierTitle.AutoSize = true;
            lblSupplierTitle.BackColor = Color.Transparent;
            lblSupplierTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplierTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblSupplierTitle.Location = new Point(14, 93);
            lblSupplierTitle.Name = "lblSupplierTitle";
            lblSupplierTitle.Size = new Size(93, 28);
            lblSupplierTitle.TabIndex = 2;
            lblSupplierTitle.Text = "Supplier:";
            // 
            // lblPriceTitle
            // 
            lblPriceTitle.AutoSize = true;
            lblPriceTitle.BackColor = Color.Transparent;
            lblPriceTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblPriceTitle.Location = new Point(14, 133);
            lblPriceTitle.Name = "lblPriceTitle";
            lblPriceTitle.Size = new Size(61, 28);
            lblPriceTitle.TabIndex = 3;
            lblPriceTitle.Text = "Price:";
            // 
            // lblStockTitle
            // 
            lblStockTitle.AutoSize = true;
            lblStockTitle.BackColor = Color.Transparent;
            lblStockTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblStockTitle.Location = new Point(14, 173);
            lblStockTitle.Name = "lblStockTitle";
            lblStockTitle.Size = new Size(67, 28);
            lblStockTitle.TabIndex = 4;
            lblStockTitle.Text = "Stock:";
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.BackColor = Color.Transparent;
            lblStatusTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblStatusTitle.Location = new Point(14, 213);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(72, 28);
            lblStatusTitle.TabIndex = 5;
            lblStatusTitle.Text = "Status:";
            // 
            // lblNameValue
            // 
            lblNameValue.AutoSize = true;
            lblNameValue.BackColor = Color.Transparent;
            lblNameValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameValue.ForeColor = Color.Black;
            lblNameValue.Location = new Point(82, 13);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(48, 28);
            lblNameValue.TabIndex = 6;
            lblNameValue.Text = "N/A";
            // 
            // lblCategoryValue
            // 
            lblCategoryValue.AutoSize = true;
            lblCategoryValue.BackColor = Color.Transparent;
            lblCategoryValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryValue.ForeColor = Color.Black;
            lblCategoryValue.Location = new Point(113, 53);
            lblCategoryValue.Name = "lblCategoryValue";
            lblCategoryValue.Size = new Size(48, 28);
            lblCategoryValue.TabIndex = 7;
            lblCategoryValue.Text = "N/A";
            // 
            // lblSupplierValue
            // 
            lblSupplierValue.AutoSize = true;
            lblSupplierValue.BackColor = Color.Transparent;
            lblSupplierValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplierValue.ForeColor = Color.Black;
            lblSupplierValue.Location = new Point(107, 93);
            lblSupplierValue.Name = "lblSupplierValue";
            lblSupplierValue.Size = new Size(48, 28);
            lblSupplierValue.TabIndex = 8;
            lblSupplierValue.Text = "N/A";
            // 
            // lblPriceValue
            // 
            lblPriceValue.AutoSize = true;
            lblPriceValue.BackColor = Color.Transparent;
            lblPriceValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceValue.ForeColor = Color.Black;
            lblPriceValue.Location = new Point(78, 133);
            lblPriceValue.Name = "lblPriceValue";
            lblPriceValue.Size = new Size(48, 28);
            lblPriceValue.TabIndex = 9;
            lblPriceValue.Text = "N/A";
            // 
            // lblStockValue
            // 
            lblStockValue.AutoSize = true;
            lblStockValue.BackColor = Color.Transparent;
            lblStockValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockValue.ForeColor = Color.Black;
            lblStockValue.Location = new Point(85, 173);
            lblStockValue.Name = "lblStockValue";
            lblStockValue.Size = new Size(48, 28);
            lblStockValue.TabIndex = 10;
            lblStockValue.Text = "N/A";
            // 
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.BackColor = Color.Transparent;
            lblStatusValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusValue.ForeColor = Color.Black;
            lblStatusValue.Location = new Point(88, 213);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(48, 28);
            lblStatusValue.TabIndex = 11;
            lblStatusValue.Text = "N/A";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(143, 328);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 47);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // numAddStock
            // 
            numAddStock.Location = new Point(74, 253);
            numAddStock.Margin = new Padding(3, 4, 3, 4);
            numAddStock.Name = "numAddStock";
            numAddStock.Size = new Size(137, 27);
            numAddStock.TabIndex = 15;
            // 
            // lblAddStockTitle
            // 
            lblAddStockTitle.AutoSize = true;
            lblAddStockTitle.BackColor = Color.Transparent;
            lblAddStockTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddStockTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblAddStockTitle.Location = new Point(14, 253);
            lblAddStockTitle.Name = "lblAddStockTitle";
            lblAddStockTitle.Size = new Size(54, 28);
            lblAddStockTitle.TabIndex = 16;
            lblAddStockTitle.Text = "Add:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(3, 38, 53);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(256, 252);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 31);
            btnSave.TabIndex = 63;
            btnSave.Text = "+ Add";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnAddStock_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(3, 38, 53);
            btnCancel.Location = new Point(248, 328);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 47);
            btnCancel.TabIndex = 64;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(353, 391);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblAddStockTitle);
            Controls.Add(numAddStock);
            Controls.Add(btnDelete);
            Controls.Add(lblStatusValue);
            Controls.Add(lblStockValue);
            Controls.Add(lblPriceValue);
            Controls.Add(lblSupplierValue);
            Controls.Add(lblCategoryValue);
            Controls.Add(lblNameValue);
            Controls.Add(lblStatusTitle);
            Controls.Add(lblStockTitle);
            Controls.Add(lblPriceTitle);
            Controls.Add(lblSupplierTitle);
            Controls.Add(lblCategoryTitle);
            Controls.Add(lblNameTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product Details";
            ((System.ComponentModel.ISupportInitialize)numAddStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameTitle;
        private Label lblCategoryTitle;
        private Label lblSupplierTitle;
        private Label lblPriceTitle;
        private Label lblStockTitle;
        private Label lblStatusTitle;
        private Label lblNameValue;
        private Label lblCategoryValue;
        private Label lblSupplierValue;
        private Label lblPriceValue;
        private Label lblStockValue;
        private Label lblStatusValue;
        private Button btnDelete;
        private NumericUpDown numAddStock;
        private Label lblAddStockTitle;
        private Button btnSave;
        private Button btnCancel;
    }
}