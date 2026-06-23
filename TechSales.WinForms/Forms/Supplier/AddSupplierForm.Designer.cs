namespace TechSales.WinForms.Forms.Supplier
{
    partial class AddSupplierForm
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
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPhoneNumber = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblPhone = new Label();
            lblCompanyName = new Label();
            txtCompanyName = new TextBox();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(13, 177);
            txtAddress.MaxLength = 500;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(400, 80);
            txtAddress.TabIndex = 35;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.FromArgb(3, 38, 53);
            lblAddress.Location = new Point(11, 148);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 34;
            lblAddress.Text = "Address";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(13, 112);
            txtPhoneNumber.MaxLength = 11;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(235, 25);
            txtPhoneNumber.TabIndex = 33;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(3, 38, 53);
            btnCancel.Location = new Point(216, 281);
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
            btnSave.Location = new Point(129, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 35);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(3, 38, 53);
            lblPhone.Location = new Point(11, 83);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(120, 21);
            lblPhone.TabIndex = 30;
            lblPhone.Text = "Phone Number";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompanyName.ForeColor = Color.FromArgb(3, 38, 53);
            lblCompanyName.Location = new Point(11, 18);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(126, 21);
            lblCompanyName.TabIndex = 29;
            lblCompanyName.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCompanyName.Location = new Point(13, 47);
            txtCompanyName.MaxLength = 100;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(235, 25);
            txtCompanyName.TabIndex = 28;
            // 
            // AddSupplierForm
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
            Controls.Add(lblCompanyName);
            Controls.Add(txtCompanyName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSupplierForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Supplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtPhoneNumber;
        private Button btnCancel;
        private Button btnSave;
        private Label lblPhone;
        private Label lblCompanyName;
        private TextBox txtCompanyName;
    }
}