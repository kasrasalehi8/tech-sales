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
            pnlOrders = new Panel();
            iconOrders = new FontAwesome.Sharp.IconPictureBox();
            lblOrders = new Label();
            lblTitleOrders = new Label();
            lineOrders = new Panel();
            pnlProducts = new Panel();
            iconProducts = new FontAwesome.Sharp.IconPictureBox();
            lblProducts = new Label();
            lblTitleProducts = new Label();
            lineProducts = new Panel();
            pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRevenue).BeginInit();
            pnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCustomers).BeginInit();
            pnlOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconOrders).BeginInit();
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
            iconRevenue.IconSize = 30;
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
            iconCustomers.IconSize = 30;
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
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.White;
            pnlOrders.Controls.Add(iconOrders);
            pnlOrders.Controls.Add(lblOrders);
            pnlOrders.Controls.Add(lblTitleOrders);
            pnlOrders.Controls.Add(lineOrders);
            pnlOrders.Location = new Point(338, 85);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(120, 60);
            pnlOrders.TabIndex = 3;
            // 
            // iconOrders
            // 
            iconOrders.BackColor = Color.Transparent;
            iconOrders.ForeColor = Color.SlateBlue;
            iconOrders.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            iconOrders.IconColor = Color.SlateBlue;
            iconOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconOrders.IconSize = 30;
            iconOrders.Location = new Point(86, 4);
            iconOrders.Name = "iconOrders";
            iconOrders.Size = new Size(32, 32);
            iconOrders.TabIndex = 3;
            iconOrders.TabStop = false;
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrders.ForeColor = Color.Black;
            lblOrders.Location = new Point(8, 30);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(46, 21);
            lblOrders.TabIndex = 2;
            lblOrders.Text = "7640";
            // 
            // lblTitleOrders
            // 
            lblTitleOrders.AutoSize = true;
            lblTitleOrders.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleOrders.ForeColor = Color.DimGray;
            lblTitleOrders.Location = new Point(8, 5);
            lblTitleOrders.Name = "lblTitleOrders";
            lblTitleOrders.Size = new Size(51, 19);
            lblTitleOrders.TabIndex = 1;
            lblTitleOrders.Text = "Orders";
            // 
            // lineOrders
            // 
            lineOrders.BackColor = Color.SlateBlue;
            lineOrders.Dock = DockStyle.Left;
            lineOrders.Location = new Point(0, 0);
            lineOrders.Name = "lineOrders";
            lineOrders.Size = new Size(3, 60);
            lineOrders.TabIndex = 0;
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
            iconProducts.IconSize = 30;
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
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            Controls.Add(pnlProducts);
            Controls.Add(pnlOrders);
            Controls.Add(pnlCustomers);
            Controls.Add(lblDashboardTitle);
            Controls.Add(pnlRevenue);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardControl";
            Size = new Size(725, 543);
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconRevenue).EndInit();
            pnlCustomers.ResumeLayout(false);
            pnlCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCustomers).EndInit();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconOrders).EndInit();
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
        private Panel pnlOrders;
        private FontAwesome.Sharp.IconPictureBox iconOrders;
        private Label lblOrders;
        private Label lblTitleOrders;
        private Panel lineOrders;
        private Panel pnlProducts;
        private FontAwesome.Sharp.IconPictureBox iconProducts;
        private Label lblProducts;
        private Label lblTitleProducts;
        private Panel lineProducts;
    }
}