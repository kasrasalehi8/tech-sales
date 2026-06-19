namespace TechSales.Application.DTO
{
    public interface IProductDto
    {
        string Name { get; }
        int CategoryId { get; }
        int SupplierId { get; }
        decimal UnitPrice { get; }
        int StockQuantity { get; }
    }
}
