using Microsoft.EntityFrameworkCore;
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

        public List<InvoiceListDto> GetAllForList()
        {
            return _db.Invoices
                .OrderByDescending(i => i.InvoiceDate)
                .Include(i => i.Customer)
                .Select(i => new InvoiceListDto
                {
                    Id = i.Id,

                    CustomerName =
                        i.Customer.FullName,

                    InvoiceDate =
                        i.InvoiceDate,

                    TotalAmount =
                        i.TotalAmount,

                    PaidAmount =
                        i.PaidAmount,

                    RemainingAmount =
                        i.TotalAmount - i.PaidAmount,

                    Status =
                        ((InvoiceStatus)i.Status).ToString()
                })
                .ToList();
        }

        public Invoice? GetById(int id)
        {
            return _db.Invoices.Find(id);
        }

        public InvoiceDetailsDto? GetDetails(int invoiceId)
        {
            return _db.Invoices
                .Include(i => i.Customer)
                .Include(i => i.InvoiceItems)
                    .ThenInclude(ii => ii.Product)
                .Include(i => i.Payments)
                .Where(i => i.Id == invoiceId)
                .Select(i => new InvoiceDetailsDto
                {
                    Id = i.Id,

                    CustomerName =
                        i.Customer.FullName,

                    InvoiceDate =
                        i.InvoiceDate,

                    TotalAmount =
                        i.TotalAmount,

                    PaidAmount =
                        i.PaidAmount,

                    RemainingAmount =
                        i.TotalAmount - i.PaidAmount,

                    Status =
                        ((InvoiceStatus)i.Status).ToString(),

                    Items =
                        i.InvoiceItems
                            .Select(ii => new InvoiceItemDetailsDto
                            {
                                ProductName = ii.Product.Name,
                                UnitPrice = ii.UnitPrice,
                                Quantity = ii.Quantity,
                                LineTotal = ii.LineTotal
                            })
                            .ToList(),

                    Payments =
                        i.Payments
                            .OrderByDescending(p => p.PaymentDate)
                            .Select(p => new PaymentListDto
                            {
                                PaymentDate = p.PaymentDate,
                                Amount = p.Amount
                            })
                            .ToList()
                })
                .FirstOrDefault();
        }

        public List<InvoiceListDto> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return GetAllForList();
            }

            searchTerm = searchTerm.Trim().ToLower();

            return _db.Invoices
                .Include(i => i.Customer)
                .Where(i =>
                    i.Customer.FullName.ToLower().Contains(searchTerm) ||

                    i.Id.ToString().Contains(searchTerm) ||

                    ((InvoiceStatus)i.Status)
                        .ToString()
                        .ToLower()
                        .Contains(searchTerm))
                .OrderByDescending(i => i.InvoiceDate)
                .Select(i => new InvoiceListDto
                {
                    Id = i.Id,

                    CustomerName =
                        i.Customer.FullName,

                    InvoiceDate =
                        i.InvoiceDate,

                    TotalAmount =
                        i.TotalAmount,

                    PaidAmount =
                        i.PaidAmount,

                    RemainingAmount =
                        i.TotalAmount - i.PaidAmount,

                    Status =
                        ((InvoiceStatus)i.Status).ToString()
                })
                .ToList();
        }

        public void Create(AddInvoiceDto args)
        {
            if (args.InvoiceDate > DateTime.Now)
            {
                throw new Exception(
                    "Invoice date cannot be in the future.");
            }

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
                InvoiceDate = args.InvoiceDate,
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
