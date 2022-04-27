using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Recipes.Integration.Tests
{
    public class ControllerTests : IClassFixture<ApiWebApplicationFactory>
    {
        readonly HttpClient _client;

        public ControllerTests(ApiWebApplicationFactory application)
        {
            _client = application.CreateClient();
        }

        [Fact(DisplayName = "path /test should return 200 ok")]
        public async Task FirstTest()
        {
            var response = await _client.GetAsync("/test");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
