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
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            pnlInvoices = new Panel();
            lblInvoices = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
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
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            pnlInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
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
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(176, 733);
            sidebar.TabIndex = 1;
            // 
            // pnlSuppliers
            // 
            pnlSuppliers.Controls.Add(lblSuppliers);
            pnlSuppliers.Controls.Add(iconPictureBox3);
            pnlSuppliers.Location = new Point(-1, 260);
            pnlSuppliers.Name = "pnlSuppliers";
            pnlSuppliers.Size = new Size(176, 39);
            pnlSuppliers.TabIndex = 11;
            // 
            // lblSuppliers
            // 
            lblSuppliers.AutoSize = true;
            lblSuppliers.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSuppliers.ForeColor = SystemColors.ControlLightLight;
            lblSuppliers.Location = new Point(51, 11);
            lblSuppliers.Name = "lblSuppliers";
            lblSuppliers.Size = new Size(63, 17);
            lblSuppliers.TabIndex = 3;
            lblSuppliers.Text = "Suppliers";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Building;
            iconPictureBox3.IconColor = SystemColors.ControlLightLight;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 27;
            iconPictureBox3.Location = new Point(18, 5);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(30, 27);
            iconPictureBox3.TabIndex = 2;
            iconPictureBox3.TabStop = false;
            // 
            // pnlInvoices
            // 
            pnlInvoices.Controls.Add(lblInvoices);
            pnlInvoices.Controls.Add(iconPictureBox2);
            pnlInvoices.Location = new Point(0, 223);
            pnlInvoices.Name = "pnlInvoices";
            pnlInvoices.Size = new Size(176, 39);
            pnlInvoices.TabIndex = 10;
            // 
            // lblInvoices
            // 
            lblInvoices.AutoSize = true;
            lblInvoices.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvoices.ForeColor = SystemColors.ControlLightLight;
            lblInvoices.Location = new Point(51, 11);
            lblInvoices.Name = "lblInvoices";
            lblInvoices.Size = new Size(57, 17);
            lblInvoices.TabIndex = 3;
            lblInvoices.Text = "Invoices";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            iconPictureBox2.IconColor = SystemColors.ControlLightLight;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 27;
            iconPictureBox2.Location = new Point(17, 5);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(30, 27);
            iconPictureBox2.TabIndex = 2;
            iconPictureBox2.TabStop = false;
            // 
            // pnlCustomers
            // 
            pnlCustomers.Controls.Add(lblCustomers);
            pnlCustomers.Controls.Add(iconCustomers);
            pnlCustomers.Location = new Point(0, 185);
            pnlCustomers.Name = "pnlCustomers";
            pnlCustomers.Size = new Size(176, 39);
            pnlCustomers.TabIndex = 9;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomers.ForeColor = SystemColors.ControlLightLight;
            lblCustomers.Location = new Point(51, 11);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(73, 17);
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
            iconCustomers.IconSize = 27;
            iconCustomers.Location = new Point(18, 5);
            iconCustomers.Name = "iconCustomers";
            iconCustomers.Size = new Size(30, 27);
            iconCustomers.TabIndex = 2;
            iconCustomers.TabStop = false;
            // 
            // pnlProduct
            // 
            pnlProduct.Controls.Add(lblProduct);
            pnlProduct.Controls.Add(iconProduct);
            pnlProduct.Location = new Point(0, 148);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.Size = new Size(176, 39);
            pnlProduct.TabIndex = 9;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduct.ForeColor = SystemColors.ControlLightLight;
            lblProduct.Location = new Point(51, 11);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(62, 17);
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
            iconProduct.IconSize = 27;
            iconProduct.Location = new Point(18, 5);
            iconProduct.Name = "iconProduct";
            iconProduct.Size = new Size(30, 27);
            iconProduct.TabIndex = 2;
            iconProduct.TabStop = false;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(iconDashboard);
            pnlDashboard.Location = new Point(0, 111);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(176, 39);
            pnlDashboard.TabIndex = 8;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = SystemColors.ControlLightLight;
            lblDashboard.Location = new Point(51, 11);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(74, 17);
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
            iconDashboard.IconSize = 27;
            iconDashboard.Location = new Point(18, 5);
            iconDashboard.Name = "iconDashboard";
            iconDashboard.Size = new Size(30, 27);
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
            iconPictureBox1.IconSize = 29;
            iconPictureBox1.Location = new Point(18, 13);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(30, 29);
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            // 
            // TechSales
            // 
            TechSales.AutoSize = true;
            TechSales.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TechSales.ForeColor = SystemColors.ControlLightLight;
            TechSales.Location = new Point(43, 9);
            TechSales.Name = "TechSales";
            TechSales.Size = new Size(112, 30);
            TechSales.TabIndex = 5;
            TechSales.Text = "TechSales";
            // 
            // mainMenu
            // 
            mainMenu.AutoSize = true;
            mainMenu.Font = new Font("Segoe UI Semibold", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainMenu.ForeColor = SystemColors.ControlLightLight;
            mainMenu.Location = new Point(18, 88);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(64, 12);
            mainMenu.TabIndex = 3;
            mainMenu.Text = "MAIN MENU";
            // 
            // salesManagementDashboard
            // 
            salesManagementDashboard.AutoSize = true;
            salesManagementDashboard.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesManagementDashboard.ForeColor = SystemColors.ControlLightLight;
            salesManagementDashboard.Location = new Point(18, 44);
            salesManagementDashboard.Name = "salesManagementDashboard";
            salesManagementDashboard.Size = new Size(133, 15);
            salesManagementDashboard.TabIndex = 2;
            salesManagementDashboard.Text = "Sales Management App";
            // 
            // topbar
            // 
            topbar.BackColor = SystemColors.ControlLightLight;
            topbar.Controls.Add(lblWelcomeText);
            topbar.Controls.Add(userIcon);
            topbar.Dock = DockStyle.Top;
            topbar.Location = new Point(176, 0);
            topbar.Name = "topbar";
            topbar.Size = new Size(806, 55);
            topbar.TabIndex = 2;
            // 
            // lblWelcomeText
            // 
            lblWelcomeText.AutoSize = true;
            lblWelcomeText.BackColor = Color.Transparent;
            lblWelcomeText.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeText.ForeColor = Color.FromArgb(3, 38, 53);
            lblWelcomeText.Location = new Point(11, 9);
            lblWelcomeText.Name = "lblWelcomeText";
            lblWelcomeText.Size = new Size(173, 32);
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
            userIcon.IconSize = 49;
            userIcon.Location = new Point(745, 5);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(59, 49);
            userIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            userIcon.TabIndex = 0;
            userIcon.TabStop = false;
            userIcon.Click += iconPictureBox2_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(176, 55);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(806, 678);
            mainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(982, 733);
            Controls.Add(mainPanel);
            Controls.Add(topbar);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            pnlSuppliers.ResumeLayout(false);
            pnlSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            pnlInvoices.ResumeLayout(false);
            pnlInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel pnlSuppliers;
        private Label lblSuppliers;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label lblWelcomeText;
    }
}
