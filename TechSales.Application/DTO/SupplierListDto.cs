namespace TechSales.Application.DTO
{
    public class SupplierListDto
    {
        public int Id { get; set; }

        public string CompanyName { get; set; } = "";

        public string? Phone { get; set; }

        public string? Address { get; set; }
    }
}
