using System;
using System.Collections.Generic;

namespace TechSales.Infrastructure.Entities;

public partial class Supplier
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
