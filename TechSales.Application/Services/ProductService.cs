using Microsoft.EntityFrameworkCore;
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
    public class ProductService
    {
        private readonly TechSalesDbContext _db;

        public ProductService(TechSalesDbContext db)
        {
            _db = db;
        }

        public List<Product> GetAll()
        {
            return _db.Products
                .Where(p => p.IsActive)
                .OrderBy(p => p.Name)
                .ToList();
        }

        public Product? GetById(int id)
        {
            return _db.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefault(p => p.Id == id);
        }

        public void Add(AddProductDto productDto)
        {
            ValidateProduct(productDto);

            var product = new Product
            {
                Name = productDto.Name.Trim(),
                CategoryId = productDto.CategoryId,
                SupplierId = productDto.SupplierId,
                UnitPrice = productDto.UnitPrice,
                StockQuantity = productDto.StockQuantity,
                IsActive = true
            };

            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public void Update(UpdateProductDto productDto)
        {
            if (productDto.Id <= 0)
            {
                throw new ArgumentException("Product not found");
            }

            ValidateProduct(productDto);

            var product = _db.Products.FirstOrDefault(p => p.Id == productDto.Id && p.IsActive);

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            product.Name = productDto.Name.Trim();
            product.CategoryId = productDto.CategoryId;
            product.SupplierId = productDto.SupplierId;
            product.UnitPrice = productDto.UnitPrice;
            product.StockQuantity = productDto.StockQuantity;

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Product not found");
            }

            var product = _db.Products.FirstOrDefault(p => p.Id == id && p.IsActive);

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            product.IsActive = false;

            _db.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return _db.Categories
                .OrderBy(c => c.Name)
                .ToList();
        }

        public List<Supplier> GetSuppliers()
        {
            return _db.Suppliers
                .OrderBy(s => s.CompanyName)
                .ToList();
        }

        public List<ProductListDto> GetProductList()
        {
            return _db.Products
                .Where(p => p.IsActive)
                .OrderBy(p => p.Name)
                .Select(p => new ProductListDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.Name,
                    Supplier = p.Supplier.CompanyName,
                    Price = p.UnitPrice,
                    Stock = p.StockQuantity,
                    IsActive = p.IsActive
                })
                .ToList();
        }

        public List<ProductListDto> Search(string searchTerm)
        {
            searchTerm = searchTerm.Trim();

            return _db.Products
                .Where(p =>
                    p.IsActive &&
                    p.Name.Contains(searchTerm))
                .OrderBy(p => p.Name)
                .Select(p => new ProductListDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.Name,
                    Supplier = p.Supplier.CompanyName,
                    Price = p.UnitPrice,
                    Stock = p.StockQuantity,
                    IsActive = p.IsActive
                })
                .ToList();
        }

        // Admin

        public List<Product> GetAllIncludingInactive()
        {
            return _db.Products
                .OrderBy(p => p.Name)
                .ToList();
        }

        public void Restore(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Product not found");
            }

            var product = _db.Products
                .FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            product.IsActive = true;

            _db.SaveChanges();
        }

        private void ValidateProduct(IProductDto productDto)
        {
            if (string.IsNullOrWhiteSpace(productDto.Name))
            {
                throw new ArgumentException("Please enter a product name");
            }

            if (productDto.UnitPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative");
            }

            if (productDto.StockQuantity < 0)
            {
                throw new ArgumentException("Stock cannot be negative");
            }

            bool categoryExists =
                _db.Categories.Any(c => c.Id == productDto.CategoryId);

            if (!categoryExists)
            {
                throw new ArgumentException("Invalid category");
            }

            bool supplierExists =
                _db.Suppliers.Any(s => s.Id == productDto.SupplierId);

            if (!supplierExists)
            {
                throw new ArgumentException("Invalid supplier");
            }
        }
    }
}
