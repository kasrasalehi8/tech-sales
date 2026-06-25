namespace TechSales.WinForms.Forms
{
    partial class DashboardControl
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
            pnlRevenue = new Panel();
            iconRevenue = new FontAwesome.Sharp.IconPictureBox();
            lblRevenue = new Label();
            lblTitleRevenue = new Label();
            lineRevenue = new Panel();
            lblDashboardTitle = new Label();
            pnlCustomers = new Panel();
            iconCustomers = new FontAwesome.Sharp.IconPictureBox();
            lblCustomers = new Label();
            lblTitleCustomers = new Label();
            lineCustomers = new Panel();
            pnlInvoices = new Panel();
            iconInvoices = new FontAwesome.Sharp.IconPictureBox();
            lblInvoices = new Label();
            lblTitleInvoices = new Label();
            lineInvoices = new Panel();
            pnlProducts = new Panel();
            iconProducts = new FontAwesome.Sharp.IconPictureBox();
            lblProducts = new Label();
            lblTitleProducts = new Label();
            lineProducts = new Panel();
            pnlAnalytics = new Panel();
            pnlOutstanding = new Panel();
            iconOutstanding = new FontAwesome.Sharp.IconPictureBox();
            lblOutstanding = new Label();
            lblOutstandingTitle = new Label();
            lineOutstanding = new Panel();
            pnlLowStock = new Panel();
            iconLowStock = new FontAwesome.Sharp.IconPictureBox();
            lblLowStock = new Label();
            lblLowStockTitle = new Label();
            lineLowStock = new Panel();
            dgvRecentInvoices = new DataGridView();
            dgvTopProducts = new DataGridView();
            lblTopProducts = new Label();
            lblRecentInvoices = new Label();
            pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRevenue).BeginInit();
            pnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCustomers).BeginInit();
            pnlInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconInvoices).BeginInit();
            pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconProducts).BeginInit();
            pnlOutstanding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconOutstanding).BeginInit();
            pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconLowStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(iconRevenue);
            pnlRevenue.Controls.Add(lblRevenue);
            pnlRevenue.Controls.Add(lblTitleRevenue);
            pnlRevenue.Controls.Add(lineRevenue);
            pnlRevenue.Location = new Point(18, 65);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(200, 70);
            pnlRevenue.TabIndex = 0;
            // 
            // iconRevenue
            // 
            iconRevenue.BackColor = Color.Transparent;
            iconRevenue.ForeColor = Color.ForestGreen;
            iconRevenue.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            iconRevenue.IconColor = Color.ForestGreen;
            iconRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRevenue.Location = new Point(165, 3);
            iconRevenue.Name = "iconRevenue";
            iconRevenue.Size = new Size(32, 32);
            iconRevenue.TabIndex = 3;
            iconRevenue.TabStop = false;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenue.ForeColor = Color.Black;
            lblRevenue.Location = new Point(8, 35);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(28, 21);
            lblRevenue.TabIndex = 2;
            lblRevenue.Text = "$0";
            // 
            // lblTitleRevenue
            // 
            lblTitleRevenue.AutoSize = true;
            lblTitleRevenue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleRevenue.ForeColor = Color.DimGray;
            lblTitleRevenue.Location = new Point(8, 5);
            lblTitleRevenue.Name = "lblTitleRevenue";
            lblTitleRevenue.Size = new Size(62, 19);
            lblTitleRevenue.TabIndex = 1;
            lblTitleRevenue.Text = "Revenue";
            // 
            // lineRevenue
            // 
            lineRevenue.BackColor = Color.ForestGreen;
            lineRevenue.Dock = DockStyle.Left;
            lineRevenue.Location = new Point(0, 0);
            lineRevenue.Name = "lineRevenue";
            lineRevenue.Size = new Size(2, 70);
            lineRevenue.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblDashboardTitle.Location = new Point(8, 3);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(157, 37);
            lblDashboardTitle.TabIndex = 1;
            lblDashboardTitle.Text = "Dashboard";
            // 
            // pnlCustomers
            // 
            pnlCustomers.BackColor = Color.White;
            pnlCustomers.Controls.Add(iconCustomers);
            pnlCustomers.Controls.Add(lblCustomers);
            pnlCustomers.Controls.Add(lblTitleCustomers);
            pnlCustomers.Controls.Add(lineCustomers);
            pnlCustomers.Location = new Point(233, 65);
            pnlCustomers.Name = "pnlCustomers";
            pnlCustomers.Size = new Size(200, 70);
            pnlCustomers.TabIndex = 2;
            pnlCustomers.Click += pnlCustomers_Click;
            pnlCustomers.Paint += pnlCustomers_Paint;
            // 
            // iconCustomers
            // 
            iconCustomers.BackColor = Color.Transparent;
            iconCustomers.ForeColor = Color.LightSeaGreen;
            iconCustomers.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconCustomers.IconColor = Color.LightSeaGreen;
            iconCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCustomers.Location = new Point(165, 3);
            iconCustomers.Name = "iconCustomers";
            iconCustomers.Size = new Size(32, 32);
            iconCustomers.TabIndex = 3;
            iconCustomers.TabStop = false;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomers.ForeColor = Color.Black;
            lblCustomers.Location = new Point(8, 35);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(19, 21);
            lblCustomers.TabIndex = 2;
            lblCustomers.Text = "0";
            // 
            // lblTitleCustomers
            // 
            lblTitleCustomers.AutoSize = true;
            lblTitleCustomers.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleCustomers.ForeColor = Color.DimGray;
            lblTitleCustomers.Location = new Point(8, 5);
            lblTitleCustomers.Name = "lblTitleCustomers";
            lblTitleCustomers.Size = new Size(75, 19);
            lblTitleCustomers.TabIndex = 1;
            lblTitleCustomers.Text = "Customers";
            // 
            // lineCustomers
            // 
            lineCustomers.BackColor = Color.LightSeaGreen;
            lineCustomers.Dock = DockStyle.Left;
            lineCustomers.Location = new Point(0, 0);
            lineCustomers.Name = "lineCustomers";
            lineCustomers.Size = new Size(2, 70);
            lineCustomers.TabIndex = 0;
            // 
            // pnlInvoices
            // 
            pnlInvoices.BackColor = Color.White;
            pnlInvoices.Controls.Add(iconInvoices);
            pnlInvoices.Controls.Add(lblInvoices);
            pnlInvoices.Controls.Add(lblTitleInvoices);
            pnlInvoices.Controls.Add(lineInvoices);
            pnlInvoices.Location = new Point(18, 145);
            pnlInvoices.Name = "pnlInvoices";
            pnlInvoices.Size = new Size(200, 70);
            pnlInvoices.TabIndex = 3;
            pnlInvoices.Click += pnlInvoices_Click;
            // 
            // iconInvoices
            // 
            iconInvoices.BackColor = Color.Transparent;
            iconInvoices.ForeColor = Color.SlateBlue;
            iconInvoices.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            iconInvoices.IconColor = Color.SlateBlue;
            iconInvoices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconInvoices.Location = new Point(165, 3);
            iconInvoices.Name = "iconInvoices";
            iconInvoices.Size = new Size(32, 32);
            iconInvoices.TabIndex = 3;
            iconInvoices.TabStop = false;
            // 
            // lblInvoices
            // 
            lblInvoices.AutoSize = true;
            lblInvoices.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoices.ForeColor = Color.Black;
            lblInvoices.Location = new Point(8, 35);
            lblInvoices.Name = "lblInvoices";
            lblInvoices.Size = new Size(19, 21);
            lblInvoices.TabIndex = 2;
            lblInvoices.Text = "0";
            // 
            // lblTitleInvoices
            // 
            lblTitleInvoices.AutoSize = true;
            lblTitleInvoices.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleInvoices.ForeColor = Color.DimGray;
            lblTitleInvoices.Location = new Point(8, 5);
            lblTitleInvoices.Name = "lblTitleInvoices";
            lblTitleInvoices.Size = new Size(60, 19);
            lblTitleInvoices.TabIndex = 1;
            lblTitleInvoices.Text = "Invoices";
            // 
            // lineInvoices
            // 
            lineInvoices.BackColor = Color.SlateBlue;
            lineInvoices.Dock = DockStyle.Left;
            lineInvoices.Location = new Point(0, 0);
            lineInvoices.Name = "lineInvoices";
            lineInvoices.Size = new Size(2, 70);
            lineInvoices.TabIndex = 0;
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = Color.White;
            pnlProducts.Controls.Add(iconProducts);
            pnlProducts.Controls.Add(lblProducts);
            pnlProducts.Controls.Add(lblTitleProducts);
            pnlProducts.Controls.Add(lineProducts);
            pnlProducts.Location = new Point(233, 145);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(200, 70);
            pnlProducts.TabIndex = 4;
            pnlProducts.Click += pnlProducts_Click;
            // 
            // iconProducts
            // 
            iconProducts.BackColor = Color.Transparent;
            iconProducts.ForeColor = Color.DarkMagenta;
            iconProducts.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            iconProducts.IconColor = Color.DarkMagenta;
            iconProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconProducts.Location = new Point(165, 3);
            iconProducts.Name = "iconProducts";
            iconProducts.Size = new Size(32, 32);
            iconProducts.TabIndex = 3;
            iconProducts.TabStop = false;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducts.ForeColor = Color.Black;
            lblProducts.Location = new Point(8, 35);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(19, 21);
            lblProducts.TabIndex = 2;
            lblProducts.Text = "0";
            // 
            // lblTitleProducts
            // 
            lblTitleProducts.AutoSize = true;
            lblTitleProducts.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleProducts.ForeColor = Color.DimGray;
            lblTitleProducts.Location = new Point(8, 5);
            lblTitleProducts.Name = "lblTitleProducts";
            lblTitleProducts.Size = new Size(64, 19);
            lblTitleProducts.TabIndex = 1;
            lblTitleProducts.Text = "Products";
            // 
            // lineProducts
            // 
            lineProducts.BackColor = Color.DarkMagenta;
            lineProducts.Dock = DockStyle.Left;
            lineProducts.Location = new Point(0, 0);
            lineProducts.Name = "lineProducts";
            lineProducts.Size = new Size(2, 70);
            lineProducts.TabIndex = 0;
            // 
            // pnlAnalytics
            // 
            pnlAnalytics.BackColor = Color.White;
            pnlAnalytics.Location = new Point(18, 313);
            pnlAnalytics.Margin = new Padding(3, 2, 3, 2);
            pnlAnalytics.Name = "pnlAnalytics";
            pnlAnalytics.Size = new Size(415, 215);
            pnlAnalytics.TabIndex = 5;
            pnlAnalytics.Paint += pnlAnalytics_Paint;
            // 
            // pnlOutstanding
            // 
            pnlOutstanding.BackColor = Color.White;
            pnlOutstanding.Controls.Add(iconOutstanding);
            pnlOutstanding.Controls.Add(lblOutstanding);
            pnlOutstanding.Controls.Add(lblOutstandingTitle);
            pnlOutstanding.Controls.Add(lineOutstanding);
            pnlOutstanding.Location = new Point(18, 225);
            pnlOutstanding.Name = "pnlOutstanding";
            pnlOutstanding.Size = new Size(200, 70);
            pnlOutstanding.TabIndex = 5;
            // 
            // iconOutstanding
            // 
            iconOutstanding.BackColor = Color.Transparent;
            iconOutstanding.ForeColor = Color.Goldenrod;
            iconOutstanding.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            iconOutstanding.IconColor = Color.Goldenrod;
            iconOutstanding.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconOutstanding.Location = new Point(165, 3);
            iconOutstanding.Name = "iconOutstanding";
            iconOutstanding.Size = new Size(32, 32);
            iconOutstanding.TabIndex = 3;
            iconOutstanding.TabStop = false;
            // 
            // lblOutstanding
            // 
            lblOutstanding.AutoSize = true;
            lblOutstanding.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutstanding.ForeColor = Color.Black;
            lblOutstanding.Location = new Point(8, 35);
            lblOutstanding.Name = "lblOutstanding";
            lblOutstanding.Size = new Size(28, 21);
            lblOutstanding.TabIndex = 2;
            lblOutstanding.Text = "$0";
            // 
            // lblOutstandingTitle
            // 
            lblOutstandingTitle.AutoSize = true;
            lblOutstandingTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutstandingTitle.ForeColor = Color.DimGray;
            lblOutstandingTitle.Location = new Point(8, 5);
            lblOutstandingTitle.Name = "lblOutstandingTitle";
            lblOutstandingTitle.Size = new Size(87, 19);
            lblOutstandingTitle.TabIndex = 1;
            lblOutstandingTitle.Text = "Outstanding";
            // 
            // lineOutstanding
            // 
            lineOutstanding.BackColor = Color.Goldenrod;
            lineOutstanding.Dock = DockStyle.Left;
            lineOutstanding.Location = new Point(0, 0);
            lineOutstanding.Name = "lineOutstanding";
            lineOutstanding.Size = new Size(2, 70);
            lineOutstanding.TabIndex = 0;
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.Controls.Add(iconLowStock);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Controls.Add(lblLowStockTitle);
            pnlLowStock.Controls.Add(lineLowStock);
            pnlLowStock.Location = new Point(233, 225);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(200, 70);
            pnlLowStock.TabIndex = 6;
            // 
            // iconLowStock
            // 
            iconLowStock.BackColor = Color.Transparent;
            iconLowStock.ForeColor = Color.Crimson;
            iconLowStock.IconChar = FontAwesome.Sharp.IconChar.LongArrowDown;
            iconLowStock.IconColor = Color.Crimson;
            iconLowStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconLowStock.IconSize = 30;
            iconLowStock.Location = new Point(165, 3);
            iconLowStock.Name = "iconLowStock";
            iconLowStock.Size = new Size(32, 30);
            iconLowStock.TabIndex = 3;
            iconLowStock.TabStop = false;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.Black;
            lblLowStock.Location = new Point(8, 35);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(19, 21);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "0";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockTitle.ForeColor = Color.DimGray;
            lblLowStockTitle.Location = new Point(8, 5);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(74, 19);
            lblLowStockTitle.TabIndex = 1;
            lblLowStockTitle.Text = "Low Stock";
            // 
            // lineLowStock
            // 
            lineLowStock.BackColor = Color.Crimson;
            lineLowStock.Dock = DockStyle.Left;
            lineLowStock.Location = new Point(0, 0);
            lineLowStock.Name = "lineLowStock";
            lineLowStock.Size = new Size(2, 70);
            lineLowStock.TabIndex = 0;
            // 
            // dgvRecentInvoices
            // 
            dgvRecentInvoices.AllowUserToAddRows = false;
            dgvRecentInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentInvoices.BackgroundColor = Color.White;
            dgvRecentInvoices.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentInvoices.Location = new Point(448, 313);
            dgvRecentInvoices.MultiSelect = false;
            dgvRecentInvoices.Name = "dgvRecentInvoices";
            dgvRecentInvoices.ReadOnly = true;
            dgvRecentInvoices.RowHeadersVisible = false;
            dgvRecentInvoices.RowHeadersWidth = 51;
            dgvRecentInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentInvoices.Size = new Size(227, 150);
            dgvRecentInvoices.TabIndex = 10;
            dgvRecentInvoices.CellDoubleClick += dgvRecentInvoices_CellDoubleClick;
            dgvRecentInvoices.DataBindingComplete += dgvRecentInvoices_DataBindingComplete;
            // 
            // dgvTopProducts
            // 
            dgvTopProducts.AllowUserToAddRows = false;
            dgvTopProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopProducts.BackgroundColor = Color.White;
            dgvTopProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTopProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTopProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTopProducts.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTopProducts.Location = new Point(448, 65);
            dgvTopProducts.MultiSelect = false;
            dgvTopProducts.Name = "dgvTopProducts";
            dgvTopProducts.ReadOnly = true;
            dgvTopProducts.RowHeadersVisible = false;
            dgvTopProducts.RowHeadersWidth = 51;
            dgvTopProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTopProducts.Size = new Size(227, 150);
            dgvTopProducts.TabIndex = 11;
            dgvTopProducts.CellDoubleClick += dgvTopProducts_CellDoubleClick;
            dgvTopProducts.DataBindingComplete += dgvTopProducts_DataBindingComplete;
            // 
            // lblTopProducts
            // 
            lblTopProducts.AutoSize = true;
            lblTopProducts.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopProducts.ForeColor = Color.DarkMagenta;
            lblTopProducts.Location = new Point(448, 30);
            lblTopProducts.Name = "lblTopProducts";
            lblTopProducts.Size = new Size(130, 25);
            lblTopProducts.TabIndex = 12;
            lblTopProducts.Text = "Top Products";
            // 
            // lblRecentInvoices
            // 
            lblRecentInvoices.AutoSize = true;
            lblRecentInvoices.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentInvoices.ForeColor = Color.SlateBlue;
            lblRecentInvoices.Location = new Point(448, 279);
            lblRecentInvoices.Name = "lblRecentInvoices";
            lblRecentInvoices.Size = new Size(149, 25);
            lblRecentInvoices.TabIndex = 13;
            lblRecentInvoices.Text = "Recent Invoices";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            Controls.Add(lblRecentInvoices);
            Controls.Add(lblTopProducts);
            Controls.Add(dgvTopProducts);
            Controls.Add(dgvRecentInvoices);
            Controls.Add(pnlLowStock);
            Controls.Add(pnlOutstanding);
            Controls.Add(pnlAnalytics);
            Controls.Add(pnlProducts);
            Controls.Add(pnlInvoices);
            Controls.Add(pnlCustomers);
            Controls.Add(lblDashboardTitle);
            Controls.Add(pnlRevenue);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardControl";
            Size = new Size(725, 725);
            Load += DashboardControl_Load;
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconRevenue).EndInit();
            pnlCustomers.ResumeLayout(false);
            pnlCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCustomers).EndInit();
            pnlInvoices.ResumeLayout(false);
            pnlInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconInvoices).EndInit();
            pnlProducts.ResumeLayout(false);
            pnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconProducts).EndInit();
            pnlOutstanding.ResumeLayout(false);
            pnlOutstanding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconOutstanding).EndInit();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconLowStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlRevenue;
        private Panel lineRevenue;
        private Label lblTitleRevenue;
        private Label lblRevenue;
        private FontAwesome.Sharp.IconPictureBox iconRevenue;
        private Label lblDashboardTitle;
        private Panel pnlCustomers;
        private FontAwesome.Sharp.IconPictureBox iconCustomers;
        private Label lblCustomers;
        private Label lblTitleCustomers;
        private Panel lineCustomers;
        private Panel pnlInvoices;
        private FontAwesome.Sharp.IconPictureBox iconInvoices;
        private Label lblInvoices;
        private Label lblTitleInvoices;
        private Panel lineInvoices;
        private Panel pnlProducts;
        private FontAwesome.Sharp.IconPictureBox iconProducts;
        private Label lblProducts;
        private Label lblTitleProducts;
        private Panel lineProducts;
        private Panel pnlAnalytics;
        private Panel pnlOutstanding;
        private FontAwesome.Sharp.IconPictureBox iconOutstanding;
        private Label lblOutstanding;
        private Label lblOutstandingTitle;
        private Panel lineOutstanding;
        private Panel pnlLowStock;
        private FontAwesome.Sharp.IconPictureBox iconLowStock;
        private Label lblLowStock;
        private Label lblLowStockTitle;
        private Panel lineLowStock;
        private DataGridView dgvRecentInvoices;
        private DataGridView dgvTopProducts;
        private Label lblTopProducts;
        private Label lblRecentInvoices;
    }
}