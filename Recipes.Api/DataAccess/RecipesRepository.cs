using System.Linq;
using Recipes.Api.Models;

namespace Recipes.Api.DataAccess
{
    public interface IRecipesRepository
    {
        (bool, Recipe) InsertRecipe(Recipe recipe);
    }

    public class RecipesRepository : IRecipesRepository
    {
        private readonly RecipeDbContext _recipeDbContext;

        public RecipesRepository(RecipeDbContext recipeDbContext)
        {
            _recipeDbContext = recipeDbContext;
        }

        public (bool, Recipe) InsertRecipe(Recipe recipe)
         {
            _recipeDbContext.Recipes.Add(recipe);
            
            // note: > 0 instead of == 1 because sometimes (or many times) savechanges
            // change more than one entry on db
            var succesful = _recipeDbContext.SaveChanges() > 0;

            return (succesful, recipe);
        }
    }
}
