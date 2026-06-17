using System;
using System.Collections.Generic;

namespace TechSales.Infrastructure.Entities;

public partial class Invoice
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public DateTime InvoiceDate { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal PaidAmount { get; set; }

    public int Status { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
