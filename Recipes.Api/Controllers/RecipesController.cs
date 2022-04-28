using Microsoft.AspNetCore.Mvc;
using Recipes.Api.Dtos;
using Recipes.Api.Models;
using Recipes.Api.Services;

namespace Recipes.Api.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _service;

        public RecipesController(IRecipeService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult InsertRecipe([FromBody] RecipeDto recipeDto)
        {

            var recipe = _service.InsertRecipe(recipeDto);

            return Created($"/api/recipes/{recipe.Id}", recipe);
        }
    }
}
