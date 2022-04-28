namespace Recipes.Api.Models
{
    public class Ingredient
    {
        public long Id { get; set; }
        public Food Food { get; set; } = new Food();
        public int Quantity { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}
