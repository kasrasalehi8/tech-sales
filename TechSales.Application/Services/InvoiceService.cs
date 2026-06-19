using TechSales.Application.DTO;
using TechSales.Domain.Enums;
using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;

namespace TechSales.Application.Services
{
    public class InvoiceService
    {
        private readonly TechSalesDbContext _db;

        public InvoiceService(TechSalesDbContext db)
        {
            _db = db;
        }

        public List<Invoice> GetAll()
        {
            return _db.Invoices
                .OrderByDescending(i => i.InvoiceDate)
                .ToList();
        }

        public Invoice? GetById(int id)
        {
            return _db.Invoices.Find(id);
        }

        public void Create(AddInvoiceDto args)
        {
            var customer = _db.Customers.Find(args.CustomerId);

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            if (!args.Items.Any())
            {
                throw new Exception(
                    "Invoice must contain at least one item");
            }

            decimal totalAmount = 0;

            var invoiceItems = new List<InvoiceItem>();

            foreach (var item in args.Items)
            {
                var product = _db.Products
                    .FirstOrDefault(p => p.Id == item.ProductId && p.IsActive);

                if (product == null)
                {
                    throw new Exception($"Product {item.ProductId} not found");
                }

                if (item.Quantity <= 0)
                {
                    throw new Exception("Quantity must be greater than zero");
                }

                if (product.StockQuantity < item.Quantity)
                {
                    throw new Exception($"Insufficient stock for {product.Name}");
                }

                decimal lineTotal = product.UnitPrice * item.Quantity;

                totalAmount += lineTotal;

                invoiceItems.Add(
                    new InvoiceItem
                    {
                        ProductId = product.Id,
                        Quantity = item.Quantity,
                        UnitPrice = product.UnitPrice,
                        LineTotal = lineTotal
                    });

                product.StockQuantity -= item.Quantity;

                _db.InventoryTransactions.Add(
                    new InventoryTransaction
                    {
                        ProductId = product.Id,
                        QuantityChange = -item.Quantity,
                        TransactionDate = DateTime.Now,
                        TransactionType = (int)InventoryTransactionType.Sale
                    });
            }

            var invoice = new Invoice
            {
                CustomerId = args.CustomerId,
                InvoiceDate = DateTime.Now,
                TotalAmount = totalAmount,
                PaidAmount = 0,
                Status = (int)InvoiceStatus.Unpaid
            };

            _db.Invoices.Add(invoice);

            _db.SaveChanges();

            foreach (var item in invoiceItems)
            {
                item.InvoiceId = invoice.Id;
            }

            _db.InvoiceItems.AddRange(invoiceItems);

            _db.SaveChanges();
        }
    }
}
