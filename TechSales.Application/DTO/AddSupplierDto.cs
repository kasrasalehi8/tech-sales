namespace TechSales.Application.DTO
{
    public class AddSupplierDto
    {
        public string CompanyName { get; set; } = string.Empty;

        public string? Phone { get; set; }

        public string? Address { get; set; }
    }
}
