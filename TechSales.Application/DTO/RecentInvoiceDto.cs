namespace TechSales.Application.DTO
{
    public class RecentInvoiceDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = "";
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "";
    }
}
