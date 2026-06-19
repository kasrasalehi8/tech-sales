using TechSales.Application.DTO;
using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;

namespace TechSales.Application.Services
{
    public class InventoryService
    {
        private readonly TechSalesDbContext _db;

        public InventoryService(TechSalesDbContext db)
        {
            _db = db;
        }

        public List<InventoryTransaction> GetHistory()
        {
            return _db.InventoryTransactions
                .OrderByDescending(t => t.TransactionDate)
                .ToList();
        }

        public List<InventoryTransaction> GetProductHistory(int productId)
        {
            return _db.InventoryTransactions
                .Where(t => t.ProductId == productId)
                .OrderByDescending(t => t.TransactionDate)
                .ToList();
        }

        public void AdjustStock(AdjustInventoryDto dto)
        {
            var product = _db.Products
                .FirstOrDefault(p =>
                    p.Id == dto.ProductId &&
                    p.IsActive);

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            int newStock =
                product.StockQuantity +
                dto.QuantityChange;

            if (newStock < 0)
            {
                throw new InvalidOperationException(
                    "Insufficient stock");
            }

            product.StockQuantity = newStock;

            var transaction =
                new InventoryTransaction
                {
                    ProductId = dto.ProductId,
                    QuantityChange = dto.QuantityChange,
                    TransactionDate = DateTime.Now,
                    TransactionType = dto.TransactionType,
                    ReferenceId = dto.ReferenceId
                };

            _db.InventoryTransactions.Add(transaction);

            _db.SaveChanges();
        }
    }
}