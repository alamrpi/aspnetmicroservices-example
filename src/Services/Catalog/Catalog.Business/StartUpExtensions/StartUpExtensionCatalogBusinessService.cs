using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data.StartUpExtensions
{
    public static class StartUpExtensionCatalogBusinessService
    {
        public static void AddCatalogBusinessService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddCatalogDataService(configuration);
        }
    }
}
