using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSales.Application.Services;
using TechSales.Infrastructure.Persistence;

namespace TechSales.WinForms.Forms
{
    public partial class DashboardControl : UserControl
    {
        private readonly DashboardService _dashboardService;

        public DashboardControl(TechSalesDbContext db)
        {
            InitializeComponent();

            _dashboardService = new DashboardService(db);

            AutoScaleMode = AutoScaleMode.None;

            RegisterCardHover(pnlRevenue, Color.ForestGreen);
            RegisterCardHover(pnlCustomers, Color.LightSeaGreen);
            RegisterCardHover(pnlInvoices, Color.SlateBlue);
            RegisterCardHover(pnlProducts, Color.Crimson);

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            var stats = _dashboardService.GetStats();

            lblRevenue.Text = stats.TotalRevenue.ToString("C");

            lblCustomers.Text = stats.TotalCustomers.ToString();

            lblInvoices.Text = stats.TotalInvoices.ToString();

            lblProducts.Text = stats.TotalProducts.ToString();
        }

        private Color _defaultBack = Color.White;

        private Color Lighten(Color c, float factor)
        {
            return Color.FromArgb(
                255,
                (int)(c.R + (255 - c.R) * factor),
                (int)(c.G + (255 - c.G) * factor),
                (int)(c.B + (255 - c.B) * factor)
            );
        }

        private void RegisterCardHover(Panel panel, Color accentColor)
        {
            panel.Cursor = Cursors.Hand;

            void ApplyHover()
            {
                panel.BackColor = Lighten(accentColor, 0.85f);
            }

            void ResetHover()
            {
                panel.BackColor = Color.White;
            }

            panel.MouseEnter += (s, e) => ApplyHover();
            panel.MouseLeave += (s, e) => ResetHover();

            foreach (Control c in panel.Controls)
            {
                c.Cursor = Cursors.Hand;

                c.MouseEnter += (s, e) => ApplyHover();
                c.MouseLeave += (s, e) =>
                {
                    if (!panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
                        ResetHover();
                };
            }
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {

        }
    }
}
