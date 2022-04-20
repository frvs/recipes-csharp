namespace RecipesApi.Models
{
    public class Recipe
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Hero { get; set; } = string.Empty; // what does this mean?

        public IList<Ingredient> Ingredients { get; set; } = new List<Ingredient>(); // should I use another interface? ICollection? IEnumerable?
        public IList<Equipment> Equipments { get; set; } = new List<Equipment>(); // should I use another interface? ICollection? IEnumerable?
    }
}
