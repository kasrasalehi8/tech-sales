namespace TechSales.Application.DTO
{
    public class AdjustInventoryDto
    {
        public int ProductId { get; set; }

        public int QuantityChange { get; set; }

        public int TransactionType { get; set; }

        public int? ReferenceId { get; set; }
    }
}
