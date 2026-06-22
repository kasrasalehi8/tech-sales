namespace TechSales.WinForms.Forms.Customer
{
    partial class AddCustomerForm
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
            btnCancel = new Button();
            btnSave = new Button();
            lblPhone = new Label();
            lblCustomerFullName = new Label();
            txtFullName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
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
            btnCancel.Location = new Point(216, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 35);
            btnCancel.TabIndex = 24;
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
            btnSave.Location = new Point(129, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 35);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(3, 38, 53);
            lblPhone.Location = new Point(11, 81);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(120, 21);
            lblPhone.TabIndex = 16;
            lblPhone.Text = "Phone Number";
            // 
            // lblCustomerFullName
            // 
            lblCustomerFullName.AutoSize = true;
            lblCustomerFullName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerFullName.ForeColor = Color.FromArgb(3, 38, 53);
            lblCustomerFullName.Location = new Point(11, 16);
            lblCustomerFullName.Name = "lblCustomerFullName";
            lblCustomerFullName.Size = new Size(82, 21);
            lblCustomerFullName.TabIndex = 14;
            lblCustomerFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(13, 45);
            txtFullName.MaxLength = 100;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(235, 25);
            txtFullName.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(13, 110);
            txtPhoneNumber.MaxLength = 11;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(235, 25);
            txtPhoneNumber.TabIndex = 25;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(13, 175);
            txtAddress.MaxLength = 500;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(400, 80);
            txtAddress.TabIndex = 27;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.FromArgb(3, 38, 53);
            lblAddress.Location = new Point(11, 146);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 26;
            lblAddress.Text = "Address";
            // 
            // AddCustomerForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancel;
            ClientSize = new Size(425, 335);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPhone);
            Controls.Add(lblCustomerFullName);
            Controls.Add(txtFullName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label lblPhone;
        private Label lblCustomerFullName;
        private TextBox txtFullName;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private Label lblAddress;
    }
}