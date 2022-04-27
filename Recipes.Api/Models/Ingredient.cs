namespace Recipes.Api.Models
{
    public class Ingredient
    {
        public Food Food { get; set; } = new Food();
        public int Quantity { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}
