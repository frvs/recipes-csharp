using System.Collections.Generic;

namespace Recipes.Api.Models
{
    public class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Hero { get; set; } = string.Empty;
        public IEnumerable<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public IEnumerable<Equipment> Equipments { get; set; } = new List<Equipment>();
    }
}
