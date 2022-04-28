using System.Collections.Generic;

namespace Recipes.Api.Dtos
{
    public class RecipeDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Hero { get; set; } = string.Empty;
        public IEnumerable<IngredientDto> Ingredients { get; set; }
        public IEnumerable<EquipmentDto> Equipments { get; set; }
    }
}
