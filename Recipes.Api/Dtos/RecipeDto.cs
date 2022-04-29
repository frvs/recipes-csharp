using System.Collections.Generic;

namespace Recipes.Api.Dtos
{
    public class RecipeDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Hero { get; set; } = string.Empty;
        // fun fact: enumerable.empty<t> generate a exception in serialization.
        public IEnumerable<IngredientDto> Ingredients { get; set; } = new List<IngredientDto>();
        public IEnumerable<EquipmentDto> Equipments { get; set; } = new List<EquipmentDto>();
    }
}
