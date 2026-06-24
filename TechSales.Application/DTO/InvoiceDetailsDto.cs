namespace TechSales.Application.DTO
{
    public class InvoiceDetailsDto
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal RemainingAmount { get; set; }

        public string Status { get; set; }

        public List<InvoiceItemDetailsDto> Items { get; set; } = new();

        public List<PaymentListDto> Payments { get; set; } = new();
    }
}
