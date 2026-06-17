using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;
using TechSales.Application.DTO;

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

        public void Add(AddCustomerDto customerDto)
        {
            if (string.IsNullOrWhiteSpace(customerDto.FullName))
            {
                throw new ArgumentException("نام و نام خانوادگی را وارد کنید");
            }

            var customer = new Customer
            {
                FullName = customerDto.FullName.Trim(),
                Phone = customerDto.Phone?.Trim(),
                Address = customerDto.Address?.Trim()
            };

            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        public void Update(UpdateCustomerDto customerDto)
        {
            if (customerDto.Id <= 0)
            {
                throw new ArgumentException("مشتری یافت نشد");
            }

            if (string.IsNullOrWhiteSpace(customerDto.FullName))
            {
                throw new ArgumentException("نام و نام خانوادگی را وارد کنید");
            }

            var customer = _db.Customers.Find(customerDto.Id);

            if (customer == null)
            {
                throw new Exception("مشتری یافت نشد");
            }

            customer.FullName = customerDto.FullName.Trim();
            customer.Phone = customerDto.Phone?.Trim();
            customer.Address = customerDto.Address?.Trim();

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("مشتری یافت نشد");
            }

            var customer = _db.Customers.Find(id);

            if (customer == null)
            {
                throw new Exception("مشتری یافت نشد");
            }

            if (customer == null)
                return;

            _db.Customers.Remove(customer);
            _db.SaveChanges();
        }
    }
}
