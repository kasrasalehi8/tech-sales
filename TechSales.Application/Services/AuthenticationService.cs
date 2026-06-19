using Microsoft.EntityFrameworkCore;
using TechSales.Application.DTO;
using TechSales.Application.Security;
using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;

namespace TechSales.Application.Services
{
    public class AuthenticationService
    {
        private readonly TechSalesDbContext _db;

        public AuthenticationService(TechSalesDbContext db)
        {
            _db = db;
        }

        public User Login(LoginDto args)
        {
            var user = _db.Users
                .Include(x => x.Role)
                .FirstOrDefault(x => x.Username == args.Username);

            if (user == null)
            {
                throw new Exception("Invalid username or password");
            }

            bool valid = PasswordHasher.Verify(args.Password, user.PasswordHash);

            if (!valid)
            {
                throw new Exception("Invalid username or password");
            }

            return user;
        }
    }
}
