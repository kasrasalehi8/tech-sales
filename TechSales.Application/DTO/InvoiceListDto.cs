namespace TechSales.Application.DTO
{
    public class InvoiceListDto
    {
        public int Id { get; set; }

        public string CustomerName { get; set; } = "";

        public DateTime InvoiceDate { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal RemainingAmount { get; set; }

        public string Status { get; set; } = "";
    }
}
