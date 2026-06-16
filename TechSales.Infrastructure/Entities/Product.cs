using System;
using System.Collections.Generic;

namespace TechSales.Infrastructure.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public int SupplierId { get; set; }

    public decimal UnitPrice { get; set; }

    public int StockQuantity { get; set; }

    public bool IsActive { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();

    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

    public virtual Supplier Supplier { get; set; } = null!;
}
