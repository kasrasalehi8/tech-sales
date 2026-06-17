using System;
using System.Collections.Generic;

namespace TechSales.Infrastructure.Entities;

public partial class Payment
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public DateTime PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;
}
