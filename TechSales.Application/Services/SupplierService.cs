using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSales.Application.DTO;
using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;

namespace TechSales.Application.Services
{
    public class SupplierService
    {
        private readonly TechSalesDbContext _db;

        public SupplierService(TechSalesDbContext db)
        {
            _db = db; 
        }

        public List<Supplier> getAll()
        {
            return _db.Suppliers
                .OrderBy(s => s.CompanyName)
                .ToList();
        }
        public Supplier? GetbyId(int id)
        {
            return _db.Suppliers.Find(id);
        }
        public void Add(AddSupplierDto supplierDto)
        {
            ValidateSupplier(supplierDto);


            var Supplir = new Supplier
            {
                CompanyName = supplierDto.CompanyName.Trim(),
                Phone = supplierDto.Phone?.Trim(),
                Address = supplierDto.Address?.Trim(),
            };

            _db.Suppliers.Add(Supplir);


            _db.SaveChanges();

        }

        public void Update (UpdateSupplierDto supplierDto)
        {
            if (supplierDto.Id <= 0)
            {
                throw new ArgumentException("Supplier not found");
            }

            ValidateSupplier(supplierDto);

            var supplier = _db.Suppliers.Find(supplierDto.Id);

            if (supplier == null)
            {
                throw new Exception("Supplier not found");
            }

            supplier.CompanyName = supplierDto.CompanyName.Trim();
            supplier.Phone = supplierDto.Phone?.Trim();
            supplier.Address = supplierDto.Address?.Trim();


            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Supplier not found");
            }

            bool hasProducts =  _db.Products
                .Any(p => p.SupplierId  == id);

            if (hasProducts)
            {
                throw new InvalidOperationException(
                    "Cannot delete supplier because products are assigned to it.");
            }
        }

        private void ValidateSupplier(dynamic supplierDto)
        {
            if (string.IsNullOrWhiteSpace(supplierDto.CompanyName))
            {
                throw new ArgumentException(
                    "Please enter a company name");
            }
        }
    }
}
