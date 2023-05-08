using HappinessReporter.Models;
using Microsoft.EntityFrameworkCore;

namespace HappinessReporter.Persistence
{
    public class HappinessDbContext : DbContext
    {
        public HappinessDbContext(DbContextOptions<HappinessDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<WorkdaySatisfaction> WorkdaySatisfactions { get; set; }
    }
}