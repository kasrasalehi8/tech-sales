using System;
using System.Collections.Generic;

namespace TechSales.Infrastructure.Entities;

public partial class InventoryTransaction
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int QuantityChange { get; set; }

    public DateTime TransactionDate { get; set; }

    public int TransactionType { get; set; }

    public int? ReferenceId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
