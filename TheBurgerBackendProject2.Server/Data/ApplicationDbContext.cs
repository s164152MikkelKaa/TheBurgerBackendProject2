using Microsoft.EntityFrameworkCore;
using TheBurgerBackendProject2.Server.Models;

namespace TheBurgerBackendProject2.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<BurgerSpots> TheBurgerSpots { get; set; }
        public DbSet<UserReview> TheUserReviews { get; set; }
    }
}
