namespace RecipesApi.Models
{
    public class Equipment
    {
        public Tool Tool { get; set; } = new Tool();
        public int Quantity { get; set; }
    }
}
