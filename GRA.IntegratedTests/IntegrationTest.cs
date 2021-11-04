using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using GRA.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GRA.IntegratedTests
{
    public class IntegrationTest
    {
        protected readonly HttpClient TestClient;
        protected IntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        services.RemoveAll(typeof(DatabaseContext));
                        services.AddDbContext<DatabaseContext>(optionsAction =>
                        {
                            optionsAction.UseInMemoryDatabase(databaseName: "DbTest");
                        });
                    });
                }
                );

            TestClient = appFactory.CreateClient();
        }        
    }
}
