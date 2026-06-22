namespace TechSales.WinForms.Forms.Product
{
    partial class AddProductForm
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
            txtName = new TextBox();
            lblProductName = new Label();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            lblSupplier = new Label();
            cboSupplier = new ComboBox();
            numPrice = new NumericUpDown();
            lblPrice = new Label();
            lblStock = new Label();
            numStock = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            StartPosition = FormStartPosition.CenterParent;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(12, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(235, 25);
            txtName.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(3, 38, 53);
            lblProductName.Location = new Point(10, 17);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(115, 21);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name";
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("Segoe UI", 10F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(12, 111);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 25);
            cboCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(3, 38, 53);
            lblCategory.Location = new Point(10, 82);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 21);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplier.ForeColor = Color.FromArgb(3, 38, 53);
            lblSupplier.Location = new Point(10, 148);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(71, 21);
            lblSupplier.TabIndex = 6;
            lblSupplier.Text = "Supplier";
            // 
            // cboSupplier
            // 
            cboSupplier.Font = new Font("Segoe UI", 10F);
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(12, 177);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(200, 25);
            cboSupplier.TabIndex = 5;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Font = new Font("Segoe UI", 10F);
            numPrice.Location = new Point(12, 315);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(200, 25);
            numPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(3, 38, 53);
            lblPrice.Location = new Point(10, 286);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 21);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.FromArgb(3, 38, 53);
            lblStock.Location = new Point(9, 217);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(51, 21);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock";
            // 
            // numStock
            // 
            numStock.Font = new Font("Segoe UI", 10F);
            numStock.Location = new Point(12, 246);
            numStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(199, 25);
            numStock.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(3, 38, 53);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(45, 364);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 35);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.Cursor = Cursors.Hand;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(3, 38, 53);
            btnCancel.Location = new Point(132, 364);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 35);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.Cursor = Cursors.Hand;
            // 
            // AddProductForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(259, 414);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblStock);
            Controls.Add(numStock);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(lblSupplier);
            Controls.Add(cboSupplier);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblProductName);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddProductForm";
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Label lblProductName;
        private ComboBox cboCategory;
        private Label lblCategory;
        private Label lblSupplier;
        private ComboBox cboSupplier;
        private NumericUpDown numPrice;
        private Label lblPrice;
        private Label lblStock;
        private NumericUpDown numStock;
        private Button btnSave;
        private Button btnCancel;
    }
}