namespace TechSales.Application.DTO
{
    public class UpdateProductDto : IProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQuantity { get; set; }
    }
}
