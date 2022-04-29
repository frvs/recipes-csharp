using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Recipes.Api.Dtos;
using Recipes.Api.Models;
using Xunit;

namespace Recipes.Integration.Tests
{
    public class RecipesControllerTests : IClassFixture<ApiWebApplicationFactory>
    {
        readonly HttpClient _client;

        public RecipesControllerTests(ApiWebApplicationFactory application)
        {
            _client = application.CreateClient();
        }

        // should I verify if the recipe was sucessfully inserted on DB  
        // or should I only assert the status code? ... < this one
        [Fact(DisplayName = "POST - Success - should return 201 created")]
        public async Task InsertRecipeSuccess()
        {
            var recipeDto = CreateFullRecipeDto();
            // utf-32 encoding doesnt work and idk why. check later?
            var body = new StringContent(JToken.FromObject(recipeDto).ToString(), Encoding.UTF8, "application/json");

            var httpResponseMessage = await _client.PostAsync("/api/recipes", body);

            var contentAsString = await httpResponseMessage.Content.ReadAsStringAsync();
            var recipe = JToken.Parse(contentAsString).ToObject<Recipe>();

            Assert.Equal(HttpStatusCode.Created, httpResponseMessage.StatusCode);
            Assert.Equal(recipeDto.Description, recipe.Description);
            Assert.Equal(recipeDto.Name, recipe.Name);
            Assert.Equal(recipeDto.Ingredients.Count(), recipe.Ingredients.Count());
            Assert.Equal(recipeDto.Equipments.Count(), recipe.Equipments.Count());
            // i could check the properties inside ingredients and equipments but thats boring to do and i think you've already understand my intentions here
        }

        private RecipeDto CreateFullRecipeDto()
        {
            // dont judge me for the content in pt-br. its better this way, trust me.
            return new RecipeDto
            {
                Description = "bolo de fuba que parece feito pela sua magnifica vozinha",
                Hero = "https://receitasgostosas.com.br/bolodefuba.jpg",
                Name = "Bolo de fuba",
                Equipments = new List<EquipmentDto>
                {
                    new EquipmentDto
                    {
                        Tool = new ToolDto
                        {
                            Name = "Fue", 
                            Hero = "https://receitasgostosas.com.br/fue.jpg"
                        }, 
                        Quantity = 1
                    },
                    new EquipmentDto
                    {
                        Tool = new ToolDto
                        {
                            Name = "Batedeira", 
                            Hero = "https://receitasgostosas.com.br/batedeira.jpg"
                        },
                        Quantity = 1
                    }
                },
                Ingredients = new List<IngredientDto>
                {
                    new IngredientDto
                    {
                        Food = new FoodDto
                        {
                            Name = "Fuba de milho",
                            Hero = "https://receitasgostosas.com.br/fuba.jpg"
                        },
                        Quantity = 300,
                        Unit = "gramas"
                    },
                    new IngredientDto
                    {
                        Food = new FoodDto
                        {
                            Name = "Ovo", 
                            Hero = "https://receitasgostosas.com.br/ovo.jpg"
                        }, 
                        Quantity = 4, 
                        Unit = "unidades"
                    }
                }
            };
        }
    }
}
