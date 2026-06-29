namespace TechSales.WinForms.Forms.Customer
{
    partial class CustomersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvCustomers = new DataGridView();
            lblSearch = new Label();
            btnAddCustomer = new Button();
            lblCustomers = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.Location = new Point(21, 155);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(761, 417);
            dgvCustomers.TabIndex = 4;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            dgvCustomers.DataBindingComplete += dgvCustomers_DataBindingComplete;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(3, 38, 53);
            lblSearch.Location = new Point(472, 101);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(96, 32);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Search:";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.FromArgb(3, 38, 53);
            btnAddCustomer.Cursor = Cursors.Hand;
            btnAddCustomer.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(21, 99);
            btnAddCustomer.Margin = new Padding(3, 4, 3, 4);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(138, 39);
            btnAddCustomer.TabIndex = 6;
            btnAddCustomer.Text = "+ Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomers.ForeColor = Color.FromArgb(3, 38, 53);
            lblCustomers.Location = new Point(9, 4);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(189, 46);
            lblCustomers.TabIndex = 5;
            lblCustomers.Text = "Customers";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(3, 38, 53);
            txtSearch.Location = new Point(571, 99);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(211, 34);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // CustomersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            Controls.Add(txtSearch);
            Controls.Add(dgvCustomers);
            Controls.Add(lblSearch);
            Controls.Add(btnAddCustomer);
            Controls.Add(lblCustomers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomersControl";
            Size = new Size(829, 967);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvCustomers;
        private Label lblSearch;
        private Button btnAddCustomer;
        private Label lblCustomers;
        private TextBox txtSearch;
    }
}
