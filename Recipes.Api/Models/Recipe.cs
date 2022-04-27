using System.Collections.Generic;

namespace Recipes.Api.Models
{
    public class Recipe
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Hero { get; set; } = string.Empty;
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<Equipment> Equipments { get; set; }
    }
}
