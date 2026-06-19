using TechSales.Application.DTO;
using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;

namespace TechSales.Application.Services
{
    public class CategoryService
    {
        private readonly TechSalesDbContext _db;

        public CategoryService(TechSalesDbContext db)
        {
            _db = db;
        }

        public List<Category> GetAll()
        {
            return _db.Categories
                .OrderBy(c => c.Name)
                .ToList();
        }

        public Category? GetById(int id)
        {
            return _db.Categories.Find(id);
        }

        public void Add(AddCategoryDto categoryDto)
        {
            ValidateName(categoryDto.Name);

            bool exists = _db.Categories
                .Any(c => c.Name == categoryDto.Name.Trim());

            if (exists)
            {
                throw new ArgumentException("Category already exists");
            }

            var category = new Category
            {
                Name = categoryDto.Name.Trim()
            };

            _db.Categories.Add(category);

            _db.SaveChanges();
        }

        public void Update(UpdateCategoryDto categoryDto)
        {
            if (categoryDto.Id <= 0)
            {
                throw new ArgumentException("Category not found");
            }

            ValidateName(categoryDto.Name);

            var category = _db.Categories.Find(categoryDto.Id);

            if (category == null)
            {
                throw new Exception("Category not found");
            }

            bool duplicateExists = _db.Categories.Any(c =>
                c.Id != categoryDto.Id &&
                c.Name == categoryDto.Name.Trim());

            if (duplicateExists)
            {
                throw new ArgumentException("Category already exists");
            }

            category.Name = categoryDto.Name.Trim();

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Category not found");
            }

            var category = _db.Categories.Find(id);

            if (category == null)
            {
                throw new Exception("Category not found");
            }

            bool hasProducts = _db.Products
                .Any(p => p.CategoryId == id);

            if (hasProducts)
            {
                throw new InvalidOperationException(
                    "Cannot delete a category that contains products");
            }

            _db.Categories.Remove(category);

            _db.SaveChanges();
        }

        private void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Please enter a category name");
            }
        }
    }
}
