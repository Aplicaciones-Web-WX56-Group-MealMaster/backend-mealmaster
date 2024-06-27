
using BasePlatform.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BasePlatform.API.MealPlans
{
    public class MealPlanDbContext : AppDbContext
    {
        public MealPlanDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MealPlan> MealPlans { get; set; }
    }
}