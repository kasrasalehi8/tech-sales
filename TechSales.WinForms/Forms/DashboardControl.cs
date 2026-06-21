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
using System.Windows.Forms.DataVisualization.Charting;

namespace TechSales.WinForms.Forms
{
    public partial class DashboardControl : UserControl
    {
        private readonly DashboardService _dashboardService;

        private Chart? _salesChart;

        public DashboardControl(TechSalesDbContext db)
        {
            InitializeComponent();

            _dashboardService = new DashboardService(db);

            InitializeChart();
            LoadSampleChart();

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

        private void InitializeChart()
        {
            _salesChart = new Chart();

            _salesChart.Dock = DockStyle.Fill;
            _salesChart.BackColor = Color.White;

            var chartArea = new ChartArea();

            chartArea.BackColor = Color.White;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            _salesChart.ChartAreas.Add(chartArea);

            pnlAnalytics.Controls.Add(_salesChart);
        }

        private void LoadSampleChart()
        {
            var series = new Series("Revenue");

            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.Color = Color.ForestGreen;

            series.Points.AddXY("Jan", 1200);
            series.Points.AddXY("Feb", 1800);
            series.Points.AddXY("Mar", 2500);
            series.Points.AddXY("Apr", 2100);
            series.Points.AddXY("May", 3200);

            _salesChart?.Series.Add(series);
        }

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
                    if (!panel.ClientRectangle.Contains(panel.PointToClient(System.Windows.Forms.Cursor.Position)))
                        ResetHover();
                };
            }
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {

        }
    }
}
