using TechSales.Application.DTO;
using TechSales.Domain.Enums;
using TechSales.Infrastructure.Persistence;

namespace TechSales.Application.Services
{
    public class DashboardService
    {
        private readonly TechSalesDbContext _db;

        public DashboardService(TechSalesDbContext db)
        {
            _db = db;
        }

        public DashboardStatsDto GetStats()
        {
            return new DashboardStatsDto
            {
                TotalRevenue = _db.Payments.Sum(p => p.Amount),

                TotalCustomers = _db.Customers.Count(),

                TotalProducts = _db.Products.Count(p => p.IsActive),

                TotalInvoices = _db.Invoices.Count(),

                OutstandingBalance = _db.Invoices.Sum(i => i.TotalAmount - i.PaidAmount),

                PaidInvoices = _db.Invoices.Count(i => i.Status == (int)InvoiceStatus.Paid),

                UnpaidInvoices = _db.Invoices.Count(i => i.Status != (int)InvoiceStatus.Paid)
            };
        }
    }
}
