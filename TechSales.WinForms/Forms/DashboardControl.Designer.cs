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
            pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRevenue).BeginInit();
            pnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCustomers).BeginInit();
            pnlInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconInvoices).BeginInit();
            pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(iconRevenue);
            pnlRevenue.Controls.Add(lblRevenue);
            pnlRevenue.Controls.Add(lblTitleRevenue);
            pnlRevenue.Controls.Add(lineRevenue);
            pnlRevenue.Location = new Point(18, 85);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(120, 60);
            pnlRevenue.TabIndex = 0;
            // 
            // iconRevenue
            // 
            iconRevenue.BackColor = Color.Transparent;
            iconRevenue.ForeColor = Color.ForestGreen;
            iconRevenue.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            iconRevenue.IconColor = Color.ForestGreen;
            iconRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRevenue.Location = new Point(86, 4);
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
            lblRevenue.Location = new Point(8, 30);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(59, 21);
            lblRevenue.TabIndex = 2;
            lblRevenue.Text = "$7,302";
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
            lineRevenue.Size = new Size(3, 60);
            lineRevenue.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.FromArgb(3, 38, 53);
            lblDashboardTitle.Location = new Point(8, 23);
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
            pnlCustomers.Location = new Point(178, 85);
            pnlCustomers.Name = "pnlCustomers";
            pnlCustomers.Size = new Size(120, 60);
            pnlCustomers.TabIndex = 2;
            // 
            // iconCustomers
            // 
            iconCustomers.BackColor = Color.Transparent;
            iconCustomers.ForeColor = Color.LightSeaGreen;
            iconCustomers.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconCustomers.IconColor = Color.LightSeaGreen;
            iconCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCustomers.Location = new Point(86, 4);
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
            lblCustomers.Location = new Point(8, 30);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(37, 21);
            lblCustomers.TabIndex = 2;
            lblCustomers.Text = "532";
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
            lineCustomers.Size = new Size(3, 60);
            lineCustomers.TabIndex = 0;
            // 
            // pnlInvoices
            // 
            pnlInvoices.BackColor = Color.White;
            pnlInvoices.Controls.Add(iconInvoices);
            pnlInvoices.Controls.Add(lblInvoices);
            pnlInvoices.Controls.Add(lblTitleInvoices);
            pnlInvoices.Controls.Add(lineInvoices);
            pnlInvoices.Location = new Point(338, 85);
            pnlInvoices.Name = "pnlInvoices";
            pnlInvoices.Size = new Size(120, 60);
            pnlInvoices.TabIndex = 3;
            // 
            // iconInvoices
            // 
            iconInvoices.BackColor = Color.Transparent;
            iconInvoices.ForeColor = Color.SlateBlue;
            iconInvoices.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            iconInvoices.IconColor = Color.SlateBlue;
            iconInvoices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconInvoices.Location = new Point(86, 4);
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
            lblInvoices.Location = new Point(8, 30);
            lblInvoices.Name = "lblInvoices";
            lblInvoices.Size = new Size(46, 21);
            lblInvoices.TabIndex = 2;
            lblInvoices.Text = "7640";
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
            lineInvoices.Size = new Size(3, 60);
            lineInvoices.TabIndex = 0;
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = Color.White;
            pnlProducts.Controls.Add(iconProducts);
            pnlProducts.Controls.Add(lblProducts);
            pnlProducts.Controls.Add(lblTitleProducts);
            pnlProducts.Controls.Add(lineProducts);
            pnlProducts.Location = new Point(498, 85);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(120, 60);
            pnlProducts.TabIndex = 4;
            // 
            // iconProducts
            // 
            iconProducts.BackColor = Color.Transparent;
            iconProducts.ForeColor = Color.Crimson;
            iconProducts.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            iconProducts.IconColor = Color.Crimson;
            iconProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconProducts.Location = new Point(86, 4);
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
            lblProducts.Location = new Point(8, 30);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(37, 21);
            lblProducts.TabIndex = 2;
            lblProducts.Text = "540";
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
            lineProducts.BackColor = Color.Crimson;
            lineProducts.Dock = DockStyle.Left;
            lineProducts.Location = new Point(0, 0);
            lineProducts.Name = "lineProducts";
            lineProducts.Size = new Size(3, 60);
            lineProducts.TabIndex = 0;
            // 
            // pnlAnalytics
            // 
            pnlAnalytics.BackColor = Color.White;
            pnlAnalytics.Location = new Point(18, 183);
            pnlAnalytics.Margin = new Padding(3, 2, 3, 2);
            pnlAnalytics.Name = "pnlAnalytics";
            pnlAnalytics.Size = new Size(278, 183);
            pnlAnalytics.TabIndex = 5;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
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
    }
}