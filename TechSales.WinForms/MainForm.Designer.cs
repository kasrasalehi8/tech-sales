namespace TechSales.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebar = new Panel();
            pnlSuppliers = new Panel();
            lblSuppliers = new Label();
            iconSuppliers = new FontAwesome.Sharp.IconPictureBox();
            pnlInvoices = new Panel();
            lblInvoices = new Label();
            iconInvoices = new FontAwesome.Sharp.IconPictureBox();
            pnlCustomers = new Panel();
            lblCustomers = new Label();
            iconCustomers = new FontAwesome.Sharp.IconPictureBox();
            pnlProduct = new Panel();
            lblProduct = new Label();
            iconProduct = new FontAwesome.Sharp.IconPictureBox();
            pnlDashboard = new Panel();
            lblDashboard = new Label();
            iconDashboard = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            TechSales = new Label();
            mainMenu = new Label();
            salesManagementDashboard = new Label();
            topbar = new Panel();
            lblWelcomeText = new Label();
            userIcon = new FontAwesome.Sharp.IconPictureBox();
            mainPanel = new Panel();
            sidebar.SuspendLayout();
            pnlSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconSuppliers).BeginInit();
            pnlInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconInvoices).BeginInit();
            pnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCustomers).BeginInit();
            pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconProduct).BeginInit();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(3, 38, 53);
            sidebar.Controls.Add(pnlSuppliers);
            sidebar.Controls.Add(pnlInvoices);
            sidebar.Controls.Add(pnlCustomers);
            sidebar.Controls.Add(pnlProduct);
            sidebar.Controls.Add(pnlDashboard);
            sidebar.Controls.Add(iconPictureBox1);
            sidebar.Controls.Add(TechSales);
            sidebar.Controls.Add(mainMenu);
            sidebar.Controls.Add(salesManagementDashboard);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 2, 3, 2);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(154, 550);
            sidebar.TabIndex = 1;
            // 
            // pnlSuppliers
            // 
            pnlSuppliers.Controls.Add(lblSuppliers);
            pnlSuppliers.Controls.Add(iconSuppliers);
            pnlSuppliers.Location = new Point(-1, 195);
            pnlSuppliers.Margin = new Padding(3, 2, 3, 2);
            pnlSuppliers.Name = "pnlSuppliers";
            pnlSuppliers.Size = new Size(154, 29);
            pnlSuppliers.TabIndex = 11;
            // 
            // lblSuppliers
            // 
            lblSuppliers.AutoSize = true;
            lblSuppliers.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuppliers.ForeColor = SystemColors.ControlLightLight;
            lblSuppliers.Location = new Point(45, 8);
            lblSuppliers.Name = "lblSuppliers";
            lblSuppliers.Size = new Size(47, 12);
            lblSuppliers.TabIndex = 3;
            lblSuppliers.Text = "Suppliers";
            // 
            // iconSuppliers
            // 
            iconSuppliers.BackColor = Color.Transparent;
            iconSuppliers.ForeColor = SystemColors.ControlLightLight;
            iconSuppliers.IconChar = FontAwesome.Sharp.IconChar.Building;
            iconSuppliers.IconColor = SystemColors.ControlLightLight;
            iconSuppliers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSuppliers.IconSize = 20;
            iconSuppliers.Location = new Point(16, 4);
            iconSuppliers.Margin = new Padding(3, 2, 3, 2);
            iconSuppliers.Name = "iconSuppliers";
            iconSuppliers.Size = new Size(26, 20);
            iconSuppliers.TabIndex = 2;
            iconSuppliers.TabStop = false;
            // 
            // pnlInvoices
            // 
            pnlInvoices.Controls.Add(lblInvoices);
            pnlInvoices.Controls.Add(iconInvoices);
            pnlInvoices.Location = new Point(0, 167);
            pnlInvoices.Margin = new Padding(3, 2, 3, 2);
            pnlInvoices.Name = "pnlInvoices";
            pnlInvoices.Size = new Size(154, 29);
            pnlInvoices.TabIndex = 10;
            // 
            // lblInvoices
            // 
            lblInvoices.AutoSize = true;
            lblInvoices.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoices.ForeColor = SystemColors.ControlLightLight;
            lblInvoices.Location = new Point(45, 8);
            lblInvoices.Name = "lblInvoices";
            lblInvoices.Size = new Size(42, 12);
            lblInvoices.TabIndex = 3;
            lblInvoices.Text = "Invoices";
            // 
            // iconInvoices
            // 
            iconInvoices.BackColor = Color.Transparent;
            iconInvoices.ForeColor = SystemColors.ControlLightLight;
            iconInvoices.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            iconInvoices.IconColor = SystemColors.ControlLightLight;
            iconInvoices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconInvoices.IconSize = 20;
            iconInvoices.Location = new Point(15, 4);
            iconInvoices.Margin = new Padding(3, 2, 3, 2);
            iconInvoices.Name = "iconInvoices";
            iconInvoices.Size = new Size(26, 20);
            iconInvoices.TabIndex = 2;
            iconInvoices.TabStop = false;
            // 
            // pnlCustomers
            // 
            pnlCustomers.Controls.Add(lblCustomers);
            pnlCustomers.Controls.Add(iconCustomers);
            pnlCustomers.Location = new Point(0, 139);
            pnlCustomers.Margin = new Padding(3, 2, 3, 2);
            pnlCustomers.Name = "pnlCustomers";
            pnlCustomers.Size = new Size(154, 29);
            pnlCustomers.TabIndex = 9;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomers.ForeColor = SystemColors.ControlLightLight;
            lblCustomers.Location = new Point(45, 8);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(53, 12);
            lblCustomers.TabIndex = 3;
            lblCustomers.Text = "Customers";
            // 
            // iconCustomers
            // 
            iconCustomers.BackColor = Color.Transparent;
            iconCustomers.ForeColor = SystemColors.ControlLightLight;
            iconCustomers.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconCustomers.IconColor = SystemColors.ControlLightLight;
            iconCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCustomers.IconSize = 20;
            iconCustomers.Location = new Point(16, 4);
            iconCustomers.Margin = new Padding(3, 2, 3, 2);
            iconCustomers.Name = "iconCustomers";
            iconCustomers.Size = new Size(26, 20);
            iconCustomers.TabIndex = 2;
            iconCustomers.TabStop = false;
            // 
            // pnlProduct
            // 
            pnlProduct.Controls.Add(lblProduct);
            pnlProduct.Controls.Add(iconProduct);
            pnlProduct.Location = new Point(0, 111);
            pnlProduct.Margin = new Padding(3, 2, 3, 2);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new Size(154, 29);
            pnlProduct.TabIndex = 9;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduct.ForeColor = SystemColors.ControlLightLight;
            lblProduct.Location = new Point(45, 8);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(46, 12);
            lblProduct.TabIndex = 3;
            lblProduct.Text = "Products";
            // 
            // iconProduct
            // 
            iconProduct.BackColor = Color.Transparent;
            iconProduct.ForeColor = SystemColors.ControlLightLight;
            iconProduct.IconChar = FontAwesome.Sharp.IconChar.Box;
            iconProduct.IconColor = SystemColors.ControlLightLight;
            iconProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconProduct.IconSize = 20;
            iconProduct.Location = new Point(16, 4);
            iconProduct.Margin = new Padding(3, 2, 3, 2);
            iconProduct.Name = "iconProduct";
            iconProduct.Size = new Size(26, 20);
            iconProduct.TabIndex = 2;
            iconProduct.TabStop = false;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(iconDashboard);
            pnlDashboard.Location = new Point(0, 83);
            pnlDashboard.Margin = new Padding(3, 2, 3, 2);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(154, 29);
            pnlDashboard.TabIndex = 8;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = SystemColors.ControlLightLight;
            lblDashboard.Location = new Point(45, 8);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(54, 12);
            lblDashboard.TabIndex = 3;
            lblDashboard.Text = "Dashboard";
            // 
            // iconDashboard
            // 
            iconDashboard.BackColor = Color.Transparent;
            iconDashboard.ForeColor = SystemColors.ControlLightLight;
            iconDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            iconDashboard.IconColor = SystemColors.ControlLightLight;
            iconDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDashboard.IconSize = 20;
            iconDashboard.Location = new Point(16, 4);
            iconDashboard.Margin = new Padding(3, 2, 3, 2);
            iconDashboard.Name = "iconDashboard";
            iconDashboard.Size = new Size(26, 20);
            iconDashboard.TabIndex = 2;
            iconDashboard.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Poll;
            iconPictureBox1.IconColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 22;
            iconPictureBox1.Location = new Point(16, 10);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(26, 22);
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            // 
            // TechSales
            // 
            TechSales.AutoSize = true;
            TechSales.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TechSales.ForeColor = SystemColors.ControlLightLight;
            TechSales.Location = new Point(38, 7);
            TechSales.Name = "TechSales";
            TechSales.Size = new Size(94, 25);
            TechSales.TabIndex = 5;
            TechSales.Text = "TechSales";
            // 
            // mainMenu
            // 
            mainMenu.AutoSize = true;
            mainMenu.Font = new Font("Segoe UI Semibold", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainMenu.ForeColor = SystemColors.ControlLightLight;
            mainMenu.Location = new Point(16, 66);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(50, 11);
            mainMenu.TabIndex = 3;
            mainMenu.Text = "MAIN MENU";
            // 
            // salesManagementDashboard
            // 
            salesManagementDashboard.AutoSize = true;
            salesManagementDashboard.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesManagementDashboard.ForeColor = SystemColors.ControlLightLight;
            salesManagementDashboard.Location = new Point(16, 33);
            salesManagementDashboard.Name = "salesManagementDashboard";
            salesManagementDashboard.Size = new Size(112, 12);
            salesManagementDashboard.TabIndex = 2;
            salesManagementDashboard.Text = "Sales Management App";
            // 
            // topbar
            // 
            topbar.BackColor = SystemColors.ControlLightLight;
            topbar.Controls.Add(lblWelcomeText);
            topbar.Controls.Add(userIcon);
            topbar.Dock = DockStyle.Top;
            topbar.Location = new Point(154, 0);
            topbar.Margin = new Padding(3, 2, 3, 2);
            topbar.Name = "topbar";
            topbar.Size = new Size(705, 41);
            topbar.TabIndex = 2;
            // 
            // lblWelcomeText
            // 
            lblWelcomeText.AutoSize = true;
            lblWelcomeText.BackColor = Color.Transparent;
            lblWelcomeText.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeText.ForeColor = Color.FromArgb(3, 38, 53);
            lblWelcomeText.Location = new Point(10, 7);
            lblWelcomeText.Name = "lblWelcomeText";
            lblWelcomeText.Size = new Size(137, 25);
            lblWelcomeText.TabIndex = 1;
            lblWelcomeText.Text = "Welcome Back";
            lblWelcomeText.Click += label1_Click_2;
            // 
            // userIcon
            // 
            userIcon.BackColor = SystemColors.ControlLightLight;
            userIcon.ForeColor = Color.FromArgb(3, 38, 53);
            userIcon.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            userIcon.IconColor = Color.FromArgb(3, 38, 53);
            userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userIcon.IconSize = 37;
            userIcon.Location = new Point(652, 4);
            userIcon.Margin = new Padding(3, 2, 3, 2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(52, 37);
            userIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            userIcon.TabIndex = 0;
            userIcon.TabStop = false;
            userIcon.Click += iconPictureBox2_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(154, 41);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(705, 509);
            mainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(859, 550);
            Controls.Add(mainPanel);
            Controls.Add(topbar);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            pnlSuppliers.ResumeLayout(false);
            pnlSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconSuppliers).EndInit();
            pnlInvoices.ResumeLayout(false);
            pnlInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconInvoices).EndInit();
            pnlCustomers.ResumeLayout(false);
            pnlCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCustomers).EndInit();
            pnlProduct.ResumeLayout(false);
            pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconProduct).EndInit();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            topbar.ResumeLayout(false);
            topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebar;
        private Panel topbar;
        private Label salesManagementDashboard;
        private Label mainMenu;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private Panel mainPanel;
        private Label TechSales;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel pnlDashboard;
        private Label lblDashboard;
        private FontAwesome.Sharp.IconPictureBox iconDashboard;
        private Panel pnlProduct;
        private Label lblProduct;
        private FontAwesome.Sharp.IconPictureBox iconProduct;
        private Panel pnlCustomers;
        private Label lblCustomers;
        private FontAwesome.Sharp.IconPictureBox iconCustomers;
        private Panel pnlInvoices;
        private Label lblInvoices;
        private FontAwesome.Sharp.IconPictureBox iconInvoices;
        private Panel pnlSuppliers;
        private Label lblSuppliers;
        private FontAwesome.Sharp.IconPictureBox iconSuppliers;
        private Label lblWelcomeText;
    }
}
