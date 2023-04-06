using Basket.BAL.IServices;
using Basket.BAL.Services;
using Catalog.Data.StartUpExtensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket.BAL.StartupExtensions
{
    public static class StartupBasketBusinessExtensionService
    {
        public static void AddBasketBusinessService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddBasketDataService(configuration);

            serviceCollection.AddScoped<IBasketService, BasketService>();
        }
    }
}
