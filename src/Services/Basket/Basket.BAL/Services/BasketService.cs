using Basket.BAL.IServices;
using Basket.DAL.IRepositories;
using Basket.Entities;

namespace Basket.BAL.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepository;

        public BasketService(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }
        public async Task DeleteBasket(string userName)
        {
            await _basketRepository.DeleteBasket(userName);
        }

        public Task<ShoppingCart> GetBasket(string userName)
        {
            return _basketRepository.GetBasket(userName);
        }

        public Task<ShoppingCart> UpdateBasket(ShoppingCart basket)
        {
            return _basketRepository.UpdateBasket(basket);
        }
    }
}
