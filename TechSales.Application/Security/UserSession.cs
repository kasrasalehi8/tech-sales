using TechSales.Infrastructure.Entities;

namespace TechSales.Application.Security
{
    public static class UserSession
    {
        public static User? CurrentUser { get; set; }

        public static bool IsLoggedIn => CurrentUser != null;
    }
}
