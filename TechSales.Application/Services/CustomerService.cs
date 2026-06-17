using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;

namespace TechSales.Application.Services
{
    public class CustomerService
    {
        private readonly TechSalesDbContext _db;

        public CustomerService(TechSalesDbContext db)
        {
            _db = db;
        }

        public List<Customer> GetAll()
        {
            return _db.Customers
                .OrderBy(c => c.FullName)
                .ToList();
        }

        public Customer? GetById(int id)
        {
            return _db.Customers
                .FirstOrDefault(c => c.Id == id);
        }

        public void Add(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _db.Customers.Update(customer);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = _db.Customers.Find(id);

            if (customer == null)
                return;

            _db.Customers.Remove(customer);
            _db.SaveChanges();
        }
    }
}
