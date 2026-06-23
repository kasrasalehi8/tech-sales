namespace TechSales.WinForms.Forms.Supplier
{
    partial class SupplierDetailsForm
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
            btnDelete = new Button();
            txtAddress = new TextBox();
            lblPhoneNumberValue = new Label();
            lblCompanyNameValue = new Label();
            lblAddressTitle = new Label();
            lblPhoneNumberTitle = new Label();
            lblNameTitle = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(181, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 35);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI Semibold", 12F);
            txtAddress.Location = new Point(92, 70);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(340, 80);
            txtAddress.TabIndex = 21;
            txtAddress.Text = "N/A";
            // 
            // lblPhoneNumberValue
            // 
            lblPhoneNumberValue.AutoSize = true;
            lblPhoneNumberValue.BackColor = Color.Transparent;
            lblPhoneNumberValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumberValue.ForeColor = Color.Black;
            lblPhoneNumberValue.Location = new Point(78, 42);
            lblPhoneNumberValue.Name = "lblPhoneNumberValue";
            lblPhoneNumberValue.Size = new Size(40, 21);
            lblPhoneNumberValue.TabIndex = 20;
            lblPhoneNumberValue.Text = "N/A";
            // 
            // lblCompanyNameValue
            // 
            lblCompanyNameValue.AutoSize = true;
            lblCompanyNameValue.BackColor = Color.Transparent;
            lblCompanyNameValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompanyNameValue.ForeColor = Color.Black;
            lblCompanyNameValue.Location = new Point(148, 12);
            lblCompanyNameValue.Name = "lblCompanyNameValue";
            lblCompanyNameValue.Size = new Size(40, 21);
            lblCompanyNameValue.TabIndex = 19;
            lblCompanyNameValue.Text = "N/A";
            // 
            // lblAddressTitle
            // 
            lblAddressTitle.AutoSize = true;
            lblAddressTitle.BackColor = Color.Transparent;
            lblAddressTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblAddressTitle.Location = new Point(12, 72);
            lblAddressTitle.Name = "lblAddressTitle";
            lblAddressTitle.Size = new Size(74, 21);
            lblAddressTitle.TabIndex = 18;
            lblAddressTitle.Text = "Address:";
            // 
            // lblPhoneNumberTitle
            // 
            lblPhoneNumberTitle.AutoSize = true;
            lblPhoneNumberTitle.BackColor = Color.Transparent;
            lblPhoneNumberTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumberTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblPhoneNumberTitle.Location = new Point(12, 42);
            lblPhoneNumberTitle.Name = "lblPhoneNumberTitle";
            lblPhoneNumberTitle.Size = new Size(60, 21);
            lblPhoneNumberTitle.TabIndex = 17;
            lblPhoneNumberTitle.Text = "Phone:";
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.BackColor = Color.Transparent;
            lblNameTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblNameTitle.Location = new Point(12, 12);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(130, 21);
            lblNameTitle.TabIndex = 16;
            lblNameTitle.Text = "Company Name:";
            // 
            // SupplierDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(444, 212);
            Controls.Add(btnDelete);
            Controls.Add(txtAddress);
            Controls.Add(lblPhoneNumberValue);
            Controls.Add(lblCompanyNameValue);
            Controls.Add(lblAddressTitle);
            Controls.Add(lblPhoneNumberTitle);
            Controls.Add(lblNameTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupplierDetailsForm";
            Text = "Supplier Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private TextBox txtAddress;
        private Label lblPhoneNumberValue;
        private Label lblCompanyNameValue;
        private Label lblAddressTitle;
        private Label lblPhoneNumberTitle;
        private Label lblNameTitle;
    }
}