namespace TechSales.WinForms.Forms.Invoice
{
    partial class CreateInvoiceForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnCancel = new Button();
            btnSave = new Button();
            lblCustomer = new Label();
            cboCustomer = new ComboBox();
            lblProduct = new Label();
            cboProduct = new ComboBox();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            btnAddItem = new Button();
            dgvItems = new DataGridView();
            lblTotalTitle = new Label();
            lblTotalValue = new Label();
            lblDate = new Label();
            dtpInvoiceDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(3, 38, 53);
            btnCancel.Location = new Point(462, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 35);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(3, 38, 53);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(548, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 35);
            btnSave.TabIndex = 31;
            btnSave.Text = "Create Invoice";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.ForeColor = Color.FromArgb(3, 38, 53);
            lblCustomer.Location = new Point(10, 15);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(81, 21);
            lblCustomer.TabIndex = 29;
            lblCustomer.Text = "Customer";
            // 
            // cboCustomer
            // 
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(13, 45);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(235, 23);
            cboCustomer.TabIndex = 36;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduct.ForeColor = Color.FromArgb(3, 38, 53);
            lblProduct.Location = new Point(10, 80);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(68, 21);
            lblProduct.TabIndex = 37;
            lblProduct.Text = "Product";
            // 
            // cboProduct
            // 
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(13, 110);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(235, 23);
            cboProduct.TabIndex = 38;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(291, 110);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 39;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.FromArgb(3, 38, 53);
            lblQuantity.Location = new Point(288, 80);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 21);
            lblQuantity.TabIndex = 40;
            lblQuantity.Text = "Quantity";
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(3, 38, 53);
            btnAddItem.Cursor = Cursors.Hand;
            btnAddItem.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 9F);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(453, 110);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(110, 23);
            btnAddItem.TabIndex = 41;
            btnAddItem.Text = "+ Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle4;
            dgvItems.Location = new Point(13, 156);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(666, 173);
            dgvItems.TabIndex = 42;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            dgvItems.CellMouseEnter += dgvItems_CellMouseEnter;
            dgvItems.CellMouseLeave += dgvItems_CellMouseLeave;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblTotalTitle.Location = new Point(10, 348);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(49, 21);
            lblTotalTitle.TabIndex = 43;
            lblTotalTitle.Text = "Total:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblTotalValue.Location = new Point(63, 348);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(19, 21);
            lblTotalValue.TabIndex = 44;
            lblTotalValue.Text = "0";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(3, 38, 53);
            lblDate.Location = new Point(288, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 21);
            lblDate.TabIndex = 45;
            lblDate.Text = "Date";
            // 
            // dtpInvoiceDate
            // 
            dtpInvoiceDate.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpInvoiceDate.Location = new Point(291, 45);
            dtpInvoiceDate.Name = "dtpInvoiceDate";
            dtpInvoiceDate.Size = new Size(200, 23);
            dtpInvoiceDate.TabIndex = 47;
            // 
            // CreateInvoiceForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            CancelButton = btnCancel;
            ClientSize = new Size(693, 465);
            Controls.Add(dtpInvoiceDate);
            Controls.Add(lblDate);
            Controls.Add(lblTotalValue);
            Controls.Add(lblTotalTitle);
            Controls.Add(dgvItems);
            Controls.Add(btnAddItem);
            Controls.Add(lblQuantity);
            Controls.Add(numQuantity);
            Controls.Add(cboProduct);
            Controls.Add(lblProduct);
            Controls.Add(cboCustomer);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblCustomer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CreateInvoiceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Invoice";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnSave;
        private Label lblCustomer;
        private ComboBox cboCustomer;
        private Label lblProduct;
        private ComboBox cboProduct;
        private NumericUpDown numQuantity;
        private Label lblQuantity;
        private Button btnAddItem;
        private DataGridView dgvItems;
        private Label lblTotalTitle;
        private Label lblTotalValue;
        private Label lblDate;
        private DateTimePicker dtpInvoiceDate;
    }
}