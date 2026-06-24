namespace TechSales.Application.DTO
{
    public class AddInvoiceDto
    {
        public int CustomerId { get; set; }

        public DateTime InvoiceDate { get; set; }

        public List<AddInvoiceItemDto> Items { get; set; } = new();
    }
}
