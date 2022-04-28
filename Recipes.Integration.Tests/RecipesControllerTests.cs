using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
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
            var recipe = new Recipe();
            var body = new StringContent(JToken.FromObject(recipe).ToString());

            var response = await _client.PostAsync("/api/recipes", body);

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }
    }
}
