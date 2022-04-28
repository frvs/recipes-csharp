namespace Recipes.Api.Dtos
{
    public class IngredientDto
    {
        public FoodDto Food { get; set; } = new FoodDto();
        public int Quantity { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}
