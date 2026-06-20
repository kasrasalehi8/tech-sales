using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TechSales.Infrastructure.Persistence;
using TechSales.WinForms.Forms;

namespace TechSales.WinForms
{
    public partial class MainForm : Form
    {
        private readonly TechSalesDbContext _db;

        public MainForm()
        {
            InitializeComponent();
            InitializeMenu();

            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<TechSalesDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            _db = new TechSalesDbContext(options);

            pnlDashboard.Click += PnlDashboard_Click;
            lblDashboard.Click += PnlDashboard_Click;
            iconDashboard.Click += PnlDashboard_Click;

            RegisterMenuHover(pnlDashboard);
            RegisterMenuHover(pnlProduct);
            RegisterMenuHover(pnlCustomers);
            RegisterMenuHover(pnlInvoices);
            RegisterMenuHover(pnlSuppliers);
        }

        private readonly Color SidebarColor = Color.FromArgb(3, 38, 53);
        private readonly Color HoverColor = Color.FromArgb(28, 55, 68);

        private void RegisterMenuHover(Panel panel)
        {
            panel.Cursor = Cursors.Hand;

            panel.MouseEnter += Menu_MouseEnter;
            panel.MouseLeave += Menu_MouseLeave;

            foreach (Control control in panel.Controls)
            {
                control.Cursor = Cursors.Hand;

                control.MouseEnter += (s, e) =>
                {
                    panel.BackColor = HoverColor;
                };

                control.MouseLeave += (s, e) =>
                {
                    Point p = panel.PointToClient(Cursor.Position);

                    if (!panel.ClientRectangle.Contains(p))
                    {
                        panel.BackColor = SidebarColor;
                    }
                };
            }
        }

        private void Menu_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Control control)
            {
                control.BackColor = HoverColor;
            }
        }

        private void Menu_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Control control)
            {
                control.BackColor = SidebarColor;
            }
        }

        private void PnlDashboard_Click(object? sender, EventArgs e)
        {
            LoadControl(new DashboardControl(_db));
        }

        private void InitializeMenu()
        {
            pnlDashboard.Text = "Dashboard";
        }

        private void LoadControl(UserControl control)
        {
            mainPanel.Controls.Clear();

            control.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(control);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl(_db));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
