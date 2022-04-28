namespace Recipes.Api.Models
{
    public class Equipment
    {
        public long Id { get; set; }
        public Tool Tool { get; set; } = new Tool();
        public int Quantity { get; set; }
    }
}
