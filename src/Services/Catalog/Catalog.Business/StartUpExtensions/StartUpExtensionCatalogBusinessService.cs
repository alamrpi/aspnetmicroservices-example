using Catalog.Business.IServices;
using Catalog.Business.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data.StartUpExtensions
{
    public static class StartUpExtensionCatalogBusinessService
    {
        public static void AddCatalogBusinessService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddCatalogDataService(configuration);
            serviceCollection.AddScoped<IProductService, ProductService>();
        }
    }
}
