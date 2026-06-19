using TechSales.Application.DTO;
using TechSales.Application.Security;
using TechSales.Infrastructure.Entities;
using TechSales.Infrastructure.Persistence;

namespace TechSales.Application.Services
{
    public class UserService
    {
        private readonly TechSalesDbContext _db;

        public UserService(TechSalesDbContext db)
        {
            _db = db;
        }

        public List<User> GetAll()
        {
            return _db.Users
                .OrderBy(u => u.Username)
                .ToList();
        }

        public User? GetById(int id)
        {
            return _db.Users.Find(id);
        }

        public void Create(CreateUserDto args)
        {
            if (string.IsNullOrWhiteSpace(args.Username))
            {
                throw new ArgumentException("Username is required");
            }

            if (string.IsNullOrWhiteSpace(args.Password))
            {
                throw new ArgumentException("Password is required");
            }

            bool usernameExists = _db.Users.Any(u => u.Username == args.Username);

            if (usernameExists)
            {
                throw new ArgumentException("Username already exists");
            }

            bool roleExists = _db.Roles.Any(r => r.Id == args.RoleId);

            if (!roleExists)
            {
                throw new ArgumentException("Invalid role");
            }

            var user = new User
            {
                Username = args.Username.Trim(),
                PasswordHash = PasswordHasher.Hash(args.Password),
                RoleId = args.RoleId
            };

            _db.Users.Add(user);

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _db.Users.Find(id);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            _db.Users.Remove(user);

            _db.SaveChanges();
        }

        public void ResetPassword(int userId, string newPassword)
        {
            var user = _db.Users.Find(userId);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                throw new ArgumentException("Password is required");
            }

            user.PasswordHash = PasswordHasher.Hash(newPassword);

            _db.SaveChanges();
        }
    }
}
