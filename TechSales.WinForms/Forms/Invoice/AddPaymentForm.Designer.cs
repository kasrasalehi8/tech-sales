namespace TechSales.WinForms.Forms.Invoice
{
    partial class AddPaymentForm
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
            lblRemainingBalanceValue = new Label();
            lblRemainingBalanceTitle = new Label();
            lblCustomerValue = new Label();
            lblCustomerTitle = new Label();
            lblInvoiceNumberValue = new Label();
            lblInvoiceNumberTitle = new Label();
            lblPaymentAmount = new Label();
            numAmount = new NumericUpDown();
            btnCancel = new Button();
            btnSave = new Button();
            dtpPaymentDate = new DateTimePicker();
            lblDate = new Label();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // lblRemainingBalanceValue
            // 
            lblRemainingBalanceValue.AutoSize = true;
            lblRemainingBalanceValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingBalanceValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblRemainingBalanceValue.Location = new Point(130, 82);
            lblRemainingBalanceValue.Name = "lblRemainingBalanceValue";
            lblRemainingBalanceValue.Size = new Size(19, 21);
            lblRemainingBalanceValue.TabIndex = 59;
            lblRemainingBalanceValue.Text = "0";
            // 
            // lblRemainingBalanceTitle
            // 
            lblRemainingBalanceTitle.AutoSize = true;
            lblRemainingBalanceTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingBalanceTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblRemainingBalanceTitle.Location = new Point(12, 82);
            lblRemainingBalanceTitle.Name = "lblRemainingBalanceTitle";
            lblRemainingBalanceTitle.Size = new Size(112, 21);
            lblRemainingBalanceTitle.TabIndex = 58;
            lblRemainingBalanceTitle.Text = "Total Amount:";
            // 
            // lblCustomerValue
            // 
            lblCustomerValue.AutoSize = true;
            lblCustomerValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblCustomerValue.Location = new Point(108, 52);
            lblCustomerValue.Name = "lblCustomerValue";
            lblCustomerValue.Size = new Size(40, 21);
            lblCustomerValue.TabIndex = 55;
            lblCustomerValue.Text = "N/A";
            // 
            // lblCustomerTitle
            // 
            lblCustomerTitle.AutoSize = true;
            lblCustomerTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblCustomerTitle.Location = new Point(12, 52);
            lblCustomerTitle.Name = "lblCustomerTitle";
            lblCustomerTitle.Size = new Size(90, 21);
            lblCustomerTitle.TabIndex = 54;
            lblCustomerTitle.Text = "Customer: ";
            // 
            // lblInvoiceNumberValue
            // 
            lblInvoiceNumberValue.AutoSize = true;
            lblInvoiceNumberValue.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceNumberValue.ForeColor = Color.FromArgb(3, 38, 53);
            lblInvoiceNumberValue.Location = new Point(88, 9);
            lblInvoiceNumberValue.Name = "lblInvoiceNumberValue";
            lblInvoiceNumberValue.Size = new Size(24, 28);
            lblInvoiceNumberValue.TabIndex = 53;
            lblInvoiceNumberValue.Text = "#";
            // 
            // lblInvoiceNumberTitle
            // 
            lblInvoiceNumberTitle.AutoSize = true;
            lblInvoiceNumberTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoiceNumberTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblInvoiceNumberTitle.Location = new Point(12, 9);
            lblInvoiceNumberTitle.Name = "lblInvoiceNumberTitle";
            lblInvoiceNumberTitle.Size = new Size(77, 28);
            lblInvoiceNumberTitle.TabIndex = 52;
            lblInvoiceNumberTitle.Text = "Invoice";
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentAmount.ForeColor = Color.FromArgb(3, 38, 53);
            lblPaymentAmount.Location = new Point(12, 138);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(136, 21);
            lblPaymentAmount.TabIndex = 60;
            lblPaymentAmount.Text = "Payment Amount";
            // 
            // numAmount
            // 
            numAmount.DecimalPlaces = 2;
            numAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAmount.Location = new Point(17, 166);
            numAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(120, 25);
            numAmount.TabIndex = 61;
            numAmount.ThousandsSeparator = true;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(3, 38, 53);
            btnCancel.Location = new Point(176, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 35);
            btnCancel.TabIndex = 63;
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
            btnSave.Location = new Point(16, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 35);
            btnSave.TabIndex = 62;
            btnSave.Text = "Add Payment";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.CalendarFont = new Font("Segoe UI", 10F);
            dtpPaymentDate.CustomFormat = "yyyy/MM/dd HH:mm";
            dtpPaymentDate.Format = DateTimePickerFormat.Custom;
            dtpPaymentDate.Location = new Point(17, 238);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(200, 23);
            dtpPaymentDate.TabIndex = 64;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(3, 38, 53);
            lblDate.Location = new Point(12, 211);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 21);
            lblDate.TabIndex = 65;
            lblDate.Text = "Date";
            // 
            // AddPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 345);
            Controls.Add(lblDate);
            Controls.Add(dtpPaymentDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numAmount);
            Controls.Add(lblPaymentAmount);
            Controls.Add(lblRemainingBalanceValue);
            Controls.Add(lblRemainingBalanceTitle);
            Controls.Add(lblCustomerValue);
            Controls.Add(lblCustomerTitle);
            Controls.Add(lblInvoiceNumberValue);
            Controls.Add(lblInvoiceNumberTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddPaymentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Payment";
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRemainingBalanceValue;
        private Label lblRemainingBalanceTitle;
        private Label lblCustomerValue;
        private Label lblCustomerTitle;
        private Label lblInvoiceNumberValue;
        private Label lblInvoiceNumberTitle;
        private Label lblPaymentAmount;
        private NumericUpDown numAmount;
        private Button btnCancel;
        private Button btnSave;
        private DateTimePicker dtpPaymentDate;
        private Label lblDate;
    }
}