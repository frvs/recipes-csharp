namespace RecipesApi.Models
{
    public class Ingredient
    {
        public Food Food { get; set; } = new Food();
        public int Quantity  { get; set; } // changed to int
        public string Unit { get; set; } = string.Empty; // what does unit mean if we already have quantity?
    }
}
