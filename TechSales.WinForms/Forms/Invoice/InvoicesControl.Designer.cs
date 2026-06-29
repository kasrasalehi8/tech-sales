namespace TechSales.WinForms.Forms.Invoice
{
    partial class InvoicesControl
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
            dgvInvoices = new DataGridView();
            lblSearch = new Label();
            btnCreateInvoice = new Button();
            txtSearch = new TextBox();
            lblInvoices = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.BackgroundColor = Color.White;
            dgvInvoices.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoices.Location = new Point(21, 155);
            dgvInvoices.Margin = new Padding(3, 4, 3, 4);
            dgvInvoices.MultiSelect = false;
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(761, 417);
            dgvInvoices.TabIndex = 4;
            dgvInvoices.CellDoubleClick += dgvInvoices_CellDoubleClick;
            dgvInvoices.CellFormatting += dgvInvoices_CellFormatting;
            dgvInvoices.DataBindingComplete += dgvInvoices_DataBindingComplete;
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
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search:";
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.BackColor = Color.FromArgb(3, 38, 53);
            btnCreateInvoice.Cursor = Cursors.Hand;
            btnCreateInvoice.FlatAppearance.BorderColor = Color.FromArgb(3, 38, 53);
            btnCreateInvoice.FlatAppearance.BorderSize = 0;
            btnCreateInvoice.FlatStyle = FlatStyle.Flat;
            btnCreateInvoice.ForeColor = Color.White;
            btnCreateInvoice.Location = new Point(21, 99);
            btnCreateInvoice.Margin = new Padding(3, 4, 3, 4);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(138, 39);
            btnCreateInvoice.TabIndex = 7;
            btnCreateInvoice.Text = "+ Create Invoice";
            btnCreateInvoice.UseVisualStyleBackColor = false;
            btnCreateInvoice.Click += btnCreateInvoice_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(3, 38, 53);
            txtSearch.Location = new Point(571, 99);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(211, 34);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblInvoices
            // 
            lblInvoices.AutoSize = true;
            lblInvoices.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoices.ForeColor = Color.FromArgb(3, 38, 53);
            lblInvoices.Location = new Point(9, 4);
            lblInvoices.Name = "lblInvoices";
            lblInvoices.Size = new Size(150, 46);
            lblInvoices.TabIndex = 5;
            lblInvoices.Text = "Invoices";
            // 
            // InvoicesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            Controls.Add(dgvInvoices);
            Controls.Add(lblSearch);
            Controls.Add(btnCreateInvoice);
            Controls.Add(txtSearch);
            Controls.Add(lblInvoices);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InvoicesControl";
            Size = new Size(829, 967);
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInvoices;
        private Label lblSearch;
        private Button btnCreateInvoice;
        private TextBox txtSearch;
        private Label lblInvoices;
    }
}
