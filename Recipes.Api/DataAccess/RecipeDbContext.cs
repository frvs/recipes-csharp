using Microsoft.EntityFrameworkCore;
using Recipes.Api.Models;

namespace Recipes.Api.DataAccess
{
    public class RecipeDbContext : DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
