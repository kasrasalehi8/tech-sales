using System;
using System.Collections.Generic;

namespace TechSales.Infrastructure.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
