namespace TechSales.WinForms.Forms.Invoice
{
    partial class InvoiceDetailsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblInvoiceNumberTitle = new Label();
            lblInvoiceNumberValue = new Label();
            lblCustomerTitle = new Label();
            lblCustomerValue = new Label();
            lblDateTitle = new Label();
            lblDateValue = new Label();
            lblTotalAmountTitle = new Label();
            lblTotalAmountValue = new Label();
            lblPaidAmountTitle = new Label();
            lblRemainingTitle = new Label();
            lblPaidAmountValue = new Label();
            lblRemainingValue = new Label();
            lblInvoiceItems = new Label();
            dgvItems = new DataGridView();
            lblPayments = new Label();
            dgvPayments = new DataGridView();
            lblPaymentStatus = new Label();
            btnAddPayment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // lblInvoiceNumberTitle
            // 
            lblInvoiceNumberTitle.AutoSize = true;
            lblInvoiceNumberTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceNumberTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblInvoiceNumberTitle.Location = new Point(12, 9);
            lblInvoiceNumberTitle.Name = "lblInvoiceNumberTitle";
            lblInvoiceNumberTitle.Size = new Size(77, 28);
            lblInvoiceNumberTitle.TabIndex = 44;
            lblInvoiceNumberTitle.Text = "Invoice";
            // 
            // lblInvoiceNumberValue
            // 
            lblInvoiceNumberValue.AutoSize = true;
            lblInvoiceNumberValue.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceNumberValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblInvoiceNumberValue.Location = new Point(88, 9);
            lblInvoiceNumberValue.Name = "lblInvoiceNumberValue";
            lblInvoiceNumberValue.Size = new Size(24, 28);
            lblInvoiceNumberValue.TabIndex = 45;
            lblInvoiceNumberValue.Text = "#";
            // 
            // lblCustomerTitle
            // 
            lblCustomerTitle.AutoSize = true;
            lblCustomerTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblCustomerTitle.Location = new Point(12, 52);
            lblCustomerTitle.Name = "lblCustomerTitle";
            lblCustomerTitle.Size = new Size(90, 21);
            lblCustomerTitle.TabIndex = 46;
            lblCustomerTitle.Text = "Customer: ";
            // 
            // lblCustomerValue
            // 
            lblCustomerValue.AutoSize = true;
            lblCustomerValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblCustomerValue.Location = new Point(108, 52);
            lblCustomerValue.Name = "lblCustomerValue";
            lblCustomerValue.Size = new Size(40, 21);
            lblCustomerValue.TabIndex = 47;
            lblCustomerValue.Text = "N/A";
            // 
            // lblDateTitle
            // 
            lblDateTitle.AutoSize = true;
            lblDateTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblDateTitle.Location = new Point(12, 82);
            lblDateTitle.Name = "lblDateTitle";
            lblDateTitle.Size = new Size(48, 21);
            lblDateTitle.TabIndex = 48;
            lblDateTitle.Text = "Date:";
            // 
            // lblDateValue
            // 
            lblDateValue.AutoSize = true;
            lblDateValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblDateValue.Location = new Point(66, 82);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Size = new Size(40, 21);
            lblDateValue.TabIndex = 49;
            lblDateValue.Text = "N/A";
            // 
            // lblTotalAmountTitle
            // 
            lblTotalAmountTitle.AutoSize = true;
            lblTotalAmountTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmountTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblTotalAmountTitle.Location = new Point(12, 112);
            lblTotalAmountTitle.Name = "lblTotalAmountTitle";
            lblTotalAmountTitle.Size = new Size(112, 21);
            lblTotalAmountTitle.TabIndex = 50;
            lblTotalAmountTitle.Text = "Total Amount:";
            // 
            // lblTotalAmountValue
            // 
            lblTotalAmountValue.AutoSize = true;
            lblTotalAmountValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmountValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblTotalAmountValue.Location = new Point(130, 112);
            lblTotalAmountValue.Name = "lblTotalAmountValue";
            lblTotalAmountValue.Size = new Size(19, 21);
            lblTotalAmountValue.TabIndex = 51;
            lblTotalAmountValue.Text = "0";
            // 
            // lblPaidAmountTitle
            // 
            lblPaidAmountTitle.AutoSize = true;
            lblPaidAmountTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaidAmountTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblPaidAmountTitle.Location = new Point(12, 142);
            lblPaidAmountTitle.Name = "lblPaidAmountTitle";
            lblPaidAmountTitle.Size = new Size(108, 21);
            lblPaidAmountTitle.TabIndex = 52;
            lblPaidAmountTitle.Text = "Paid Amount:";
            // 
            // lblRemainingTitle
            // 
            lblRemainingTitle.AutoSize = true;
            lblRemainingTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblRemainingTitle.Location = new Point(12, 172);
            lblRemainingTitle.Name = "lblRemainingTitle";
            lblRemainingTitle.Size = new Size(91, 21);
            lblRemainingTitle.TabIndex = 53;
            lblRemainingTitle.Text = "Remaining:";
            // 
            // lblPaidAmountValue
            // 
            lblPaidAmountValue.AutoSize = true;
            lblPaidAmountValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaidAmountValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblPaidAmountValue.Location = new Point(126, 142);
            lblPaidAmountValue.Name = "lblPaidAmountValue";
            lblPaidAmountValue.Size = new Size(19, 21);
            lblPaidAmountValue.TabIndex = 54;
            lblPaidAmountValue.Text = "0";
            // 
            // lblRemainingValue
            // 
            lblRemainingValue.AutoSize = true;
            lblRemainingValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblRemainingValue.Location = new Point(109, 172);
            lblRemainingValue.Name = "lblRemainingValue";
            lblRemainingValue.Size = new Size(19, 21);
            lblRemainingValue.TabIndex = 55;
            lblRemainingValue.Text = "0";
            // 
            // lblInvoiceItems
            // 
            lblInvoiceItems.AutoSize = true;
            lblInvoiceItems.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceItems.ForeColor = Color.FromArgb(3, 38, 53);
            lblInvoiceItems.Location = new Point(12, 220);
            lblInvoiceItems.Name = "lblInvoiceItems";
            lblInvoiceItems.Size = new Size(134, 28);
            lblInvoiceItems.TabIndex = 56;
            lblInvoiceItems.Text = "Invoice Items";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.Location = new Point(12, 261);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(630, 110);
            dgvItems.TabIndex = 57;
            // 
            // lblPayments
            // 
            lblPayments.AutoSize = true;
            lblPayments.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayments.ForeColor = Color.FromArgb(3, 38, 53);
            lblPayments.Location = new Point(12, 402);
            lblPayments.Name = "lblPayments";
            lblPayments.Size = new Size(91, 28);
            lblPayments.TabIndex = 58;
            lblPayments.Text = "Payment";
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPayments.Location = new Point(11, 442);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(341, 110);
            dgvPayments.TabIndex = 59;
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentStatus.ForeColor = Color.FromArgb(3, 38, 53);
            lblPaymentStatus.Location = new Point(179, 402);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(173, 28);
            lblPaymentStatus.TabIndex = 60;
            lblPaymentStatus.Text = "[PARTIALLY PAID]";
            // 
            // btnAddPayment
            // 
            btnAddPayment.BackColor = Color.FromArgb(3, 38, 53);
            btnAddPayment.Cursor = Cursors.Hand;
            btnAddPayment.Enabled = false;
            btnAddPayment.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnAddPayment.FlatStyle = FlatStyle.Flat;
            btnAddPayment.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPayment.ForeColor = Color.White;
            btnAddPayment.Location = new Point(11, 580);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new Size(133, 35);
            btnAddPayment.TabIndex = 61;
            btnAddPayment.Text = "Add Payment";
            btnAddPayment.UseVisualStyleBackColor = false;
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // InvoiceDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(653, 626);
            Controls.Add(btnAddPayment);
            Controls.Add(lblPaymentStatus);
            Controls.Add(dgvPayments);
            Controls.Add(lblPayments);
            Controls.Add(dgvItems);
            Controls.Add(lblInvoiceItems);
            Controls.Add(lblRemainingValue);
            Controls.Add(lblPaidAmountValue);
            Controls.Add(lblRemainingTitle);
            Controls.Add(lblPaidAmountTitle);
            Controls.Add(lblTotalAmountValue);
            Controls.Add(lblTotalAmountTitle);
            Controls.Add(lblDateValue);
            Controls.Add(lblDateTitle);
            Controls.Add(lblCustomerValue);
            Controls.Add(lblCustomerTitle);
            Controls.Add(lblInvoiceNumberValue);
            Controls.Add(lblInvoiceNumberTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InvoiceDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Invoice Details";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvoiceNumberTitle;
        private Label lblInvoiceNumberValue;
        private Label lblCustomerTitle;
        private Label lblCustomerValue;
        private Label lblDateTitle;
        private Label lblDateValue;
        private Label lblTotalAmountTitle;
        private Label lblTotalAmountValue;
        private Label lblPaidAmountTitle;
        private Label lblRemainingTitle;
        private Label lblPaidAmountValue;
        private Label lblRemainingValue;
        private Label lblInvoiceItems;
        private DataGridView dgvItems;
        private Label lblPayments;
        private DataGridView dgvPayments;
        private Label lblPaymentStatus;
        private Button btnAddPayment;
    }
}