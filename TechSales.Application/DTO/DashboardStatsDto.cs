namespace TechSales.Application.DTO
{
    public class DashboardStatsDto
    {
        public decimal TotalRevenue { get; set; }

        public int TotalCustomers { get; set; }

        public int TotalProducts { get; set; }

        public int TotalInvoices { get; set; }

        public decimal OutstandingBalance { get; set; }

        public int PaidInvoices { get; set; }

        public int UnpaidInvoices { get; set; }

        public int LowStockProducts { get; set; }
    }
}
