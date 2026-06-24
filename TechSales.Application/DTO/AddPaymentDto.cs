namespace TechSales.Application.DTO
{
    public class AddPaymentDto
    {
        public int InvoiceId { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
