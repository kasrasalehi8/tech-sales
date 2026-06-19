using TechSales.Application.DTO;
using TechSales.Domain.Enums;
using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;

namespace TechSales.Application.Services
{
    public class PaymentService
    {
        private readonly TechSalesDbContext _db;

        public PaymentService(TechSalesDbContext db)
        {
            _db = db;
        }

        public List<Payment> GetAll()
        {
            return _db.Payments
                .OrderByDescending(p => p.PaymentDate)
                .ToList();
        }

        public Payment? GetById(int id)
        {
            return _db.Payments.Find(id);
        }

        public List<Payment> GetInvoicePayments(int invoiceId)
        {
            return _db.Payments
                .Where(p => p.InvoiceId == invoiceId)
                .OrderByDescending(p => p.PaymentDate)
                .ToList();
        }

        public void Create(AddPaymentDto args)
        {
            var invoice = _db.Invoices
                .FirstOrDefault(i => i.Id == args.InvoiceId);

            if (invoice == null)
            {
                throw new Exception("Invoice not found");
            }

            if (args.Amount <= 0)
            {
                throw new ArgumentException("Payment amount must be greater than zero");
            }

            decimal remainingBalance = invoice.TotalAmount - invoice.PaidAmount;

            if (args.Amount > remainingBalance)
            {
                throw new ArgumentException("Payment exceeds remaining balance");
            }

            var payment = new Payment
            {
                InvoiceId = args.InvoiceId,
                Amount = args.Amount,
                PaymentDate = DateTime.Now
            };

            _db.Payments.Add(payment);

            invoice.PaidAmount += args.Amount;

            if (invoice.PaidAmount == 0)
            {
                invoice.Status = (int)InvoiceStatus.Unpaid;
            }
            else if (invoice.PaidAmount < invoice.TotalAmount)
            {
                invoice.Status = (int)InvoiceStatus.PartiallyPaid;
            }
            else
            {
                invoice.Status = (int)InvoiceStatus.Paid;
            }

            _db.SaveChanges();
        }
    }
}