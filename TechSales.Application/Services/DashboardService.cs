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

                UnpaidInvoices = _db.Invoices.Count(i => i.Status != (int)InvoiceStatus.Paid),

                LowStockProducts = _db.Products.Count(p => p.StockQuantity <= 5)
            };
        }

        public List<RevenuePointDto> GetRevenue(DateTime? startDate)
        {
            var query = _db.Payments.AsQueryable();

            if (startDate.HasValue)
            {
                query = query.Where(p => p.PaymentDate >= startDate.Value);
            }

            var revenueData = query
                .GroupBy(p => p.PaymentDate.Date)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(x => x.Amount)
                );

            DateTime firstDate = startDate ?? (
                revenueData.Any()
                    ? revenueData.Keys.Min()
                    : DateTime.Today
            );

            DateTime lastDate = DateTime.Today;

            var result = new List<RevenuePointDto>();

            for (var date = firstDate.Date; date <= lastDate.Date; date = date.AddDays(1))
            {
                result.Add(new RevenuePointDto
                {
                    Date = date,
                    Revenue = revenueData.TryGetValue(date, out var revenue)
                        ? revenue
                        : 0
                });
            }

            return result;
        }

        public List<TopSellingProductDto> GetTopSellingProducts()
        {
            return _db.InvoiceItems
                .GroupBy(i => new { i.ProductId, i.Product.Name })
                .Select(g => new TopSellingProductDto
                {
                    Id = g.Key.ProductId,
                    ProductName = g.Key.Name,
                    QuantitySold = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(x => x.QuantitySold)
                .Take(5)
                .ToList();
        }

        public List<RecentInvoiceDto> GetRecentInvoices()
        {
            return _db.Invoices
                .OrderByDescending(i => i.InvoiceDate)
                .Take(5)
                .Select(i => new RecentInvoiceDto
                {
                    Id = i.Id,
                    CustomerName = i.Customer.FullName,
                    TotalAmount = i.TotalAmount,
                    Status = ((InvoiceStatus)i.Status).ToString()
                })
                .ToList();
        }
    }
}
