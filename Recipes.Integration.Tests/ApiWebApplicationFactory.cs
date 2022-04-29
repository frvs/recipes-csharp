using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Recipes.Api.DataAccess;
using Recipes.Api.Services;

namespace Recipes.Integration.Tests
{
    public class ApiWebApplicationFactory : WebApplicationFactory<Api.Startup>
    {
        // for some reason i dont know, if i dont override the configurewebhost method 
        // the factory dont use the api.startup dependency injection. ~triggered~
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            // configure dbcontext 
            // maybe configure some mocks
            builder.ConfigureServices(services =>
            {
                services.AddDbContext<RecipeDbContext>(options =>
                {
                    // temporarily it will be a in memory database (in the future maybe a sqlite, maybe a sqlserver/postgres db... im thinking about it)
                    options.UseInMemoryDatabase("testdatabase");
                });
                services.AddScoped<IRecipesRepository, RecipesRepository>();
                services.AddScoped<IRecipeService, RecipesService>();
            });
        }
    }
}
