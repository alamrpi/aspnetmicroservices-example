using Basket.DAL.IRepositories;
using Basket.DAL.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Data.StartUpExtensions
{
    public static class StartUpExtensionBasketDALService
    {
        public static void AddBasketDataService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddStackExchangeRedisCache(opt =>
            {
                opt.Configuration = configuration.GetSection("CacheSettings:ConnectionString").Value;
            });

            serviceCollection.AddScoped<IBasketRepository, BasketRepository>();
        }
    }
}
