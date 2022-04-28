using System.Collections.Generic;
using Recipes.Api.Dtos;
using Recipes.Api.Models;

namespace Recipes.Api.Services
{
    public interface IRecipeService
    {
        Recipe InsertRecipe(RecipeDto recipeDto);
    }

    public class RecipesService : IRecipeService
    {
        public Recipe InsertRecipe(RecipeDto recipeDto)
        {
            var recipe = ToRecipe(recipeDto);

            return recipe;
        }

        // this method could be extracted to a translator class but...
        // we are going to keep things simple
        // another alternative is to use automapper-like libs but nah
        private Recipe ToRecipe(RecipeDto recipeDto)
        {
            var equipments = new List<Equipment>();
            var ingredients = new List<Ingredient>();

            foreach (var equipmentDto in recipeDto.Equipments)
            {
                equipments.Add(new Equipment
                {
                    Quantity = equipmentDto.Quantity,
                    Tool = new Tool
                    {
                        Name = equipmentDto.Tool.Name, 
                        Hero = equipmentDto.Tool.Hero
                    }
                });
            }

            foreach (var ingredientDto in recipeDto.Ingredients)
            {
                ingredients.Add(new Ingredient
                {
                    Quantity = ingredientDto.Quantity,
                    Unit = ingredientDto.Unit, 
                    Food = new Food
                    {
                        Name = ingredientDto.Food.Name,
                        Hero = ingredientDto.Food.Hero
                    }
                });
            }

            var recipe = new Recipe
            {
                Description = recipeDto.Description,
                Hero = recipeDto.Hero,
                Name = recipeDto.Name,
                Equipments = equipments,
                Ingredients = ingredients
            };

            return recipe;
        }
    }
}
