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

        public List<Supplier> GetAll()
        {
            return _db.Suppliers
                .OrderBy(s => s.CompanyName)
                .ToList();
        }

        public List<SupplierListDto> GetSupplierList()
        {
            return _db.Suppliers
                .OrderBy(s => s.CompanyName)
                .Select(s => new SupplierListDto
                {
                    Id = s.Id,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone,
                    Address = s.Address
                })
                .ToList();
        }

        public Supplier? GetbyId(int id)
        {
            return _db.Suppliers.Find(id);
        }

        public void Add(AddSupplierDto supplierDto)
        {
            ValidateSupplier(supplierDto);


            var Supplier = new Supplier
            {
                CompanyName = supplierDto.CompanyName.Trim(),
                Phone = supplierDto.Phone?.Trim(),
                Address = supplierDto.Address?.Trim(),
            };

            _db.Suppliers.Add(Supplier);


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
                throw new ArgumentException(
                    "Supplier not found");
            }

            bool hasProducts =
                _db.Products.Any(
                    p => p.SupplierId == id);

            if (hasProducts)
            {
                throw new InvalidOperationException(
                    "Cannot delete supplier because products are assigned to it.");
            }

            var supplier =
                _db.Suppliers.Find(id);

            if (supplier == null)
            {
                throw new Exception(
                    "Supplier not found");
            }

            _db.Suppliers.Remove(supplier);

            _db.SaveChanges();
        }

        public List<SupplierListDto> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return GetSupplierList();
            }

            searchTerm = searchTerm.Trim();

            return _db.Suppliers
                .Where(s =>
                    s.CompanyName.Contains(searchTerm) ||
                    (s.Phone != null &&
                     s.Phone.Contains(searchTerm)))
                .OrderBy(s => s.CompanyName)
                .Select(s => new SupplierListDto
                {
                    Id = s.Id,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone,
                    Address = s.Address
                })
                .ToList();
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
