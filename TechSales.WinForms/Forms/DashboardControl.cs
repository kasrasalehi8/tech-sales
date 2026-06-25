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
        private readonly TechSalesDbContext _db;
        private Chart? _salesChart;

        private enum RevenuePeriod
        {
            Today,
            Week,
            Month,
            Year,
            All
        }

        private RevenuePeriod _currentRevenuePeriod = RevenuePeriod.Week;

        public DashboardControl(TechSalesDbContext db)
        {
            InitializeComponent();

            this.AutoScroll = true;

            _dashboardService = new DashboardService(db);

            InitializeChart();
            _db = db;
            AutoScaleMode = AutoScaleMode.None;

            RegisterCardHover(pnlRevenue, Color.ForestGreen);
            RegisterCardHover(pnlCustomers, Color.LightSeaGreen);
            RegisterCardHover(pnlInvoices, Color.SlateBlue);
            RegisterCardHover(pnlProducts, Color.DarkMagenta);
            RegisterCardHover(pnlOutstanding, Color.Goldenrod);
            RegisterCardHover(pnlLowStock, Color.Crimson);

            LoadDashboardData();
            LoadRevenueChart();
            LoadTopProducts();
            LoadRecentInvoices();

            pnlRevenue.Click += RevenueCard_Click;
            lblRevenue.Click += RevenueCard_Click;
            lblTitleRevenue.Click += RevenueCard_Click;
            iconRevenue.Click += RevenueCard_Click;

            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            // Top Products Grid

            dgvTopProducts.EnableHeadersVisualStyles = false;

            dgvTopProducts.ColumnHeadersDefaultCellStyle.BackColor =
                Color.DarkMagenta;

            dgvTopProducts.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvTopProducts.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            dgvTopProducts.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.DarkMagenta;

            dgvTopProducts.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvTopProducts.DataSource = _dashboardService.GetTopSellingProducts();

            if (dgvTopProducts.Columns["Id"] != null)
                dgvTopProducts.Columns["Id"].Visible = false;

            // Recent Invoices Grid

            dgvRecentInvoices.EnableHeadersVisualStyles = false;

            dgvRecentInvoices.ColumnHeadersDefaultCellStyle.BackColor =
                Color.SlateBlue;

            dgvRecentInvoices.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvRecentInvoices.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            dgvRecentInvoices.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.SlateBlue;

            dgvRecentInvoices.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.White;

        }

        private void ChangeRevenuePeriod(RevenuePeriod period)
        {
            UpdateChartTitle();
            LoadRevenueChart();
            LoadDashboardData();
        }

        private void RevenueCard_Click(object? sender, EventArgs e)
        {
            _currentRevenuePeriod = _currentRevenuePeriod switch
            {
                RevenuePeriod.Today => RevenuePeriod.Week,
                RevenuePeriod.Week => RevenuePeriod.Month,
                RevenuePeriod.Month => RevenuePeriod.Year,
                RevenuePeriod.Year => RevenuePeriod.All,
                RevenuePeriod.All => RevenuePeriod.Today,
                _ => RevenuePeriod.Today
            };

            ChangeRevenuePeriod(_currentRevenuePeriod);
        }

        private void dgvRecentInvoices_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRecentInvoices.ClearSelection();
        }

        private void dgvTopProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTopProducts.ClearSelection();
        }

        public event Action<string>? NavigationRequested;

        private void pnlProducts_Click(object sender, EventArgs e)
        {
            NavigationRequested?.Invoke("Products");
        }

        private void pnlCustomers_Click(object sender, EventArgs e)
        {
            NavigationRequested?.Invoke("Customers");
        }

        private void pnlInvoices_Click(object sender, EventArgs e)
        {
            NavigationRequested?.Invoke("Invoices");
        }

        private void LoadDashboardData()
        {

            var stats = _dashboardService.GetStats();

            lblRevenue.Text = GetRevenueForCurrentPeriod().ToString("C");
            lblTitleRevenue.Text = _currentRevenuePeriod switch
            {
                RevenuePeriod.Today => "Revenue (Today)",
                RevenuePeriod.Week => "Revenue (7D)",
                RevenuePeriod.Month => "Revenue (30D)",
                RevenuePeriod.Year => "Revenue (1Y)",
                RevenuePeriod.All => "Revenue (All)",
                _ => "Revenue"
            };
            lblCustomers.Text = stats.TotalCustomers.ToString();
            lblInvoices.Text = stats.TotalInvoices.ToString();
            lblProducts.Text = stats.TotalProducts.ToString();
            lblOutstanding.Text = stats.OutstandingBalance.ToString("C");
            lblLowStock.Text = stats.LowStockProducts.ToString();
        }

        private Color _defaultBack = Color.White;

        private void InitializeChart()
        {
            _salesChart = new Chart();

            _salesChart.Dock = DockStyle.Fill;
            _salesChart.BackColor = Color.White;

            _salesChart.BorderlineWidth = 0;
            _salesChart.BorderlineColor = Color.Transparent;

            _salesChart.AntiAliasing = AntiAliasingStyles.All;

            _salesChart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

            _salesChart.Legends.Clear();

            var chartArea = new ChartArea();

            chartArea.BackColor = Color.White;

            chartArea.AxisX.MajorGrid.Enabled = false;

            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);

            chartArea.AxisX.LineWidth = 0;
            chartArea.AxisY.LineWidth = 0;

            chartArea.AxisX.IsMarginVisible = false;

            chartArea.AxisX.LabelStyle.Format = "dd MMM";
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

            _salesChart.ChartAreas.Add(chartArea);

            _salesChart.Titles.Add(
            new Title()
            {
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(3, 38, 53)
            });

            pnlAnalytics.Controls.Add(_salesChart);
        }

        private decimal GetRevenueForCurrentPeriod()
        {
            DateTime? startDate = _currentRevenuePeriod switch
            {
                RevenuePeriod.Today => DateTime.Today,
                RevenuePeriod.Week => DateTime.Today.AddDays(-6),
                RevenuePeriod.Month => DateTime.Today.AddDays(-29),
                RevenuePeriod.Year => DateTime.Today.AddYears(-1),
                _ => null
            };

            return _dashboardService
                .GetRevenue(startDate)
                .Sum(x => x.Revenue);
        }

        private void UpdateChartTitle()
        {
            if (_salesChart == null)
                return;

            _salesChart.Titles[0].Text = _currentRevenuePeriod switch
            {
                RevenuePeriod.Today => "Revenue (Today)",
                RevenuePeriod.Week => "Revenue (Last 7 Days)",
                RevenuePeriod.Month => "Revenue (Last 30 Days)",
                RevenuePeriod.Year => "Revenue (Last Year)",
                _ => "Revenue (All Time)"
            };
        }

        private void LoadRevenueChart()
        {
            if (_salesChart == null)
                return;

            DateTime? startDate = _currentRevenuePeriod switch
            {
                RevenuePeriod.Today => DateTime.Today,
                RevenuePeriod.Week => DateTime.Today.AddDays(-6),
                RevenuePeriod.Month => DateTime.Today.AddDays(-29),
                RevenuePeriod.Year => DateTime.Today.AddYears(-1),
                _ => null
            };

            _salesChart.Series.Clear();

            var data = _dashboardService.GetRevenue(startDate);

            var series = new Series("Revenue");

            series.ChartType = SeriesChartType.Column;

            series.BorderWidth = 3;

            series.Color = Color.ForestGreen;

            series.XValueType = ChartValueType.String;



            series.YValueType = ChartValueType.Double;

            series["PointWidth"] = "0.9";

            series.ToolTip = "#VALX\nRevenue: " + "{0:C}";

            foreach (var item in data)
            {
                series.Points.AddXY(item.Date.ToString("dd MMM"), (double)item.Revenue);
            }

            _salesChart.Series.Add(series);
        }

        private void LoadTopProducts()
        {
            dgvTopProducts.DataSource =
                _dashboardService.GetTopSellingProducts();

            dgvTopProducts.Columns["ProductName"].HeaderText =
                "Product";

            dgvTopProducts.Columns["QuantitySold"].HeaderText =
                "Sold";

            dgvTopProducts.ClearSelection();
        }

        private void LoadRecentInvoices()
        {
            dgvRecentInvoices.DataSource =
                _dashboardService.GetRecentInvoices();

            dgvRecentInvoices.Columns["Id"].HeaderText = "#";
            dgvRecentInvoices.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvRecentInvoices.Columns["CustomerName"].HeaderText =
                "Customer";

            dgvRecentInvoices.Columns["TotalAmount"].HeaderText =
                "Total";

            dgvRecentInvoices.Columns["TotalAmount"]
                .DefaultCellStyle.Format =
                    "C";

            dgvRecentInvoices.Columns["Status"].Visible = false;

            dgvRecentInvoices.ClearSelection();
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

        private void dgvTopProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTopProducts.Rows[e.RowIndex];

            if (row.Cells["Id"].Value == null)
                return;

            int productId = (int)dgvTopProducts.Rows[e.RowIndex].Cells["Id"].Value;

            using var form = new Product.ProductDetailsForm(_db, productId);

            form.ShowDialog();
        }

        private void dgvRecentInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvRecentInvoices.Rows[e.RowIndex];

            if (row.Cells["Id"].Value == null)
                return;

            int invoiceId = (int)row.Cells["Id"].Value;

            using var form = new Invoice.InvoiceDetailsForm(_db, invoiceId);

            form.ShowDialog();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {

        }

        private void pnlAnalytics_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCustomers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void last7DaysToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lastToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
