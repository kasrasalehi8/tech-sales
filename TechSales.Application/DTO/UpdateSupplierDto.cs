using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSales.Application.DTO
{
    public class UpdateSupplierDto
    {
        public int Id { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public string? Phone { get; set; }

        public string? Address { get; set; }
    }
}
